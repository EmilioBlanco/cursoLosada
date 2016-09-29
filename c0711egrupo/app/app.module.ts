import './rxjs-extensions';

import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule }   from '@angular/forms';
import { HttpModule }    from '@angular/http';
//Imports for loading & configuring the in-memory web api
import { InMemoryWebApiModule } from 'angular2-in-memory-web-api';
//import { InMemoryDataService }  from './in-memory-data-service';

import { AppComponent }         from './app.component';
import { UsuarioService }          from './usuario.service';
import { MensajesComponent }      from './mensajes.component';
import { MensajeDetailComponent }  from './mensaje-detail.component';
import { MensajeService }          from './mensaje.service';
import { routing }              from './app.routing';
import { SalidaComponent } from './salida.component';

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
      MensajeDetailComponent,
      MensajesComponent,
      SalidaComponent
  ],
  providers: [
      UsuarioService,
      MensajeService,
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule {
}