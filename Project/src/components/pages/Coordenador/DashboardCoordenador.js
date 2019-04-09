import React from 'react';
import { MDBRow } from 'mdbreact';
import CoordenadorSection from './Coordenador/CoordenadorSection';
import BreadcrumSection from '../BreadcrumSection';
// import ModalSection from './sections/ModalSection';

const DashboardCoordenador = () => {
  return (
    <React.Fragment>
      <BreadcrumSection />
      <CoordenadorSection />
    </React.Fragment>
  )
}

export default DashboardCoordenador;