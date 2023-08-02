import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CatalogosMerchandisingRow } from "./CatalogosMerchandisingRow";

export namespace CatalogosMerchandisingService {
    export const baseUrl = 'Merchandising/CatalogosMerchandising';

    export declare function Create(request: SaveRequest<CatalogosMerchandisingRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CatalogosMerchandisingRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CatalogosMerchandisingRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CatalogosMerchandisingRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Merchandising/CatalogosMerchandising/Create",
        Update: "Merchandising/CatalogosMerchandising/Update",
        Delete: "Merchandising/CatalogosMerchandising/Delete",
        Retrieve: "Merchandising/CatalogosMerchandising/Retrieve",
        List: "Merchandising/CatalogosMerchandising/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CatalogosMerchandisingService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}