import { Component }          from '@angular/core';
import {Usuario} from './usuario'
import {UsuarioService} from './usuario.service';
import { ActivatedRoute, Params } from '@angular/router';
@Component({
  selector: 'my-app',

  template: `
    <head><base href="/"/> </head>
    <h2>{{title}}</h2>
    <div *ngIf="listo">
    <select id="cmbSelectedCliente"[(ngModel)]="selectedUsuario" (change)="onChange($event.target.value)">
        <option *ngFor="let usuario of usuarios" [value]="usuario.id" >{{usuario.nombre}}</option>
    </select>
    </div> 
    <nav>
        <a routerLink="/mensajes" routerLinkActive="active">Mensajes</a>
        <a routerLink="/entrada" routerLinkActive="active">Bandeja de Entrada</a>
        <a routerLink="/salida" routerLinkActive="active">Bandeja de Salida</a>
        <a routerLink="/papelera" routerLinkActive="active">Papelera</a>
    </nav>
    <router-outlet></router-outlet>
    
    
  `,
  styleUrls: ['app/app.component.css']
})
export class AppComponent {
    title = 'This.youMaiL';
    usuarios: Usuario[];
    selectedUsuario: Usuario;
    listo: boolean;

    constructor(
        private usuarioService: UsuarioService,
        private route: ActivatedRoute) { }
    ngOnInit(): void
    {
        this.listo = false;
        this.usuarioService.getUsuarios()
            .then(usuarios => this.usuarios = usuarios)
            .then(users => this.listo = true);
        
    }
    onChange(usuarioSeleccionado: number)
    {
        this.selectedUsuario = this.usuarios[usuarioSeleccionado-1];
        this.usuarioService.update(this.selectedUsuario);
    }

}