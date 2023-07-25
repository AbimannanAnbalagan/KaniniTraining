import React, { useState } from 'react'

const ExpenseForm = () => {

    // const [data, setData] = useState
    //     (
    //         { date: '', type: '', amount: '' }
    //     );

    const [type, setType] = useState('');
    const [date, setDate] = useState('');
    const [amount, setAmount] = useState('');

    const addNewDate = (val) => {
        // setData((prevState) => {
        //     return { ...prevState, date: event.target.value };
        // });
        setDate(val);
        console.log(val);
    }

    const addNewType = (val) => {
        // setData((prevState) => {
        //     return { ...prevState, type: event.target.value };
        // });
        setType(val);
        console.log(val);
    }

    const addNewAmount = (val) => {

        // setData((prevState) => {
        //     return { ...prevState, amount: event.target.value };
        // });
        console.log(val);
        setAmount(val)
    };

    //shared handler function
    const newDataAdd = (str, val) =>
    {
        if (str==='date')
        addNewDate(val);
        else if(str=='type')
        addNewType(val);
        else if(str=='amount')
        addNewAmount(val);
    };

    const addNewExpense = (event) =>
    {
        event.preventDefault();
        
    }

    return (
        <form onSubmit={addNewExpense}>
            <div>
                <div>
                    <label>Date</label>
                    <input type="text" onChange={(event)=>
                        newDataAdd('date', event.target.value)
                    }></input>
                </div>
                <div>
                    <label>Expense</label>
                    <input type="text" onChange={(event)=>
                        newDataAdd('type', event.target.value)}></input>
                </div>
                <div>
                    <label>Amount</label>
                    <input type="number" onChange={(event)=>
                        newDataAdd('amount', event.target.value)}></input>
                </div>
                <button type="submit">Add New</button>
            </div>
        </form>
    );
}


export default ExpenseForm;