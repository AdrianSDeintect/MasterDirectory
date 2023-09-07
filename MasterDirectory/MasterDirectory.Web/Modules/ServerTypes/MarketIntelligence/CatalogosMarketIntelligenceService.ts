import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { CatalogosMarketIntelligenceRow } from "./CatalogosMarketIntelligenceRow";

export namespace CatalogosMarketIntelligenceService {
    export const baseUrl = 'MarketIntelligence/CatalogosMarketIntelligence';

    export declare function Create(request: SaveRequest<CatalogosMarketIntelligenceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<CatalogosMarketIntelligenceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CatalogosMarketIntelligenceRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CatalogosMarketIntelligenceRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "MarketIntelligence/CatalogosMarketIntelligence/Create",
        Update: "MarketIntelligence/CatalogosMarketIntelligence/Update",
        Delete: "MarketIntelligence/CatalogosMarketIntelligence/Delete",
        Retrieve: "MarketIntelligence/CatalogosMarketIntelligence/Retrieve",
        List: "MarketIntelligence/CatalogosMarketIntelligence/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CatalogosMarketIntelligenceService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}