import Auth from "./pages/Auth";
import Basket from "./pages/Basket";
import Main from "./pages/Main";
import Product from "./pages/Product";
import Profile from "./pages/Profile";
import { AUTH_ROUTE, BASKET_ROUTE, MAIN_ROUTE, PRODUCT_ROUTE, PROFILE_ROUTE } from "./utils/consts";

export const authRoutes = [
    {
        path: PROFILE_ROUTE,
        Component: Profile
    },
    {
        path: BASKET_ROUTE,
        Component: Basket
    },
]

export const publicRoutes = [
    {
        path: MAIN_ROUTE,
        Component: Main
    },
    {
        path: AUTH_ROUTE,
        Component: Auth
    },
    {
        path: PRODUCT_ROUTE + '/:productId',
        Component: Product
    },
]