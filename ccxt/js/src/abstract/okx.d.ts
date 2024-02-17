import { implicitReturnType } from '../base/types.js';
import { Exchange as _Exchange } from '../base/Exchange.js';
interface Exchange {
    publicGetMarketBooksFull(params?: {}): Promise<implicitReturnType>;
    publicGetMarketTickers(params?: {}): Promise<implicitReturnType>;
    publicGetMarketTicker(params?: {}): Promise<implicitReturnType>;
    publicGetMarketIndexTickers(params?: {}): Promise<implicitReturnType>;
    publicGetMarketBooks(params?: {}): Promise<implicitReturnType>;
    publicGetMarketBooksLite(params?: {}): Promise<implicitReturnType>;
    publicGetMarketCandles(params?: {}): Promise<implicitReturnType>;
    publicGetMarketHistoryCandles(params?: {}): Promise<implicitReturnType>;
    publicGetMarketIndexCandles(params?: {}): Promise<implicitReturnType>;
    publicGetMarketHistoryIndexCandles(params?: {}): Promise<implicitReturnType>;
    publicGetMarketMarkPriceCandles(params?: {}): Promise<implicitReturnType>;
    publicGetMarketHistoryMarkPriceCandles(params?: {}): Promise<implicitReturnType>;
    publicGetMarketTrades(params?: {}): Promise<implicitReturnType>;
    publicGetMarketHistoryTrades(params?: {}): Promise<implicitReturnType>;
    publicGetMarketOptionInstrumentFamilyTrades(params?: {}): Promise<implicitReturnType>;
    publicGetMarketPlatform24Volume(params?: {}): Promise<implicitReturnType>;
    publicGetMarketOpenOracle(params?: {}): Promise<implicitReturnType>;
    publicGetMarketExchangeRate(params?: {}): Promise<implicitReturnType>;
    publicGetMarketIndexComponents(params?: {}): Promise<implicitReturnType>;
    publicGetPublicEconomicCalendar(params?: {}): Promise<implicitReturnType>;
    publicGetMarketBlockTickers(params?: {}): Promise<implicitReturnType>;
    publicGetMarketBlockTicker(params?: {}): Promise<implicitReturnType>;
    publicGetPublicBlockTrades(params?: {}): Promise<implicitReturnType>;
    publicGetPublicInstruments(params?: {}): Promise<implicitReturnType>;
    publicGetPublicDeliveryExerciseHistory(params?: {}): Promise<implicitReturnType>;
    publicGetPublicOpenInterest(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFundingRate(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFundingRateHistory(params?: {}): Promise<implicitReturnType>;
    publicGetPublicPriceLimit(params?: {}): Promise<implicitReturnType>;
    publicGetPublicOptSummary(params?: {}): Promise<implicitReturnType>;
    publicGetPublicEstimatedPrice(params?: {}): Promise<implicitReturnType>;
    publicGetPublicDiscountRateInterestFreeQuota(params?: {}): Promise<implicitReturnType>;
    publicGetPublicTime(params?: {}): Promise<implicitReturnType>;
    publicGetPublicMarkPrice(params?: {}): Promise<implicitReturnType>;
    publicGetPublicPositionTiers(params?: {}): Promise<implicitReturnType>;
    publicGetPublicInterestRateLoanQuota(params?: {}): Promise<implicitReturnType>;
    publicGetPublicVipInterestRateLoanQuota(params?: {}): Promise<implicitReturnType>;
    publicGetPublicUnderlying(params?: {}): Promise<implicitReturnType>;
    publicGetPublicInsuranceFund(params?: {}): Promise<implicitReturnType>;
    publicGetPublicConvertContractCoin(params?: {}): Promise<implicitReturnType>;
    publicGetPublicOptionTrades(params?: {}): Promise<implicitReturnType>;
    publicGetPublicInstrumentTickBands(params?: {}): Promise<implicitReturnType>;
    publicGetRubikStatTradingDataSupportCoin(params?: {}): Promise<implicitReturnType>;
    publicGetRubikStatTakerVolume(params?: {}): Promise<implicitReturnType>;
    publicGetRubikStatMarginLoanRatio(params?: {}): Promise<implicitReturnType>;
    publicGetRubikStatContractsLongShortAccountRatio(params?: {}): Promise<implicitReturnType>;
    publicGetRubikStatContractsOpenInterestVolume(params?: {}): Promise<implicitReturnType>;
    publicGetRubikStatOptionOpenInterestVolume(params?: {}): Promise<implicitReturnType>;
    publicGetRubikStatOptionOpenInterestVolumeRatio(params?: {}): Promise<implicitReturnType>;
    publicGetRubikStatOptionOpenInterestVolumeExpiry(params?: {}): Promise<implicitReturnType>;
    publicGetRubikStatOptionOpenInterestVolumeStrike(params?: {}): Promise<implicitReturnType>;
    publicGetRubikStatOptionTakerBlockVolume(params?: {}): Promise<implicitReturnType>;
    publicGetSystemStatus(params?: {}): Promise<implicitReturnType>;
    publicGetSprdSpreads(params?: {}): Promise<implicitReturnType>;
    publicGetSprdBooks(params?: {}): Promise<implicitReturnType>;
    publicGetSprdTicker(params?: {}): Promise<implicitReturnType>;
    publicGetSprdPublicTrades(params?: {}): Promise<implicitReturnType>;
    publicGetTradingBotGridAiParam(params?: {}): Promise<implicitReturnType>;
    publicGetTradingBotGridMinInvestment(params?: {}): Promise<implicitReturnType>;
    publicGetTradingBotPublicRsiBackTesting(params?: {}): Promise<implicitReturnType>;
    publicGetAssetExchangeList(params?: {}): Promise<implicitReturnType>;
    publicGetFinanceStakingDefiEthApyHistory(params?: {}): Promise<implicitReturnType>;
    publicGetFinanceSavingsLendingRateSummary(params?: {}): Promise<implicitReturnType>;
    publicGetFinanceSavingsLendingRateHistory(params?: {}): Promise<implicitReturnType>;
    publicGetFinanceSfpDcdProducts(params?: {}): Promise<implicitReturnType>;
    publicGetCopytradingPublicLeadTraders(params?: {}): Promise<implicitReturnType>;
    publicGetCopytradingPublicWeeklyPnl(params?: {}): Promise<implicitReturnType>;
    publicGetCopytradingPublicStats(params?: {}): Promise<implicitReturnType>;
    publicGetCopytradingPublicPreferenceCurrency(params?: {}): Promise<implicitReturnType>;
    publicGetCopytradingPublicCurrentSubpositions(params?: {}): Promise<implicitReturnType>;
    publicGetCopytradingPublicSubpositionsHistory(params?: {}): Promise<implicitReturnType>;
    privateGetRfqCounterparties(params?: {}): Promise<implicitReturnType>;
    privateGetRfqMakerInstrumentSettings(params?: {}): Promise<implicitReturnType>;
    privateGetRfqMmpConfig(params?: {}): Promise<implicitReturnType>;
    privateGetRfqRfqs(params?: {}): Promise<implicitReturnType>;
    privateGetRfqQuotes(params?: {}): Promise<implicitReturnType>;
    privateGetRfqTrades(params?: {}): Promise<implicitReturnType>;
    privateGetRfqPublicTrades(params?: {}): Promise<implicitReturnType>;
    privateGetSprdOrder(params?: {}): Promise<implicitReturnType>;
    privateGetSprdOrdersPending(params?: {}): Promise<implicitReturnType>;
    privateGetSprdOrdersHistory(params?: {}): Promise<implicitReturnType>;
    privateGetSprdOrdersHistoryArchive(params?: {}): Promise<implicitReturnType>;
    privateGetSprdTrades(params?: {}): Promise<implicitReturnType>;
    privateGetTradeOrder(params?: {}): Promise<implicitReturnType>;
    privateGetTradeOrdersPending(params?: {}): Promise<implicitReturnType>;
    privateGetTradeOrdersHistory(params?: {}): Promise<implicitReturnType>;
    privateGetTradeOrdersHistoryArchive(params?: {}): Promise<implicitReturnType>;
    privateGetTradeFills(params?: {}): Promise<implicitReturnType>;
    privateGetTradeFillsHistory(params?: {}): Promise<implicitReturnType>;
    privateGetTradeFillsArchive(params?: {}): Promise<implicitReturnType>;
    privateGetTradeOrderAlgo(params?: {}): Promise<implicitReturnType>;
    privateGetTradeOrdersAlgoPending(params?: {}): Promise<implicitReturnType>;
    privateGetTradeOrdersAlgoHistory(params?: {}): Promise<implicitReturnType>;
    privateGetTradeEasyConvertCurrencyList(params?: {}): Promise<implicitReturnType>;
    privateGetTradeEasyConvertHistory(params?: {}): Promise<implicitReturnType>;
    privateGetTradeOneClickRepayCurrencyList(params?: {}): Promise<implicitReturnType>;
    privateGetTradeOneClickRepayHistory(params?: {}): Promise<implicitReturnType>;
    privateGetTradeAccountRateLimit(params?: {}): Promise<implicitReturnType>;
    privateGetAssetCurrencies(params?: {}): Promise<implicitReturnType>;
    privateGetAssetBalances(params?: {}): Promise<implicitReturnType>;
    privateGetAssetNonTradableAssets(params?: {}): Promise<implicitReturnType>;
    privateGetAssetAssetValuation(params?: {}): Promise<implicitReturnType>;
    privateGetAssetTransferState(params?: {}): Promise<implicitReturnType>;
    privateGetAssetBills(params?: {}): Promise<implicitReturnType>;
    privateGetAssetDepositLightning(params?: {}): Promise<implicitReturnType>;
    privateGetAssetDepositAddress(params?: {}): Promise<implicitReturnType>;
    privateGetAssetDepositHistory(params?: {}): Promise<implicitReturnType>;
    privateGetAssetWithdrawalHistory(params?: {}): Promise<implicitReturnType>;
    privateGetAssetDepositWithdrawStatus(params?: {}): Promise<implicitReturnType>;
    privateGetAssetConvertCurrencies(params?: {}): Promise<implicitReturnType>;
    privateGetAssetConvertCurrencyPair(params?: {}): Promise<implicitReturnType>;
    privateGetAssetConvertHistory(params?: {}): Promise<implicitReturnType>;
    privateGetAssetMonthlyStatement(params?: {}): Promise<implicitReturnType>;
    privateGetAccountBalance(params?: {}): Promise<implicitReturnType>;
    privateGetAccountPositions(params?: {}): Promise<implicitReturnType>;
    privateGetAccountPositionsHistory(params?: {}): Promise<implicitReturnType>;
    privateGetAccountAccountPositionRisk(params?: {}): Promise<implicitReturnType>;
    privateGetAccountBills(params?: {}): Promise<implicitReturnType>;
    privateGetAccountBillsArchive(params?: {}): Promise<implicitReturnType>;
    privateGetAccountConfig(params?: {}): Promise<implicitReturnType>;
    privateGetAccountMaxSize(params?: {}): Promise<implicitReturnType>;
    privateGetAccountMaxAvailSize(params?: {}): Promise<implicitReturnType>;
    privateGetAccountLeverageInfo(params?: {}): Promise<implicitReturnType>;
    privateGetAccountAdjustLeverageInfo(params?: {}): Promise<implicitReturnType>;
    privateGetAccountMaxLoan(params?: {}): Promise<implicitReturnType>;
    privateGetAccountTradeFee(params?: {}): Promise<implicitReturnType>;
    privateGetAccountInterestAccrued(params?: {}): Promise<implicitReturnType>;
    privateGetAccountInterestRate(params?: {}): Promise<implicitReturnType>;
    privateGetAccountMaxWithdrawal(params?: {}): Promise<implicitReturnType>;
    privateGetAccountRiskState(params?: {}): Promise<implicitReturnType>;
    privateGetAccountQuickMarginBorrowRepayHistory(params?: {}): Promise<implicitReturnType>;
    privateGetAccountBorrowRepayHistory(params?: {}): Promise<implicitReturnType>;
    privateGetAccountVipInterestAccrued(params?: {}): Promise<implicitReturnType>;
    privateGetAccountVipInterestDeducted(params?: {}): Promise<implicitReturnType>;
    privateGetAccountVipLoanOrderList(params?: {}): Promise<implicitReturnType>;
    privateGetAccountVipLoanOrderDetail(params?: {}): Promise<implicitReturnType>;
    privateGetAccountInterestLimits(params?: {}): Promise<implicitReturnType>;
    privateGetAccountGreeks(params?: {}): Promise<implicitReturnType>;
    privateGetAccountPositionTiers(params?: {}): Promise<implicitReturnType>;
    privateGetAccountMmpConfig(params?: {}): Promise<implicitReturnType>;
    privateGetUsersSubaccountList(params?: {}): Promise<implicitReturnType>;
    privateGetAccountSubaccountBalances(params?: {}): Promise<implicitReturnType>;
    privateGetAssetSubaccountBalances(params?: {}): Promise<implicitReturnType>;
    privateGetAccountSubaccountMaxWithdrawal(params?: {}): Promise<implicitReturnType>;
    privateGetAssetSubaccountBills(params?: {}): Promise<implicitReturnType>;
    privateGetAssetSubaccountManagedSubaccountBills(params?: {}): Promise<implicitReturnType>;
    privateGetUsersEntrustSubaccountList(params?: {}): Promise<implicitReturnType>;
    privateGetAccountSubaccountInterestLimits(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotGridOrdersAlgoPending(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotGridOrdersAlgoHistory(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotGridOrdersAlgoDetails(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotGridSubOrders(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotGridPositions(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotGridAiParam(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotSignalSignals(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotSignalOrdersAlgoDetails(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotSignalOrdersAlgoHistory(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotSignalPositions(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotSignalPositionsHistory(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotSignalSubOrders(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotSignalEventHistory(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotRecurringOrdersAlgoPending(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotRecurringOrdersAlgoHistory(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotRecurringOrdersAlgoDetails(params?: {}): Promise<implicitReturnType>;
    privateGetTradingBotRecurringSubOrders(params?: {}): Promise<implicitReturnType>;
    privateGetFinanceSavingsBalance(params?: {}): Promise<implicitReturnType>;
    privateGetFinanceSavingsLendingHistory(params?: {}): Promise<implicitReturnType>;
    privateGetFinanceStakingDefiOffers(params?: {}): Promise<implicitReturnType>;
    privateGetFinanceStakingDefiOrdersActive(params?: {}): Promise<implicitReturnType>;
    privateGetFinanceStakingDefiOrdersHistory(params?: {}): Promise<implicitReturnType>;
    privateGetFinanceStakingDefiEthBalance(params?: {}): Promise<implicitReturnType>;
    privateGetFinanceStakingDefiEthPurchaseRedeemHistory(params?: {}): Promise<implicitReturnType>;
    privateGetCopytradingCurrentSubpositions(params?: {}): Promise<implicitReturnType>;
    privateGetCopytradingSubpositionsHistory(params?: {}): Promise<implicitReturnType>;
    privateGetCopytradingInstruments(params?: {}): Promise<implicitReturnType>;
    privateGetCopytradingProfitSharingDetails(params?: {}): Promise<implicitReturnType>;
    privateGetCopytradingTotalProfitSharing(params?: {}): Promise<implicitReturnType>;
    privateGetCopytradingUnrealizedProfitSharingDetails(params?: {}): Promise<implicitReturnType>;
    privateGetCopytradingCopySettings(params?: {}): Promise<implicitReturnType>;
    privateGetCopytradingBatchLeverageInfo(params?: {}): Promise<implicitReturnType>;
    privateGetCopytradingCurrentLeadTraders(params?: {}): Promise<implicitReturnType>;
    privateGetCopytradingLeadTradersHistory(params?: {}): Promise<implicitReturnType>;
    privateGetBrokerNdInfo(params?: {}): Promise<implicitReturnType>;
    privateGetBrokerNdSubaccountInfo(params?: {}): Promise<implicitReturnType>;
    privateGetBrokerNdSubaccountApikey(params?: {}): Promise<implicitReturnType>;
    privateGetAssetBrokerNdSubaccountDepositAddress(params?: {}): Promise<implicitReturnType>;
    privateGetAssetBrokerNdSubaccountDepositHistory(params?: {}): Promise<implicitReturnType>;
    privateGetAssetBrokerNdSubaccountWithdrawalHistory(params?: {}): Promise<implicitReturnType>;
    privateGetBrokerNdRebateDaily(params?: {}): Promise<implicitReturnType>;
    privateGetBrokerNdRebatePerOrders(params?: {}): Promise<implicitReturnType>;
    privateGetFinanceSfpDcdOrder(params?: {}): Promise<implicitReturnType>;
    privateGetFinanceSfpDcdOrders(params?: {}): Promise<implicitReturnType>;
    privateGetBrokerFdRebatePerOrders(params?: {}): Promise<implicitReturnType>;
    privateGetBrokerFdIfRebate(params?: {}): Promise<implicitReturnType>;
    privateGetAffiliateInviteeDetail(params?: {}): Promise<implicitReturnType>;
    privateGetUsersPartnerIfRebate(params?: {}): Promise<implicitReturnType>;
    privatePostRfqCreateRfq(params?: {}): Promise<implicitReturnType>;
    privatePostRfqCancelRfq(params?: {}): Promise<implicitReturnType>;
    privatePostRfqCancelBatchRfqs(params?: {}): Promise<implicitReturnType>;
    privatePostRfqCancelAllRfqs(params?: {}): Promise<implicitReturnType>;
    privatePostRfqExecuteQuote(params?: {}): Promise<implicitReturnType>;
    privatePostRfqMakerInstrumentSettings(params?: {}): Promise<implicitReturnType>;
    privatePostRfqMmpReset(params?: {}): Promise<implicitReturnType>;
    privatePostRfqMmpConfig(params?: {}): Promise<implicitReturnType>;
    privatePostRfqCreateQuote(params?: {}): Promise<implicitReturnType>;
    privatePostRfqCancelQuote(params?: {}): Promise<implicitReturnType>;
    privatePostRfqCancelBatchQuotes(params?: {}): Promise<implicitReturnType>;
    privatePostRfqCancelAllQuotes(params?: {}): Promise<implicitReturnType>;
    privatePostSprdOrder(params?: {}): Promise<implicitReturnType>;
    privatePostSprdCancelOrder(params?: {}): Promise<implicitReturnType>;
    privatePostSprdMassCancel(params?: {}): Promise<implicitReturnType>;
    privatePostSprdAmendOrder(params?: {}): Promise<implicitReturnType>;
    privatePostTradeOrder(params?: {}): Promise<implicitReturnType>;
    privatePostTradeBatchOrders(params?: {}): Promise<implicitReturnType>;
    privatePostTradeCancelOrder(params?: {}): Promise<implicitReturnType>;
    privatePostTradeCancelBatchOrders(params?: {}): Promise<implicitReturnType>;
    privatePostTradeAmendOrder(params?: {}): Promise<implicitReturnType>;
    privatePostTradeAmendBatchOrders(params?: {}): Promise<implicitReturnType>;
    privatePostTradeClosePosition(params?: {}): Promise<implicitReturnType>;
    privatePostTradeFillsArchive(params?: {}): Promise<implicitReturnType>;
    privatePostTradeOrderAlgo(params?: {}): Promise<implicitReturnType>;
    privatePostTradeCancelAlgos(params?: {}): Promise<implicitReturnType>;
    privatePostTradeAmendAlgos(params?: {}): Promise<implicitReturnType>;
    privatePostTradeCancelAdvanceAlgos(params?: {}): Promise<implicitReturnType>;
    privatePostTradeEasyConvert(params?: {}): Promise<implicitReturnType>;
    privatePostTradeOneClickRepay(params?: {}): Promise<implicitReturnType>;
    privatePostTradeMassCancel(params?: {}): Promise<implicitReturnType>;
    privatePostTradeCancelAllAfter(params?: {}): Promise<implicitReturnType>;
    privatePostAssetTransfer(params?: {}): Promise<implicitReturnType>;
    privatePostAssetWithdrawal(params?: {}): Promise<implicitReturnType>;
    privatePostAssetWithdrawalLightning(params?: {}): Promise<implicitReturnType>;
    privatePostAssetCancelWithdrawal(params?: {}): Promise<implicitReturnType>;
    privatePostAssetConvertDustAssets(params?: {}): Promise<implicitReturnType>;
    privatePostAssetConvertEstimateQuote(params?: {}): Promise<implicitReturnType>;
    privatePostAssetConvertTrade(params?: {}): Promise<implicitReturnType>;
    privatePostAssetMonthlyStatement(params?: {}): Promise<implicitReturnType>;
    privatePostAccountSetPositionMode(params?: {}): Promise<implicitReturnType>;
    privatePostAccountSetLeverage(params?: {}): Promise<implicitReturnType>;
    privatePostAccountPositionMarginBalance(params?: {}): Promise<implicitReturnType>;
    privatePostAccountSetGreeks(params?: {}): Promise<implicitReturnType>;
    privatePostAccountSetIsolatedMode(params?: {}): Promise<implicitReturnType>;
    privatePostAccountQuickMarginBorrowRepay(params?: {}): Promise<implicitReturnType>;
    privatePostAccountBorrowRepay(params?: {}): Promise<implicitReturnType>;
    privatePostAccountSimulatedMargin(params?: {}): Promise<implicitReturnType>;
    privatePostAccountSetRiskOffsetType(params?: {}): Promise<implicitReturnType>;
    privatePostAccountActivateOption(params?: {}): Promise<implicitReturnType>;
    privatePostAccountSetAutoLoan(params?: {}): Promise<implicitReturnType>;
    privatePostAccountSetAccountLevel(params?: {}): Promise<implicitReturnType>;
    privatePostAccountMmpReset(params?: {}): Promise<implicitReturnType>;
    privatePostAccountMmpConfig(params?: {}): Promise<implicitReturnType>;
    privatePostUsersSubaccountModifyApikey(params?: {}): Promise<implicitReturnType>;
    privatePostAssetSubaccountTransfer(params?: {}): Promise<implicitReturnType>;
    privatePostUsersSubaccountSetTransferOut(params?: {}): Promise<implicitReturnType>;
    privatePostAccountSubaccountSetLoanAllocation(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotGridOrderAlgo(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotGridAmendOrderAlgo(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotGridStopOrderAlgo(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotGridClosePosition(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotGridCancelCloseOrder(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotGridOrderInstantTrigger(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotGridWithdrawIncome(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotGridComputeMarginBalance(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotGridMarginBalance(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotGridMinInvestment(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotSignalCreateSignal(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotSignalOrderAlgo(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotSignalStopOrderAlgo(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotSignalMarginBalance(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotSignalAmendTPSL(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotSignalSetInstruments(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotSignalClosePosition(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotSignalSubOrder(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotSignalCancelSubOrder(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotRecurringOrderAlgo(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotRecurringAmendOrderAlgo(params?: {}): Promise<implicitReturnType>;
    privatePostTradingBotRecurringStopOrderAlgo(params?: {}): Promise<implicitReturnType>;
    privatePostFinanceSavingsPurchaseRedempt(params?: {}): Promise<implicitReturnType>;
    privatePostFinanceSavingsSetLendingRate(params?: {}): Promise<implicitReturnType>;
    privatePostFinanceStakingDefiPurchase(params?: {}): Promise<implicitReturnType>;
    privatePostFinanceStakingDefiRedeem(params?: {}): Promise<implicitReturnType>;
    privatePostFinanceStakingDefiCancel(params?: {}): Promise<implicitReturnType>;
    privatePostFinanceStakingDefiEthPurchase(params?: {}): Promise<implicitReturnType>;
    privatePostFinanceStakingDefiEthRedeem(params?: {}): Promise<implicitReturnType>;
    privatePostCopytradingAlgoOrder(params?: {}): Promise<implicitReturnType>;
    privatePostCopytradingCloseSubposition(params?: {}): Promise<implicitReturnType>;
    privatePostCopytradingSetInstruments(params?: {}): Promise<implicitReturnType>;
    privatePostCopytradingFirstCopySettings(params?: {}): Promise<implicitReturnType>;
    privatePostCopytradingAmendCopySettings(params?: {}): Promise<implicitReturnType>;
    privatePostCopytradingStopCopyTrading(params?: {}): Promise<implicitReturnType>;
    privatePostCopytradingBatchSetLeverage(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerNdCreateSubaccount(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerNdDeleteSubaccount(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerNdSubaccountApikey(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerNdSubaccountModifyApikey(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerNdSubaccountDeleteApikey(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerNdSetSubaccountLevel(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerNdSetSubaccountFeeRate(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerNdSetSubaccountAssets(params?: {}): Promise<implicitReturnType>;
    privatePostAssetBrokerNdSubaccountDepositAddress(params?: {}): Promise<implicitReturnType>;
    privatePostAssetBrokerNdModifySubaccountDepositAddress(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerNdRebatePerOrders(params?: {}): Promise<implicitReturnType>;
    privatePostFinanceSfpDcdQuote(params?: {}): Promise<implicitReturnType>;
    privatePostFinanceSfpDcdOrder(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerNdReportSubaccountIp(params?: {}): Promise<implicitReturnType>;
    privatePostBrokerFdRebatePerOrders(params?: {}): Promise<implicitReturnType>;
}
declare abstract class Exchange extends _Exchange {
}
export default Exchange;