import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CatalogosTesoreriaRow } from "./CatalogosTesoreriaRow";

export namespace CatalogosTesoreriaService {
    export const baseUrl = 'Tesoreria/CatalogosTesoreria';

    export declare function Create(request: SaveRequest<CatalogosTesoreriaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CatalogosTesoreriaRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CatalogosTesoreriaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CatalogosTesoreriaRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Tesoreria/CatalogosTesoreria/Create",
        Update: "Tesoreria/CatalogosTesoreria/Update",
        Delete: "Tesoreria/CatalogosTesoreria/Delete",
        Retrieve: "Tesoreria/CatalogosTesoreria/Retrieve",
        List: "Tesoreria/CatalogosTesoreria/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CatalogosTesoreriaService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}