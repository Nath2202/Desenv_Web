import React from 'react';
import { Route, Switch } from 'react-router-dom';
import DashboardCoordenador from './pages/Coordenador/DashboardCoordenador';
import AddProfessor from './pages/Coordenador/AddProfessor';
import ShowProfessor from './pages/Coordenador/ShowProfessores';
import AddDisciplina from './pages/Coordenador/AddDisciplina';
import ShowDisciplina from './pages/Coordenador/ShowDisciplinas';
import AddTurma from './pages/Coordenador/AddTurmas';
import ShowTurma from './pages/Coordenador/ShowTurmas';


class Routes extends React.Component {
  render() {
    return (
      <Switch>
        <Route path='/' exact component={DashboardCoordenador} />
        <Route path='/dashboardCoordenador' component={DashboardCoordenador} />
        <Route path='/addProfessor' component={AddProfessor}/>
        <Route path='/showProfessor' component={ShowProfessor}/>
        <Route path='/addDisciplina' component={AddDisciplina}/>
        <Route path='/showDisciplina' component={ShowDisciplina}/>
        <Route path='/addTurma' component={AddTurma}/>
        <Route path='/showTurma' component={ShowTurma}/>
      </Switch>
    );
  }
}

export default Routes;
