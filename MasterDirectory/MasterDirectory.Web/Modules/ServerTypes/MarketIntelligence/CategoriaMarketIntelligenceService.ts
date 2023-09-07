import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CategoriaMarketIntelligenceRow } from "./CategoriaMarketIntelligenceRow";

export namespace CategoriaMarketIntelligenceService {
    export const baseUrl = 'MarketIntelligence/CategoriaMarketIntelligence';

    export declare function Create(request: SaveRequest<CategoriaMarketIntelligenceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CategoriaMarketIntelligenceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategoriaMarketIntelligenceRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategoriaMarketIntelligenceRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "MarketIntelligence/CategoriaMarketIntelligence/Create",
        Update: "MarketIntelligence/CategoriaMarketIntelligence/Update",
        Delete: "MarketIntelligence/CategoriaMarketIntelligence/Delete",
        Retrieve: "MarketIntelligence/CategoriaMarketIntelligence/Retrieve",
        List: "MarketIntelligence/CategoriaMarketIntelligence/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CategoriaMarketIntelligenceService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}