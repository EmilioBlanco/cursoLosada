import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { Cliente } from './cliente';

@Injectable()
export class ClienteService {

    private headers = new Headers({ 'Content-Type': 'application/json' });
    private headersAccept = new Headers({ 'Accept': 'application/json' });
  private clientesUrl = 'api/clientes';  // URL to web api

  constructor(private http: Http) { }

  getClientes(): Promise<Cliente[]> {
    return this.http.get(this.clientesUrl)
               .toPromise()
               .then(response => response.json() as Cliente[])
               .catch(this.handleError);
  }

  getCliente(id: number): Promise<Cliente> {
    return this.getClientes()
               .then(clientes => clientes.find(cliente => cliente.id === id));
  }

  delete(id: number): Promise<boolean> {
    let url = `${this.clientesUrl}/${id}`;
    return this.http.delete(url, {headers: this.headers})
        .toPromise()
        .then(res => res.json() as boolean)
      .catch(this.handleError);
  }

  create(cliente: Cliente): Promise<Cliente> {
      return this.http
          .post(this.clientesUrl, cliente, { headers: this.headersAccept })
      .toPromise()
      .then(res => res.json())
      .catch(this.handleError);
  }

  update(cliente: Cliente): Promise<Cliente> {
    const url = `${this.clientesUrl}/${cliente.id}`;
    return this.http
      .put(url, JSON.stringify(cliente), {headers: this.headers})
      .toPromise()
      .then(() => cliente)
      .catch(this.handleError);
  }

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
  }
}