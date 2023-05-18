import { Link } from 'react-router-dom'
import { DESSERTS_ROUTE, DRINKS_ROUTE, MAIN_ROUTE, PIZZA_ROUTE, PROFILE_ROUTE, SAUCES_ROUTE } from '../utils/consts'
import '../css/footer.css'
import SocialMediaIcons from './SocialMediaIcons'

const Footer = () => {
    // добавить на фон картинку с помидорами или чем-то другим и найти иконки соц сетей
    return(
        <footer className="footer">
            <div className="container">
                <div className="logo">
                    <Link to={MAIN_ROUTE}>Pizzazz Pizza</Link> 
                </div>
                <span>Italian pizza</span>
                <nav className="nav-footer">
                    <ul className='nav-list-footer'>
                        <li> <Link to={MAIN_ROUTE}>Homme</Link> </li>
                        <li> <Link to={PIZZA_ROUTE}>Pizza</Link> </li>
                        <li> <Link to={DRINKS_ROUTE}>Drinks</Link> </li>
                        <li> <Link to={SAUCES_ROUTE}>Sauces</Link> </li>
                        <li> <Link to={DESSERTS_ROUTE}>Desserts</Link></li>
                    </ul>
                </nav>
                <div className='social-media-icons'>
                    <SocialMediaIcons />
                </div>
            </div>
        </footer>
    )
}

export default Footer