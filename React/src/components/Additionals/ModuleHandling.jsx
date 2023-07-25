import React from "react"
import Button from "./Button"

const ModuleHandling =()=>{
    
    const handleClick =()=>{
    console.log("Button Clicked");
    }
    return(
        <div>
            <Button onClick={handleClick} text="Click !!!"></Button>
        </div>
    );
}
export default ModuleHandling;