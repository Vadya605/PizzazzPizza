import { Link } from 'react-router-dom'
import { BASKET_ROUTE, MAIN_ROUTE, PROFILE_ROUTE } from '../utils/consts'
import BasketSvg from './ComponentsSvg/BasketSvg';
import ProfileSvg from './ComponentsSvg/ProfileSvg';
import Menu from './Menu';
import '../css/header.css';
const Header = () => {
    return(
        <header className="header">
            <div className="container">
                <div className="header-nav">
                    <Menu/>
                    <div className="logo">
                        <Link to={MAIN_ROUTE}>Pizzazz Pizza</Link> 
                    </div>
                    <div className="links-basket-profile">
                        <Link to={PROFILE_ROUTE}>
                            <ProfileSvg/>
                        </Link>
                        <Link to={BASKET_ROUTE}>
                            <BasketSvg/>
                        </Link>
                    </div>
                </div>
               
            </div>
        </header>
    )
}

export default Header