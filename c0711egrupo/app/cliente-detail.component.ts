import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

import { Cliente }        from './cliente';
import { ClienteService } from './cliente.service';

@Component({
  selector: 'my-cliente-detail',
  templateUrl: 'app/cliente-detail.component.html',
  styleUrls: ['app/cliente-detail.component.css']
})
export class ClienteDetailComponent implements OnInit {
    cliente: Cliente;
    create: boolean;
    vacio: boolean;

  constructor(
    private clienteService: ClienteService,
    private route: ActivatedRoute) {
  }

  ngOnInit(): void {
    this.route.params.forEach((params: Params) => {
        let id = +params['id'];
        if (id) {
            this.create = false;
            this.clienteService.getCliente(id)
                .then(cliente => this.cliente = cliente);
        } else {
            this.cliente = new Cliente();
            this.create = true;
        }
      });
  }

  save(): void {
      if (!this.cliente.nombre || !this.cliente.apellidos || !this.cliente.dni || !this.cliente.direccion || !this.cliente.fechaAlta) {
          this.vacio = true;
      } 
      this.clienteService.update(this.cliente)
      .then(this.goBack);
  }
  add(): void {
      if (!this.cliente.nombre || !this.cliente.apellidos || !this.cliente.dni || !this.cliente.direccion || !this.cliente.fechaAlta) {
          this.vacio = true;
      } else {

          this.vacio = false;
          this.clienteService.create(this.cliente)
              .then(this.goBack);
      }
  }

  goBack(): void {
    window.history.back();
  }
}