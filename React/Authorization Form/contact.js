import React from 'react';
import ReactDOM from 'react-dom';

class Contact extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      password: 'swordfish',
      authorized: false
    };
    this.authorize = this.authorize.bind(this);
  }

  authorize(e) {
    const password = e.target.querySelector(
      'input[type="password"]').value;
    const auth = password == this.state.password;
    this.setState({
      authorized: auth
    });
  }

  render() {
    let status;
    const login = (
      <form action='#' onSubmit={this.authorize}>
        <input type='password' placeholder='Password' />
        <input type='submit'/>
      </form>
    )
    const contactInfo = (
      <ul>
        <li>
          client@example.com
        </li>
        <li>
          555.555.5555
        </li>
      </ul>
    );
    if (this.state.authorized === true) {
      status = <h1>Contact</h1>
    } else {
      status = <h1>Enter the Password</h1>
    }
    
    return (
      <div id="authorization">
        {status}
        {this.state.authorized === true ? contactInfo : login}
      </div>
    );
  }
}

ReactDOM.render(
  <Contact />, 
  document.getElementById('app')
);