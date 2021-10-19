import * as React from 'react';

export default class Layout extends React.PureComponent<{}> {
    public render() {
        return (
            <header className="header">
            <div className="header-upper">
                <div className="container">
                  <div className="header-upp-block">
                    <div className="header-logo">
                      <a href="index.html">
                          <img src={ process.env.PUBLIC_URL +'/assets/images/logo.png' } alt="Laatokoshero Foods" className="img-fluid" /></a>
                    </div>
                    <div className="header-right">
                      <div className="header-address">
                        <div className="item-header-address">
                          <i className="fas fa-map-marker-alt"></i>
                          <address className="head-addrs">
                            <a>Dhobighat<br/>
                            Lalitpur, Nepal</a>
                          </address>
                        </div>
                        <div className="item-header-address">
                          <i className="fas fa-phone-alt"></i>
                          <address className="head-addrs">
                            <a>9847379890, 9801079890</a>
                            <br/> 
                            <span>24 hrs Service</span>
                          </address>
                        </div>
                      </div>
                      <div className="header-social">
                        <a href="https://www.facebook.com/Laatokoshero" target="_blank"><i className="fab fa-facebook-f"></i></a>
                        <a href="#"><i className="fab fa-twitter"></i></a>
                        <a href="https://www.youtube.com/channel/UCeZm-VKD2WJlO7085v0fbdA" target="_blank"><i className="fab fa-youtube"></i></a>
                        <a href="http://instagram.com/laatokoshero" target="_blank"><i className="fab fa-instagram-square"></i></a>
                      </div>
                    </div>
                  </div>
                </div>
            </div>
          </header>
        );
    }
}