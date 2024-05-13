import React, { useState } from "react";
import './App.css';
import {
  BrowserRouter as Router,
  Routes,
  Route,
  Navigate,
  Link,
  BrowserRouter,
} from "react-router-dom";
import { CssVarsProvider, useColorScheme } from '@mui/joy/styles';
import StudyTime from './componenets/StudyTime';
import SubjectList from './componenets/SubjectList';
import LoginFinal from './componenets/LogIn';
import SignupFinal from './componenets/SignUp';
import SubjectItem from "./componenets/SubjectItem";
//import { CssVarsProvider } from "@mui/joy/styles";
import { experimental_extendTheme as extendtheme, } from "@mui/material/styles";
// import {experimental_extendTheme as extendtheme, Experimental_CssVarsProvider as CssVarsProvider} from "@mui/material/styles";
import Alerts from "./componenets/Alerts";
import ModeToggle from "./componenets/ButtonChangeMode";
import PrimarySearchAppBar from "./componenets/navbar";
import BottomActionsCard from "./componenets/User"
import Home from "./componenets/Home";

/**
 * 
{
  "email":"miryami@mail.com",
  "password":12345"
}

 */
const userList = [
  { name: 'aaa', id: '9', email: 'aaa@mail.com', password: '123456' },
  { name: 'bbb', id: '10', email: 'bbb@mail.com', password: '123456' },
  { name: 'ccc', id: '11', email: 'ccc@mail.com', password: '123456' },
  { name: 'miryami', id: '12', email: 'miryami@mail.com', password: '12345' }
]
function App() {
  const [showSignUp, setShowSignUp] = useState(false);
  const [showLogIn, setLogIn] = useState(true);
  const [users, setUsers] = useState([...userList]);
  const [user, setUser] = useState(null);  // the logged-in user or null
  const [loginSuccess, setLoginSuccess] = useState(null);  // the logged-in user or null


  //נקבל מהשרת בהמשך
  let courses = [
    { name: 'Course', id: '01', photo: './public/photos/10.JPG', hasNewContent: false, onclick: 'toLesson(course)' }, { name: '22', id: '02', photo: "public/photos/11.JPG", hasNewContent: false, },
  ];

  const login = (email, password) => {
    const user = users.find(u => u.email === email && u.password === password);
    if (user) {
      setShowSignUp(false)
      setUser(user)
      setLoginSuccess(true)


    } else {
      setShowSignUp(false)
      setLoginSuccess(false)


    }

  }

  const logout = () => {
    setUser(null);
    setLoginSuccess(null)
  }

  const subjects = [
    { id: 1, name: 'הלכה' },


  ]

  const validateLogin = (email, password) => {
    const serverUrl = 'https://localhost:7567/api/users';

    fetch(serverUrl, {
      method: 'POST',
      headers: { 'content-type': 'application/json' },
      body: JSON.stringify({ email, password })
    })
      .then(response => response.json())
      .then(response => {
        console.log(response);
        // Handle login response as needed
      });
  };

  const handleSignupClick = () => {
    setShowSignUp(!showSignUp);


    if (!showSignUp) {
      // Use the `Navigate` component to programmatically navigate
      // You can adjust the route based on your application structure
      return <Navigate to="/signup" />;
    }

  };
  return (
    <div className="App">
      {/* <StudyTime /> */}

      {/*         
        {loginSuccess !== null && <Alerts type={loginSuccess} text=""/>}
        <PrimarySearchAppBar/>
        {!user && <>
           
          {showLogIn &&<LoginFinal onLogin={login}/>}
      
          </>}
        
        {user && <SubjectList subjects={subjects} /> } */}
      {/* {showSignUp && <SignUp />} */}


      <BrowserRouter>
        <meta name="referrer" content="strict-origin-when-cross-origin" /> {/* הוספת ה-"Referrer Policy" */}
        <Routes>
          <Route>
            <Route
              exact path="/"
              element={<Navigate to="/LogIn" />}
            ></Route>

            <Route path="/LogIn" element={<LoginFinal />} />
            <Route path="/SignUp" element={<SignupFinal />} />
            <Route path="/User" element={<BottomActionsCard />} />
            <Route path="/Home" element={<Home />}/>
          </Route>
        </Routes>
      </BrowserRouter>
      {/* <CssVarsProvider>
        <ModeToggle />
      </CssVarsProvider> */}
    </div>
  );
}

export default App;