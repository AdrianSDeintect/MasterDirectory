import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaMerchandisingRow } from "./CategoriaMerchandisingRow";

export namespace CategoriaMerchandisingService {
    export const baseUrl = 'Merchandising/CategoriaMerchandising';

    export declare function Create(request: SaveRequest<CategoriaMerchandisingRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaMerchandisingRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaMerchandisingRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaMerchandisingRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Merchandising/CategoriaMerchandising/Create",
        Update: "Merchandising/CategoriaMerchandising/Update",
        Delete: "Merchandising/CategoriaMerchandising/Delete",
        Retrieve: "Merchandising/CategoriaMerchandising/Retrieve",
        List: "Merchandising/CategoriaMerchandising/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CategoriaMerchandisingService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}