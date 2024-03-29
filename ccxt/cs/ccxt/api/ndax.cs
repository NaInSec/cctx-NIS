// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class ndax : Exchange
{
    public ndax (object args = null): base(args) {}

    public async Task<object> publicGetActivate2FA (object parameters = null)
    {
        return await this.callAsync ("publicGetActivate2FA",parameters);
    }

    public async Task<object> publicGetAuthenticate2FA (object parameters = null)
    {
        return await this.callAsync ("publicGetAuthenticate2FA",parameters);
    }

    public async Task<object> publicGetAuthenticateUser (object parameters = null)
    {
        return await this.callAsync ("publicGetAuthenticateUser",parameters);
    }

    public async Task<object> publicGetGetL2Snapshot (object parameters = null)
    {
        return await this.callAsync ("publicGetGetL2Snapshot",parameters);
    }

    public async Task<object> publicGetGetLevel1 (object parameters = null)
    {
        return await this.callAsync ("publicGetGetLevel1",parameters);
    }

    public async Task<object> publicGetGetValidate2FARequiredEndpoints (object parameters = null)
    {
        return await this.callAsync ("publicGetGetValidate2FARequiredEndpoints",parameters);
    }

    public async Task<object> publicGetLogOut (object parameters = null)
    {
        return await this.callAsync ("publicGetLogOut",parameters);
    }

    public async Task<object> publicGetGetTickerHistory (object parameters = null)
    {
        return await this.callAsync ("publicGetGetTickerHistory",parameters);
    }

    public async Task<object> publicGetGetProduct (object parameters = null)
    {
        return await this.callAsync ("publicGetGetProduct",parameters);
    }

    public async Task<object> publicGetGetProducts (object parameters = null)
    {
        return await this.callAsync ("publicGetGetProducts",parameters);
    }

    public async Task<object> publicGetGetInstrument (object parameters = null)
    {
        return await this.callAsync ("publicGetGetInstrument",parameters);
    }

    public async Task<object> publicGetGetInstruments (object parameters = null)
    {
        return await this.callAsync ("publicGetGetInstruments",parameters);
    }

    public async Task<object> publicGetPing (object parameters = null)
    {
        return await this.callAsync ("publicGetPing",parameters);
    }

    public async Task<object> publicGetTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetTrades",parameters);
    }

    public async Task<object> publicGetGetLastTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetGetLastTrades",parameters);
    }

    public async Task<object> publicGetSubscribeLevel1 (object parameters = null)
    {
        return await this.callAsync ("publicGetSubscribeLevel1",parameters);
    }

    public async Task<object> publicGetSubscribeLevel2 (object parameters = null)
    {
        return await this.callAsync ("publicGetSubscribeLevel2",parameters);
    }

    public async Task<object> publicGetSubscribeTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetSubscribeTicker",parameters);
    }

    public async Task<object> publicGetSubscribeTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetSubscribeTrades",parameters);
    }

    public async Task<object> publicGetSubscribeBlockTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetSubscribeBlockTrades",parameters);
    }

    public async Task<object> publicGetUnsubscribeBlockTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetUnsubscribeBlockTrades",parameters);
    }

    public async Task<object> publicGetUnsubscribeLevel1 (object parameters = null)
    {
        return await this.callAsync ("publicGetUnsubscribeLevel1",parameters);
    }

    public async Task<object> publicGetUnsubscribeLevel2 (object parameters = null)
    {
        return await this.callAsync ("publicGetUnsubscribeLevel2",parameters);
    }

    public async Task<object> publicGetUnsubscribeTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetUnsubscribeTicker",parameters);
    }

    public async Task<object> publicGetUnsubscribeTrades (object parameters = null)
    {
        return await this.callAsync ("publicGetUnsubscribeTrades",parameters);
    }

    public async Task<object> publicGetAuthenticate (object parameters = null)
    {
        return await this.callAsync ("publicGetAuthenticate",parameters);
    }

    public async Task<object> privateGetGetUserAccountInfos (object parameters = null)
    {
        return await this.callAsync ("privateGetGetUserAccountInfos",parameters);
    }

    public async Task<object> privateGetGetUserAccounts (object parameters = null)
    {
        return await this.callAsync ("privateGetGetUserAccounts",parameters);
    }

    public async Task<object> privateGetGetUserAffiliateCount (object parameters = null)
    {
        return await this.callAsync ("privateGetGetUserAffiliateCount",parameters);
    }

    public async Task<object> privateGetGetUserAffiliateTag (object parameters = null)
    {
        return await this.callAsync ("privateGetGetUserAffiliateTag",parameters);
    }

    public async Task<object> privateGetGetUserConfig (object parameters = null)
    {
        return await this.callAsync ("privateGetGetUserConfig",parameters);
    }

    public async Task<object> privateGetGetAllUnredactedUserConfigsForUser (object parameters = null)
    {
        return await this.callAsync ("privateGetGetAllUnredactedUserConfigsForUser",parameters);
    }

    public async Task<object> privateGetGetUnredactedUserConfigByKey (object parameters = null)
    {
        return await this.callAsync ("privateGetGetUnredactedUserConfigByKey",parameters);
    }

    public async Task<object> privateGetGetUserDevices (object parameters = null)
    {
        return await this.callAsync ("privateGetGetUserDevices",parameters);
    }

    public async Task<object> privateGetGetUserReportTickets (object parameters = null)
    {
        return await this.callAsync ("privateGetGetUserReportTickets",parameters);
    }

    public async Task<object> privateGetGetUserReportWriterResultRecords (object parameters = null)
    {
        return await this.callAsync ("privateGetGetUserReportWriterResultRecords",parameters);
    }

    public async Task<object> privateGetGetAccountInfo (object parameters = null)
    {
        return await this.callAsync ("privateGetGetAccountInfo",parameters);
    }

    public async Task<object> privateGetGetAccountPositions (object parameters = null)
    {
        return await this.callAsync ("privateGetGetAccountPositions",parameters);
    }

    public async Task<object> privateGetGetAllAccountConfigs (object parameters = null)
    {
        return await this.callAsync ("privateGetGetAllAccountConfigs",parameters);
    }

    public async Task<object> privateGetGetTreasuryProductsForAccount (object parameters = null)
    {
        return await this.callAsync ("privateGetGetTreasuryProductsForAccount",parameters);
    }

    public async Task<object> privateGetGetAccountTrades (object parameters = null)
    {
        return await this.callAsync ("privateGetGetAccountTrades",parameters);
    }

    public async Task<object> privateGetGetAccountTransactions (object parameters = null)
    {
        return await this.callAsync ("privateGetGetAccountTransactions",parameters);
    }

    public async Task<object> privateGetGetOpenTradeReports (object parameters = null)
    {
        return await this.callAsync ("privateGetGetOpenTradeReports",parameters);
    }

    public async Task<object> privateGetGetAllOpenTradeReports (object parameters = null)
    {
        return await this.callAsync ("privateGetGetAllOpenTradeReports",parameters);
    }

    public async Task<object> privateGetGetTradesHistory (object parameters = null)
    {
        return await this.callAsync ("privateGetGetTradesHistory",parameters);
    }

    public async Task<object> privateGetGetOpenOrders (object parameters = null)
    {
        return await this.callAsync ("privateGetGetOpenOrders",parameters);
    }

    public async Task<object> privateGetGetOpenQuotes (object parameters = null)
    {
        return await this.callAsync ("privateGetGetOpenQuotes",parameters);
    }

    public async Task<object> privateGetGetOrderFee (object parameters = null)
    {
        return await this.callAsync ("privateGetGetOrderFee",parameters);
    }

    public async Task<object> privateGetGetOrderHistory (object parameters = null)
    {
        return await this.callAsync ("privateGetGetOrderHistory",parameters);
    }

    public async Task<object> privateGetGetOrdersHistory (object parameters = null)
    {
        return await this.callAsync ("privateGetGetOrdersHistory",parameters);
    }

    public async Task<object> privateGetGetOrderStatus (object parameters = null)
    {
        return await this.callAsync ("privateGetGetOrderStatus",parameters);
    }

    public async Task<object> privateGetGetOmsFeeTiers (object parameters = null)
    {
        return await this.callAsync ("privateGetGetOmsFeeTiers",parameters);
    }

    public async Task<object> privateGetGetAccountDepositTransactions (object parameters = null)
    {
        return await this.callAsync ("privateGetGetAccountDepositTransactions",parameters);
    }

    public async Task<object> privateGetGetAccountWithdrawTransactions (object parameters = null)
    {
        return await this.callAsync ("privateGetGetAccountWithdrawTransactions",parameters);
    }

    public async Task<object> privateGetGetAllDepositRequestInfoTemplates (object parameters = null)
    {
        return await this.callAsync ("privateGetGetAllDepositRequestInfoTemplates",parameters);
    }

    public async Task<object> privateGetGetDepositInfo (object parameters = null)
    {
        return await this.callAsync ("privateGetGetDepositInfo",parameters);
    }

    public async Task<object> privateGetGetDepositRequestInfoTemplate (object parameters = null)
    {
        return await this.callAsync ("privateGetGetDepositRequestInfoTemplate",parameters);
    }

    public async Task<object> privateGetGetDeposits (object parameters = null)
    {
        return await this.callAsync ("privateGetGetDeposits",parameters);
    }

    public async Task<object> privateGetGetDepositTicket (object parameters = null)
    {
        return await this.callAsync ("privateGetGetDepositTicket",parameters);
    }

    public async Task<object> privateGetGetDepositTickets (object parameters = null)
    {
        return await this.callAsync ("privateGetGetDepositTickets",parameters);
    }

    public async Task<object> privateGetGetOMSWithdrawFees (object parameters = null)
    {
        return await this.callAsync ("privateGetGetOMSWithdrawFees",parameters);
    }

    public async Task<object> privateGetGetWithdrawFee (object parameters = null)
    {
        return await this.callAsync ("privateGetGetWithdrawFee",parameters);
    }

    public async Task<object> privateGetGetWithdraws (object parameters = null)
    {
        return await this.callAsync ("privateGetGetWithdraws",parameters);
    }

    public async Task<object> privateGetGetWithdrawTemplate (object parameters = null)
    {
        return await this.callAsync ("privateGetGetWithdrawTemplate",parameters);
    }

    public async Task<object> privateGetGetWithdrawTemplateTypes (object parameters = null)
    {
        return await this.callAsync ("privateGetGetWithdrawTemplateTypes",parameters);
    }

    public async Task<object> privateGetGetWithdrawTicket (object parameters = null)
    {
        return await this.callAsync ("privateGetGetWithdrawTicket",parameters);
    }

    public async Task<object> privateGetGetWithdrawTickets (object parameters = null)
    {
        return await this.callAsync ("privateGetGetWithdrawTickets",parameters);
    }

    public async Task<object> privatePostAddUserAffiliateTag (object parameters = null)
    {
        return await this.callAsync ("privatePostAddUserAffiliateTag",parameters);
    }

    public async Task<object> privatePostCancelUserReport (object parameters = null)
    {
        return await this.callAsync ("privatePostCancelUserReport",parameters);
    }

    public async Task<object> privatePostRegisterNewDevice (object parameters = null)
    {
        return await this.callAsync ("privatePostRegisterNewDevice",parameters);
    }

    public async Task<object> privatePostSubscribeAccountEvents (object parameters = null)
    {
        return await this.callAsync ("privatePostSubscribeAccountEvents",parameters);
    }

    public async Task<object> privatePostUpdateUserAffiliateTag (object parameters = null)
    {
        return await this.callAsync ("privatePostUpdateUserAffiliateTag",parameters);
    }

    public async Task<object> privatePostGenerateTradeActivityReport (object parameters = null)
    {
        return await this.callAsync ("privatePostGenerateTradeActivityReport",parameters);
    }

    public async Task<object> privatePostGenerateTransactionActivityReport (object parameters = null)
    {
        return await this.callAsync ("privatePostGenerateTransactionActivityReport",parameters);
    }

    public async Task<object> privatePostGenerateTreasuryActivityReport (object parameters = null)
    {
        return await this.callAsync ("privatePostGenerateTreasuryActivityReport",parameters);
    }

    public async Task<object> privatePostScheduleTradeActivityReport (object parameters = null)
    {
        return await this.callAsync ("privatePostScheduleTradeActivityReport",parameters);
    }

    public async Task<object> privatePostScheduleTransactionActivityReport (object parameters = null)
    {
        return await this.callAsync ("privatePostScheduleTransactionActivityReport",parameters);
    }

    public async Task<object> privatePostScheduleTreasuryActivityReport (object parameters = null)
    {
        return await this.callAsync ("privatePostScheduleTreasuryActivityReport",parameters);
    }

    public async Task<object> privatePostCancelAllOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostCancelAllOrders",parameters);
    }

    public async Task<object> privatePostCancelOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostCancelOrder",parameters);
    }

    public async Task<object> privatePostCancelQuote (object parameters = null)
    {
        return await this.callAsync ("privatePostCancelQuote",parameters);
    }

    public async Task<object> privatePostCancelReplaceOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostCancelReplaceOrder",parameters);
    }

    public async Task<object> privatePostCreateQuote (object parameters = null)
    {
        return await this.callAsync ("privatePostCreateQuote",parameters);
    }

    public async Task<object> privatePostModifyOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostModifyOrder",parameters);
    }

    public async Task<object> privatePostSendOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostSendOrder",parameters);
    }

    public async Task<object> privatePostSubmitBlockTrade (object parameters = null)
    {
        return await this.callAsync ("privatePostSubmitBlockTrade",parameters);
    }

    public async Task<object> privatePostUpdateQuote (object parameters = null)
    {
        return await this.callAsync ("privatePostUpdateQuote",parameters);
    }

    public async Task<object> privatePostCancelWithdraw (object parameters = null)
    {
        return await this.callAsync ("privatePostCancelWithdraw",parameters);
    }

    public async Task<object> privatePostCreateDepositTicket (object parameters = null)
    {
        return await this.callAsync ("privatePostCreateDepositTicket",parameters);
    }

    public async Task<object> privatePostCreateWithdrawTicket (object parameters = null)
    {
        return await this.callAsync ("privatePostCreateWithdrawTicket",parameters);
    }

    public async Task<object> privatePostSubmitDepositTicketComment (object parameters = null)
    {
        return await this.callAsync ("privatePostSubmitDepositTicketComment",parameters);
    }

    public async Task<object> privatePostSubmitWithdrawTicketComment (object parameters = null)
    {
        return await this.callAsync ("privatePostSubmitWithdrawTicketComment",parameters);
    }

    public async Task<object> privatePostGetOrderHistoryByOrderId (object parameters = null)
    {
        return await this.callAsync ("privatePostGetOrderHistoryByOrderId",parameters);
    }

}