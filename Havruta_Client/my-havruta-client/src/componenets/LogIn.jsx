import React, { useState, } from 'react';
import { CssBaseline, Typography, FormControl, FormLabel, Input, Button, Sheet, Link } from '@mui/joy'; // Import MUI components
import { useNavigate } from 'react-router-dom';
import Alerts from './Alerts';

export default function LoginFinal() {
  const [showAlert, setShowAlert] = useState(false)
  const[alertMeaage, setAlertMessage] = useState('')
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const Navigate = useNavigate()

  const handleLogin = () => {
    fetchLogin()

  };
  const fetchLogin = async () => {
    try {
      const response = await fetch(`http://localhost:5126/api/User/Login`,
        {
          method: "POST",
          headers: {
            'accept': '*/*',
            'Content-Type': 'application/json',
          },
          body: JSON.stringify({
            "userName": email,
            "password": password
          })
        }
      );
      if (!response.ok) {
        console.log('error in the server')
        setAlertMessage(`There is an error in our system, please try again later`)
        setShowAlert(true)
        setTimeout(()=>
        {
          setShowAlert(false)
        }, 4000)
      }
      const data = await response.json();
      if (data == 0 ){//|| data !== false ) {
        console.log('@@@')
        //צריך להוסיף את הid לlocal storage
        localStorage.setItem('userId', data)
        // להעביר את המשתמש שנרשם לדף הבית
        Navigate('/Home')
      }
      else{
        setAlertMessage(`User name or password are not exist!`)
        setShowAlert(true)
        setTimeout(()=>
        {
          setShowAlert(false)
        }, 4000)
      }
    } catch (error) {
      console.error('Error fetching data:', error);
      setAlertMessage(`There is an error in our system, please try again later`)
      setShowAlert(true)
      setTimeout(()=>
      {
        setShowAlert(false)
      }, 5000)
    }
  };

  return (
    <main>
      {showAlert ? <Alerts type={false} text={alertMeaage}/> : <></>}
      <CssBaseline />
      <Sheet
        sx={{
          width: 300,
          mx: 'auto',
          my: 4,
          py: 3,
          px: 2,
          display: 'flex',
          flexDirection: 'column',
          gap: 2,
          borderRadius: 'sm',
          boxShadow: 'md',
        }}
        variant="outlined"
      >
        <div>
          <Typography level="h4" component="h1">
            <b>Welcome!</b>
          </Typography>
          <Typography level="body-sm">Sign in to continue.</Typography>
        </div>
        <FormControl>
          <FormLabel>Email</FormLabel>
          <Input
            name="email"
            type="email"
            placeholder="johndoe@email.com"
            value={email}
            onChange={(event) => setEmail(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>ססמא</FormLabel>
          <Input
            name="password"
            type="password"
            placeholder="password"
            value={password}
            onChange={(event) => setPassword(event.target.value)}
          />
        </FormControl>
        <Button onClick={handleLogin} sx={{ mt: 1 }}>
          הרשמה
        </Button>
        <Typography fontSize="sm" sx={{ alignSelf: 'center' }}>
          Don't have an account?{' '}
          <Link href="SignUp">הרשמה</Link>
        </Typography>
      </Sheet>



    </main>
  );
}
