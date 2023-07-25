import React, { useState } from 'react';
import ExpenseDateLoad from "./ExpenseDateLoad";
import Card from '../UI/Card'
import NewExpense from './NewExpense';

const Expenses = (props) => {
  // const expense = "Rent";
  // const amount = "10000";
  // exptype = props.exptype;
  const [type, setType] = useState(props.exptype);
  const changeExpType = () => {
    setType("Rent")
    console.log(type);
  }
  return (
    <div>
      {/* {props.expdate.toISOString()} */}

      

      <Card>
        <ExpenseDateLoad
          expdate={props.expdate}
        ></ExpenseDateLoad>
        {type}  {props.expamt}
        <button onClick={changeExpType}>Change Expense Type</button>
      </Card>
    </div>
  );
}

export default Expenses;