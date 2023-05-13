import Visa from '../assets/Visa.svg'
import PayPal from '../assets/PayPal.svg'
import { useState } from 'react'

const FormAddingBankCard = () => {
    const [numberActiveImg, setNumberActiveImg] = useState(1) // мб есть что-то умнее?
    return(
        <form className="form-adding-bank-card" onSubmit={(e) => e.preventDefault()}>
            <div className="choosing-type-bank-card">
                <div className={numberActiveImg==1? 'border active': 'border'} onClick={() => setNumberActiveImg(1)} >
                    <img src={PayPal} alt="" />  
                </div>
                <div className={numberActiveImg==2? 'border active': 'border'} onClick={() => setNumberActiveImg(2)} >
                    <img src={Visa} alt="" />
                </div>
            </div>
            <div className="inputs">
                <div className="input-box">
                    <input type="text" className="input" id='number-bank-card'  placeholder=' ' />
                    <label htmlFor="number-bank-card" className="flying-placeholder">Number bank card</label>
                </div>
                <div className="input-box">
                    <input type="text" className="input" id='cardholder'  placeholder=' ' />
                    <label htmlFor="cardholder" className="flying-placeholder">Cardholder</label>
                </div>
                <div className="row-inputs">
                    <div className="input-box">
                        <input type="text" className="input" id='expiration-date-bank-card'  placeholder=' ' />
                        <label htmlFor="expiration-date-bank-card" className="flying-placeholder">Expiration date</label>
                    </div>
                    <div className="input-box">
                        <input type="password" className="input" id='cvv-code'  placeholder=' ' />
                        <label htmlFor="cvv-code" className="flying-placeholder">CVV</label>
                    </div>
                </div>
            </div>
            <button type="submit" className='check-out'>Check out</button>
        </form>
    )
}

export default FormAddingBankCard