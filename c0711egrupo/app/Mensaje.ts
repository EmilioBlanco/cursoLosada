import {Usuario} from './usuario';
export class Mensaje {
    id: number;
    emisorID: number;
    emisor: Usuario;
    receptorID: number;
    receptor: Usuario;
    asunto: string;
    fecha: string;
    cuerpo: string;
    estado: boolean;
    bandeja: boolean;
}