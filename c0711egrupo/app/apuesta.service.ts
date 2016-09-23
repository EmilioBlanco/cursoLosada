import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { Apuesta } from './apuesta';

@Injectable()
export class ApuestaService {

    private headersAccept = new Headers({ 'Accept': 'application/json' });
    private headers = new Headers({ 'Content-Type': 'application/json' });
  private apuestasUrl = 'api/apuestas';  // URL to web api

  constructor(private http: Http) { }

  getApuestas(): Promise<Apuesta[]> {
    return this.http.get(this.apuestasUrl)
               .toPromise()
               .then(response => response.json() as Apuesta[])
               .catch(this.handleError);
  }

  getApuesta(id: number): Promise<Apuesta> {
    return this.getApuestas()
               .then(apuestas => apuestas.find(apuesta => apuesta.id === id));
  }

  delete(id: number): Promise<void> {
    let url = `${this.apuestasUrl}/${id}`;
    return this.http.delete(url, {headers: this.headers})
      .toPromise()
      .then(() => null)
      .catch(this.handleError);
  }

  create(apuesta: Apuesta): Promise<Apuesta> {
      return this.http
          .post(this.apuestasUrl, apuesta, { headers: this.headersAccept })
          .toPromise()
          .then(res => res.json())
          .catch(this.handleError);
  }

  update(apuesta: Apuesta): Promise<Apuesta> {
    const url = `${this.apuestasUrl}/${apuesta.id}`;
    return this.http
        .put(url, JSON.stringify(apuesta),
        { headers: this.headers })
      .toPromise()
      .then(() => apuesta)
      .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
  }
}