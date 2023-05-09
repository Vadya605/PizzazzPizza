import { useState } from 'react';
import { Link } from 'react-router-dom';
import { MAIN_ROUTE, PROFILE_ROUTE } from '../utils/consts';
const Menu = ()=> {
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
                    <li> <Link to={MAIN_ROUTE}>Главная</Link> </li>
                    <li> <Link to={PROFILE_ROUTE}>Пицца</Link> </li>
                    <li> <Link to={PROFILE_ROUTE}>Напитки</Link> </li>
                    <li> <Link to={PROFILE_ROUTE}>Соусы</Link> </li>
                    <li> <Link to={PROFILE_ROUTE}>И еще что-нибудь</Link> </li>
                </ul>
            </div>
            <div className="menu-background"></div>
        </div>
    )
}

export default Menu;