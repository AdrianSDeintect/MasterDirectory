import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaUltimaMillaRow } from "./CategoriaUltimaMillaRow";

export namespace CategoriaUltimaMillaService {
    export const baseUrl = 'UltimaMilla/CategoriaUltimaMilla';

    export declare function Create(request: SaveRequest<CategoriaUltimaMillaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaUltimaMillaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaUltimaMillaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaUltimaMillaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "UltimaMilla/CategoriaUltimaMilla/Create",
        Update: "UltimaMilla/CategoriaUltimaMilla/Update",
        Delete: "UltimaMilla/CategoriaUltimaMilla/Delete",
        Retrieve: "UltimaMilla/CategoriaUltimaMilla/Retrieve",
        List: "UltimaMilla/CategoriaUltimaMilla/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CategoriaUltimaMillaService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}