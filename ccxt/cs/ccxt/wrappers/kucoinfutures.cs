namespace ccxt;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class kucoinfutures
{
    /// <summary>
    /// the latest known information on the availability of the exchange API
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/market-data/get-service-status"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [status structure]{@link https://docs.ccxt.com/#/?id=exchange-status-structure}.</returns>
    public async Task<Dictionary<string, object>> FetchStatus(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchStatus(parameters);
        return ((Dictionary<string, object>)res);
    }
    /// <summary>
    /// retrieves data on all markets for kucoinfutures
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/market-data/get-symbols-list"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange api endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> an array of objects representing market data.</returns>
    public async Task<List<Dictionary<string, object>>> FetchMarkets(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchMarkets(parameters);
        return ((IList<object>)res).Select(item => (item as Dictionary<string, object>)).ToList();
    }
    /// <summary>
    /// fetches the current integer timestamp in milliseconds from the exchange server
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/market-data/get-server-time"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>int</term> the current integer timestamp in milliseconds from the exchange server.</returns>
    public async Task<Int64> FetchTime(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTime(parameters);
        return (Int64)res;
    }
    /// <summary>
    /// fetches historical candlestick data containing the open, high, low, and close price, and the volume of a market
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/market-data/get-klines"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest candle to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of candles to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.paginate</term>
    /// <description>
    /// boolean : default false, when true will automatically paginate by calling this endpoint multiple times. See in the docs all the [availble parameters](https://github.com/ccxt/ccxt/wiki/Manual#pagination-params)
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>int[][]</term> A list of candles ordered as timestamp, open, high, low, close, volume.</returns>
    public async Task<List<OHLCV>> FetchOHLCV(string symbol, string timeframe = "1m", Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOHLCV(symbol, timeframe, since, limit, parameters);
        return ((IList<object>)res).Select(item => new OHLCV(item)).ToList<OHLCV>();
    }
    /// <summary>
    /// fetch the deposit address for a currency associated with this account
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/funding/deposit/get-deposit-address"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an [address structure]{@link https://docs.ccxt.com/#/?id=address-structure}.</returns>
    public async Task<Dictionary<string, object>> FetchDepositAddress(string code, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchDepositAddress(code, parameters);
        return ((Dictionary<string, object>)res);
    }
    /// <summary>
    /// fetches information on open orders with bid (buy) and ask (sell) prices, volumes and other data
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/market-data/get-part-order-book-level-2"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of order book entries to return
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> A dictionary of [order book structures]{@link https://docs.ccxt.com/#/?id=order-book-structure} indexed by market symbols.</returns>
    public async Task<OrderBook> FetchOrderBook(string symbol, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOrderBook(symbol, limit, parameters);
        return new OrderBook(res);
    }
    /// <summary>
    /// fetches a price ticker, a statistical calculation with the information calculated over the past 24 hours for a specific market
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/market-data/get-ticker"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [ticker structure]{@link https://docs.ccxt.com/#/?id=ticker-structure}.</returns>
    public async Task<Ticker> FetchTicker(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchTicker(symbol, parameters);
        return new Ticker(res);
    }
    /// <summary>
    /// fetch the history of funding payments paid and received on this account
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/funding-fees/get-funding-history"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch funding history for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of funding history structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [funding history structure]{@link https://docs.ccxt.com/#/?id=funding-history-structure}.</returns>
    public async Task<List<FundingHistory>> FetchFundingHistory(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchFundingHistory(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new FundingHistory(item)).ToList<FundingHistory>();
    }
    /// <summary>
    /// fetch data on an open position
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.kucoin.com/futures/#get-position-details"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [position structure]{@link https://docs.ccxt.com/#/?id=position-structure}.</returns>
    public async Task<Position> FetchPosition(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchPosition(symbol, parameters);
        return new Position(res);
    }
    /// <summary>
    /// fetch all open positions
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.kucoin.com/futures/#get-position-list"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [position structure]{@link https://docs.ccxt.com/#/?id=position-structure}.</returns>
    public async Task<List<Position>> FetchPositions(List<String> symbols = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchPositions(symbols, parameters);
        return ((IList<object>)res).Select(item => new Position(item)).ToList<Position>();
    }
    /// <summary>
    /// Create an order on the exchange
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.kucoin.com/futures/#place-an-order"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>price</term>
    /// <description>
    /// float : *ignored in "market" orders* the price at which the order is to be fullfilled at in units of the quote currency
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object :  extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.triggerPrice</term>
    /// <description>
    /// float : The price a trigger order is triggered at
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stopLossPrice</term>
    /// <description>
    /// float : price to trigger stop-loss orders
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.takeProfitPrice</term>
    /// <description>
    /// float : price to trigger take-profit orders
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.reduceOnly</term>
    /// <description>
    /// bool : A mark to reduce the position size only. Set to false by default. Need to set the position size when reduceOnly is true.
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.timeInForce</term>
    /// <description>
    /// string : GTC, GTT, IOC, or FOK, default is GTC, limit orders only
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.postOnly</term>
    /// <description>
    /// string : Post only flag, invalid when timeInForce is IOC or FOK
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.leverage</term>
    /// <description>
    /// float : Leverage size of the order
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.clientOid</term>
    /// <description>
    /// string : client order id, defaults to uuid if not passed
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.remark</term>
    /// <description>
    /// string : remark for the order, length cannot exceed 100 utf8 characters
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stop</term>
    /// <description>
    /// string : 'up' or 'down', the direction the stopPrice is triggered from, requires stopPrice. down: Triggers when the price reaches or goes below the stopPrice. up: Triggers when the price reaches or goes above the stopPrice.
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.stopPriceType</term>
    /// <description>
    /// string :  TP, IP or MP, defaults to MP: Mark Price
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.closeOrder</term>
    /// <description>
    /// bool : set to true to close position
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.test</term>
    /// <description>
    /// bool : set to true to use the test order endpoint (does not submit order, use to validate params)
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.forceHold</term>
    /// <description>
    /// bool : A mark to forcely hold the funds for an order, even though it's an order to reduce the position size. This helps the order stay on the order book and not get canceled when the position size changes. Set to false by default.
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> CreateOrder(string symbol, string type, string side, double amount, double? price2 = 0, Dictionary<string, object> parameters = null)
    {
        var price = price2 == 0 ? null : (object)price2;
        var res = await this.createOrder(symbol, type, side, amount, price, parameters);
        return new Order(res);
    }
    /// <summary>
    /// create a list of trade orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/orders/place-multiple-orders"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object :  extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> an [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> CreateOrders(List<OrderRequest> orders, Dictionary<string, object> parameters = null)
    {
        var res = await this.createOrders(orders, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    public Dictionary<string, object> CreateContractOrderRequest(string symbol, string type, string side, double amount, double? price2 = 0, Dictionary<string, object> parameters = null)
    {
        var price = price2 == 0 ? null : (object)price2;
        var res = this.createContractOrderRequest(symbol, type, side, amount, price, parameters);
        return ((Dictionary<string, object>)res);
    }
    /// <summary>
    /// cancels an open order
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/orders/cancel-futures-order-by-orderid"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.clientOrderId</term>
    /// <description>
    /// string : cancel order by client order id
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Dictionary<string, object>> CancelOrder(string id, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.cancelOrder(id, symbol, parameters);
        return ((Dictionary<string, object>)res);
    }
    /// <summary>
    /// cancel all open orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/orders/cancel-multiple-futures-limit-orders"/>  <br/>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/orders/cancel-multiple-futures-stop-orders"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.trigger</term>
    /// <description>
    /// object : When true, all the trigger orders will be cancelled
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>undefined</term> undefined.</returns>
    public async Task<Dictionary<string, object>> CancelAllOrders(string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.cancelAllOrders(symbol, parameters);
        return ((Dictionary<string, object>)res);
    }
    /// <summary>
    /// fetches a list of orders placed on the exchange
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.kucoin.com/futures/#get-order-list"/>  <br/>
    /// See <see href="https://docs.kucoin.com/futures/#get-untriggered-stop-order-list"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest order to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : The maximum number of orders to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : exchange specific parameters
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.trigger</term>
    /// <description>
    /// bool : set to true to retrieve untriggered stop orders
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.until</term>
    /// <description>
    /// int : End time in ms
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.side</term>
    /// <description>
    /// string : buy or sell
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.type</term>
    /// <description>
    /// string : limit or market
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.paginate</term>
    /// <description>
    /// boolean : default false, when true will automatically paginate by calling this endpoint multiple times. See in the docs all the [availble parameters](https://github.com/ccxt/ccxt/wiki/Manual#pagination-params)
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>undefined</term> undefined.</returns>
    public async Task<List<Order>> FetchOrdersByStatus(object status, string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchOrdersByStatus(status, symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetches information on multiple closed orders made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.kucoin.com/futures/#get-order-list"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch orders for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of order structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.till</term>
    /// <description>
    /// int : end time in ms
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.side</term>
    /// <description>
    /// string : buy or sell
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.type</term>
    /// <description>
    /// string : limit, or market
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.paginate</term>
    /// <description>
    /// boolean : default false, when true will automatically paginate by calling this endpoint multiple times. See in the docs all the [availble parameters](https://github.com/ccxt/ccxt/wiki/Manual#pagination-params)
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Order[]</term> a list of [order structures]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<List<Order>> FetchClosedOrders(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchClosedOrders(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Order(item)).ToList<Order>();
    }
    /// <summary>
    /// fetches information on an order made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.kucoin.com/futures/#get-details-of-a-single-order"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> An [order structure]{@link https://docs.ccxt.com/#/?id=order-structure}.</returns>
    public async Task<Order> FetchOrder(string id = null, string symbol = null, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchOrder(id, symbol, parameters);
        return new Order(res);
    }
    /// <summary>
    /// fetch the current funding rate
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/funding-fees/get-current-funding-rate"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [funding rate structure]{@link https://docs.ccxt.com/#/?id=funding-rate-structure}.</returns>
    public async Task<Dictionary<string, object>> FetchFundingRate(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchFundingRate(symbol, parameters);
        return ((Dictionary<string, object>)res);
    }
    /// <summary>
    /// query for balance and get the amount of funds available for trading or funds locked in orders
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/funding/funding-overview/get-account-detail-futures"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [balance structure]{@link https://docs.ccxt.com/#/?id=balance-structure}.</returns>
    public async Task<Balances> FetchBalance(Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchBalance(parameters);
        return new Balances(res);
    }
    /// <summary>
    /// transfer currency internally between wallets on the same account
    /// </summary>
    /// <remarks>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [transfer structure]{@link https://docs.ccxt.com/#/?id=transfer-structure}.</returns>
    public async Task<TransferEntry> Transfer(string code, double amount, string fromAccount, string toAccount, Dictionary<string, object> parameters = null)
    {
        var res = await this.transfer(code, amount, fromAccount, toAccount, parameters);
        return new TransferEntry(res);
    }
    /// <summary>
    /// fetch all trades made by the user
    /// </summary>
    /// <remarks>
    /// See <see href="https://docs.kucoin.com/futures/#get-fills"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch trades for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of trades structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.until</term>
    /// <description>
    /// int : End time in ms
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.paginate</term>
    /// <description>
    /// boolean : default false, when true will automatically paginate by calling this endpoint multiple times. See in the docs all the [availble parameters](https://github.com/ccxt/ccxt/wiki/Manual#pagination-params)
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Trade[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=trade-structure}.</returns>
    public async Task<List<Trade>> FetchMyTrades(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchMyTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// get the list of most recent trades for a particular symbol
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/market-data/get-transaction-history"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : timestamp in ms of the earliest trade to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of trades to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>Trade[]</term> a list of [trade structures]{@link https://docs.ccxt.com/#/?id=public-trades}.</returns>
    public async Task<List<Trade>> FetchTrades(string symbol, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchTrades(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Trade(item)).ToList<Trade>();
    }
    /// <summary>
    /// fetch all deposits made to an account
    /// </summary>
    /// <remarks>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch deposits for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of deposits structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<List<Transaction>> FetchDeposits(string code = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchDeposits(code, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Transaction(item)).ToList<Transaction>();
    }
    /// <summary>
    /// fetch all withdrawals made from an account
    /// </summary>
    /// <remarks>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : the earliest time in ms to fetch withdrawals for
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum number of withdrawals structures to retrieve
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [transaction structures]{@link https://docs.ccxt.com/#/?id=transaction-structure}.</returns>
    public async Task<List<Transaction>> FetchWithdrawals(string code = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchWithdrawals(code, since, limit, parameters);
        return ((IList<object>)res).Select(item => new Transaction(item)).ToList<Transaction>();
    }
    /// <summary>
    /// retrieve information on the maximum leverage, and maintenance margin for trades of varying trade sizes for a single market
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/risk-limit/get-futures-risk-limit-level"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object</term> a [leverage tiers structure]{@link https://docs.ccxt.com/#/?id=leverage-tiers-structure}.</returns>
    public async Task<List<Dictionary<string, object>>> FetchMarketLeverageTiers(string symbol, Dictionary<string, object> parameters = null)
    {
        var res = await this.fetchMarketLeverageTiers(symbol, parameters);
        return ((IList<object>)res).Select(item => (item as Dictionary<string, object>)).ToList();
    }
    /// <summary>
    /// fetches historical funding rate prices
    /// </summary>
    /// <remarks>
    /// See <see href="https://www.kucoin.com/docs/rest/futures-trading/funding-fees/get-public-funding-history#request-url"/>  <br/>
    /// <list type="table">
    /// <item>
    /// <term>since</term>
    /// <description>
    /// int : not used by kucuoinfutures
    /// </description>
    /// </item>
    /// <item>
    /// <term>limit</term>
    /// <description>
    /// int : the maximum amount of [funding rate structures]{@link https://docs.ccxt.com/#/?id=funding-rate-history-structure} to fetch
    /// </description>
    /// </item>
    /// <item>
    /// <term>params</term>
    /// <description>
    /// object : extra parameters specific to the exchange API endpoint
    /// </description>
    /// </item>
    /// <item>
    /// <term>params.until</term>
    /// <description>
    /// int : end time in ms
    /// </description>
    /// </item>
    /// </list>
    /// </remarks>
    /// <returns> <term>object[]</term> a list of [funding rate structures]{@link https://docs.ccxt.com/#/?id=funding-rate-history-structure}.</returns>
    public async Task<List<FundingRateHistory>> FetchFundingRateHistory(string symbol = null, Int64? since2 = 0, Int64? limit2 = 0, Dictionary<string, object> parameters = null)
    {
        var since = since2 == 0 ? null : (object)since2;
        var limit = limit2 == 0 ? null : (object)limit2;
        var res = await this.fetchFundingRateHistory(symbol, since, limit, parameters);
        return ((IList<object>)res).Select(item => new FundingRateHistory(item)).ToList<FundingRateHistory>();
    }
}