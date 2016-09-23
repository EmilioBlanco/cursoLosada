import { ModuleWithProviders }  from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ClientesComponent }     from './clientes.component';
import { ClienteDetailComponent } from './cliente-detail.component';
import {ApuestasComponent} from './apuestas.component';
import {ApuestaDetailComponent} from './apuesta-detail.component';

const appRoutes: Routes = [
  {
    path: '',
    redirectTo: '/apuestas',
    pathMatch: 'full'
  },
  {
      path: 'cliente-details/:id',
      component: ClienteDetailComponent
  },
  {
      path: 'cliente-details',
      component: ClienteDetailComponent
  },
  {
      path: 'clientes',
      component: ClientesComponent
  },
  {
      path: 'apuestas',
      component: ApuestasComponent
  },
  {
      path: 'apuesta-details/:id',
      component: ApuestaDetailComponent
  },
  {
      path: 'apuesta-details',
      component: ApuestaDetailComponent
  }

];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);