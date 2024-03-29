// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class coinex : Exchange
{
    public coinex (object args = null): base(args) {}

    public async Task<object> publicGetAmmMarket (object parameters = null)
    {
        return await this.callAsync ("publicGetAmmMarket",parameters);
    }

    public async Task<object> publicGetCommonCurrencyRate (object parameters = null)
    {
        return await this.callAsync ("publicGetCommonCurrencyRate",parameters);
    }

    public async Task<object> publicGetCommonAssetConfig (object parameters = null)
    {
        return await this.callAsync ("publicGetCommonAssetConfig",parameters);
    }

    public async Task<object> publicGetCommonMaintainInfo (object parameters = null)
    {
        return await this.callAsync ("publicGetCommonMaintainInfo",parameters);
    }

    public async Task<object> publicGetCommonTempMaintainInfo (object parameters = null)
    {
        return await this.callAsync ("publicGetCommonTempMaintainInfo",parameters);
    }

    public async Task<object> publicGetMarginMarket (object parameters = null)
    {
        return await this.callAsync ("publicGetMarginMarket",parameters);
    }

    public async Task<object> publicGetMarketInfo (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketInfo",parameters);
    }

    public async Task<object> publicGetMarketList (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketList",parameters);
    }

    public async Task<object> publicGetMarketTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketTicker",parameters);
    }

    public async Task<object> publicGetMarketTickerAll (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketTickerAll",parameters);
    }

    public async Task<object> publicGetMarketDepth (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketDepth",parameters);
    }

    public async Task<object> publicGetMarketDeals (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketDeals",parameters);
    }

    public async Task<object> publicGetMarketKline (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketKline",parameters);
    }

    public async Task<object> publicGetMarketDetail (object parameters = null)
    {
        return await this.callAsync ("publicGetMarketDetail",parameters);
    }

    public async Task<object> privateGetAccountAmmBalance (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountAmmBalance",parameters);
    }

    public async Task<object> privateGetAccountInvestmentBalance (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountInvestmentBalance",parameters);
    }

    public async Task<object> privateGetAccountBalanceHistory (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountBalanceHistory",parameters);
    }

    public async Task<object> privateGetAccountMarketFee (object parameters = null)
    {
        return await this.callAsync ("privateGetAccountMarketFee",parameters);
    }

    public async Task<object> privateGetBalanceCoinDeposit (object parameters = null)
    {
        return await this.callAsync ("privateGetBalanceCoinDeposit",parameters);
    }

    public async Task<object> privateGetBalanceCoinWithdraw (object parameters = null)
    {
        return await this.callAsync ("privateGetBalanceCoinWithdraw",parameters);
    }

    public async Task<object> privateGetBalanceInfo (object parameters = null)
    {
        return await this.callAsync ("privateGetBalanceInfo",parameters);
    }

    public async Task<object> privateGetBalanceDepositAddressCoinType (object parameters = null)
    {
        return await this.callAsync ("privateGetBalanceDepositAddressCoinType",parameters);
    }

    public async Task<object> privateGetContractTransferHistory (object parameters = null)
    {
        return await this.callAsync ("privateGetContractTransferHistory",parameters);
    }

    public async Task<object> privateGetCreditInfo (object parameters = null)
    {
        return await this.callAsync ("privateGetCreditInfo",parameters);
    }

    public async Task<object> privateGetCreditBalance (object parameters = null)
    {
        return await this.callAsync ("privateGetCreditBalance",parameters);
    }

    public async Task<object> privateGetInvestmentTransferHistory (object parameters = null)
    {
        return await this.callAsync ("privateGetInvestmentTransferHistory",parameters);
    }

    public async Task<object> privateGetMarginAccount (object parameters = null)
    {
        return await this.callAsync ("privateGetMarginAccount",parameters);
    }

    public async Task<object> privateGetMarginConfig (object parameters = null)
    {
        return await this.callAsync ("privateGetMarginConfig",parameters);
    }

    public async Task<object> privateGetMarginLoanHistory (object parameters = null)
    {
        return await this.callAsync ("privateGetMarginLoanHistory",parameters);
    }

    public async Task<object> privateGetMarginTransferHistory (object parameters = null)
    {
        return await this.callAsync ("privateGetMarginTransferHistory",parameters);
    }

    public async Task<object> privateGetOrderDeals (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderDeals",parameters);
    }

    public async Task<object> privateGetOrderFinished (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderFinished",parameters);
    }

    public async Task<object> privateGetOrderPending (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderPending",parameters);
    }

    public async Task<object> privateGetOrderStatus (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderStatus",parameters);
    }

    public async Task<object> privateGetOrderStatusBatch (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderStatusBatch",parameters);
    }

    public async Task<object> privateGetOrderUserDeals (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderUserDeals",parameters);
    }

    public async Task<object> privateGetOrderStopFinished (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderStopFinished",parameters);
    }

    public async Task<object> privateGetOrderStopPending (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderStopPending",parameters);
    }

    public async Task<object> privateGetOrderUserTradeFee (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderUserTradeFee",parameters);
    }

    public async Task<object> privateGetOrderMarketTradeInfo (object parameters = null)
    {
        return await this.callAsync ("privateGetOrderMarketTradeInfo",parameters);
    }

    public async Task<object> privateGetSubAccountBalance (object parameters = null)
    {
        return await this.callAsync ("privateGetSubAccountBalance",parameters);
    }

    public async Task<object> privateGetSubAccountTransferHistory (object parameters = null)
    {
        return await this.callAsync ("privateGetSubAccountTransferHistory",parameters);
    }

    public async Task<object> privateGetSubAccountAuthApi (object parameters = null)
    {
        return await this.callAsync ("privateGetSubAccountAuthApi",parameters);
    }

    public async Task<object> privateGetSubAccountAuthApiUserAuthId (object parameters = null)
    {
        return await this.callAsync ("privateGetSubAccountAuthApiUserAuthId",parameters);
    }

    public async Task<object> privatePostBalanceCoinWithdraw (object parameters = null)
    {
        return await this.callAsync ("privatePostBalanceCoinWithdraw",parameters);
    }

    public async Task<object> privatePostContractBalanceTransfer (object parameters = null)
    {
        return await this.callAsync ("privatePostContractBalanceTransfer",parameters);
    }

    public async Task<object> privatePostMarginFlat (object parameters = null)
    {
        return await this.callAsync ("privatePostMarginFlat",parameters);
    }

    public async Task<object> privatePostMarginLoan (object parameters = null)
    {
        return await this.callAsync ("privatePostMarginLoan",parameters);
    }

    public async Task<object> privatePostMarginTransfer (object parameters = null)
    {
        return await this.callAsync ("privatePostMarginTransfer",parameters);
    }

    public async Task<object> privatePostOrderLimitBatch (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderLimitBatch",parameters);
    }

    public async Task<object> privatePostOrderIoc (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderIoc",parameters);
    }

    public async Task<object> privatePostOrderLimit (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderLimit",parameters);
    }

    public async Task<object> privatePostOrderMarket (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderMarket",parameters);
    }

    public async Task<object> privatePostOrderModify (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderModify",parameters);
    }

    public async Task<object> privatePostOrderStopLimit (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderStopLimit",parameters);
    }

    public async Task<object> privatePostOrderStopMarket (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderStopMarket",parameters);
    }

    public async Task<object> privatePostOrderStopModify (object parameters = null)
    {
        return await this.callAsync ("privatePostOrderStopModify",parameters);
    }

    public async Task<object> privatePostSubAccountTransfer (object parameters = null)
    {
        return await this.callAsync ("privatePostSubAccountTransfer",parameters);
    }

    public async Task<object> privatePostSubAccountRegister (object parameters = null)
    {
        return await this.callAsync ("privatePostSubAccountRegister",parameters);
    }

    public async Task<object> privatePostSubAccountUnfrozen (object parameters = null)
    {
        return await this.callAsync ("privatePostSubAccountUnfrozen",parameters);
    }

    public async Task<object> privatePostSubAccountFrozen (object parameters = null)
    {
        return await this.callAsync ("privatePostSubAccountFrozen",parameters);
    }

    public async Task<object> privatePostSubAccountAuthApi (object parameters = null)
    {
        return await this.callAsync ("privatePostSubAccountAuthApi",parameters);
    }

    public async Task<object> privatePutBalanceDepositAddressCoinType (object parameters = null)
    {
        return await this.callAsync ("privatePutBalanceDepositAddressCoinType",parameters);
    }

    public async Task<object> privatePutSubAccountUnfrozen (object parameters = null)
    {
        return await this.callAsync ("privatePutSubAccountUnfrozen",parameters);
    }

    public async Task<object> privatePutSubAccountFrozen (object parameters = null)
    {
        return await this.callAsync ("privatePutSubAccountFrozen",parameters);
    }

    public async Task<object> privatePutSubAccountAuthApiUserAuthId (object parameters = null)
    {
        return await this.callAsync ("privatePutSubAccountAuthApiUserAuthId",parameters);
    }

    public async Task<object> privatePutV1AccountSettings (object parameters = null)
    {
        return await this.callAsync ("privatePutV1AccountSettings",parameters);
    }

    public async Task<object> privateDeleteBalanceCoinWithdraw (object parameters = null)
    {
        return await this.callAsync ("privateDeleteBalanceCoinWithdraw",parameters);
    }

    public async Task<object> privateDeleteOrderPendingBatch (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrderPendingBatch",parameters);
    }

    public async Task<object> privateDeleteOrderPending (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrderPending",parameters);
    }

    public async Task<object> privateDeleteOrderStopPending (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrderStopPending",parameters);
    }

    public async Task<object> privateDeleteOrderStopPendingId (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrderStopPendingId",parameters);
    }

    public async Task<object> privateDeleteOrderPendingByClientId (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrderPendingByClientId",parameters);
    }

    public async Task<object> privateDeleteOrderStopPendingByClientId (object parameters = null)
    {
        return await this.callAsync ("privateDeleteOrderStopPendingByClientId",parameters);
    }

    public async Task<object> privateDeleteSubAccountAuthApiUserAuthId (object parameters = null)
    {
        return await this.callAsync ("privateDeleteSubAccountAuthApiUserAuthId",parameters);
    }

    public async Task<object> privateDeleteSubAccountAuthorizeId (object parameters = null)
    {
        return await this.callAsync ("privateDeleteSubAccountAuthorizeId",parameters);
    }

    public async Task<object> perpetualPublicGetPing (object parameters = null)
    {
        return await this.callAsync ("perpetualPublicGetPing",parameters);
    }

    public async Task<object> perpetualPublicGetTime (object parameters = null)
    {
        return await this.callAsync ("perpetualPublicGetTime",parameters);
    }

    public async Task<object> perpetualPublicGetMarketList (object parameters = null)
    {
        return await this.callAsync ("perpetualPublicGetMarketList",parameters);
    }

    public async Task<object> perpetualPublicGetMarketLimitConfig (object parameters = null)
    {
        return await this.callAsync ("perpetualPublicGetMarketLimitConfig",parameters);
    }

    public async Task<object> perpetualPublicGetMarketTicker (object parameters = null)
    {
        return await this.callAsync ("perpetualPublicGetMarketTicker",parameters);
    }

    public async Task<object> perpetualPublicGetMarketTickerAll (object parameters = null)
    {
        return await this.callAsync ("perpetualPublicGetMarketTickerAll",parameters);
    }

    public async Task<object> perpetualPublicGetMarketDepth (object parameters = null)
    {
        return await this.callAsync ("perpetualPublicGetMarketDepth",parameters);
    }

    public async Task<object> perpetualPublicGetMarketDeals (object parameters = null)
    {
        return await this.callAsync ("perpetualPublicGetMarketDeals",parameters);
    }

    public async Task<object> perpetualPublicGetMarketFundingHistory (object parameters = null)
    {
        return await this.callAsync ("perpetualPublicGetMarketFundingHistory",parameters);
    }

    public async Task<object> perpetualPublicGetMarketKline (object parameters = null)
    {
        return await this.callAsync ("perpetualPublicGetMarketKline",parameters);
    }

    public async Task<object> perpetualPrivateGetMarketUserDeals (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetMarketUserDeals",parameters);
    }

    public async Task<object> perpetualPrivateGetAssetQuery (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetAssetQuery",parameters);
    }

    public async Task<object> perpetualPrivateGetOrderPending (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetOrderPending",parameters);
    }

    public async Task<object> perpetualPrivateGetOrderFinished (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetOrderFinished",parameters);
    }

    public async Task<object> perpetualPrivateGetOrderStopFinished (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetOrderStopFinished",parameters);
    }

    public async Task<object> perpetualPrivateGetOrderStopPending (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetOrderStopPending",parameters);
    }

    public async Task<object> perpetualPrivateGetOrderStatus (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetOrderStatus",parameters);
    }

    public async Task<object> perpetualPrivateGetOrderStopStatus (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetOrderStopStatus",parameters);
    }

    public async Task<object> perpetualPrivateGetPositionFinished (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetPositionFinished",parameters);
    }

    public async Task<object> perpetualPrivateGetPositionPending (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetPositionPending",parameters);
    }

    public async Task<object> perpetualPrivateGetPositionFunding (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetPositionFunding",parameters);
    }

    public async Task<object> perpetualPrivateGetPositionAdlHistory (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetPositionAdlHistory",parameters);
    }

    public async Task<object> perpetualPrivateGetMarketPreference (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetMarketPreference",parameters);
    }

    public async Task<object> perpetualPrivateGetPositionMarginHistory (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetPositionMarginHistory",parameters);
    }

    public async Task<object> perpetualPrivateGetPositionSettleHistory (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivateGetPositionSettleHistory",parameters);
    }

    public async Task<object> perpetualPrivatePostMarketAdjustLeverage (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostMarketAdjustLeverage",parameters);
    }

    public async Task<object> perpetualPrivatePostMarketPositionExpect (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostMarketPositionExpect",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderPutLimit (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderPutLimit",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderPutMarket (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderPutMarket",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderPutStopLimit (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderPutStopLimit",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderPutStopMarket (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderPutStopMarket",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderModify (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderModify",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderModifyStop (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderModifyStop",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderCancel (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderCancel",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderCancelAll (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderCancelAll",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderCancelBatch (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderCancelBatch",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderCancelStop (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderCancelStop",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderCancelStopAll (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderCancelStopAll",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderCloseLimit (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderCloseLimit",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderCloseMarket (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderCloseMarket",parameters);
    }

    public async Task<object> perpetualPrivatePostPositionAdjustMargin (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostPositionAdjustMargin",parameters);
    }

    public async Task<object> perpetualPrivatePostPositionStopLoss (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostPositionStopLoss",parameters);
    }

    public async Task<object> perpetualPrivatePostPositionTakeProfit (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostPositionTakeProfit",parameters);
    }

    public async Task<object> perpetualPrivatePostPositionMarketClose (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostPositionMarketClose",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderCancelByClientId (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderCancelByClientId",parameters);
    }

    public async Task<object> perpetualPrivatePostOrderCancelStopByClientId (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostOrderCancelStopByClientId",parameters);
    }

    public async Task<object> perpetualPrivatePostMarketPreference (object parameters = null)
    {
        return await this.callAsync ("perpetualPrivatePostMarketPreference",parameters);
    }

}