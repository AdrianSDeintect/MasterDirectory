import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaTIRow } from "./CategoriaTIRow";

export namespace CategoriaTIService {
    export const baseUrl = 'TecnologiasInformacion/CategoriaTI';

    export declare function Create(request: SaveRequest<CategoriaTIRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaTIRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaTIRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaTIRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "TecnologiasInformacion/CategoriaTI/Create",
        Update: "TecnologiasInformacion/CategoriaTI/Update",
        Delete: "TecnologiasInformacion/CategoriaTI/Delete",
        Retrieve: "TecnologiasInformacion/CategoriaTI/Retrieve",
        List: "TecnologiasInformacion/CategoriaTI/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CategoriaTIService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}