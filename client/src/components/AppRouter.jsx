import { Navigate, Route, Routes } from "react-router-dom";
import { authRoutes, publicRoutes } from "../routes";
import { MAIN_ROUTE } from "../utils/consts";
import AuthRoute from "./AuthRoute";


const AppRouter = () => {
    return(
        <Routes>
            {publicRoutes.map(({path, Component}) => 
                <Route key={path} path={path} Component={Component} exact/>
            )}
            <Route element={<AuthRoute/>}>
                {authRoutes.map(({path, Component}) => 
                    <Route key={path} path={path} Component = {Component} exact/>
                )}
            </Route>
            <Route path="*" element={<Navigate to={MAIN_ROUTE} replace />}/>
        </Routes>
    )
}

export default AppRouter;