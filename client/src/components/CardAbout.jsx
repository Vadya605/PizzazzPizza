const CardAbout = ( { textCard, imageCard, dataAOS  } ) => {
    
    return(
        <div data-aos={dataAOS} className="card-about">
            <img src={imageCard} alt="" />
            <p className="text">{textCard}</p>
        </div>
    )
}

export default CardAbout