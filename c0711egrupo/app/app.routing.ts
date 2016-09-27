import { ModuleWithProviders }  from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { MensajesComponent }     from './mensajes.component';
import { MensajeDetailComponent } from './mensaje-detail.component';

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
  }

];

export const routing: ModuleWithProviders = RouterModule.forRoot(appRoutes);