import React from 'react';
import { MDBDataTable } from 'mdbreact';

const ShowProfessores = () => {
  const data = {
    columns: [
      {
        label: 'Nome',
        field: 'nome',
        sort: 'asc',
        width: 150
      },
      {
        label: 'Email',
        field: 'email',
        sort: 'asc',
        width: 150
      },
      {
        label: 'Telefone',
        field: 'tel',
        sort: 'asc',
        width: 150
      },
      {
        label: 'Disciplina',
        field: 'codDisciplina',
        sort: 'asc',
        width: 150
      }
    ]
  };

  return (
    <MDBDataTable
      striped
      hover
      data={data}
    />
  );
}

export default ShowProfessores;