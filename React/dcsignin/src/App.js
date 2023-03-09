// import logo from './logo.svg';
import './App.css';
import React, { useState, useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.css';
import Button from 'react-bootstrap/Button';
import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';

function AppFunction() {

  const nav = (
    <Container>
      <div>
        <h5></h5>
      </div>
    </Container>
  );

  const header = (
    <Container fluid>
          <Row>
            <h2 class='font-size: 2.5em;'>The School District of Palm Beach County</h2>
          </Row>
    </Container>
  );

  const title = (
    <div>
      <h1>Data Center Sign In</h1>
    </div>
  );

  const names = (
    <div>
      <h4>###</h4>
    </div>
  );

  const signIn = (
      <div className='d-grid gap-2'>
        <Button type='submit' variant="outline-success" size='lg'>
          <h1>Sign In</h1>
        </Button>
      </div>
  );
  

  const signOut = (
    <div className='d-grid gap-2'>
          <Button type='submit' variant="outline-danger" size='lg'>
            <h1>Sign Out</h1>
          </Button>
      </div>
  );

  const footer = (
    <div>
      <h6>Fulton-Holland Educational Services Center - 3300 Forest Hill Boulevard - West Palm Beach, FL 33406</h6>
    </div>
  );

  return (
    <div className='App'>
      <div className='Header'>
          <div className='Overlay'>
            {header}
        </div>
      </div>

      <Container>
        <div className='Content'>
          <Container>
            <div className='Title'>
              {title}
            </div>
            <div className='Buttons'>
              <Container>
                <Row>
                  <Col><div className='Names'>{names}</div></Col>
                </Row>
                <Row>
                  <Col><div className='SignIn'>{signIn}</div></Col>
                  <Col><div className='SignOut'>{signOut}</div></Col>
                </Row>
              </Container>
            </div>
          </Container>
        </div> 
        <div className='Footer'>{footer}</div>
      </Container>
    </div>
  );

  
    
    
    
    
    
    
    /* <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div> */
}



export default AppFunction;
