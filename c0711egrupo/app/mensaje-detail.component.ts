import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

import { Mensaje }        from './mensaje';
import { MensajeService } from './mensaje.service';
import {Usuario} from './usuario';
import {UsuarioService} from './usuario.service';

@Component({
  selector: 'my-mensaje-detail',
  templateUrl: 'app/mensaje-detail.component.html',
  styleUrls: ['app/mensaje-detail.component.css']
})
export class MensajeDetailComponent implements OnInit {
    mensaje: Mensaje;
    create: boolean;
    usuarios: Usuario[];
    //vacio: boolean;

  constructor(
      private mensajeService: MensajeService,
      private usuarioService: UsuarioService,
    private route: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.route.params.forEach((params: Params) => {
        let id = +params['id'];
        if (id) {
            this.create = false;
            this.mensajeService.getMensaje(id)
                .then(mensaje => this.mensaje = mensaje);
            
        } else {
            this.mensaje = new Mensaje();
            this.create = true;
        }        
      });
    this.route.params.forEach((params: Params) => {
        this.usuarioService.getUsuarios().then(usuario => this.usuarios = usuario)
    });
}
  

  //save(): void {
  //    if (!this.mensaje.textoUsuario || !this.apuesta.cantidad || !this.apuesta.UsrID || !this.apuesta.fechaApuesta) {
  //        this.vacio = true;
  //    } else {
  //        this.vacio = false;
  //        this.apuestaService.update(this.apuesta)
  //            .then(this.goBack);
  //    }
  //}
  add(): void {
          this.mensajeService.create(this.mensaje)
              .then(this.goBack);

      
      
  }

  goBack(): void {
    window.history.back();
  }
}