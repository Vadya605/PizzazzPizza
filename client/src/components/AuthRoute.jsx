import { Navigate, Outlet, Route, Routes } from "react-router-dom";
import { AUTH_ROUTE } from "../utils/consts";

const AuthRoute = () => {
    const isAuth = true; // пока заглушка, брать из контекста

    return(
        isAuth? <Outlet /> : <Navigate to={AUTH_ROUTE} />
    )
    
}

export default AuthRoute;