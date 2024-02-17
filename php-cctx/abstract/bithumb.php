<?php

namespace ccxt\abstract;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


abstract class bithumb extends \ccxt\Exchange {
    public function public_get_ticker_currency($params = array()) {
        return $this->request('ticker/{currency}', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_ticker_all($params = array()) {
        return $this->request('ticker/all', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_ticker_all_btc($params = array()) {
        return $this->request('ticker/ALL_BTC', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_ticker_all_krw($params = array()) {
        return $this->request('ticker/ALL_KRW', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_orderbook_currency($params = array()) {
        return $this->request('orderbook/{currency}', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_orderbook_all($params = array()) {
        return $this->request('orderbook/all', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_transaction_history_currency($params = array()) {
        return $this->request('transaction_history/{currency}', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_transaction_history_all($params = array()) {
        return $this->request('transaction_history/all', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_candlestick_currency_interval($params = array()) {
        return $this->request('candlestick/{currency}/{interval}', 'public', 'GET', $params, null, null, array());
    }
    public function private_post_info_account($params = array()) {
        return $this->request('info/account', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_info_balance($params = array()) {
        return $this->request('info/balance', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_info_wallet_address($params = array()) {
        return $this->request('info/wallet_address', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_info_ticker($params = array()) {
        return $this->request('info/ticker', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_info_orders($params = array()) {
        return $this->request('info/orders', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_info_user_transactions($params = array()) {
        return $this->request('info/user_transactions', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_info_order_detail($params = array()) {
        return $this->request('info/order_detail', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_trade_place($params = array()) {
        return $this->request('trade/place', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_trade_cancel($params = array()) {
        return $this->request('trade/cancel', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_trade_btc_withdrawal($params = array()) {
        return $this->request('trade/btc_withdrawal', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_trade_krw_deposit($params = array()) {
        return $this->request('trade/krw_deposit', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_trade_krw_withdrawal($params = array()) {
        return $this->request('trade/krw_withdrawal', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_trade_market_buy($params = array()) {
        return $this->request('trade/market_buy', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_trade_market_sell($params = array()) {
        return $this->request('trade/market_sell', 'private', 'POST', $params, null, null, array());
    }
    public function publicGetTickerCurrency($params = array()) {
        return $this->request('ticker/{currency}', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetTickerAll($params = array()) {
        return $this->request('ticker/all', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetTickerALLBTC($params = array()) {
        return $this->request('ticker/ALL_BTC', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetTickerALLKRW($params = array()) {
        return $this->request('ticker/ALL_KRW', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetOrderbookCurrency($params = array()) {
        return $this->request('orderbook/{currency}', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetOrderbookAll($params = array()) {
        return $this->request('orderbook/all', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetTransactionHistoryCurrency($params = array()) {
        return $this->request('transaction_history/{currency}', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetTransactionHistoryAll($params = array()) {
        return $this->request('transaction_history/all', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetCandlestickCurrencyInterval($params = array()) {
        return $this->request('candlestick/{currency}/{interval}', 'public', 'GET', $params, null, null, array());
    }
    public function privatePostInfoAccount($params = array()) {
        return $this->request('info/account', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostInfoBalance($params = array()) {
        return $this->request('info/balance', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostInfoWalletAddress($params = array()) {
        return $this->request('info/wallet_address', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostInfoTicker($params = array()) {
        return $this->request('info/ticker', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostInfoOrders($params = array()) {
        return $this->request('info/orders', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostInfoUserTransactions($params = array()) {
        return $this->request('info/user_transactions', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostInfoOrderDetail($params = array()) {
        return $this->request('info/order_detail', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostTradePlace($params = array()) {
        return $this->request('trade/place', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostTradeCancel($params = array()) {
        return $this->request('trade/cancel', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostTradeBtcWithdrawal($params = array()) {
        return $this->request('trade/btc_withdrawal', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostTradeKrwDeposit($params = array()) {
        return $this->request('trade/krw_deposit', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostTradeKrwWithdrawal($params = array()) {
        return $this->request('trade/krw_withdrawal', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostTradeMarketBuy($params = array()) {
        return $this->request('trade/market_buy', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostTradeMarketSell($params = array()) {
        return $this->request('trade/market_sell', 'private', 'POST', $params, null, null, array());
    }
}