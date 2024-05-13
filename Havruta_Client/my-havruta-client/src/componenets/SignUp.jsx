
// import React, { useState } from 'react';
// import { CssBaseline, Typography, FormControl, FormLabel, Input, Button, Link, Sheet } from '@mui/material'; // Assuming MUI components are imported this way
import { useState, useEffect } from 'react';
import { CssVarsProvider, useColorScheme } from '@mui/joy/styles';
import Sheet from '@mui/joy/Sheet';
import CssBaseline from '@mui/joy/CssBaseline';
import Typography from '@mui/joy/Typography';
import FormControl from '@mui/joy/FormControl';
import FormLabel from '@mui/joy/FormLabel';
import Input from '@mui/joy/Input';
import Button from '@mui/joy/Button';
import Link from '@mui/joy/Link';
import ModeToggle from './ButtonChangeMode';
import Alerts from './Alerts';
import { useNavigate } from 'react-router-dom';




export default function SignupFinal({ onSignup }) {
  const [showAlert, setShowAlert] = useState(false)
  const [alertMeaage, setAlertMessage] = useState('')

  const [firstName, setFirstName] = useState('');
  const [lastName, setLastName] = useState('');
  const [phoneNumber, setPhoneNumber] = useState('');
  const [address, setAddress] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const [gender, setGender] = useState('');
  const [sector, setSector] = useState('');
  const [age, setAge] = useState('');
  const [description, setDescription] = useState('')

  const Navigate = useNavigate()

  const handleSignup = () => {
    // Validation logic can be added here before calling onSignup
   

      let body = {
        iduser: 123456789,
        fName: firstName,
        lName: lastName,
        address: address,
        phone: phoneNumber,
        sector: sector,
        gender: gender,
        age: age,
        email: email,
        decriptionMyStudy: description,
        password: password
      }
      fetchSignin(JSON.stringify(body))

 
  };

  const fetchSignin = async (body) => {
    try {
      const response = await fetch('http://localhost:5126/api/User/SignIn',
        {
          method: "POST",
          headers: {
            'accept': '*/*',
            'Content-Type': 'application/json',
          },
          body: body
        }
      );
      if (!response.ok) {
        console.log('error in the server')
        setAlertMessage(`There is an error in our system, please try again later`)
        setShowAlert(true)
        setTimeout(() => {
          setShowAlert(false)
        }, 4000)
      }
      const data = await response.json();
      if (data !== false) {
        //צריך להוסיף את הid לlocal storage
        localStorage.setItem('userId', data)
        // להעביר את המשתמש שנרשם לדף הבית
        Navigate('Home')
      }
      else {
        setAlertMessage(`Somthing went Wrong...`)
        setShowAlert(true)
        setTimeout(() => {
          setShowAlert(false)
        }, 4000)
      }
    } catch (error) {
      console.error('Error fetching data:', error);
      setAlertMessage(`There is an error in our system, please try again later`)
      setShowAlert(true)
      setTimeout(() => {
        setShowAlert(false)
      }, 5000)
    }
  };

  return (
    <main>
      {showAlert ? <Alerts type={false} text={alertMeaage} /> : <></>}
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
            <b>Sign Up</b>
          </Typography>
          <Typography level="body-sm">Create your account.</Typography>
        </div>
        <FormControl>
          <FormLabel>First Name</FormLabel>
          <Input
            name="firstName"
            type="text"
            placeholder="First Name"
            value={firstName}
            onChange={(event) => setFirstName(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>Last Name</FormLabel>
          <Input
            name="lastName"
            type="text"
            placeholder="Last Name"
            value={lastName}
            onChange={(event) => setLastName(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>Cell Phone Number</FormLabel>
          <Input
            name="phoneNumber"
            type="tel"
            placeholder="Phone Number"
            value={phoneNumber}
            onChange={(event) => setPhoneNumber(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>Residential Address</FormLabel>
          <Input
            name="address"
            type="text"
            placeholder="Address"
            value={address}
            onChange={(event) => setAddress(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>Email</FormLabel>
          <Input
            name="email"
            type="email"
            placeholder="Email"
            value={email}
            onChange={(event) => setEmail(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>Description</FormLabel>
          <Input
            name="description"
            type="text"
            placeholder="description"
            value={description}
            onChange={(event) => setDescription(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>Password:</FormLabel>
          <Input
            name="password"
            type="password"
            placeholder="Password"
            value={password}
            onChange={(event) => setPassword(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>Confirm Password</FormLabel>
          <Input
            name="confirmPassword"
            type="password"
            placeholder="Confirm Password"
            value={confirmPassword}
            onChange={(event) => setConfirmPassword(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>Gender</FormLabel>
          <Input
            name="gender"
            type="text"
            placeholder="Gender"
            value={gender}
            onChange={(event) => setGender(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>Sector</FormLabel>
          <Input
            name="sector"
            type="text"
            placeholder="Sector"
            value={sector}
            onChange={(event) => setSector(event.target.value)}
          />
        </FormControl>
        <FormControl>
          <FormLabel>Age</FormLabel>
          <Input
            name="age"
            type="number"
            placeholder="Age"
            value={age}
            onChange={(event) => setAge(event.target.value)}
          />
        </FormControl>
        <Button onClick={handleSignup} sx={{ mt: 1 }}>Sign Up</Button>
        <Typography
          endDecorator={<Link href="/login">Login</Link>}
          fontSize="sm"
          sx={{ alignSelf: 'center' }}
        >
          Already have an account?
       
        </Typography>
      </Sheet>
    </main>
  );
}
