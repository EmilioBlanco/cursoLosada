import { Component, OnInit } from '@angular/core';
import { Router }            from '@angular/router';

import { Usuario }                from './usuario';
import { UsuarioService }         from './usuario.service';

@Component({
  selector: 'my-app',
  templateUrl: 'app/usuarios.component.html',
  styleUrls:  ['app/usuarios.component.css']
})
export class UsuariosComponent implements OnInit {
  usuarios: Usuario[];
  selectedUsuario: Usuario;

  constructor(
    private usuarioService: UsuarioService,
    private router: Router) { }

  getUsuarios(): void {
      this.usuarioService
          .getUsuarios()
        .then(usuarios => this.usuarios = usuarios);
  }

  //delete(usuario: Usuario): void {
  //    debugger
  //    var test = "br";
  //    this.usuarioService.delete(usuario.id)
  //        .then(x => {
  //            this.puedeBorrar = x;
  //            if (this.puedeBorrar) {
  //                this.noDeleted = false;
  //            this.usuarios = this.usuarios.filter(usuario2 => usuario2 !== usuario);
  //            if (this.selectedUsuario === usuario) { this.selectedUsuario = null; }
  //    } else {
  //        this.noDeleted = true;
  //        }
  //    });
      

      /*this.usuarioService
          .delete(usuario.id)
          .then(() => {
              this.usuarios = this.usuarios.filter(usuario2 => usuario2 !== usuario);
              if (this.selectedUsuario === usuario) {
                  this.selectedUsuario = null;
              }
          });*/

  ngOnInit(): void {
    this.getUsuarios();
  }

  onSelect(usuario: Usuario): void {
      this.selectedUsuario = usuario;
  }
}