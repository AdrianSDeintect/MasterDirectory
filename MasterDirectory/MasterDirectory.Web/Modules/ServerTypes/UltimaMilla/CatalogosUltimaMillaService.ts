import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CatalogosUltimaMillaRow } from "./CatalogosUltimaMillaRow";

export namespace CatalogosUltimaMillaService {
    export const baseUrl = 'UltimaMilla/CatalogosUltimaMilla';

    export declare function Create(request: SaveRequest<CatalogosUltimaMillaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CatalogosUltimaMillaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CatalogosUltimaMillaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CatalogosUltimaMillaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "UltimaMilla/CatalogosUltimaMilla/Create",
        Update: "UltimaMilla/CatalogosUltimaMilla/Update",
        Delete: "UltimaMilla/CatalogosUltimaMilla/Delete",
        Retrieve: "UltimaMilla/CatalogosUltimaMilla/Retrieve",
        List: "UltimaMilla/CatalogosUltimaMilla/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CatalogosUltimaMillaService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}