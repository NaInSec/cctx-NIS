// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class lykke : Exchange
{
    public lykke (object args = null): base(args) {}

    public async Task<object> publicGetAssetpairs (object parameters = null)
    {
        return await this.callAsync ("publicGetAssetpairs",parameters);
    }

    public async Task<object> publicGetAssetpairsId (object parameters = null)
    {
        return await this.callAsync ("publicGetAssetpairsId",parameters);
    }

    public async Task<object> publicGetAssets (object parameters = null)
    {
        return await this.callAsync ("publicGetAssets",parameters);
    }

    public async Task<object> publicGetAssetsId (object parameters = null)
    {
        return await this.callAsync ("publicGetAssetsId",parameters);
    }

    public async Task<object> publicGetIsalive (object parameters = null)
    {
        return await this.callAsync ("publicGetIsalive",parameters);
    }

    public async Task<object> publicGetOrderbooks (object parameters = null)
    {
        return await this.callAsync ("publicGetOrderbooks",parameters);
    }

    public async Task<object> publicGetTickers (object parameters = null)
    {
        return await this.callAsync ("publicGetTickers",parameters);
    }

    public async Task<object> publicGetPrices (object parameters = null)
    {
        return await this.callAsync ("publicGetPrices",parameters);
    }

    public async Task<object> publicGetTradesPublicAssetPairId (object parameters = null)
    {
        return await this.callAsync ("publicGetTradesPublicAssetPairId",parameters);
    }

    public async Task<object> privateGetBalance (object parameters = null)
    {
        return await this.callAsync ("privateGetBalance",parameters);
    }

    public async Task<object> privateGetTrades (object parameters = null)
    {
        return await this.callAsync ("privateGetTrades",parameters);
    }

    public async Task<object> privateGetTradesOrderOrderId (object parameters = null)
    {
        return await this.callAsync ("privateGetTradesOrderOrderId",parameters);
    }

    public async Task<object> privateGetOrdersActive (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersActive",parameters);
    }

    public async Task<object> privateGetOrdersClosed (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersClosed",parameters);
    }

    public async Task<object> privateGetOrdersOrderId (object parameters = null)
    {
        return await this.callAsync ("privateGetOrdersOrderId",parameters);
    }

    public async Task<object> privateGetOperations (object parameters = null)
    {
        return await this.callAsync ("privateGetOperations",parameters);
    }

    public async Task<object> privateGetOperationsDepositsAddresses (object parameters = null)
    {
        return await this.callAsync ("privateGetOperationsDepositsAddresses",parameters);
    }

    public async Task<object> privateGetOperationsDepositsAddressesAssetId (object parameters = null)
    {
        return await this.callAsync ("privateGetOperationsDepositsAddressesAssetId",parameters);
    }

    public async Task<object> privatePostOrdersLimit (object parameters = null)
    {
        return await this.callAsync ("privatePostOrdersLimit",parameters);
    }

    public async Task<object> privatePostOrdersMarket (object parameters = null)
    {
        return await this.callAsync ("privatePostOrdersMarket",parameters);
    }

    public async Task<object> privatePostOrdersBulk (object parameters = null)
    {
        return await this.callAsync ("privatePostOrdersBulk",parameters);
    }

    public async Task<object> privatePostOperationsWithdrawals (object parameters = null)
    {
        return await this.callAsync ("privatePostOperationsWithdrawals",parameters);
    }

    public async Task<object> privatePostOperationsDepositsAddresses (object parameters = null)
    {
        return await this.callAsync ("privatePostOperationsDepositsAddresses",parameters);
    }

    public async Task<object> privateDeleteOrders (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrders",parameters);
    }

    public async Task<object> privateDeleteOrdersOrderId (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrdersOrderId",parameters);
    }

}