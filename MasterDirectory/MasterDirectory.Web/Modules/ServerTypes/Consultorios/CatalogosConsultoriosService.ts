import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CatalogosConsultoriosRow } from "./CatalogosConsultoriosRow";

export namespace CatalogosConsultoriosService {
    export const baseUrl = 'Consultorios/CatalogosConsultorios';

    export declare function Create(request: SaveRequest<CatalogosConsultoriosRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CatalogosConsultoriosRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CatalogosConsultoriosRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CatalogosConsultoriosRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Consultorios/CatalogosConsultorios/Create",
        Update: "Consultorios/CatalogosConsultorios/Update",
        Delete: "Consultorios/CatalogosConsultorios/Delete",
        Retrieve: "Consultorios/CatalogosConsultorios/Retrieve",
        List: "Consultorios/CatalogosConsultorios/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CatalogosConsultoriosService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}