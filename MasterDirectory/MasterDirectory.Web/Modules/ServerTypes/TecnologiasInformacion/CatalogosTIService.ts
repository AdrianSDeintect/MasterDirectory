import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CatalogosTIRow } from "./CatalogosTIRow";

export namespace CatalogosTIService {
    export const baseUrl = 'TecnologiasInformacion/CatalogosTI';

    export declare function Create(request: SaveRequest<CatalogosTIRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CatalogosTIRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CatalogosTIRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CatalogosTIRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "TecnologiasInformacion/CatalogosTI/Create",
        Update: "TecnologiasInformacion/CatalogosTI/Update",
        Delete: "TecnologiasInformacion/CatalogosTI/Delete",
        Retrieve: "TecnologiasInformacion/CatalogosTI/Retrieve",
        List: "TecnologiasInformacion/CatalogosTI/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CatalogosTIService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}