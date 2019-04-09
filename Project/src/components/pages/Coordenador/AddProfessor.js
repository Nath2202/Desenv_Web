import React from "react";
import { MDBContainer, MDBRow, MDBCol, MDBBtn, MDBInput } from 'mdbreact';

const AddProfessor = () => {
  return (
    <MDBContainer>
      <MDBRow>
        <MDBCol md="6">
          <form>
            <p className="h5 text-center mb-4">Cadastro de Disciplinas</p>
            <div className="grey-text">
              <MDBInput
                label="Nome"
                icon=""
                group
                type="text"              
              />
              <MDBInput
                label="Email"
                icon=""
                group
                type="text"   
              />
              <MDBInput
                label="Telefone"
                icon=""
                group
                type="text"   
              />
              <MDBInput
                label="Código da Disciplina"
                icon=""
                group
                type="text"   
              />
            </div>
            <div className="text-center">
              <MDBBtn color="primary">Submit</MDBBtn>
            </div>
          </form>
        </MDBCol>
      </MDBRow>
    </MDBContainer>
  );
};

export default AddProfessor;