import React from 'react';
import { MDBFooter, MDBBtn, MDBIcon } from 'mdbreact';

const Footer = () => {
    return (
        <MDBFooter color="blue" className="text-center font-small darken-2">
            {/* <div className="pt-4">
                <MDBBtn outline color="white" tag="a" href="https://mdbootstrap.com/docs/react/getting-started/download/" target="_blank">Download MDB<MDBIcon icon="download" className="ml-2"/></MDBBtn>
                <MDBBtn outline color="white" tag="a" href="https://mdbootstrap.com/docs/react/getting-started/quick-start/" target="_blank">Start free tutorial<MDBIcon icon="graduation-cap" className="ml-2"/></MDBBtn>
                <hr className="my4"/>
            </div>
            <p className="footer-copyright mb-0 py-3 text-center">
                &copy; {new Date().getFullYear()} Copyright: <a href="https://www.MDBootstrap.com"> MDBootstrap.com </a>
            </p> */}
        </MDBFooter>
    );
}

export default Footer;