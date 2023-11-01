import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaOperacionesRow } from "./CategoriaOperacionesRow";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";

export namespace CategoriaOperacionesService {
    export const baseUrl = 'Operaciones/CategoriaOperaciones';

    export declare function Create(request: SaveRequest<CategoriaOperacionesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaOperacionesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaOperacionesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaOperacionesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Operaciones/CategoriaOperaciones/Create",
        Update: "Operaciones/CategoriaOperaciones/Update",
        Delete: "Operaciones/CategoriaOperaciones/Delete",
        Retrieve: "Operaciones/CategoriaOperaciones/Retrieve",
        List: "Operaciones/CategoriaOperaciones/List",
        ExcelImport: "Operaciones/CategoriaOperaciones/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>CategoriaOperacionesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}