import { Injectable }    from '@angular/core';
import { Headers, Http } from '@angular/http';

import 'rxjs/add/operator/toPromise';

import { Usuario } from './usuario';

@Injectable()
export class UsuarioService {

    private headers = new Headers({ 'Content-Type': 'application/json' });
    private headersAccept = new Headers({ 'Accept': 'application/json' });
    private usuariosUrl = 'api/usuario';  // URL to web api

  constructor(private http: Http) { }

  getUsuarios(): Promise<Usuario[]> {
      return this.http.get(this.usuariosUrl)
          .toPromise().then(
          response =>
              response.json() as Usuario[]
    )
               .catch(this.handleError);
  }

  update(usuario: Usuario): Promise<Usuario>
  {

      return this.http.put(this.usuariosUrl, JSON.stringify(usuario), { headers: this.headers })
          .toPromise()
          .then(()=> usuario);
      
  }
  //getUsuario(id: number): Promise<Usuario> {
  //  return this.getUsuarios()
  //             .then(users => users.find(usuario => usuario.id === id));
  //}

  //update(usuario: Usuario): Promise<Usuario> {
  //    const url = `${this.usuariosUrl}/${usuario.id}`;
  //    return this.http
  //        .put(url, JSON.stringify(usuario), { headers: this.headers })
  //        .toPromise()
  //        .then(() => usuario)
  //        .catch(this.handleError);
  //} 

  /*delete(id: number): Promise<boolean> {
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

*/

  private handleError(error: any): Promise<any> {
    console.error('An error occurred', error); // for demo purposes only
    return Promise.reject(error.message || error);
  }
}