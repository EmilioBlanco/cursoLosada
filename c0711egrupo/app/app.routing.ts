import { ModuleWithProviders }  from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ClientesComponent }     from './clientes.component';
import { ClienteDetailComponent } from './cliente-detail.component';
import {MensajesComponent} from './Mensajes.component';
import {MensajeDetailComponent} from './Mensaje-detail.component';

const appRoutes: Routes = [
  {
    path: '',
    redirectTo: '/Mensajes',
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
      path: 'Mensajes',
      component: MensajesComponent
  },
  {
      path: 'Mensaje-details/:id',
      component: MensajeDetailComponent
  },
  {
      path: 'Mensaje-details',
      component: MensajeDetailComponent
  }

];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);