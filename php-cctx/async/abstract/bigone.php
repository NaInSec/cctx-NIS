<?php

namespace ccxt\async\abstract;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


abstract class bigone extends \ccxt\async\Exchange {
    public function public_get_ping($params = array()) {
        return $this->request('ping', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_asset_pairs($params = array()) {
        return $this->request('asset_pairs', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_asset_pairs_asset_pair_name_depth($params = array()) {
        return $this->request('asset_pairs/{asset_pair_name}/depth', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_asset_pairs_asset_pair_name_trades($params = array()) {
        return $this->request('asset_pairs/{asset_pair_name}/trades', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_asset_pairs_asset_pair_name_ticker($params = array()) {
        return $this->request('asset_pairs/{asset_pair_name}/ticker', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_asset_pairs_asset_pair_name_candles($params = array()) {
        return $this->request('asset_pairs/{asset_pair_name}/candles', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_asset_pairs_tickers($params = array()) {
        return $this->request('asset_pairs/tickers', 'public', 'GET', $params, null, null, array());
    }
    public function private_get_accounts($params = array()) {
        return $this->request('accounts', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_fund_accounts($params = array()) {
        return $this->request('fund/accounts', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_assets_asset_symbol_address($params = array()) {
        return $this->request('assets/{asset_symbol}/address', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_orders($params = array()) {
        return $this->request('orders', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_orders_id($params = array()) {
        return $this->request('orders/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_orders_multi($params = array()) {
        return $this->request('orders/multi', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_trades($params = array()) {
        return $this->request('trades', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_withdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'GET', $params, null, null, array());
    }
    public function private_get_deposits($params = array()) {
        return $this->request('deposits', 'private', 'GET', $params, null, null, array());
    }
    public function private_post_orders($params = array()) {
        return $this->request('orders', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_orders_id_cancel($params = array()) {
        return $this->request('orders/{id}/cancel', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_orders_cancel($params = array()) {
        return $this->request('orders/cancel', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_withdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_transfer($params = array()) {
        return $this->request('transfer', 'private', 'POST', $params, null, null, array());
    }
    public function publicGetPing($params = array()) {
        return $this->request('ping', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetAssetPairs($params = array()) {
        return $this->request('asset_pairs', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetAssetPairsAssetPairNameDepth($params = array()) {
        return $this->request('asset_pairs/{asset_pair_name}/depth', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetAssetPairsAssetPairNameTrades($params = array()) {
        return $this->request('asset_pairs/{asset_pair_name}/trades', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetAssetPairsAssetPairNameTicker($params = array()) {
        return $this->request('asset_pairs/{asset_pair_name}/ticker', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetAssetPairsAssetPairNameCandles($params = array()) {
        return $this->request('asset_pairs/{asset_pair_name}/candles', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetAssetPairsTickers($params = array()) {
        return $this->request('asset_pairs/tickers', 'public', 'GET', $params, null, null, array());
    }
    public function privateGetAccounts($params = array()) {
        return $this->request('accounts', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetFundAccounts($params = array()) {
        return $this->request('fund/accounts', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetAssetsAssetSymbolAddress($params = array()) {
        return $this->request('assets/{asset_symbol}/address', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetOrders($params = array()) {
        return $this->request('orders', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetOrdersId($params = array()) {
        return $this->request('orders/{id}', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetOrdersMulti($params = array()) {
        return $this->request('orders/multi', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetTrades($params = array()) {
        return $this->request('trades', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetWithdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'GET', $params, null, null, array());
    }
    public function privateGetDeposits($params = array()) {
        return $this->request('deposits', 'private', 'GET', $params, null, null, array());
    }
    public function privatePostOrders($params = array()) {
        return $this->request('orders', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostOrdersIdCancel($params = array()) {
        return $this->request('orders/{id}/cancel', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostOrdersCancel($params = array()) {
        return $this->request('orders/cancel', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostWithdrawals($params = array()) {
        return $this->request('withdrawals', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostTransfer($params = array()) {
        return $this->request('transfer', 'private', 'POST', $params, null, null, array());
    }
}
