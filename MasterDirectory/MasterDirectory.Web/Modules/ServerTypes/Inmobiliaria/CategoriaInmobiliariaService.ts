import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaInmobiliariaRow } from "./CategoriaInmobiliariaRow";

export namespace CategoriaInmobiliariaService {
    export const baseUrl = 'Inmobiliaria/CategoriaInmobiliaria';

    export declare function Create(request: SaveRequest<CategoriaInmobiliariaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaInmobiliariaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaInmobiliariaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaInmobiliariaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Inmobiliaria/CategoriaInmobiliaria/Create",
        Update: "Inmobiliaria/CategoriaInmobiliaria/Update",
        Delete: "Inmobiliaria/CategoriaInmobiliaria/Delete",
        Retrieve: "Inmobiliaria/CategoriaInmobiliaria/Retrieve",
        List: "Inmobiliaria/CategoriaInmobiliaria/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CategoriaInmobiliariaService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}