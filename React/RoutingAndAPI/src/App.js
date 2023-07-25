import React, { useState } from 'react';
import {
  BrowserRouter,
 // HashRouter,
  Routes,
  Route,
  Link,
  useNavigate
} from "react-router-dom";
import Home from './Navigation/Home';
import About from './Navigation/About';
import Contact from './Navigation/Contact';
import User from './Navigation/User';

const App=()=>{
  return (
    // <BrowserRouter>
    // <MainApp/>
    // </BrowserRouter>
    <crud></crud>
  );
};

// const MainApp=()=>{
//   const [id,setid]=useState('');
//   const navigate =useNavigate();

//   const sendId =(event)=>{
//     setid(event.target.value);
//     navigate(`/user/${id}`);
//   };

//   const handleNavigation =()=>{
//     navigate(`/user/${id}`);
//   }


// function App() {
//   // const [id, setid]=useState('');
//   // const sendId = (event)=>{
//   //   setid(event.target.value);
//   // };

  // return (
  //   <div>
  //     {/* <BrowserRouter> */}
  //     {/* <HashRouter> */}
  //       <div>
  //         <nav>
  //           <ul>
  //             <li>
  //               <Link to="/">Home</Link>
  //             </li>
  //             <li>
  //               <Link to="/about">About</Link>
  //             </li>
  //             <li>
  //               <Link to="/contact">Contact</Link>
  //             </li>
  //           </ul>
  //         </nav>
  //         <input type="text" value={id} onChange={sendId}></input>
  //         <button type="button" onClick={handleNavigation}>Send</button>

        //   <hr />
        //   <Routes>
        //     <Route exact path="/" element={<Home />} />
        //     <Route path="/about" element={<About />} />
        //     <Route path="/contact" element={<Contact />} />
        //     <Route path="/user/:id" element={<User/>} />
        //   </Routes>

        // </div>
      {/* </BrowserRouter> */}
      {/* </HashRouter> */}

   // </div>
 // );
//}

export default App;