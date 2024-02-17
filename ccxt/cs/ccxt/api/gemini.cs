// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class gemini : Exchange
{
    public gemini (object args = null): base(args) {}

    public async Task<object> webExchangeGet (object parameters = null)
    {
        return await this.callAsync ("webExchangeGet",parameters);
    }

    public async Task<object> webGetRestApi (object parameters = null)
    {
        return await this.callAsync ("webGetRestApi",parameters);
    }

    public async Task<object> publicGetV1Symbols (object parameters = null)
    {
        return await this.callAsync ("publicGetV1Symbols",parameters);
    }

    public async Task<object> publicGetV1SymbolsDetailsSymbol (object parameters = null)
    {
        return await this.callAsync ("publicGetV1SymbolsDetailsSymbol",parameters);
    }

    public async Task<object> publicGetV1StakingRates (object parameters = null)
    {
        return await this.callAsync ("publicGetV1StakingRates",parameters);
    }

    public async Task<object> publicGetV1PubtickerSymbol (object parameters = null)
    {
        return await this.callAsync ("publicGetV1PubtickerSymbol",parameters);
    }

    public async Task<object> publicGetV2TickerSymbol (object parameters = null)
    {
        return await this.callAsync ("publicGetV2TickerSymbol",parameters);
    }

    public async Task<object> publicGetV2CandlesSymbolTimeframe (object parameters = null)
    {
        return await this.callAsync ("publicGetV2CandlesSymbolTimeframe",parameters);
    }

    public async Task<object> publicGetV1TradesSymbol (object parameters = null)
    {
        return await this.callAsync ("publicGetV1TradesSymbol",parameters);
    }

    public async Task<object> publicGetV1AuctionSymbol (object parameters = null)
    {
        return await this.callAsync ("publicGetV1AuctionSymbol",parameters);
    }

    public async Task<object> publicGetV1AuctionSymbolHistory (object parameters = null)
    {
        return await this.callAsync ("publicGetV1AuctionSymbolHistory",parameters);
    }

    public async Task<object> publicGetV1Pricefeed (object parameters = null)
    {
        return await this.callAsync ("publicGetV1Pricefeed",parameters);
    }

    public async Task<object> publicGetV1BookSymbol (object parameters = null)
    {
        return await this.callAsync ("publicGetV1BookSymbol",parameters);
    }

    public async Task<object> publicGetV1EarnRates (object parameters = null)
    {
        return await this.callAsync ("publicGetV1EarnRates",parameters);
    }

    public async Task<object> privatePostV1StakingUnstake (object parameters = null)
    {
        return await this.callAsync ("privatePostV1StakingUnstake",parameters);
    }

    public async Task<object> privatePostV1StakingStake (object parameters = null)
    {
        return await this.callAsync ("privatePostV1StakingStake",parameters);
    }

    public async Task<object> privatePostV1StakingRewards (object parameters = null)
    {
        return await this.callAsync ("privatePostV1StakingRewards",parameters);
    }

    public async Task<object> privatePostV1StakingHistory (object parameters = null)
    {
        return await this.callAsync ("privatePostV1StakingHistory",parameters);
    }

    public async Task<object> privatePostV1OrderNew (object parameters = null)
    {
        return await this.callAsync ("privatePostV1OrderNew",parameters);
    }

    public async Task<object> privatePostV1OrderCancel (object parameters = null)
    {
        return await this.callAsync ("privatePostV1OrderCancel",parameters);
    }

    public async Task<object> privatePostV1WrapSymbol (object parameters = null)
    {
        return await this.callAsync ("privatePostV1WrapSymbol",parameters);
    }

    public async Task<object> privatePostV1OrderCancelSession (object parameters = null)
    {
        return await this.callAsync ("privatePostV1OrderCancelSession",parameters);
    }

    public async Task<object> privatePostV1OrderCancelAll (object parameters = null)
    {
        return await this.callAsync ("privatePostV1OrderCancelAll",parameters);
    }

    public async Task<object> privatePostV1OrderStatus (object parameters = null)
    {
        return await this.callAsync ("privatePostV1OrderStatus",parameters);
    }

    public async Task<object> privatePostV1Orders (object parameters = null)
    {
        return await this.callAsync ("privatePostV1Orders",parameters);
    }

    public async Task<object> privatePostV1Mytrades (object parameters = null)
    {
        return await this.callAsync ("privatePostV1Mytrades",parameters);
    }

    public async Task<object> privatePostV1Notionalvolume (object parameters = null)
    {
        return await this.callAsync ("privatePostV1Notionalvolume",parameters);
    }

    public async Task<object> privatePostV1Tradevolume (object parameters = null)
    {
        return await this.callAsync ("privatePostV1Tradevolume",parameters);
    }

    public async Task<object> privatePostV1ClearingNew (object parameters = null)
    {
        return await this.callAsync ("privatePostV1ClearingNew",parameters);
    }

    public async Task<object> privatePostV1ClearingStatus (object parameters = null)
    {
        return await this.callAsync ("privatePostV1ClearingStatus",parameters);
    }

    public async Task<object> privatePostV1ClearingCancel (object parameters = null)
    {
        return await this.callAsync ("privatePostV1ClearingCancel",parameters);
    }

    public async Task<object> privatePostV1ClearingConfirm (object parameters = null)
    {
        return await this.callAsync ("privatePostV1ClearingConfirm",parameters);
    }

    public async Task<object> privatePostV1Balances (object parameters = null)
    {
        return await this.callAsync ("privatePostV1Balances",parameters);
    }

    public async Task<object> privatePostV1BalancesStaking (object parameters = null)
    {
        return await this.callAsync ("privatePostV1BalancesStaking",parameters);
    }

    public async Task<object> privatePostV1NotionalbalancesCurrency (object parameters = null)
    {
        return await this.callAsync ("privatePostV1NotionalbalancesCurrency",parameters);
    }

    public async Task<object> privatePostV1Transfers (object parameters = null)
    {
        return await this.callAsync ("privatePostV1Transfers",parameters);
    }

    public async Task<object> privatePostV1AddressesNetwork (object parameters = null)
    {
        return await this.callAsync ("privatePostV1AddressesNetwork",parameters);
    }

    public async Task<object> privatePostV1DepositNetworkNewAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostV1DepositNetworkNewAddress",parameters);
    }

    public async Task<object> privatePostV1DepositCurrencyNewAddress (object parameters = null)
    {
        return await this.callAsync ("privatePostV1DepositCurrencyNewAddress",parameters);
    }

    public async Task<object> privatePostV1WithdrawCurrency (object parameters = null)
    {
        return await this.callAsync ("privatePostV1WithdrawCurrency",parameters);
    }

    public async Task<object> privatePostV1AccountTransferCurrency (object parameters = null)
    {
        return await this.callAsync ("privatePostV1AccountTransferCurrency",parameters);
    }

    public async Task<object> privatePostV1PaymentsAddbank (object parameters = null)
    {
        return await this.callAsync ("privatePostV1PaymentsAddbank",parameters);
    }

    public async Task<object> privatePostV1PaymentsMethods (object parameters = null)
    {
        return await this.callAsync ("privatePostV1PaymentsMethods",parameters);
    }

    public async Task<object> privatePostV1PaymentsSenWithdraw (object parameters = null)
    {
        return await this.callAsync ("privatePostV1PaymentsSenWithdraw",parameters);
    }

    public async Task<object> privatePostV1BalancesEarn (object parameters = null)
    {
        return await this.callAsync ("privatePostV1BalancesEarn",parameters);
    }

    public async Task<object> privatePostV1EarnInterest (object parameters = null)
    {
        return await this.callAsync ("privatePostV1EarnInterest",parameters);
    }

    public async Task<object> privatePostV1EarnHistory (object parameters = null)
    {
        return await this.callAsync ("privatePostV1EarnHistory",parameters);
    }

    public async Task<object> privatePostV1ApprovedAddressesNetworkRequest (object parameters = null)
    {
        return await this.callAsync ("privatePostV1ApprovedAddressesNetworkRequest",parameters);
    }

    public async Task<object> privatePostV1ApprovedAddressesAccountNetwork (object parameters = null)
    {
        return await this.callAsync ("privatePostV1ApprovedAddressesAccountNetwork",parameters);
    }

    public async Task<object> privatePostV1ApprovedAddressesNetworkRemove (object parameters = null)
    {
        return await this.callAsync ("privatePostV1ApprovedAddressesNetworkRemove",parameters);
    }

    public async Task<object> privatePostV1Account (object parameters = null)
    {
        return await this.callAsync ("privatePostV1Account",parameters);
    }

    public async Task<object> privatePostV1AccountCreate (object parameters = null)
    {
        return await this.callAsync ("privatePostV1AccountCreate",parameters);
    }

    public async Task<object> privatePostV1AccountList (object parameters = null)
    {
        return await this.callAsync ("privatePostV1AccountList",parameters);
    }

    public async Task<object> privatePostV1Heartbeat (object parameters = null)
    {
        return await this.callAsync ("privatePostV1Heartbeat",parameters);
    }

}