// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class mercado : Exchange
{
    public mercado (object args = null): base(args) {}

    public async Task<object> publicGetCoins (object parameters = null)
    {
        return await this.callAsync ("publicGetCoins",parameters);
    }

    public async Task<object> publicGetCoinOrderbook (object parameters = null)
    {
        return await this.callAsync ("publicGetCoinOrderbook",parameters);
    }

    public async Task<object> publicGetCoinTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetCoinTicker",parameters);
    }

    public async Task<object> publicGetCoinTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetCoinTrades",parameters);
    }

    public async Task<object> publicGetCoinTradesFrom (object parameters = null)
    {
        return await this.callAsync ("publicGetCoinTradesFrom",parameters);
    }

    public async Task<object> publicGetCoinTradesFromTo (object parameters = null)
    {
        return await this.callAsync ("publicGetCoinTradesFromTo",parameters);
    }

    public async Task<object> publicGetCoinDaySummaryYearMonthDay (object parameters = null)
    {
        return await this.callAsync ("publicGetCoinDaySummaryYearMonthDay",parameters);
    }

    public async Task<object> privatePostCancelOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostCancelOrder",parameters);
    }

    public async Task<object> privatePostGetAccountInfo (object parameters = null)
    {
        return await this.callAsync ("privatePostGetAccountInfo",parameters);
    }

    public async Task<object> privatePostGetOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostGetOrder",parameters);
    }

    public async Task<object> privatePostGetWithdrawal (object parameters = null)
    {
        return await this.callAsync ("privatePostGetWithdrawal",parameters);
    }

    public async Task<object> privatePostListSystemMessages (object parameters = null)
    {
        return await this.callAsync ("privatePostListSystemMessages",parameters);
    }

    public async Task<object> privatePostListOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostListOrders",parameters);
    }

    public async Task<object> privatePostListOrderbook (object parameters = null)
    {
        return await this.callAsync ("privatePostListOrderbook",parameters);
    }

    public async Task<object> privatePostPlaceBuyOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostPlaceBuyOrder",parameters);
    }

    public async Task<object> privatePostPlaceSellOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostPlaceSellOrder",parameters);
    }

    public async Task<object> privatePostPlaceMarketBuyOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostPlaceMarketBuyOrder",parameters);
    }

    public async Task<object> privatePostPlaceMarketSellOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostPlaceMarketSellOrder",parameters);
    }

    public async Task<object> privatePostWithdrawCoin (object parameters = null)
    {
        return await this.callAsync ("privatePostWithdrawCoin",parameters);
    }

    public async Task<object> v4PublicGetCoinCandle (object parameters = null)
    {
        return await this.callAsync ("v4PublicGetCoinCandle",parameters);
    }

    public async Task<object> v4PublicNetGetCandles (object parameters = null)
    {
        return await this.callAsync ("v4PublicNetGetCandles",parameters);
    }

}