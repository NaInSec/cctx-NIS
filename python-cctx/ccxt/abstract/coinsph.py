from ccxt.base.types import Entry


class ImplicitAPI:
    public_get_openapi_v1_ping = publicGetOpenapiV1Ping = Entry('openapi/v1/ping', 'public', 'GET', {'cost': 1})
    public_get_openapi_v1_time = publicGetOpenapiV1Time = Entry('openapi/v1/time', 'public', 'GET', {'cost': 1})
    public_get_openapi_quote_v1_ticker_24hr = publicGetOpenapiQuoteV1Ticker24hr = Entry('openapi/quote/v1/ticker/24hr', 'public', 'GET', {'cost': 1, 'noSymbolAndNoSymbols': 40, 'byNumberOfSymbols': [[101, 40], [21, 20], [0, 1]]})
    public_get_openapi_quote_v1_ticker_price = publicGetOpenapiQuoteV1TickerPrice = Entry('openapi/quote/v1/ticker/price', 'public', 'GET', {'cost': 1, 'noSymbol': 2})
    public_get_openapi_quote_v1_ticker_bookticker = publicGetOpenapiQuoteV1TickerBookTicker = Entry('openapi/quote/v1/ticker/bookTicker', 'public', 'GET', {'cost': 1, 'noSymbol': 2})
    public_get_openapi_v1_exchangeinfo = publicGetOpenapiV1ExchangeInfo = Entry('openapi/v1/exchangeInfo', 'public', 'GET', {'cost': 10})
    public_get_openapi_quote_v1_depth = publicGetOpenapiQuoteV1Depth = Entry('openapi/quote/v1/depth', 'public', 'GET', {'cost': 1, 'byLimit': [[101, 5], [0, 1]]})
    public_get_openapi_quote_v1_klines = publicGetOpenapiQuoteV1Klines = Entry('openapi/quote/v1/klines', 'public', 'GET', {'cost': 1})
    public_get_openapi_quote_v1_trades = publicGetOpenapiQuoteV1Trades = Entry('openapi/quote/v1/trades', 'public', 'GET', {'cost': 1})
    public_get_openapi_v1_pairs = publicGetOpenapiV1Pairs = Entry('openapi/v1/pairs', 'public', 'GET', {'cost': 1})
    public_get_openapi_quote_v1_avgprice = publicGetOpenapiQuoteV1AvgPrice = Entry('openapi/quote/v1/avgPrice', 'public', 'GET', {'cost': 1})
    private_get_openapi_v1_account = privateGetOpenapiV1Account = Entry('openapi/v1/account', 'private', 'GET', {'cost': 10})
    private_get_openapi_v1_openorders = privateGetOpenapiV1OpenOrders = Entry('openapi/v1/openOrders', 'private', 'GET', {'cost': 3, 'noSymbol': 40})
    private_get_openapi_v1_asset_tradefee = privateGetOpenapiV1AssetTradeFee = Entry('openapi/v1/asset/tradeFee', 'private', 'GET', {'cost': 1})
    private_get_openapi_v1_order = privateGetOpenapiV1Order = Entry('openapi/v1/order', 'private', 'GET', {'cost': 2})
    private_get_openapi_v1_historyorders = privateGetOpenapiV1HistoryOrders = Entry('openapi/v1/historyOrders', 'private', 'GET', {'cost': 10, 'noSymbol': 40})
    private_get_openapi_v1_mytrades = privateGetOpenapiV1MyTrades = Entry('openapi/v1/myTrades', 'private', 'GET', {'cost': 10})
    private_get_openapi_v1_capital_deposit_history = privateGetOpenapiV1CapitalDepositHistory = Entry('openapi/v1/capital/deposit/history', 'private', 'GET', {'cost': 1})
    private_get_openapi_v1_capital_withdraw_history = privateGetOpenapiV1CapitalWithdrawHistory = Entry('openapi/v1/capital/withdraw/history', 'private', 'GET', {'cost': 1})
    private_post_openapi_v1_order_test = privatePostOpenapiV1OrderTest = Entry('openapi/v1/order/test', 'private', 'POST', {'cost': 1})
    private_post_openapi_v1_order = privatePostOpenapiV1Order = Entry('openapi/v1/order', 'private', 'POST', {'cost': 1})
    private_post_openapi_v1_capital_withdraw_apply = privatePostOpenapiV1CapitalWithdrawApply = Entry('openapi/v1/capital/withdraw/apply', 'private', 'POST', {'cost': 1})
    private_post_openapi_v1_capital_deposit_apply = privatePostOpenapiV1CapitalDepositApply = Entry('openapi/v1/capital/deposit/apply', 'private', 'POST', {'cost': 1})
    private_delete_openapi_v1_order = privateDeleteOpenapiV1Order = Entry('openapi/v1/order', 'private', 'DELETE', {'cost': 1})
    private_delete_openapi_v1_openorders = privateDeleteOpenapiV1OpenOrders = Entry('openapi/v1/openOrders', 'private', 'DELETE', {'cost': 1})