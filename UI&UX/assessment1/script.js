// function bookAppointment()
// {
//     alert("in")    
// // //     let username = document.getElementById("customerName").value;
// // //     validation = /[a-zA-Z]/g;
// // //     alert(username)
// // //     if (username == "" || validation.test(username))
// // //     {
// // //         alert("UN wrong")
// // //         document.getElementById("result").innerHTML="Enter Name"
// // //     }
// // //     else{
// // //         mobileNumber()
// // //     }


// // //     return false;
// // // }


// // // function mobileNumber()
// // // {
// // //     let mobile = document.getElementById("mobileNumber").value;
// // //     validation = /[789]{1}+[0-9]{9}/g;
// // //     if (validation.test(mobile)){
// // //         mailid()
// // //     }
// // //     else{
// // //         document.getElementById("result").innerHTML="Enter Proper Mobile Number" 
// // //     }
// // // }
// // // function mailid()
// // // {
// // //         let mail = document.getElementById("email").value
// // //         validation = /[a-z0-9]+@[a-z]+\.[a-z]/g;
// // //         if (validation.test(mail)){
// // //             validateAddress();
// // //         }
// // //         else{
// // //             document.getElementById("result").innerHTML = "Enter Proper MailId"
// // //         }
// // // }









// // function bookAppointment(){

// //     let total = 0;
// //     var x= document.getElementById("yearlyMaintenance").checked;


// //     if (x){
// //          total+1000;
// //          document.getElementById("result").innerHTML=total;
// //     }
    
// //     // let servicetype = document.getElementById("serviceType").value;
    
// //     // if (servicetype === "Cleaning"){
// //     //     total = total + 500
// //     // }
// //     // if (servicetype === "Repair"){
// //     //     total = total + 1000
// //     // }
// //     // if (servicetype === "Gas Refill"){
// //     //     total = total + 1500
// //     // }



//     return false;
// }

var name_pattern = /[a-z]/g
var phone_pattern = /[789]\d{9}/
var email_pattern = /[a-z@gmail.com]/g 

document.getElementById("submit").addEventListener('click',bookAppointment);


function bookAppointment(){
    let checked = document.getElementById("yearlyMaintenance");
    let customerName = document.getElementById("customerName").value;
    let acType = document.getElementById("acType").value;
    let serviceType = document.getElementById("serviceType").value;
    let email = document.getElementById("email").value;
    let phone = document.getElementById("mobileNumber").value;
    let result = document.getElementById("result");
    let serviceCharge = 0;
    
    switch (serviceType)
    {
        case 'Cleaning':
            serviceCharge = 500;
            break;
        case 'Repair':
            serviceCharge = 1000;
            break;
        case 'Gas Refill':
            serviceCharge = 1500;
            break;
        default:
            serviceCharge = 0;
    }


    if(customerName.match(name_pattern) &&  email.match(email_pattern) && phone.match(phone_pattern) && checked.checked ){
        result.innerHTML = `Hello ${customerName}, your service appointment for ${acType} AC
        ${serviceType} with yearly maintenance will be send to your email ID
        ${email} and the estimated service charge will be Rs ${serviceCharge + 1000}`;
    }else if(checked.checked != "true" && email.match(email_pattern) &&  serviceType.length > 0 && customerName.match(name_pattern)){
        result.innerHTML = `Hello ${customerName}, your service appointment for ${acType} AC
        ${serviceType} without yearly maintenance will be send to your email ID
        ${email} and the estimated service charge will be Rs ${serviceCharge}`;
    }else{
        result.innerHTML = "fill the details properly";
    }
    // console.log(checked.checked);
}
