import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaConsultoriosRow } from "./CategoriaConsultoriosRow";

export namespace CategoriaConsultoriosService {
    export const baseUrl = 'Consultorios/CategoriaConsultorios';

    export declare function Create(request: SaveRequest<CategoriaConsultoriosRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaConsultoriosRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaConsultoriosRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaConsultoriosRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Consultorios/CategoriaConsultorios/Create",
        Update: "Consultorios/CategoriaConsultorios/Update",
        Delete: "Consultorios/CategoriaConsultorios/Delete",
        Retrieve: "Consultorios/CategoriaConsultorios/Retrieve",
        List: "Consultorios/CategoriaConsultorios/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CategoriaConsultoriosService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}