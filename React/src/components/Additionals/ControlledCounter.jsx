import React,{useState} from "react";

const ControlledCounter = () =>
{
    const [inputValue,setInputValue]=useState('');

    const handleChange = (event) =>
    {
        setInputValue(event.target.value);
    };

    return(
    <div>
        <label htmlFor="inputField" >Enter A Value:</label>
        <input type="text" id="inputField"
        value={inputValue}  onChange={handleChange}></input>
        <p>You Entered:{inputValue}</p>
    </div>
    );
};

export default ControlledCounter;
