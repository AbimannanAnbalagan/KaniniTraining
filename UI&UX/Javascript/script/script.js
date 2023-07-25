/*function f1()
  {
    var x='hello', y=7, z=null;
    document.getElementById("para1").innerHTML=x+y+z;
    {
      let x=5, y=7,z='hi';
      document.getElementById("para2").innerHTML=x+y+z;
    }
    {
      let x=5, y=7,z;
      document.getElementById("para3").innerHTML=x+y+z;
    }
    {
      let x=5, y=7,z;
      document.getElementById("para4").innerHTML=z;
    }
  }
function f2(x,y)
  {
    document.getElementById("para5").innerHTML=x+y;
  }

function f7()
{
  stud={rollno:99, name:'abi',address:'13,adc'}
  document.getElementById('para7').innerHTML=stud.rollno + '    ' + stud.name;

  stud.name='mozhi';
  document.getElementById('para7').innerHTML=stud.rollno + '    ' + stud.name;

}
function f3() //array
{
  numbers=[100,200,300]
  alert(numbers[1])
  numbers[1]=400
  alert(numbers[1])
  numbers[3]=500
  alert(numbers[3])
  numbers[5]=700
  alert(numbers[5])
  alert(numbers[4])
  
  numbers2= new Array(1,2,3) //new-instance of class
  alert(numbers2[0])
  alert(numbers2)
  
  const numbers3 =new Array(5,6,7,8,9)
  numbers3[3]=88
  alert(numbers3)

  
}

function regex()
{
  let text = "Visit  W3Schools!"; 
  let n = text.search("W3Schools");
  document.getElementById("para5").innerHTML = n;
}

*/
let array=['abi','mozhi']
console.log(array)