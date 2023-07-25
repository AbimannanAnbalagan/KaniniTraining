function calculation(){
    
    let weight= document.getElementById('weight').value;
    let height= document.getElementById('height').value;
    
    height = height/100;
    result= weight/height**2  
    
    document.getElementById("heading").innerHTML = 'Your BMI is :'
    document.getElementById("bmi").innerHTML = result.toFixed(1)
    
    if (result <= 24.9)
    {
        document.getElementById("message").innerHTML="You are underweight"
    } 
    else if(result >=25 && result <=29.9){
        document.getElementById("message").innerHTML="you are healthy"
    }
    else{
        document.getElementById("message").innerHTML="you are Overweight"
    }
    
}

function reload() {
    Window.location.reload()
}