import {Usuario} from './usuario';
export class Mensaje {
    id: number;
    EmisorID: number;
    eUsuario: Usuario;
    ReceptorID: number;
    rUsuario: Usuario;
    asunto: string;
    fecha: string;
    cuerpo: string;
    estado: boolean;
    bandeja: boolean;
}