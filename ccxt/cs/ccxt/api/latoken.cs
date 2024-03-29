// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class latoken : Exchange
{
    public latoken (object args = null): base(args) {}

    public async Task<object> publicGetBookCurrencyQuote (object parameters = null)
    {
        return await this.callAsync ("publicGetBookCurrencyQuote",parameters);
    }

    public async Task<object> publicGetChartWeek (object parameters = null)
    {
        return await this.callAsync ("publicGetChartWeek",parameters);
    }

    public async Task<object> publicGetChartWeekCurrencyQuote (object parameters = null)
    {
        return await this.callAsync ("publicGetChartWeekCurrencyQuote",parameters);
    }

    public async Task<object> publicGetCurrency (object parameters = null)
    {
        return await this.callAsync ("publicGetCurrency",parameters);
    }

    public async Task<object> publicGetCurrencyAvailable (object parameters = null)
    {
        return await this.callAsync ("publicGetCurrencyAvailable",parameters);
    }

    public async Task<object> publicGetCurrencyQuotes (object parameters = null)
    {
        return await this.callAsync ("publicGetCurrencyQuotes",parameters);
    }

    public async Task<object> publicGetCurrencyCurrency (object parameters = null)
    {
        return await this.callAsync ("publicGetCurrencyCurrency",parameters);
    }

    public async Task<object> publicGetPair (object parameters = null)
    {
        return await this.callAsync ("publicGetPair",parameters);
    }

    public async Task<object> publicGetPairAvailable (object parameters = null)
    {
        return await this.callAsync ("publicGetPairAvailable",parameters);
    }

    public async Task<object> publicGetTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetTicker",parameters);
    }

    public async Task<object> publicGetTickerBaseQuote (object parameters = null)
    {
        return await this.callAsync ("publicGetTickerBaseQuote",parameters);
    }

    public async Task<object> publicGetTime (object parameters = null)
    {
        return await this.callAsync ("publicGetTime",parameters);
    }

    public async Task<object> publicGetTradeHistoryCurrencyQuote (object parameters = null)
    {
        return await this.callAsync ("publicGetTradeHistoryCurrencyQuote",parameters);
    }

    public async Task<object> publicGetTradeFeeCurrencyQuote (object parameters = null)
    {
        return await this.callAsync ("publicGetTradeFeeCurrencyQuote",parameters);
    }

    public async Task<object> publicGetTradeFeeLevels (object parameters = null)
    {
        return await this.callAsync ("publicGetTradeFeeLevels",parameters);
    }

    public async Task<object> publicGetTransactionBindings (object parameters = null)
    {
        return await this.callAsync ("publicGetTransactionBindings",parameters);
    }

    public async Task<object> privateGetAuthAccount (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthAccount",parameters);
    }

    public async Task<object> privateGetAuthAccountCurrencyCurrencyType (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthAccountCurrencyCurrencyType",parameters);
    }

    public async Task<object> privateGetAuthOrder (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthOrder",parameters);
    }

    public async Task<object> privateGetAuthOrderGetOrderId (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthOrderGetOrderId",parameters);
    }

    public async Task<object> privateGetAuthOrderPairCurrencyQuote (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthOrderPairCurrencyQuote",parameters);
    }

    public async Task<object> privateGetAuthOrderPairCurrencyQuoteActive (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthOrderPairCurrencyQuoteActive",parameters);
    }

    public async Task<object> privateGetAuthStopOrder (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthStopOrder",parameters);
    }

    public async Task<object> privateGetAuthStopOrderGetOrderId (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthStopOrderGetOrderId",parameters);
    }

    public async Task<object> privateGetAuthStopOrderPairCurrencyQuote (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthStopOrderPairCurrencyQuote",parameters);
    }

    public async Task<object> privateGetAuthStopOrderPairCurrencyQuoteActive (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthStopOrderPairCurrencyQuoteActive",parameters);
    }

    public async Task<object> privateGetAuthTrade (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthTrade",parameters);
    }

    public async Task<object> privateGetAuthTradePairCurrencyQuote (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthTradePairCurrencyQuote",parameters);
    }

    public async Task<object> privateGetAuthTradeFeeCurrencyQuote (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthTradeFeeCurrencyQuote",parameters);
    }

    public async Task<object> privateGetAuthTransaction (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthTransaction",parameters);
    }

    public async Task<object> privateGetAuthTransactionBindings (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthTransactionBindings",parameters);
    }

    public async Task<object> privateGetAuthTransactionBindingsCurrency (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthTransactionBindingsCurrency",parameters);
    }

    public async Task<object> privateGetAuthTransactionId (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthTransactionId",parameters);
    }

    public async Task<object> privateGetAuthTransfer (object parameters = null)
    {
        return await this.callAsync ("privateGetAuthTransfer",parameters);
    }

    public async Task<object> privatePostAuthOrderCancel (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthOrderCancel",parameters);
    }

    public async Task<object> privatePostAuthOrderCancelAll (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthOrderCancelAll",parameters);
    }

    public async Task<object> privatePostAuthOrderCancelAllCurrencyQuote (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthOrderCancelAllCurrencyQuote",parameters);
    }

    public async Task<object> privatePostAuthOrderPlace (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthOrderPlace",parameters);
    }

    public async Task<object> privatePostAuthSpotDeposit (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthSpotDeposit",parameters);
    }

    public async Task<object> privatePostAuthSpotWithdraw (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthSpotWithdraw",parameters);
    }

    public async Task<object> privatePostAuthStopOrderCancel (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthStopOrderCancel",parameters);
    }

    public async Task<object> privatePostAuthStopOrderCancelAll (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthStopOrderCancelAll",parameters);
    }

    public async Task<object> privatePostAuthStopOrderCancelAllCurrencyQuote (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthStopOrderCancelAllCurrencyQuote",parameters);
    }

    public async Task<object> privatePostAuthStopOrderPlace (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthStopOrderPlace",parameters);
    }

    public async Task<object> privatePostAuthTransactionDepositAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthTransactionDepositAddress",parameters);
    }

    public async Task<object> privatePostAuthTransactionWithdraw (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthTransactionWithdraw",parameters);
    }

    public async Task<object> privatePostAuthTransactionWithdrawCancel (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthTransactionWithdrawCancel",parameters);
    }

    public async Task<object> privatePostAuthTransactionWithdrawConfirm (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthTransactionWithdrawConfirm",parameters);
    }

    public async Task<object> privatePostAuthTransactionWithdrawResendCode (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthTransactionWithdrawResendCode",parameters);
    }

    public async Task<object> privatePostAuthTransferEmail (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthTransferEmail",parameters);
    }

    public async Task<object> privatePostAuthTransferId (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthTransferId",parameters);
    }

    public async Task<object> privatePostAuthTransferPhone (object parameters = null)
    {
        return await this.callAsync ("privatePostAuthTransferPhone",parameters);
    }

}