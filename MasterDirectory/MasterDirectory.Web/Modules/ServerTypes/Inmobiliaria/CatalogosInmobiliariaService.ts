import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CatalogosInmobiliariaRow } from "./CatalogosInmobiliariaRow";

export namespace CatalogosInmobiliariaService {
    export const baseUrl = 'Inmobiliaria/CatalogosInmobiliaria';

    export declare function Create(request: SaveRequest<CatalogosInmobiliariaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CatalogosInmobiliariaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CatalogosInmobiliariaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CatalogosInmobiliariaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Inmobiliaria/CatalogosInmobiliaria/Create",
        Update: "Inmobiliaria/CatalogosInmobiliaria/Update",
        Delete: "Inmobiliaria/CatalogosInmobiliaria/Delete",
        Retrieve: "Inmobiliaria/CatalogosInmobiliaria/Retrieve",
        List: "Inmobiliaria/CatalogosInmobiliaria/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CatalogosInmobiliariaService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}