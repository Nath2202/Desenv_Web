import React from 'react';
import { MDBRow } from 'mdbreact';
// import TableSection from './sections/TableSection';
import BreadcrumSection from './sections/BreadcrumSection';
// import ChartSection1 from './sections/ChartSection1';
// import ChartSection2 from './sections/ChartSection2';
// import MapSection from './sections/MapSection';
// import ModalSection from './sections/ModalSection';

const DashboardPage = () => {
  return (
    <React.Fragment>
      <BreadcrumSection />
      {/* <MDBRow className="mb-4">
          <MapSection />
          <ModalSection />
      </MDBRow> */}

    </React.Fragment>
  )
}

export default DashboardPage;