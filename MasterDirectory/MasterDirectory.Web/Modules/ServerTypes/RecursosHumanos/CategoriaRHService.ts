import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaRHRow } from "./CategoriaRHRow";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";

export namespace CategoriaRHService {
    export const baseUrl = 'RecursosHumanos/CategoriaRH';

    export declare function Create(request: SaveRequest<CategoriaRHRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaRHRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaRHRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaRHRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "RecursosHumanos/CategoriaRH/Create",
        Update: "RecursosHumanos/CategoriaRH/Update",
        Delete: "RecursosHumanos/CategoriaRH/Delete",
        Retrieve: "RecursosHumanos/CategoriaRH/Retrieve",
        List: "RecursosHumanos/CategoriaRH/List",
        ExcelImport: "RecursosHumanos/CategoriaRH/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>CategoriaRHService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}