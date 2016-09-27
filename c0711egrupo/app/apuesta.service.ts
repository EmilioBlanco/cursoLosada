import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { Mensaje } from './Mensaje';

@Injectable()
export class MensajeService {

    private headersAccept = new Headers({ 'Accept': 'application/json' });
    private headers = new Headers({ 'Content-Type': 'application/json' });
  private MensajesUrl = 'api/Mensajes';  // URL to web api

  constructor(private http: Http) { }

  getMensajes(): Promise<Mensaje[]> {
    return this.http.get(this.MensajesUrl)
               .toPromise()
               .then(response => response.json() as Mensaje[])
               .catch(this.handleError);
  }

  getMensaje(id: number): Promise<Mensaje> {
    return this.getMensajes()
               .then(Mensajes => Mensajes.find(Mensaje => Mensaje.id === id));
  }

  delete(id: number): Promise<void> {
    let url = `${this.MensajesUrl}/${id}`;
    return this.http.delete(url, {headers: this.headers})
      .toPromise()
      .then(() => null)
      .catch(this.handleError);
  }

  create(Mensaje: Mensaje): Promise<Mensaje> {
      return this.http
          .post(this.MensajesUrl, Mensaje, { headers: this.headersAccept })
          .toPromise()
          .then(res => res.json())
          .catch(this.handleError);
  }

  update(Mensaje: Mensaje): Promise<Mensaje> {
    const url = `${this.MensajesUrl}/${Mensaje.id}`;
    return this.http
        .put(url, JSON.stringify(Mensaje),
        { headers: this.headers })
      .toPromise()
      .then(() => Mensaje)
      .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
  }
}