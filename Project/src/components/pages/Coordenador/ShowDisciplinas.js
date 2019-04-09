import React from 'react';
import { MDBDataTable } from 'mdbreact';

const ShowTurmas = () => {
  const data = {
    columns: [
      {
        label: 'Nome',
        field: 'nome',
        sort: 'asc',
        width: 150
      },
      {
        label: 'Tipo',
        field: 'tipo',
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