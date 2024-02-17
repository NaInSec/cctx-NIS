<?php

namespace ccxt\abstract;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


abstract class cex extends \ccxt\Exchange {
    public function public_get_currency_profile($params = array()) {
        return $this->request('currency_profile', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_currency_limits($params = array()) {
        return $this->request('currency_limits/', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_last_price_pair($params = array()) {
        return $this->request('last_price/{pair}/', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_last_prices_currencies($params = array()) {
        return $this->request('last_prices/{currencies}/', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_ohlcv_hd_yyyymmdd_pair($params = array()) {
        return $this->request('ohlcv/hd/{yyyymmdd}/{pair}', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_order_book_pair($params = array()) {
        return $this->request('order_book/{pair}/', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_ticker_pair($params = array()) {
        return $this->request('ticker/{pair}/', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_tickers_currencies($params = array()) {
        return $this->request('tickers/{currencies}/', 'public', 'GET', $params, null, null, array());
    }
    public function public_get_trade_history_pair($params = array()) {
        return $this->request('trade_history/{pair}/', 'public', 'GET', $params, null, null, array());
    }
    public function public_post_convert_pair($params = array()) {
        return $this->request('convert/{pair}', 'public', 'POST', $params, null, null, array());
    }
    public function public_post_price_stats_pair($params = array()) {
        return $this->request('price_stats/{pair}', 'public', 'POST', $params, null, null, array());
    }
    public function private_post_active_orders_status($params = array()) {
        return $this->request('active_orders_status/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_archived_orders_pair($params = array()) {
        return $this->request('archived_orders/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_balance($params = array()) {
        return $this->request('balance/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_cancel_order($params = array()) {
        return $this->request('cancel_order/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_cancel_orders_pair($params = array()) {
        return $this->request('cancel_orders/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_cancel_replace_order_pair($params = array()) {
        return $this->request('cancel_replace_order/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_close_position_pair($params = array()) {
        return $this->request('close_position/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_get_address($params = array()) {
        return $this->request('get_address/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_get_crypto_address($params = array()) {
        return $this->request('get_crypto_address', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_get_myfee($params = array()) {
        return $this->request('get_myfee/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_get_order($params = array()) {
        return $this->request('get_order/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_get_order_tx($params = array()) {
        return $this->request('get_order_tx/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_open_orders_pair($params = array()) {
        return $this->request('open_orders/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_open_orders($params = array()) {
        return $this->request('open_orders/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_open_position_pair($params = array()) {
        return $this->request('open_position/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_open_positions_pair($params = array()) {
        return $this->request('open_positions/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_place_order_pair($params = array()) {
        return $this->request('place_order/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function private_post_raw_tx_history($params = array()) {
        return $this->request('raw_tx_history', 'private', 'POST', $params, null, null, array());
    }
    public function publicGetCurrencyProfile($params = array()) {
        return $this->request('currency_profile', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetCurrencyLimits($params = array()) {
        return $this->request('currency_limits/', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetLastPricePair($params = array()) {
        return $this->request('last_price/{pair}/', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetLastPricesCurrencies($params = array()) {
        return $this->request('last_prices/{currencies}/', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetOhlcvHdYyyymmddPair($params = array()) {
        return $this->request('ohlcv/hd/{yyyymmdd}/{pair}', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetOrderBookPair($params = array()) {
        return $this->request('order_book/{pair}/', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetTickerPair($params = array()) {
        return $this->request('ticker/{pair}/', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetTickersCurrencies($params = array()) {
        return $this->request('tickers/{currencies}/', 'public', 'GET', $params, null, null, array());
    }
    public function publicGetTradeHistoryPair($params = array()) {
        return $this->request('trade_history/{pair}/', 'public', 'GET', $params, null, null, array());
    }
    public function publicPostConvertPair($params = array()) {
        return $this->request('convert/{pair}', 'public', 'POST', $params, null, null, array());
    }
    public function publicPostPriceStatsPair($params = array()) {
        return $this->request('price_stats/{pair}', 'public', 'POST', $params, null, null, array());
    }
    public function privatePostActiveOrdersStatus($params = array()) {
        return $this->request('active_orders_status/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostArchivedOrdersPair($params = array()) {
        return $this->request('archived_orders/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostBalance($params = array()) {
        return $this->request('balance/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostCancelOrder($params = array()) {
        return $this->request('cancel_order/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostCancelOrdersPair($params = array()) {
        return $this->request('cancel_orders/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostCancelReplaceOrderPair($params = array()) {
        return $this->request('cancel_replace_order/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostClosePositionPair($params = array()) {
        return $this->request('close_position/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostGetAddress($params = array()) {
        return $this->request('get_address/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostGetCryptoAddress($params = array()) {
        return $this->request('get_crypto_address', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostGetMyfee($params = array()) {
        return $this->request('get_myfee/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostGetOrder($params = array()) {
        return $this->request('get_order/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostGetOrderTx($params = array()) {
        return $this->request('get_order_tx/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostOpenOrdersPair($params = array()) {
        return $this->request('open_orders/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostOpenOrders($params = array()) {
        return $this->request('open_orders/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostOpenPositionPair($params = array()) {
        return $this->request('open_position/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostOpenPositionsPair($params = array()) {
        return $this->request('open_positions/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostPlaceOrderPair($params = array()) {
        return $this->request('place_order/{pair}/', 'private', 'POST', $params, null, null, array());
    }
    public function privatePostRawTxHistory($params = array()) {
        return $this->request('raw_tx_history', 'private', 'POST', $params, null, null, array());
    }
}