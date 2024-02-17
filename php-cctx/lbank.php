<?php

namespace ccxt;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

use Exception; // a common import
use ccxt\abstract\lbank as Exchange;

class lbank extends Exchange {

    public function describe() {
        return $this->deep_extend(parent::describe(), array(
            'id' => 'lbank',
            'name' => 'LBank',
            'countries' => array( 'CN' ),
            'version' => 'v1',
            'has' => array(
                'CORS' => null,
                'spot' => true,
                'margin' => false,
                'swap' => false,
                'future' => false,
                'option' => false,
                'addMargin' => false,
                'cancelOrder' => true,
                'createOrder' => true,
                'createReduceOnlyOrder' => false,
                'createStopLimitOrder' => false,
                'createStopMarketOrder' => false,
                'createStopOrder' => false,
                'fetchBalance' => true,
                'fetchBorrowRate' => false,
                'fetchBorrowRateHistories' => false,
                'fetchBorrowRateHistory' => false,
                'fetchBorrowRates' => false,
                'fetchBorrowRatesPerSymbol' => false,
                'fetchClosedOrders' => true,
                'fetchFundingHistory' => false,
                'fetchFundingRate' => false,
                'fetchFundingRateHistory' => false,
                'fetchFundingRates' => false,
                'fetchIndexOHLCV' => false,
                'fetchLeverage' => false,
                'fetchLeverageTiers' => false,
                'fetchMarginMode' => false,
                'fetchMarkets' => true,
                'fetchMarkOHLCV' => false,
                'fetchOHLCV' => true,
                'fetchOpenInterestHistory' => false,
                'fetchOpenOrders' => false, // status 0 API doesn't work
                'fetchOrder' => true,
                'fetchOrderBook' => true,
                'fetchOrders' => true,
                'fetchPosition' => false,
                'fetchPositionMode' => false,
                'fetchPositions' => false,
                'fetchPositionsRisk' => false,
                'fetchPremiumIndexOHLCV' => false,
                'fetchTicker' => true,
                'fetchTickers' => true,
                'fetchTrades' => true,
                'fetchTradingFee' => false,
                'fetchTradingFees' => false,
                'reduceMargin' => false,
                'setLeverage' => false,
                'setMarginMode' => false,
                'setPositionMode' => false,
                'withdraw' => true,
            ),
            'timeframes' => array(
                '1m' => 'minute1',
                '5m' => 'minute5',
                '15m' => 'minute15',
                '30m' => 'minute30',
                '1h' => 'hour1',
                '2h' => 'hour2',
                '4h' => 'hour4',
                '6h' => 'hour6',
                '8h' => 'hour8',
                '12h' => 'hour12',
                '1d' => 'day1',
                '1w' => 'week1',
            ),
            'urls' => array(
                'logo' => 'https://user-images.githubusercontent.com/1294454/38063602-9605e28a-3302-11e8-81be-64b1e53c4cfb.jpg',
                'api' => array(
                    'rest' => 'https://api.lbank.info',
                ),
                'www' => 'https://www.lbank.info',
                'doc' => 'https://github.com/LBank-exchange/lbank-official-api-docs',
                'fees' => 'https://www.lbank.info/fees.html',
                'referral' => 'https://www.lbank.info/invitevip?icode=7QCY',
            ),
            'api' => array(
                'public' => array(
                    'get' => array(
                        'currencyPairs',
                        'ticker',
                        'depth',
                        'trades',
                        'kline',
                        'accuracy',
                    ),
                ),
                'private' => array(
                    'post' => array(
                        'user_info',
                        'create_order',
                        'cancel_order',
                        'orders_info',
                        'orders_info_history',
                        'withdraw',
                        'withdrawCancel',
                        'withdraws',
                        'withdrawConfigs',
                    ),
                ),
            ),
            'fees' => array(
                'trading' => array(
                    'maker' => $this->parse_number('0.001'),
                    'taker' => $this->parse_number('0.001'),
                ),
                'funding' => array(
                    'withdraw' => array(),
                ),
            ),
            'commonCurrencies' => array(
                'GMT' => 'GMT Token',
                'PNT' => 'Penta',
                'SHINJA' => 'SHINJA(1M)',
                'VET_ERC20' => 'VEN',
            ),
            'options' => array(
                'cacheSecretAsPem' => true,
            ),
            'precisionMode' => TICK_SIZE,
        ));
    }

    public function fetch_markets($params = array ()) {
        /**
         * retrieves data on all markets for lbank
         * @param {array} $params extra parameters specific to the exchange api endpoint
         * @return {array[]} an array of objects representing $market data
         */
        $response = $this->publicGetAccuracy ($params);
        //
        //    array(
        //        array(
        //            "symbol" => "btc_usdt",
        //            "quantityAccuracy" => "4",
        //            "minTranQua" => "0.0001",
        //            "priceAccuracy" => "2"
        //        ),
        //        ...
        //    )
        //
        $result = array();
        for ($i = 0; $i < count($response); $i++) {
            $market = $response[$i];
            $id = $market['symbol'];
            $parts = explode('_', $id);
            $baseId = null;
            $quoteId = null;
            $numParts = count($parts);
            // lbank will return symbols like "vet_erc20_usdt"
            if ($numParts > 2) {
                $baseId = $parts[0] . '_' . $parts[1];
                $quoteId = $parts[2];
            } else {
                $baseId = $parts[0];
                $quoteId = $parts[1];
            }
            $base = $this->safe_currency_code($baseId);
            $quote = $this->safe_currency_code($quoteId);
            $result[] = array(
                'id' => $id,
                'symbol' => $base . '/' . $quote,
                'base' => $base,
                'quote' => $quote,
                'settle' => null,
                'baseId' => $baseId,
                'quoteId' => $quoteId,
                'settleId' => null,
                'type' => 'spot',
                'spot' => true,
                'margin' => false,
                'swap' => false,
                'future' => false,
                'option' => false,
                'active' => true,
                'contract' => false,
                'linear' => null,
                'inverse' => null,
                'contractSize' => null,
                'expiry' => null,
                'expiryDatetime' => null,
                'strike' => null,
                'optionType' => null,
                'precision' => array(
                    'amount' => $this->parse_number($this->parse_precision($this->safe_string($market, 'quantityAccuracy'))),
                    'price' => $this->parse_number($this->parse_precision($this->safe_string($market, 'priceAccuracy'))),
                ),
                'limits' => array(
                    'leverage' => array(
                        'min' => null,
                        'max' => null,
                    ),
                    'amount' => array(
                        'min' => $this->safe_float($market, 'minTranQua'),
                        'max' => null,
                    ),
                    'price' => array(
                        'min' => null,
                        'max' => null,
                    ),
                    'cost' => array(
                        'min' => null,
                        'max' => null,
                    ),
                ),
                'info' => $id,
            );
        }
        return $result;
    }

    public function parse_ticker($ticker, $market = null) {
        //
        //     {
        //         "symbol":"btc_usdt",
        //         "ticker":array(
        //             "high":43416.06,
        //             "vol":7031.7427,
        //             "low":41804.26,
        //             "change":1.33,
        //             "turnover":300302447.81,
        //             "latest":43220.4
        //         ),
        //         "timestamp":1642201617747
        //     }
        //
        $marketId = $this->safe_string($ticker, 'symbol');
        $market = $this->safe_market($marketId, $market, '_');
        $symbol = $market['symbol'];
        $timestamp = $this->safe_integer($ticker, 'timestamp');
        $info = $ticker;
        $ticker = $info['ticker'];
        $last = $this->safe_string($ticker, 'latest');
        $percentage = $this->safe_string($ticker, 'change');
        return $this->safe_ticker(array(
            'symbol' => $symbol,
            'timestamp' => $timestamp,
            'datetime' => $this->iso8601($timestamp),
            'high' => $this->safe_string($ticker, 'high'),
            'low' => $this->safe_string($ticker, 'low'),
            'bid' => null,
            'bidVolume' => null,
            'ask' => null,
            'askVolume' => null,
            'vwap' => null,
            'open' => null,
            'close' => $last,
            'last' => $last,
            'previousClose' => null,
            'change' => null,
            'percentage' => $percentage,
            'average' => null,
            'baseVolume' => $this->safe_string($ticker, 'vol'),
            'quoteVolume' => $this->safe_string($ticker, 'turnover'),
            'info' => $info,
        ), $market);
    }

    public function fetch_ticker(string $symbol, $params = array ()) {
        /**
         * fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific $market
         * @param {string} $symbol unified $symbol of the $market to fetch the ticker for
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array} a ~@link https://docs.ccxt.com/#/?id=ticker-structure ticker structure~
         */
        $this->load_markets();
        $market = $this->market($symbol);
        $request = array(
            'symbol' => $market['id'],
        );
        $response = $this->publicGetTicker (array_merge($request, $params));
        // {
        //     "symbol":"btc_usdt",
        //     "ticker":array(
        //         "high":43416.06,
        //         "vol":7031.7427,
        //         "low":41804.26,
        //         "change":1.33,
        //         "turnover":300302447.81,
        //         "latest":43220.4
        //         ),
        //     "timestamp":1642201617747
        // }
        return $this->parse_ticker($response, $market);
    }

    public function fetch_tickers(?array $symbols = null, $params = array ()) {
        /**
         * fetches price tickers for multiple markets, statistical calculations with the information calculated over the past 24 hours each market
         * @param {string[]|null} $symbols unified $symbols of the markets to fetch the $ticker for, all market tickers are returned if not assigned
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array} a dictionary of ~@link https://docs.ccxt.com/#/?id=$ticker-structure $ticker structures~
         */
        $this->load_markets();
        $symbols = $this->market_symbols($symbols);
        $request = array(
            'symbol' => 'all',
        );
        $response = $this->publicGetTicker (array_merge($request, $params));
        $result = array();
        for ($i = 0; $i < count($response); $i++) {
            $ticker = $this->parse_ticker($response[$i]);
            $symbol = $ticker['symbol'];
            $result[$symbol] = $ticker;
        }
        return $this->filter_by_array($result, 'symbol', $symbols);
    }

    public function fetch_order_book(string $symbol, $limit = 60, $params = array ()) {
        /**
         * fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
         * @param {string} $symbol unified $symbol of the $market to fetch the order book for
         * @param {int|null} $limit the maximum amount of order book entries to return
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array} A dictionary of ~@link https://docs.ccxt.com/#/?id=order-book-structure order book structures~ indexed by $market symbols
         */
        $this->load_markets();
        $size = 60;
        if ($limit !== null) {
            $size = min ($limit, $size);
        }
        $market = $this->market($symbol);
        $request = array(
            'symbol' => $market['id'],
            'size' => $size,
        );
        $response = $this->publicGetDepth (array_merge($request, $params));
        return $this->parse_order_book($response, $market['symbol']);
    }

    public function parse_trade($trade, $market = null) {
        $market = $this->safe_market(null, $market);
        $timestamp = $this->safe_integer($trade, 'date_ms');
        $priceString = $this->safe_string($trade, 'price');
        $amountString = $this->safe_string($trade, 'amount');
        $price = $this->parse_number($priceString);
        $amount = $this->parse_number($amountString);
        $cost = $this->parse_number(Precise::string_mul($priceString, $amountString));
        $id = $this->safe_string($trade, 'tid');
        $type = null;
        $side = $this->safe_string($trade, 'type');
        // remove $type additions from i.e. buy_maker, sell_maker, buy_ioc, sell_ioc, buy_fok, sell_fok
        $splited = explode('_', $side);
        $side = $splited[0];
        return array(
            'id' => $id,
            'info' => $this->safe_value($trade, 'info', $trade),
            'timestamp' => $timestamp,
            'datetime' => $this->iso8601($timestamp),
            'symbol' => $market['symbol'],
            'order' => null,
            'type' => $type,
            'side' => $side,
            'takerOrMaker' => null,
            'price' => $price,
            'amount' => $amount,
            'cost' => $cost,
            'fee' => null,
        );
    }

    public function fetch_trades(string $symbol, ?int $since = null, ?int $limit = null, $params = array ()) {
        /**
         * get the list of most recent trades for a particular $symbol
         * @param {string} $symbol unified $symbol of the $market to fetch trades for
         * @param {int|null} $since timestamp in ms of the earliest trade to fetch
         * @param {int|null} $limit the maximum amount of trades to fetch
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array[]} a list of ~@link https://docs.ccxt.com/en/latest/manual.html?#public-trades trade structures~
         */
        $this->load_markets();
        $market = $this->market($symbol);
        $request = array(
            'symbol' => $market['id'],
            'size' => 100,
        );
        if ($since !== null) {
            $request['time'] = $since;
        }
        if ($limit !== null) {
            $request['size'] = $limit;
        }
        $response = $this->publicGetTrades (array_merge($request, $params));
        return $this->parse_trades($response, $market, $since, $limit);
    }

    public function parse_ohlcv($ohlcv, $market = null) {
        //
        //     array(
        //         1590969600,
        //         0.02451657,
        //         0.02452675,
        //         0.02443701,
        //         0.02447814,
        //         238.38210000
        //     )
        //
        return array(
            $this->safe_timestamp($ohlcv, 0),
            $this->safe_number($ohlcv, 1),
            $this->safe_number($ohlcv, 2),
            $this->safe_number($ohlcv, 3),
            $this->safe_number($ohlcv, 4),
            $this->safe_number($ohlcv, 5),
        );
    }

    public function fetch_ohlcv(string $symbol, $timeframe = '1m', ?int $since = null, $limit = 1000, $params = array ()) {
        /**
         * fetches historical candlestick data containing the open, high, low, and close price, and the volume of a $market
         * @param {string} $symbol unified $symbol of the $market to fetch OHLCV data for
         * @param {string} $timeframe the length of time each candle represents
         * @param {int|null} $since timestamp in ms of the earliest candle to fetch
         * @param {int|null} $limit the maximum amount of candles to fetch
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {int[][]} A list of candles ordered, open, high, low, close, volume
         */
        $this->load_markets();
        $market = $this->market($symbol);
        if ($limit === null) {
            $limit = 100; // it's defined in lbank2
        }
        if ($since === null) {
            $duration = $this->parse_timeframe($timeframe);
            $since = $this->milliseconds() - $duration * 1000 * $limit;
        }
        $request = array(
            'symbol' => $market['id'],
            'type' => $this->safe_string($this->timeframes, $timeframe, $timeframe),
            'size' => $limit,
            'time' => $this->parse_to_int($since / 1000),
        );
        $response = $this->publicGetKline (array_merge($request, $params));
        //
        //     [
        //         [1590969600,0.02451657,0.02452675,0.02443701,0.02447814,238.38210000],
        //         [1590969660,0.02447814,0.02449883,0.02443209,0.02445973,212.40270000],
        //         [1590969720,0.02445973,0.02452067,0.02445909,0.02446151,266.16920000],
        //     ]
        //
        return $this->parse_ohlcvs($response, $market, $timeframe, $since, $limit);
    }

    public function parse_balance($response) {
        $result = array(
            'info' => $response,
            'timestamp' => null,
            'datetime' => null,
        );
        $info = $this->safe_value($response, 'info', array());
        $free = $this->safe_value($info, 'free', array());
        $freeze = $this->safe_value($info, 'freeze', array());
        $asset = $this->safe_value($info, 'asset', array());
        $currencyIds = is_array($free) ? array_keys($free) : array();
        for ($i = 0; $i < count($currencyIds); $i++) {
            $currencyId = $currencyIds[$i];
            $code = $this->safe_currency_code($currencyId);
            $account = $this->account();
            $account['free'] = $this->safe_string($free, $currencyId);
            $account['used'] = $this->safe_string($freeze, $currencyId);
            $account['total'] = $this->safe_string($asset, $currencyId);
            $result[$code] = $account;
        }
        return $this->safe_balance($result);
    }

    public function fetch_balance($params = array ()) {
        /**
         * query for balance and get the amount of funds available for trading or funds locked in orders
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array} a ~@link https://docs.ccxt.com/en/latest/manual.html?#balance-structure balance structure~
         */
        $this->load_markets();
        $response = $this->privatePostUserInfo ($params);
        //
        //     {
        //         "result":"true",
        //         "info":{
        //             "freeze":array(
        //                 "iog":"0.00000000",
        //                 "ssc":"0.00000000",
        //                 "eon":"0.00000000",
        //             ),
        //             "asset":array(
        //                 "iog":"0.00000000",
        //                 "ssc":"0.00000000",
        //                 "eon":"0.00000000",
        //             ),
        //             "free":array(
        //                 "iog":"0.00000000",
        //                 "ssc":"0.00000000",
        //                 "eon":"0.00000000",
        //             ),
        //         }
        //     }
        //
        return $this->parse_balance($response);
    }

    public function parse_order_status($status) {
        $statuses = array(
            '-1' => 'cancelled', // cancelled
            '0' => 'open', // not traded
            '1' => 'open', // partial deal
            '2' => 'closed', // complete deal
            '4' => 'closed', // disposal processing
        );
        return $this->safe_string($statuses, $status);
    }

    public function parse_order($order, $market = null) {
        //
        //     {
        //         "symbol"："eth_btc",
        //         "amount"：10.000000,
        //         "create_time"：1484289832081,
        //         "price"：5000.000000,
        //         "avg_price"：5277.301200,
        //         "type"："sell",
        //         "order_id"："ab704110-af0d-48fd-a083-c218f19a4a55",
        //         "deal_amount"：10.000000,
        //         "status"：2
        //     }
        //
        $marketId = $this->safe_string($order, 'symbol');
        $symbol = $this->safe_symbol($marketId, $market, '_');
        $timestamp = $this->safe_integer($order, 'create_time');
        // Limit Order Request Returns => Order Price
        // Market Order Returns => cny $amount of $market $order
        $price = $this->safe_string($order, 'price');
        $amount = $this->safe_string($order, 'amount');
        $filled = $this->safe_string($order, 'deal_amount');
        $average = $this->safe_string($order, 'avg_price');
        $status = $this->parse_order_status($this->safe_string($order, 'status'));
        $id = $this->safe_string($order, 'order_id');
        $type = $this->safe_string($order, 'order_type');
        $side = $this->safe_string($order, 'type');
        return $this->safe_order(array(
            'id' => $id,
            'clientOrderId' => null,
            'datetime' => $this->iso8601($timestamp),
            'timestamp' => $timestamp,
            'lastTradeTimestamp' => null,
            'status' => $status,
            'symbol' => $symbol,
            'type' => $type,
            'timeInForce' => null,
            'postOnly' => null,
            'side' => $side,
            'price' => $price,
            'stopPrice' => null,
            'triggerPrice' => null,
            'cost' => null,
            'amount' => $amount,
            'filled' => $filled,
            'remaining' => null,
            'trades' => null,
            'fee' => null,
            'info' => $this->safe_value($order, 'info', $order),
            'average' => $average,
        ), $market);
    }

    public function create_order(string $symbol, string $type, string $side, $amount, $price = null, $params = array ()) {
        /**
         * create a trade $order
         * @param {string} $symbol unified $symbol of the $market to create an $order in
         * @param {string} $type 'market' or 'limit'
         * @param {string} $side 'buy' or 'sell'
         * @param {float} $amount how much of currency you want to trade in units of base currency
         * @param {float|null} $price the $price at which the $order is to be fullfilled, in units of the quote currency, ignored in $market orders
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array} an ~@link https://docs.ccxt.com/#/?id=$order-structure $order structure~
         */
        $this->load_markets();
        $market = $this->market($symbol);
        $order = array(
            'symbol' => $market['id'],
            'type' => $side,
            'amount' => $amount,
        );
        if ($type === 'market') {
            $order['type'] .= '_market';
        } else {
            $order['price'] = $price;
        }
        $response = $this->privatePostCreateOrder (array_merge($order, $params));
        $order = $this->omit($order, 'type');
        $order['order_id'] = $response['order_id'];
        $order['type'] = $side;
        $order['order_type'] = $type;
        $order['create_time'] = $this->milliseconds();
        $order['info'] = $response;
        return $this->parse_order($order, $market);
    }

    public function cancel_order(string $id, ?string $symbol = null, $params = array ()) {
        /**
         * cancels an open order
         * @param {string} $id order $id
         * @param {string|null} $symbol unified $symbol of the $market the order was made in
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array} An ~@link https://docs.ccxt.com/#/?$id=order-structure order structure~
         */
        $this->load_markets();
        $market = $this->market($symbol);
        $request = array(
            'symbol' => $market['id'],
            'order_id' => $id,
        );
        $response = $this->privatePostCancelOrder (array_merge($request, $params));
        return $response;
    }

    public function fetch_order(string $id, ?string $symbol = null, $params = array ()) {
        /**
         * fetches information on an order made by the user
         * @param {string|null} $symbol unified $symbol of the $market the order was made in
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array} An ~@link https://docs.ccxt.com/#/?$id=order-structure order structure~
         */
        // Id can be a list of ids delimited by a comma
        $this->load_markets();
        $market = $this->market($symbol);
        $request = array(
            'symbol' => $market['id'],
            'order_id' => $id,
        );
        $response = $this->privatePostOrdersInfo (array_merge($request, $params));
        $data = $this->safe_value($response, 'orders', array());
        $orders = $this->parse_orders($data, $market);
        $numOrders = count($orders);
        if ($numOrders === 1) {
            return $orders[0];
        } else {
            return $orders;
        }
    }

    public function fetch_orders(?string $symbol = null, ?int $since = null, ?int $limit = null, $params = array ()) {
        /**
         * fetches information on multiple orders made by the user
         * @param {string|null} $symbol unified $market $symbol of the $market orders were made in
         * @param {int|null} $since the earliest time in ms to fetch orders for
         * @param {int|null} $limit the maximum number of  orde structures to retrieve
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array[]} a list of ~@link https://docs.ccxt.com/#/?id=order-structure order structures~
         */
        $this->load_markets();
        if ($limit === null) {
            $limit = 100;
        }
        $market = $this->market($symbol);
        $request = array(
            'symbol' => $market['id'],
            'current_page' => 1,
            'page_length' => $limit,
        );
        $response = $this->privatePostOrdersInfoHistory (array_merge($request, $params));
        $data = $this->safe_value($response, 'orders', array());
        return $this->parse_orders($data, null, $since, $limit);
    }

    public function fetch_closed_orders(?string $symbol = null, ?int $since = null, ?int $limit = null, $params = array ()) {
        /**
         * fetches information on multiple $closed $orders made by the user
         * @param {string|null} $symbol unified $market $symbol of the $market $orders were made in
         * @param {int|null} $since the earliest time in ms to fetch $orders for
         * @param {int|null} $limit the maximum number of  orde structures to retrieve
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array[]} a list of ~@link https://docs.ccxt.com/#/?id=order-structure order structures~
         */
        $this->load_markets();
        if ($symbol !== null) {
            $market = $this->market($symbol);
            $symbol = $market['symbol'];
        }
        $orders = $this->fetch_orders($symbol, $since, $limit, $params);
        $closed = $this->filter_by($orders, 'status', 'closed');
        $canceled = $this->filter_by($orders, 'status', 'cancelled'); // cancelled $orders may be partially filled
        $allOrders = $this->array_concat($closed, $canceled);
        return $this->filter_by_symbol_since_limit($allOrders, $symbol, $since, $limit);
    }

    public function withdraw(string $code, $amount, $address, $tag = null, $params = array ()) {
        /**
         * make a withdrawal
         * @param {string} $code unified $currency $code
         * @param {float} $amount the $amount to withdraw
         * @param {string} $address the $address to withdraw to
         * @param {string|null} $tag
         * @param {array} $params extra parameters specific to the lbank api endpoint
         * @return {array} a ~@link https://docs.ccxt.com/#/?id=transaction-structure transaction structure~
         */
        list($tag, $params) = $this->handle_withdraw_tag_and_params($tag, $params);
        // mark and fee are optional $params, mark is a note and must be less than 255 characters
        $this->check_address($address);
        $this->load_markets();
        $currency = $this->currency($code);
        $request = array(
            'assetCode' => $currency['id'],
            'amount' => $amount,
            'account' => $address,
        );
        if ($tag !== null) {
            $request['memo'] = $tag;
        }
        $response = $this->privatePostWithdraw (array_merge($request, $params));
        //
        //     {
        //         'result' => 'true',
        //         'withdrawId' => 90082,
        //         'fee':0.001
        //     }
        //
        return $this->parse_transaction($response, $currency);
    }

    public function parse_transaction($transaction, $currency = null) {
        //
        // withdraw
        //
        //     {
        //         'result' => 'true',
        //         'withdrawId' => 90082,
        //         'fee':0.001
        //     }
        //
        $currency = $this->safe_currency(null, $currency);
        return array(
            'id' => $this->safe_string_2($transaction, 'id', 'withdrawId'),
            'txid' => null,
            'timestamp' => null,
            'datetime' => null,
            'network' => null,
            'addressFrom' => null,
            'address' => null,
            'addressTo' => null,
            'amount' => null,
            'type' => null,
            'currency' => $currency['code'],
            'status' => null,
            'updated' => null,
            'tagFrom' => null,
            'tag' => null,
            'tagTo' => null,
            'comment' => null,
            'fee' => null,
            'info' => $transaction,
        );
    }

    public function convert_secret_to_pem($secret) {
        $lineLength = 64;
        $secretLength = strlen($secret) - 0;
        $numLines = $this->parse_to_int($secretLength / $lineLength);
        $numLines = $this->sum($numLines, 1);
        $pem = "-----BEGIN PRIVATE KEY-----\n"; // eslint-disable-line
        for ($i = 0; $i < $numLines; $i++) {
            $start = $i * $lineLength;
            $end = $this->sum($start, $lineLength);
            $pem .= mb_substr($this->secret, $start, $end - $start) . "\n"; // eslint-disable-line
        }
        return $pem . '-----END PRIVATE KEY-----';
    }

    public function sign($path, $api = 'public', $method = 'GET', $params = array (), $headers = null, $body = null) {
        $query = $this->omit($params, $this->extract_params($path));
        $url = $this->urls['api']['rest'] . '/' . $this->version . '/' . $this->implode_params($path, $params);
        // Every endpoint ends with ".do"
        $url .= '.do';
        if ($api === 'public') {
            if ($query) {
                $url .= '?' . $this->urlencode($query);
            }
        } else {
            $this->check_required_credentials();
            $queryInner = $this->keysort(array_merge(array(
                'api_key' => $this->apiKey,
            ), $params));
            $queryString = $this->rawencode($queryInner);
            $message = strtoupper($this->hash($this->encode($queryString), 'md5'));
            $cacheSecretAsPem = $this->safe_value($this->options, 'cacheSecretAsPem', true);
            $pem = null;
            if ($cacheSecretAsPem) {
                $pem = $this->safe_value($this->options, 'pem');
                if ($pem === null) {
                    $pem = $this->convert_secret_to_pem($this->secret);
                    $this->options['pem'] = $pem;
                }
            } else {
                $pem = $this->convert_secret_to_pem($this->secret);
            }
            $query['sign'] = $this->rsa($message, $pem, 'sha256');
            $body = $this->urlencode($query);
            $headers = array( 'Content-Type' => 'application/x-www-form-urlencoded' );
        }
        return array( 'url' => $url, 'method' => $method, 'body' => $body, 'headers' => $headers );
    }

    public function handle_errors($httpCode, $reason, $url, $method, $headers, $body, $response, $requestHeaders, $requestBody) {
        if ($response === null) {
            return null;
        }
        $success = $this->safe_string($response, 'result');
        if ($success === 'false') {
            $errorCode = $this->safe_string($response, 'error_code');
            $message = $this->safe_string(array(
                '10000' => 'Internal error',
                '10001' => 'The required parameters can not be empty',
                '10002' => 'verification failed',
                '10003' => 'Illegal parameters',
                '10004' => 'User requests are too frequent',
                '10005' => 'Key does not exist',
                '10006' => 'user does not exist',
                '10007' => 'Invalid signature',
                '10008' => 'This currency pair is not supported',
                '10009' => 'Limit orders can not be missing orders and the number of orders',
                '10010' => 'Order price or order quantity must be greater than 0',
                '10011' => 'Market orders can not be missing the amount of the order',
                '10012' => 'market sell orders can not be missing orders',
                '10013' => 'is less than the minimum trading position 0.001',
                '10014' => 'Account number is not enough',
                '10015' => 'The order type is wrong',
                '10016' => 'Account balance is not enough',
                '10017' => 'Abnormal server',
                '10018' => 'order inquiry can not be more than 50 less than one',
                '10019' => 'withdrawal orders can not be more than 3 less than one',
                '10020' => 'less than the minimum amount of the transaction limit of 0.001',
                '10022' => 'Insufficient key authority',
            ), $errorCode, $this->json($response));
            $ErrorClass = $this->safe_value(array(
                '10002' => '\\ccxt\\AuthenticationError',
                '10004' => '\\ccxt\\DDoSProtection',
                '10005' => '\\ccxt\\AuthenticationError',
                '10006' => '\\ccxt\\AuthenticationError',
                '10007' => '\\ccxt\\AuthenticationError',
                '10009' => '\\ccxt\\InvalidOrder',
                '10010' => '\\ccxt\\InvalidOrder',
                '10011' => '\\ccxt\\InvalidOrder',
                '10012' => '\\ccxt\\InvalidOrder',
                '10013' => '\\ccxt\\InvalidOrder',
                '10014' => '\\ccxt\\InvalidOrder',
                '10015' => '\\ccxt\\InvalidOrder',
                '10016' => '\\ccxt\\InvalidOrder',
                '10022' => '\\ccxt\\AuthenticationError',
            ), $errorCode, '\\ccxt\\ExchangeError');
            throw new $ErrorClass($message);
        }
        return null;
    }
}
