import React from 'react';
import '../UI/Card.css'

const Card = (props) =>
{
    return(
        <div class='card'>
            {props.children}
        </div>
    );
}

export default Card;