import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

import { Mensaje }        from './Mensaje';
import { MensajeService } from './Mensaje.service';
import {Cliente} from './cliente';
import {ClienteService} from './cliente.service';

@Component({
  selector: 'my-Mensaje-detail',
  templateUrl: 'app/Mensaje-detail.component.html',
  styleUrls: ['app/Mensaje-detail.component.css']
})
export class MensajeDetailComponent implements OnInit {
    Mensaje: Mensaje;
    create: boolean;
    clientes: Cliente[];
    vacio: boolean;

  constructor(
      private MensajeService: MensajeService,
      private clienteService: ClienteService,
    private route: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.route.params.forEach((params: Params) => {
        let id = +params['id'];
        if (id) {
            this.create = false;
            this.MensajeService.getMensaje(id)
                .then(Mensaje => this.Mensaje = Mensaje);
            
        } else {
            this.Mensaje = new Mensaje();
            this.create = true;
        }        
      });
    this.route.params.forEach((params: Params) => {
        this.clienteService.getClientes().then(clientes => this.clientes = clientes)
    });
}
  

  save(): void {
      if (!this.Mensaje.textoUsuario || !this.Mensaje.cantidad || !this.Mensaje.UsrID || !this.Mensaje.fechaMensaje) {
          this.vacio = true;
      } else {
          this.vacio = false;
          this.MensajeService.update(this.Mensaje)
              .then(this.goBack);
      }
  }
  add(): void {
      if (!this.Mensaje.textoUsuario || !this.Mensaje.cantidad || !this.Mensaje.UsrID || this.Mensaje.fechaMensaje) {
          this.vacio = true;
      } else {
          this.vacio = false;
          this.MensajeService.create(this.Mensaje)
              .then(this.goBack);

      }
      
  }

  goBack(): void {
    window.history.back();
  }
}