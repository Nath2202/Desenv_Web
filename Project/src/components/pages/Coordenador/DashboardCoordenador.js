import React from 'react';
import { MDBRow } from 'mdbreact';
import CoordenadorSection from './CoordenadorSection';
import BreadcrumSection from './BreadcrumSection';

const DashboardCoordenador = () => {
  return (
    <React.Fragment>
      <BreadcrumSection />
      <CoordenadorSection />
    </React.Fragment>
  )
}

export default DashboardCoordenador;