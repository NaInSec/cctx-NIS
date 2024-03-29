<?php

namespace ccxt\async\abstract;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


abstract class btcmarkets extends \ccxt\async\Exchange {
    public function public_get_markets($params = array()) {
        return $this->request('markets', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_markets_marketid_ticker($params = array()) {
        return $this->request('markets/{marketId}/ticker', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_markets_marketid_trades($params = array()) {
        return $this->request('markets/{marketId}/trades', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_markets_marketid_orderbook($params = array()) {
        return $this->request('markets/{marketId}/orderbook', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_markets_marketid_candles($params = array()) {
        return $this->request('markets/{marketId}/candles', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_markets_tickers($params = array()) {
        return $this->request('markets/tickers', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_markets_orderbooks($params = array()) {
        return $this->request('markets/orderbooks', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_time($params = array()) {
        return $this->request('time', 'public', 'GET', $params, null, null, array());
    }
    public function private_get_orders($params = array()) {
        return $this->request('orders', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_orders_id($params = array()) {
        return $this->request('orders/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_batchorders_ids($params = array()) {
        return $this->request('batchorders/{ids}', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_trades($params = array()) {
        return $this->request('trades', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_trades_id($params = array()) {
        return $this->request('trades/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_withdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_withdrawals_id($params = array()) {
        return $this->request('withdrawals/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_deposits($params = array()) {
        return $this->request('deposits', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_deposits_id($params = array()) {
        return $this->request('deposits/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_transfers($params = array()) {
        return $this->request('transfers', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_transfers_id($params = array()) {
        return $this->request('transfers/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_addresses($params = array()) {
        return $this->request('addresses', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_withdrawal_fees($params = array()) {
        return $this->request('withdrawal-fees', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_assets($params = array()) {
        return $this->request('assets', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_accounts_me_trading_fees($params = array()) {
        return $this->request('accounts/me/trading-fees', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_accounts_me_withdrawal_limits($params = array()) {
        return $this->request('accounts/me/withdrawal-limits', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_accounts_me_balances($params = array()) {
        return $this->request('accounts/me/balances', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_accounts_me_transactions($params = array()) {
        return $this->request('accounts/me/transactions', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_reports_id($params = array()) {
        return $this->request('reports/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function private_post_orders($params = array()) {
        return $this->request('orders', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_batchorders($params = array()) {
        return $this->request('batchorders', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_withdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_reports($params = array()) {
        return $this->request('reports', 'private', 'POST', $params, null, null, array());
    }
    public function private_delete_orders($params = array()) {
        return $this->request('orders', 'private', 'DELETE', $params, null, null, array());
    }
    public function private_delete_orders_id($params = array()) {
        return $this->request('orders/{id}', 'private', 'DELETE', $params, null, null, array());
    }
    public function private_delete_batchorders_ids($params = array()) {
        return $this->request('batchorders/{ids}', 'private', 'DELETE', $params, null, null, array());
    }
    public function private_put_orders_id($params = array()) {
        return $this->request('orders/{id}', 'private', 'PUT', $params, null, null, array());
    }
    public function publicGetMarkets($params = array()) {
        return $this->request('markets', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetMarketsMarketIdTicker($params = array()) {
        return $this->request('markets/{marketId}/ticker', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetMarketsMarketIdTrades($params = array()) {
        return $this->request('markets/{marketId}/trades', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetMarketsMarketIdOrderbook($params = array()) {
        return $this->request('markets/{marketId}/orderbook', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetMarketsMarketIdCandles($params = array()) {
        return $this->request('markets/{marketId}/candles', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetMarketsTickers($params = array()) {
        return $this->request('markets/tickers', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetMarketsOrderbooks($params = array()) {
        return $this->request('markets/orderbooks', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetTime($params = array()) {
        return $this->request('time', 'public', 'GET', $params, null, null, array());
    }
    public function privateGetOrders($params = array()) {
        return $this->request('orders', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetOrdersId($params = array()) {
        return $this->request('orders/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetBatchordersIds($params = array()) {
        return $this->request('batchorders/{ids}', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetTrades($params = array()) {
        return $this->request('trades', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetTradesId($params = array()) {
        return $this->request('trades/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetWithdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetWithdrawalsId($params = array()) {
        return $this->request('withdrawals/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetDeposits($params = array()) {
        return $this->request('deposits', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetDepositsId($params = array()) {
        return $this->request('deposits/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetTransfers($params = array()) {
        return $this->request('transfers', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetTransfersId($params = array()) {
        return $this->request('transfers/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetAddresses($params = array()) {
        return $this->request('addresses', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetWithdrawalFees($params = array()) {
        return $this->request('withdrawal-fees', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetAssets($params = array()) {
        return $this->request('assets', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetAccountsMeTradingFees($params = array()) {
        return $this->request('accounts/me/trading-fees', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetAccountsMeWithdrawalLimits($params = array()) {
        return $this->request('accounts/me/withdrawal-limits', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetAccountsMeBalances($params = array()) {
        return $this->request('accounts/me/balances', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetAccountsMeTransactions($params = array()) {
        return $this->request('accounts/me/transactions', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetReportsId($params = array()) {
        return $this->request('reports/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function privatePostOrders($params = array()) {
        return $this->request('orders', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostBatchorders($params = array()) {
        return $this->request('batchorders', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostWithdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostReports($params = array()) {
        return $this->request('reports', 'private', 'POST', $params, null, null, array());
    }
    public function privateDeleteOrders($params = array()) {
        return $this->request('orders', 'private', 'DELETE', $params, null, null, array());
    }
    public function privateDeleteOrdersId($params = array()) {
        return $this->request('orders/{id}', 'private', 'DELETE', $params, null, null, array());
    }
    public function privateDeleteBatchordersIds($params = array()) {
        return $this->request('batchorders/{ids}', 'private', 'DELETE', $params, null, null, array());
    }
    public function privatePutOrdersId($params = array()) {
        return $this->request('orders/{id}', 'private', 'PUT', $params, null, null, array());
    }
}
