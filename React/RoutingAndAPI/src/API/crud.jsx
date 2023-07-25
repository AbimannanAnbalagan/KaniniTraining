import React,{useEffect,useState} from 'react';
import axios from 'axios';

const Crud = () =>{
    const [students, setStudents ] = useState([]);
    const basepath = 'https://localhost:7143';


    useEffect(()=>{
        fetchStudents();
    },[students]);

    const fetchStudents =async ()=>{
        try{
            const response = await axios.get(basepath+`/Student`);
            setStudents(response.data);
        }catch(error){
            console.error(error);
        }
    };

    const createStudent = async()=>{
        try{
            const response=await axios.post(basepath+`/Student`,newStudent);
            setStudents([...students,response.data]);
        }catch(error){
            console.error(error);
        }
    };
    return(
        <div><h1>CRUD Operation</h1><ul>
            {students.map((student) => (
                <li key={student.rno}>
                    <span>{student.name}</span>
                    <span>{student.section}</span>
                    <span>{student.phoneNum}</span>
                </li>
            ))}
        </ul></div>
    )
};
export default Crud;

