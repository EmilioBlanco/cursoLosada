import { ModuleWithProviders }  from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MensajesComponent }     from './mensajes.component';
import { MensajeDetailComponent } from './mensaje-detail.component';
import { SalidaComponent } from './salida.component';
import {PapeleraComponent} from './papelera.component';
import {EntradaComponent} from './entrada.component';

const appRoutes: Routes = [
  {
    path: '',
    redirectTo: '/mensajes',
    pathMatch: 'full'
  },
  {
      path: 'mensaje-details/:id',
      component: MensajeDetailComponent
  },
  {
      path: 'mensajes',
      component: MensajesComponent
  },
  {
      path: 'mensaje-details',
      component: MensajeDetailComponent
  },
  {
      path: 'papelera',
      component: PapeleraComponent
  },
  {
      path: 'salida',
      component: SalidaComponent
  },
  {
      path: 'entrada',
      component: EntradaComponent
  }

];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);