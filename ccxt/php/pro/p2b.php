<?php

namespace ccxt\pro;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

use Exception; // a common import
use ccxt\ExchangeError;
use ccxt\BadRequest;
use React\Async;
use React\Promise\PromiseInterface;

class p2b extends \ccxt\async\p2b {

    public function describe() {
        return $this->deep_extend(parent::describe(), array(
            'has' => array(
                'ws' => true,
                'cancelAllOrdersWs' => false,
                'cancelOrdersWs' => false,
                'cancelOrderWs' => false,
                'createOrderWs' => false,
                'editOrderWs' => false,
                'fetchBalanceWs' => false,
                'fetchOpenOrdersWs' => false,
                'fetchOrderWs' => false,
                'fetchTradesWs' => false,
                'watchBalance' => false,
                'watchMyTrades' => false,
                'watchOHLCV' => true,
                'watchOrderBook' => true,
                'watchOrders' => false,
                // 'watchStatus' => true,
                'watchTicker' => true,
                'watchTickers' => false,  // in the docs but does not return anything when subscribed to
                'watchTrades' => true,
            ),
            'urls' => array(
                'api' => array(
                    'ws' => 'wss://apiws.p2pb2b.com/',
                ),
            ),
            'options' => array(
                'OHLCVLimit' => 1000,
                'tradesLimit' => 1000,
                'timeframes' => array(
                    '15m' => 900,
                    '30m' => 1800,
                    '1h' => 3600,
                    '1d' => 86400,
                ),
                'watchTicker' => array(
                    'name' => 'state',  // or 'price'
                ),
                'watchTickers' => array(
                    'name' => 'state',  // or 'price'
                ),
            ),
            'streaming' => array(
                'ping' => array($this, 'ping'),
            ),
        ));
    }

    public function subscribe(string $name, string $messageHash, $request, $params = array ()) {
        return Async\async(function () use ($name, $messageHash, $request, $params) {
            /**
             * @ignore
             * Connects to a websocket channel
             * @param {string} $name name of the channel
             * @param {string} $messageHash string to look up in handler
             * @param {stringarray()|float[]} $request endpoint parameters
             * @param {array} [$params] extra parameters specific to the p2b api
             * @return {array} data from the websocket stream
             */
            $url = $this->urls['api']['ws'];
            $subscribe = array(
                'method' => $name,
                'params' => $request,
                'id' => $this->milliseconds(),
            );
            $query = array_merge($subscribe, $params);
            return Async\await($this->watch($url, $messageHash, $query, $messageHash));
        }) ();
    }

    public function watch_ohlcv(string $symbol, $timeframe = '15m', ?int $since = null, ?int $limit = null, $params = array ()): PromiseInterface {
        return Async\async(function () use ($symbol, $timeframe, $since, $limit, $params) {
            /**
             * watches historical candlestick data containing the open, high, low, and close price, and the volume of a $market-> Can only subscribe to one $timeframe at a time for each $symbol
             * @see https://github.com/P2B-team/P2B-WSS-Public/blob/main/wss_documentation.md#kline-candlestick
             * @param {string} $symbol unified $symbol of the $market to fetch OHLCV data for
             * @param {string} $timeframe 15m, 30m, 1h or 1d
             * @param {int} [$since] timestamp in ms of the earliest candle to fetch
             * @param {int} [$limit] the maximum amount of candles to fetch
             * @param {array} [$params] extra parameters specific to the exchange API endpoint
             * @return {int[][]} A list of candles ordered, open, high, low, close, volume
             */
            Async\await($this->load_markets());
            $timeframes = $this->safe_value($this->options, 'timeframes', array());
            $channel = $this->safe_integer($timeframes, $timeframe);
            if ($channel === null) {
                throw new BadRequest($this->id . ' watchOHLCV cannot take a $timeframe of ' . $timeframe);
            }
            $market = $this->market($symbol);
            $request = [
                $market['id'],
                $channel,
            ];
            $messageHash = 'kline::' . $market['symbol'];
            $ohlcv = Async\await($this->subscribe('kline.subscribe', $messageHash, $request, $params));
            if ($this->newUpdates) {
                $limit = $ohlcv->getLimit ($symbol, $limit);
            }
            return $this->filter_by_since_limit($ohlcv, $since, $limit, 0, true);
        }) ();
    }

    public function watch_ticker(string $symbol, $params = array ()): PromiseInterface {
        return Async\async(function () use ($symbol, $params) {
            /**
             * watches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific $market
             * @see https://github.com/P2B-team/P2B-WSS-Public/blob/main/wss_documentation.md#last-price
             * @see https://github.com/P2B-team/P2B-WSS-Public/blob/main/wss_documentation.md#$market-status
             * @param {string} $symbol unified $symbol of the $market to fetch the ticker for
             * @param {array} [$params] extra parameters specific to the exchange API endpoint
             * @param {array} [$params->method] 'state' (default) or 'price'
             * @return {array} a ~@link https://docs.ccxt.com/#/?id=ticker-structure ticker structure~
             */
            Async\await($this->load_markets());
            $watchTickerOptions = $this->safe_value($this->options, 'watchTicker');
            $name = $this->safe_string($watchTickerOptions, 'name', 'state');  // or price
            list($name, $params) = $this->handle_option_and_params($params, 'method', 'name', $name);
            $market = $this->market($symbol);
            $request = [
                $market['id'],
            ];
            $messageHash = $name . '::' . $market['symbol'];
            return Async\await($this->subscribe($name . '.subscribe', $messageHash, $request, $params));
        }) ();
    }

    public function watch_trades(string $symbol, ?int $since = null, ?int $limit = null, $params = array ()): PromiseInterface {
        return Async\async(function () use ($symbol, $since, $limit, $params) {
            /**
             * get the list of most recent $trades for a particular $symbol
             * @see https://github.com/P2B-team/P2B-WSS-Public/blob/main/wss_documentation.md#deals
             * @param {string} $symbol unified $symbol of the $market to fetch $trades for
             * @param {int} [$since] timestamp in ms of the earliest trade to fetch
             * @param {int} [$limit] the maximum amount of $trades to fetch
             * @param {array} [$params] extra parameters specific to the exchange API endpoint
             * @return {array[]} a list of ~@link https://docs.ccxt.com/#/?id=public-$trades trade structures~
             */
            Async\await($this->load_markets());
            $market = $this->market($symbol);
            $request = [
                $market['id'],
            ];
            $messageHash = 'deals::' . $market['symbol'];
            $trades = Async\await($this->subscribe('deals.subscribe', $messageHash, $request, $params));
            if ($this->newUpdates) {
                $limit = $trades->getLimit ($symbol, $limit);
            }
            return $this->filter_by_since_limit($trades, $since, $limit, 'timestamp', true);
        }) ();
    }

    public function watch_order_book(string $symbol, ?int $limit = null, $params = array ()): PromiseInterface {
        return Async\async(function () use ($symbol, $limit, $params) {
            /**
             * watches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
             * @see https://github.com/P2B-team/P2B-WSS-Public/blob/main/wss_documentation.md#depth-of-$market
             * @param {string} $symbol unified $symbol of the $market to fetch the order book for
             * @param {int} [$limit] 1-100, default=100
             * @param {array} [$params] extra parameters specific to the exchange API endpoint
             * @param {float} [$params->interval] 0, 0.00000001, 0.0000001, 0.000001, 0.00001, 0.0001, 0.001, 0.01, 0.1, $interval of precision for order, default=0.001
             * @return {array} A dictionary of ~@link https://docs.ccxt.com/#/?id=order-book-structure order book structures~ indexed by $market symbols
             */
            Async\await($this->load_markets());
            $market = $this->market($symbol);
            $name = 'depth.subscribe';
            $messageHash = 'orderbook::' . $market['symbol'];
            $interval = $this->safe_string($params, 'interval', '0.001');
            if ($limit === null) {
                $limit = 100;
            }
            $request = [
                $market['id'],
                $limit,
                $interval,
            ];
            $orderbook = Async\await($this->subscribe($name, $messageHash, $request, $params));
            return $orderbook->limit ();
        }) ();
    }

    public function handle_ohlcv(Client $client, $message) {
        //
        //    {
        //        "method" => "kline.update",
        //        "params" => array(
        //            array(
        //                1657648800,             // Kline start time
        //                "0.054146",             // Kline open price
        //                "0.053938",             // Kline close price (current price)
        //                "0.054146",             // Kline high price
        //                "0.053911",             // Kline low price
        //                "596.4674",             // Volume for stock currency
        //                "32.2298758767",        // Volume for money currency
        //                "ETH_BTC"               // Market
        //            )
        //        ),
        //        "id" => null
        //    }
        //
        $data = $this->safe_list($message, 'params');
        $data = $this->safe_list($data, 0);
        $method = $this->safe_string($message, 'method');
        $splitMethod = explode('.', $method);
        $channel = $this->safe_string($splitMethod, 0);
        $marketId = $this->safe_string($data, 7);
        $market = $this->safe_market($marketId);
        $timeframes = $this->safe_dict($this->options, 'timeframes', array());
        $timeframe = $this->find_timeframe($channel, $timeframes);
        $symbol = $this->safe_string($market, 'symbol');
        $messageHash = $channel . '::' . $symbol;
        $parsed = $this->parse_ohlcv($data, $market);
        $this->ohlcvs[$symbol] = $this->safe_value($this->ohlcvs, $symbol, array());
        $stored = $this->safe_value($this->ohlcvs[$symbol], $timeframe);
        if ($symbol !== null) {
            if ($stored === null) {
                $limit = $this->safe_integer($this->options, 'OHLCVLimit', 1000);
                $stored = new ArrayCacheByTimestamp ($limit);
                $this->ohlcvs[$symbol][$timeframe] = $stored;
            }
            $stored->append ($parsed);
            $client->resolve ($stored, $messageHash);
        }
        return $message;
    }

    public function handle_trade(Client $client, $message) {
        //
        //    {
        //        "method" => "deals.update",
        //        "params" => array(
        //            "ETH_BTC",
        //            array(
        //                array(
        //                    "id" => 4503032979,               // Order_id
        //                    "amount" => "0.103",
        //                    "type" => "sell",                 // Side
        //                    "time" => 1657661950.8487639,     // Creation time
        //                    "price" => "0.05361"
        //                ),
        //                ...
        //            )
        //        ),
        //        "id" => null
        //    }
        //
        $data = $this->safe_list($message, 'params', array());
        $trades = $this->safe_list($data, 1);
        $marketId = $this->safe_string($data, 0);
        $market = $this->safe_market($marketId);
        $symbol = $this->safe_string($market, 'symbol');
        $tradesArray = $this->safe_value($this->trades, $symbol);
        if ($tradesArray === null) {
            $tradesLimit = $this->safe_integer($this->options, 'tradesLimit', 1000);
            $tradesArray = new ArrayCache ($tradesLimit);
            $this->trades[$symbol] = $tradesArray;
        }
        for ($i = 0; $i < count($trades); $i++) {
            $item = $trades[$i];
            $trade = $this->parse_trade($item, $market);
            $tradesArray->append ($trade);
        }
        $messageHash = 'deals::' . $symbol;
        $client->resolve ($tradesArray, $messageHash);
        return $message;
    }

    public function handle_ticker(Client $client, $message) {
        //
        // state
        //
        //    {
        //        "method" => "state.update",
        //        "params" => array(
        //            "ETH_BTC",
        //            {
        //                "high" => "0.055774",         // High price for the last 24h
        //                "close" => "0.053679",        // Close price for the last 24h
        //                "low" => "0.053462",          // Low price for the last 24h
        //                "period" => 86400,            // Period 24h
        //                "last" => "0.053679",         // Last price for the last 24h
        //                "volume" => "38463.6132",     // Stock volume for the last 24h
        //                "open" => "0.055682",         // Open price for the last 24h
        //                "deal" => "2091.0038055314"   // Money volume for the last 24h
        //            }
        //        ),
        //        "id" => null
        //    }
        //
        // price
        //
        //    {
        //        "method" => "price.update",
        //        "params" => array(
        //            "ETH_BTC",      // $market
        //            "0.053836"      // last price
        //        ),
        //        "id" => null
        //    }
        //
        $data = $this->safe_list($message, 'params', array());
        $marketId = $this->safe_string($data, 0);
        $market = $this->safe_market($marketId);
        $method = $this->safe_string($message, 'method');
        $splitMethod = explode('.', $method);
        $messageHashStart = $this->safe_string($splitMethod, 0);
        $tickerData = $this->safe_dict($data, 1);
        $ticker = null;
        if ($method === 'price.update') {
            $lastPrice = $this->safe_string($data, 1);
            $ticker = $this->safe_ticker(array(
                'last' => $lastPrice,
                'close' => $lastPrice,
                'symbol' => $market['symbol'],
            ));
        } else {
            $ticker = $this->parse_ticker($tickerData, $market);
        }
        $symbol = $ticker['symbol'];
        $messageHash = $messageHashStart . '::' . $symbol;
        $client->resolve ($ticker, $messageHash);
        return $message;
    }

    public function handle_order_book(Client $client, $message) {
        //
        //    {
        //        "method" => "depth.update",
        //        "params" => array(
        //            false,                          // true - all records, false - new records
        //            array(
        //                "asks" => array(                   // side
        //                    array(
        //                        "19509.81",         // $price
        //                        "0.277"             // $amount
        //                    )
        //                )
        //            ),
        //            "BTC_USDT"
        //        ),
        //        "id" => null
        //    }
        //
        $params = $this->safe_list($message, 'params', array());
        $data = $this->safe_dict($params, 1);
        $asks = $this->safe_list($data, 'asks');
        $bids = $this->safe_list($data, 'bids');
        $marketId = $this->safe_string($params, 2);
        $market = $this->safe_market($marketId);
        $symbol = $market['symbol'];
        $messageHash = 'orderbook::' . $market['symbol'];
        $subscription = $this->safe_value($client->subscriptions, $messageHash, array());
        $limit = $this->safe_integer($subscription, 'limit');
        $orderbook = $this->safe_value($this->orderbooks, $symbol);
        if ($orderbook === null) {
            $this->orderbooks[$symbol] = $this->order_book(array(), $limit);
            $orderbook = $this->orderbooks[$symbol];
        }
        if ($bids !== null) {
            for ($i = 0; $i < count($bids); $i++) {
                $bid = $this->safe_value($bids, $i);
                $price = $this->safe_number($bid, 0);
                $amount = $this->safe_number($bid, 1);
                $bookSide = $orderbook['bids'];
                $bookSide->store ($price, $amount);
            }
        }
        if ($asks !== null) {
            for ($i = 0; $i < count($asks); $i++) {
                $ask = $this->safe_value($asks, $i);
                $price = $this->safe_number($ask, 0);
                $amount = $this->safe_number($ask, 1);
                $bookside = $orderbook['asks'];
                $bookside->store ($price, $amount);
            }
        }
        $orderbook['symbol'] = $symbol;
        $client->resolve ($orderbook, $messageHash);
    }

    public function handle_message(Client $client, $message) {
        if ($this->handle_error_message($client, $message)) {
            return;
        }
        $result = $this->safe_string($message, 'result');
        if ($result === 'pong') {
            $this->handle_pong($client, $message);
            return;
        }
        $method = $this->safe_string($message, 'method');
        $methods = array(
            'depth.update' => array($this, 'handle_order_book'),
            'price.update' => array($this, 'handle_ticker'),
            'kline.update' => array($this, 'handle_ohlcv'),
            'state.update' => array($this, 'handle_ticker'),
            'deals.update' => array($this, 'handle_trade'),
        );
        $endpoint = $this->safe_value($methods, $method);
        if ($endpoint !== null) {
            $endpoint($client, $message);
        }
    }

    public function handle_error_message(Client $client, $message) {
        $error = $this->safe_string($message, 'error');
        if ($error !== null) {
            throw new ExchangeError($this->id . ' $error => ' . $this->json($error));
        }
        return false;
    }

    public function ping($client) {
        /**
         * @see https://github.com/P2B-team/P2B-WSS-Public/blob/main/wss_documentation.md#ping
         * @param $client
         */
        return array(
            'method' => 'server.ping',
            'params' => array(),
            'id' => $this->milliseconds(),
        );
    }

    public function handle_pong(Client $client, $message) {
        //
        //    {
        //        error => null,
        //        result => 'pong',
        //        id => 1706539608030
        //    }
        //
        $client->lastPong = $this->safe_integer($message, 'id');
        return $message;
    }
}