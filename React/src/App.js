import React from 'react';
import Expenses from './components/Expenses/Expenses';
import './App.css'
import ControlledCounter from './components/Additionals/ControlledCounter';
import NewExpense from './components/Expenses/NewExpense';
import BoundedComponent from './components/Additionals/BoundedComponent';
import ModuleHandling from './components/Additionals/ModuleHandling';

function App() {

  // expenses -> helper constants
  const expenses = [
    { edate:new Date(2023, 5, 19), expname: 'Groceries', expamount: 1000 },
    { edate:new Date(2023, 6, 19), expname: 'Food', expamount: 2000 }
  ];
  return (
    <div>
      <ControlledCounter></ControlledCounter>
      <div>
        <h1>React Learning</h1> <h2>React Example</h2>
      </div>
      <h4>Expenses List</h4>
      <NewExpense></NewExpense>
      <p>Expense      Amount     Date</p>
      <Expenses
        expdate={expenses[0].edate}
        exptype={expenses[0].expname}
        expamt={expenses[0].expamount}
      ></Expenses>

      <Expenses
        expdate={expenses[1].edate}
        exptype={expenses[1].expname}
        expamt={expenses[1].expamount}
      ></Expenses>
       <BoundedComponent></BoundedComponent>
       <br></br>
       <hr></hr>
       <ModuleHandling></ModuleHandling>
       <br></br>
       <hr></hr>
       <HooksExample></HooksExample>
    </div>
   
  );
}

export default App;
