import { Link } from 'react-router-dom'
import { MAIN_ROUTE, PROFILE_ROUTE } from '../utils/consts'
import '../css/footer.css'

const Footer = () => {
    return(
        <footer className="footer">
            <div className="container">
                <img src='../assets/' alt="" />
                <div className="logo">
                    <Link to={MAIN_ROUTE}>Pizzazz Pizza</Link> 
                </div>
                <span>Italian pizza</span>
                <nav className="nav-footer">
                    <ul className='nav-list-footer'>
                        <li> <Link to={MAIN_ROUTE}>Homme</Link> </li>
                        <li> <Link to={PROFILE_ROUTE}>Пицца</Link> </li>
                        <li> <Link to={PROFILE_ROUTE}>Напитки</Link> </li>
                        <li> <Link to={PROFILE_ROUTE}>Соусы</Link> </li>
                        <li> <Link to={PROFILE_ROUTE}>И еще что-нибудь</Link> </li>
                    </ul>
                </nav>
                <div className='social-media-icons'>
                    icons not found
                </div>
            </div>
        </footer>
    )
}

export default Footer