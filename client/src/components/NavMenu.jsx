import { useState } from 'react';
import { Link } from 'react-router-dom';
import { DESSERTS_ROUTE, DRINKS_ROUTE, MAIN_ROUTE, PIZZA_ROUTE, PROFILE_ROUTE, SAUCES_ROUTE } from '../utils/consts';
const NavMenu = ()=> {
    const [isClickMenu, setIsClickMenu] = useState(false);
    
    return(
        <div className={isClickMenu? 'navigation-block isClick': 'navigation-block'} onClick={() => setIsClickMenu(!isClickMenu)}>
            <div className="hamberger-menu">
                <div className="bar upper-bar"></div>
                <div className="bar middle-bar"></div>
                <div className="bar lower-bar"></div>
            </div>
            <div className="menu-list">
                <ul>
                    <li> <Link to={MAIN_ROUTE}>Home</Link> </li>
                    <li> <Link to={PIZZA_ROUTE}>Pizza</Link> </li>
                    <li> <Link to={DRINKS_ROUTE}>Drinks</Link> </li>
                    <li> <Link to={SAUCES_ROUTE}>Sauces</Link> </li>
                    <li> <Link to={DESSERTS_ROUTE}>Desserts</Link> </li>
                </ul>
            </div>
            <div className="menu-background"></div>
        </div>
    )
}

export default NavMenu;