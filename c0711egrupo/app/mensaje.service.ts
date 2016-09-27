import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { Mensaje } from './mensaje';

@Injectable()
export class MensajeService {

    private headersAccept = new Headers({ 'Accept': 'application/json' });
    private headers = new Headers({ 'Content-Type': 'application/json' });
  private mensajeUrl = 'api/mensajes';  // URL to web api

  constructor(private http: Http) { }

  getMensajes(): Promise<Mensaje[]> {
      return this.http.get(this.mensajeUrl)
               .toPromise()
               .then(response => response.json() as Mensaje[])
               .catch(this.handleError);
  }

  getMensaje(id: number): Promise<Mensaje> {
    return this.getMensajes()
               .then(mensajes => mensajes.find(mensaje => mensaje.id === id));
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