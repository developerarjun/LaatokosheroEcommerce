import * as React from 'react';
import axios from "axios";

export default class Login  extends React.PureComponent {
    constructor(props) {
      super(props);
       this.state = {
        email: "",
        password: "",
        loginErrors: ""
      };
  
      this.handleSubmit = this.handleSubmit.bind(this);
      this.handleChange = this.handleChange.bind(this);
    }
    handleChange(event) {
        this.setState({
          [event.target.name]: event.target.value
        });
    }
    
  handleSubmit(event) {
    document.getElementById("btnLogin").disabled = true;
    const { email, password } = this.state;
    if(email == "" || password == "") 
    {
        document.getElementById("btnLogin").disabled = false; 
        alert('Please Enter Email and Password'); 
        return;
    }
    axios
      .post(
        "http://localhost:3001/sessions",
        {
          user: {
            email: email,
            password: password
          }
        },
        { withCredentials: true }
      )
      .then(response => {
        if (response.data.logged_in) {
          this.props.handleSuccessfulAuth(response.data);
        }
      })
      .catch(error => {
        document.getElementById("btnLogin").disabled = false;
        console.log("login error", error);
      });
    event.preventDefault();
  }
    componentDidMount(){
        document.title = "Laatokoshero Admin Login"
    }
    render() {
        return (          
            <div className="innner-content-sec pb-5">
            <section className="title-sec">
            <div className="container">
            <div className="inner-block-head">
            <h3 style={{ textAlign: 'center'}}>Laatokoshero Admin Login</h3>
            </div>
            </div>
            </section>
            
            <section className="menu-sec">
            <div className="container">
            <div className="m-auto" style={{maxWidth:'500px'}}>
            <div className="border-bottom pb-4 mb-3">
              
              <div className="mb-3">
                  <label htmlFor="inputEmail" className="form-label">Email address</label>
                  <input type="email" name="email" className="form-control " id="inputEmail"
                    placeholder="yours@email.com" autoComplete="off"
                    value={this.state.email}
                    onChange={this.handleChange}
                    required />
              </div>
                <div className="mb-3">
                    <label htmlFor="inputPassword" className="form-label">Password</label>
                    <input type="password" name="password" className="form-control " 
                    id="inputPassword" placeholder="*****" autoComplete="off" 
                    value={this.state.password}
                    onChange={this.handleChange}
                     />
                </div>
                <button type="submit" id="btnLogin" onClick={this.handleSubmit} className="btn btn-custom w-100">Login</button>
               
            </div>
            </div>
            </div>
            </section>
            </div>
        );
    }
}