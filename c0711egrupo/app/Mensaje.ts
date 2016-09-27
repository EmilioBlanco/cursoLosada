import {Usuario} from './usuario';
export class Mensaje {
    id: number;
    EmisorIDID: number;
    EmisorID: Usuario;
    ReceptorIDID: number;
    ReceptorID: Usuario;
    asunto: string;
    fecha: string;
    cuerpo: string;
    estado: boolean;
    bandeja: boolean;
}