import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaDigitalRow } from "./CategoriaDigitalRow";
import { ExcelImportRequest, ExcelImportResponse } from "@serenity-is/extensions";

export namespace CategoriaDigitalService {
    export const baseUrl = 'Digital/CategoriaDigital';

    export declare function Create(request: SaveRequest<CategoriaDigitalRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaDigitalRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaDigitalRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaDigitalRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Digital/CategoriaDigital/Create",
        Update: "Digital/CategoriaDigital/Update",
        Delete: "Digital/CategoriaDigital/Delete",
        Retrieve: "Digital/CategoriaDigital/Retrieve",
        List: "Digital/CategoriaDigital/List",
        ExcelImport: "Digital/CategoriaDigital/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>CategoriaDigitalService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}