﻿import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaComercialesRow } from "./CategoriaComercialesRow";

export namespace CategoriaComercialesService {
    export const baseUrl = 'Comerciales/CategoriaComerciales';

    export declare function Create(request: SaveRequest<CategoriaComercialesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaComercialesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaComercialesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaComercialesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Comerciales/CategoriaComerciales/Create",
        Update: "Comerciales/CategoriaComerciales/Update",
        Delete: "Comerciales/CategoriaComerciales/Delete",
        Retrieve: "Comerciales/CategoriaComerciales/Retrieve",
        List: "Comerciales/CategoriaComerciales/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CategoriaComercialesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}