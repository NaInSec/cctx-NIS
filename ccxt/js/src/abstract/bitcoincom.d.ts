import { implicitReturnType } from '../base/types.js';
import _fmfwio from '../fmfwio.js';
interface fmfwio {
    publicGetPublicCurrency(params?: {}): Promise<implicitReturnType>;
    publicGetPublicCurrencyCurrency(params?: {}): Promise<implicitReturnType>;
    publicGetPublicSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicSymbolSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicTicker(params?: {}): Promise<implicitReturnType>;
    publicGetPublicTickerSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicPriceRate(params?: {}): Promise<implicitReturnType>;
    publicGetPublicPriceHistory(params?: {}): Promise<implicitReturnType>;
    publicGetPublicPriceTicker(params?: {}): Promise<implicitReturnType>;
    publicGetPublicPriceTickerSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicTrades(params?: {}): Promise<implicitReturnType>;
    publicGetPublicTradesSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicOrderbook(params?: {}): Promise<implicitReturnType>;
    publicGetPublicOrderbookSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicCandles(params?: {}): Promise<implicitReturnType>;
    publicGetPublicCandlesSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesInfo(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesInfoSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesHistoryFunding(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesHistoryFundingSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesCandlesIndexPrice(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesCandlesIndexPriceSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesCandlesMarkPrice(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesCandlesMarkPriceSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesCandlesPremiumIndex(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesCandlesPremiumIndexSymbol(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesCandlesOpenInterest(params?: {}): Promise<implicitReturnType>;
    publicGetPublicFuturesCandlesOpenInterestSymbol(params?: {}): Promise<implicitReturnType>;
    privateGetSpotBalance(params?: {}): Promise<implicitReturnType>;
    privateGetSpotBalanceCurrency(params?: {}): Promise<implicitReturnType>;
    privateGetSpotOrder(params?: {}): Promise<implicitReturnType>;
    privateGetSpotOrderClientOrderId(params?: {}): Promise<implicitReturnType>;
    privateGetSpotFee(params?: {}): Promise<implicitReturnType>;
    privateGetSpotFeeSymbol(params?: {}): Promise<implicitReturnType>;
    privateGetSpotHistoryOrder(params?: {}): Promise<implicitReturnType>;
    privateGetSpotHistoryTrade(params?: {}): Promise<implicitReturnType>;
    privateGetMarginAccount(params?: {}): Promise<implicitReturnType>;
    privateGetMarginAccountIsolatedSymbol(params?: {}): Promise<implicitReturnType>;
    privateGetMarginAccountCrossCurrency(params?: {}): Promise<implicitReturnType>;
    privateGetMarginOrder(params?: {}): Promise<implicitReturnType>;
    privateGetMarginOrderClientOrderId(params?: {}): Promise<implicitReturnType>;
    privateGetMarginConfig(params?: {}): Promise<implicitReturnType>;
    privateGetMarginHistoryOrder(params?: {}): Promise<implicitReturnType>;
    privateGetMarginHistoryTrade(params?: {}): Promise<implicitReturnType>;
    privateGetMarginHistoryPositions(params?: {}): Promise<implicitReturnType>;
    privateGetMarginHistoryClearing(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesBalance(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesBalanceCurrency(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesAccount(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesAccountIsolatedSymbol(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesOrder(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesOrderClientOrderId(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesConfig(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesFee(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesFeeSymbol(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesHistoryOrder(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesHistoryTrade(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesHistoryPositions(params?: {}): Promise<implicitReturnType>;
    privateGetFuturesHistoryClearing(params?: {}): Promise<implicitReturnType>;
    privateGetWalletBalance(params?: {}): Promise<implicitReturnType>;
    privateGetWalletBalanceCurrency(params?: {}): Promise<implicitReturnType>;
    privateGetWalletCryptoAddress(params?: {}): Promise<implicitReturnType>;
    privateGetWalletCryptoAddressRecentDeposit(params?: {}): Promise<implicitReturnType>;
    privateGetWalletCryptoAddressRecentWithdraw(params?: {}): Promise<implicitReturnType>;
    privateGetWalletCryptoAddressCheckMine(params?: {}): Promise<implicitReturnType>;
    privateGetWalletTransactions(params?: {}): Promise<implicitReturnType>;
    privateGetWalletTransactionsTxId(params?: {}): Promise<implicitReturnType>;
    privateGetWalletCryptoFeeEstimate(params?: {}): Promise<implicitReturnType>;
    privateGetWalletAirdrops(params?: {}): Promise<implicitReturnType>;
    privateGetWalletAmountLocks(params?: {}): Promise<implicitReturnType>;
    privateGetSubAccount(params?: {}): Promise<implicitReturnType>;
    privateGetSubAccountAcl(params?: {}): Promise<implicitReturnType>;
    privateGetSubAccountBalanceSubAccID(params?: {}): Promise<implicitReturnType>;
    privateGetSubAccountCryptoAddressSubAccIDCurrency(params?: {}): Promise<implicitReturnType>;
    privatePostSpotOrder(params?: {}): Promise<implicitReturnType>;
    privatePostSpotOrderList(params?: {}): Promise<implicitReturnType>;
    privatePostMarginOrder(params?: {}): Promise<implicitReturnType>;
    privatePostMarginOrderList(params?: {}): Promise<implicitReturnType>;
    privatePostFuturesOrder(params?: {}): Promise<implicitReturnType>;
    privatePostFuturesOrderList(params?: {}): Promise<implicitReturnType>;
    privatePostWalletCryptoAddress(params?: {}): Promise<implicitReturnType>;
    privatePostWalletCryptoWithdraw(params?: {}): Promise<implicitReturnType>;
    privatePostWalletConvert(params?: {}): Promise<implicitReturnType>;
    privatePostWalletTransfer(params?: {}): Promise<implicitReturnType>;
    privatePostWalletInternalWithdraw(params?: {}): Promise<implicitReturnType>;
    privatePostWalletCryptoCheckOffchainAvailable(params?: {}): Promise<implicitReturnType>;
    privatePostWalletCryptoFeesEstimate(params?: {}): Promise<implicitReturnType>;
    privatePostWalletAirdropsIdClaim(params?: {}): Promise<implicitReturnType>;
    privatePostSubAccountFreeze(params?: {}): Promise<implicitReturnType>;
    privatePostSubAccountActivate(params?: {}): Promise<implicitReturnType>;
    privatePostSubAccountTransfer(params?: {}): Promise<implicitReturnType>;
    privatePostSubAccountAcl(params?: {}): Promise<implicitReturnType>;
    privatePatchSpotOrderClientOrderId(params?: {}): Promise<implicitReturnType>;
    privatePatchMarginOrderClientOrderId(params?: {}): Promise<implicitReturnType>;
    privatePatchFuturesOrderClientOrderId(params?: {}): Promise<implicitReturnType>;
    privateDeleteSpotOrder(params?: {}): Promise<implicitReturnType>;
    privateDeleteSpotOrderClientOrderId(params?: {}): Promise<implicitReturnType>;
    privateDeleteMarginPosition(params?: {}): Promise<implicitReturnType>;
    privateDeleteMarginPositionIsolatedSymbol(params?: {}): Promise<implicitReturnType>;
    privateDeleteMarginOrder(params?: {}): Promise<implicitReturnType>;
    privateDeleteMarginOrderClientOrderId(params?: {}): Promise<implicitReturnType>;
    privateDeleteFuturesPosition(params?: {}): Promise<implicitReturnType>;
    privateDeleteFuturesPositionMarginModeSymbol(params?: {}): Promise<implicitReturnType>;
    privateDeleteFuturesOrder(params?: {}): Promise<implicitReturnType>;
    privateDeleteFuturesOrderClientOrderId(params?: {}): Promise<implicitReturnType>;
    privateDeleteWalletCryptoWithdrawId(params?: {}): Promise<implicitReturnType>;
    privatePutMarginAccountIsolatedSymbol(params?: {}): Promise<implicitReturnType>;
    privatePutFuturesAccountIsolatedSymbol(params?: {}): Promise<implicitReturnType>;
    privatePutWalletCryptoWithdrawId(params?: {}): Promise<implicitReturnType>;
}
declare abstract class fmfwio extends _fmfwio {
}
export default fmfwio;
