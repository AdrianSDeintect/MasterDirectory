import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CatalogosRHRow } from "./CatalogosRHRow";

export namespace CatalogosRHService {
    export const baseUrl = 'RecursosHumanos/CatalogosRH';

    export declare function Create(request: SaveRequest<CatalogosRHRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CatalogosRHRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CatalogosRHRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CatalogosRHRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "RecursosHumanos/CatalogosRH/Create",
        Update: "RecursosHumanos/CatalogosRH/Update",
        Delete: "RecursosHumanos/CatalogosRH/Delete",
        Retrieve: "RecursosHumanos/CatalogosRH/Retrieve",
        List: "RecursosHumanos/CatalogosRH/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CatalogosRHService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}