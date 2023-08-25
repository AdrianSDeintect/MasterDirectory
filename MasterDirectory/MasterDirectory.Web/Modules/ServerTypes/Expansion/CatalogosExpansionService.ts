import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CatalogosExpansionRow } from "./CatalogosExpansionRow";

export namespace CatalogosExpansionService {
    export const baseUrl = 'Expansion/CatalogosExpansion';

    export declare function Create(request: SaveRequest<CatalogosExpansionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CatalogosExpansionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CatalogosExpansionRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CatalogosExpansionRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Expansion/CatalogosExpansion/Create",
        Update: "Expansion/CatalogosExpansion/Update",
        Delete: "Expansion/CatalogosExpansion/Delete",
        Retrieve: "Expansion/CatalogosExpansion/Retrieve",
        List: "Expansion/CatalogosExpansion/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CatalogosExpansionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}