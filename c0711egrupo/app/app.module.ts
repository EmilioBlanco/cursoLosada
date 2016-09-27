import './rxjs-extensions';

import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }   from '@angular/forms';
import { HttpModule }    from '@angular/http';
// Imports for loading & configuring the in-memory web api
import { InMemoryWebApiModule } from 'angular2-in-memory-web-api';
//import { InMemoryDataService }  from './in-memory-data.service';

import { AppComponent }         from './app.component';
import { ClientesComponent }      from './clientes.component';
import { ClienteDetailComponent }  from './cliente-detail.component';
import { ClienteService }          from './cliente.service';
import { MensajesComponent }      from './Mensajes.component';
import { MensajeDetailComponent }  from './Mensaje-detail.component';
import { MensajeService }          from './Mensaje.service';
import { routing }              from './app.routing';

@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    //InMemoryWebApiModule.forRoot(InMemoryDataService),
    routing
  ],
  declarations: [
    AppComponent,
    ClienteDetailComponent,
    ClientesComponent,
    MensajeDetailComponent,
    MensajesComponent,
  ],
  providers: [
      ClienteService,
      MensajeService,
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule {
}