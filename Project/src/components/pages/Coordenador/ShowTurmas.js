import React from 'react';
import { MDBDataTable } from 'mdbreact';

const ShowTurmas = () => {
  const data = {
    columns: [
      {
        label: 'Id',
        field: 'id',
        sort: 'asc',
        width: 150
      },
      {
        label: 'Disciplina',
        field: 'disciplina',
        sort: 'asc',
        width: 150
      },
      {
        label: 'Período',
        field: 'periodo',
        sort: 'asc',
        width: 150
      },
      {
        label: 'Vagas',
        field: 'vagas',
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

export default ShowTurmas;