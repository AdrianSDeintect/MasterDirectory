import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaTesoreriaRow } from "./CategoriaTesoreriaRow";

export namespace CategoriaTesoreriaService {
    export const baseUrl = 'Tesoreria/CategoriaTesoreria';

    export declare function Create(request: SaveRequest<CategoriaTesoreriaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaTesoreriaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaTesoreriaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaTesoreriaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Tesoreria/CategoriaTesoreria/Create",
        Update: "Tesoreria/CategoriaTesoreria/Update",
        Delete: "Tesoreria/CategoriaTesoreria/Delete",
        Retrieve: "Tesoreria/CategoriaTesoreria/Retrieve",
        List: "Tesoreria/CategoriaTesoreria/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CategoriaTesoreriaService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}