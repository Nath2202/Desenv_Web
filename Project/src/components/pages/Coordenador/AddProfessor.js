import React from 'react';
import { MDBCard, MDBCardBody, MDBIcon, MDBRow, MDBCol } from 'mdbreact';

const AddProfessor = () => {
  return (
    <MDBRow className="mb-4">
        <MDBContainer>
      <MDBRow>
        <MDBCol md="6">
          <form>
            <p className="h5 text-center mb-4">Cadastro de Disciplinas</p>
            <div className="grey-text">
              <MDBInput
                label="Nome da Disciplina"
                icon=""
                group
                type="text"
                validate
                error="wrong"
                success="right"
              />
              <MDBInput
                label="Código da Disciplina"
                icon=""
                group
                type="text"
                validate
              />
            </div>
            <div className="text-center">
              <MDBBtn color="primary">Submit</MDBBtn>
            </div>
          </form>
        </MDBCol>
      </MDBRow>
    </MDBContainer>
      </MDBRow>
  )
}

export default AddProfessor;

