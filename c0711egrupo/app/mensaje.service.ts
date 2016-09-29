import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { Mensaje } from './mensaje';
import {Usuario} from './usuario';

@Injectable()
export class MensajeService {

    private headersAccept = new Headers({ 'Accept': 'application/json' });
    private headers = new Headers({ 'Content-Type': 'application/json' });
    private mensajeUrl = 'api/mensaje';  // URL to web api
    private entradaUrl = 'api/entrada'; //URL entrada
    private salidaUrl = 'api/salida';//URL salidas
    private papeleraUrl = 'api/papelera'; //URL papelera

  constructor(private http: Http) { }

  getMensajes(): Promise<Mensaje[]> {
      return this.http.get(this.mensajeUrl)
               .toPromise()
               .then(response => response.json() as Mensaje[])
               .catch(this.handleError);
  }

  getMensaje(id: number): Promise<Mensaje> {
      debugger
      return this.http.get(this.mensajeUrl + '/' + id)
          .toPromise()
          .then(response => response.json() as Mensaje);
  }
  getEntrada(): Promise<Mensaje[]> {
      return this.http.get(this.entradaUrl)
          .toPromise()
          .then(response => response.json() as Mensaje[])
          .catch(this.handleError);
  }

  getSalida(): Promise<Mensaje[]> {
      return this.http.get(this.salidaUrl)
          .toPromise()
          .then(response => response.json() as Mensaje[])
          .catch(this.handleError);
  }
  getPapelera(): Promise<Mensaje[]> {
      return this.http.get(this.papeleraUrl)
          .toPromise()
          .then(response => response.json() as Mensaje[])
          .catch(this.handleError);
  }
    

  update(mensaje: Mensaje): Promise<Mensaje> {
      const url = `${this.mensajeUrl}/${mensaje.id}`;
      return this.http
          .put(url, JSON.stringify(mensaje), { headers: this.headers })
          .toPromise()
          .then(() => mensaje)
          .catch(this.handleError);
  }

  delete(id: number): Promise<void> {
    let url = `${this.mensajeUrl}/${id}`;
    return this.http.delete(url, {headers: this.headers})
      .toPromise()
      .then(() => null)
      .catch(this.handleError);
  }

  create(mensaje: Mensaje): Promise<Mensaje> {
      return this.http
          .post(this.mensajeUrl, mensaje, { headers: this.headersAccept })
          .toPromise()
          .then(res => res.json())
          .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
  }
}