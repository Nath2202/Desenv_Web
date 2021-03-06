import React from 'react';
import { MDBCard, MDBCardBody, MDBIcon, MDBRow, MDBCol, MDBCardText, MDBBtn } from 'mdbreact';

const CoordenadorSection = () => {
  return (
    <MDBRow className="mb-4">
        <MDBCol xl="3" md="6" className="mb-r">
          <MDBCard className="cascading-admin-card">
              <div className="admin-up">
              <MDBIcon icon="graduation-cap" className="light-blue darken-2"/>
                <div className="data">
                  <h4>
                    <strong>Professores</strong>
                  </h4>
                </div>
              </div>
              <MDBCardBody>
                <MDBBtn tag="a" href="/AddProfessor.js" size="md" floating gradient="purple"> 
                  <MDBIcon icon="user-plus"></MDBIcon>
                </MDBBtn>
                <MDBBtn tag="a" href="/ShowProfessores.js" size="md" floating gradient="peach"> 
                  <MDBIcon icon="eye"></MDBIcon>
                </MDBBtn>
              </MDBCardBody>
            </MDBCard>
        </MDBCol>
        <MDBCol xl="3" md="6" className="mb-r">
          <MDBCard className="cascading-admin-card">
              <div className="admin-up">
              <MDBIcon icon="book-open" className="light-green darken-2"/>
                <div className="data">
                  <h4>
                    <strong>Disciplinas</strong>
                  </h4>
                </div>
              </div>
              <MDBCardBody>
              <MDBBtn tag="a" href="/AddDisciplina.js" size="md" floating gradient="purple"> 
                  <MDBIcon icon="user-plus"></MDBIcon>
                </MDBBtn>
                <MDBBtn tag="a" href="/ShowDisciplinas.js" size="md" floating gradient="peach"> 
                  <MDBIcon icon="eye"></MDBIcon>
                </MDBBtn>
              </MDBCardBody>
            </MDBCard>
        </MDBCol>
        <MDBCol xl="3" md="6" className="mb-r">
          <MDBCard className="cascading-admin-card">
              <div className="admin-up">
              <MDBIcon icon="chalkboard-teacher" className="yellow lighten-1"/>
                <div className="data">
                  <h4>
                    <strong>Turmas</strong>
                  </h4>
                </div>
              </div>
              <MDBCardBody>
              <MDBBtn tag="a" href="/AddTurmas.js" size="md" floating gradient="purple"> 
                  <MDBIcon icon="user-plus"></MDBIcon>
                </MDBBtn>
                <MDBBtn tag="a" href="/ShowTurmas.js" size="md" floating gradient="peach"> 
                  <MDBIcon icon="eye"></MDBIcon>
                </MDBBtn>
              </MDBCardBody>
            </MDBCard>
        </MDBCol>
      </MDBRow>
  )
}

export default CoordenadorSection;

