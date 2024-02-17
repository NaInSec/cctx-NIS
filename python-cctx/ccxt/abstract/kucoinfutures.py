from ccxt.base.types import Entry


class ImplicitAPI:
    public_get_timestamp = publicGetTimestamp = Entry('timestamp', 'public', 'GET', {'cost': 1})
    public_get_status = publicGetStatus = Entry('status', 'public', 'GET', {'cost': 1})
    public_get_symbols = publicGetSymbols = Entry('symbols', 'public', 'GET', {'cost': 1})
    public_get_markets = publicGetMarkets = Entry('markets', 'public', 'GET', {'cost': 1})
    public_get_market_alltickers = publicGetMarketAllTickers = Entry('market/allTickers', 'public', 'GET', {'cost': 1})
    public_get_market_orderbook_level_level_limit = publicGetMarketOrderbookLevelLevelLimit = Entry('market/orderbook/level{level}_{limit}', 'public', 'GET', {'cost': 1})
    public_get_market_orderbook_level2_20 = publicGetMarketOrderbookLevel220 = Entry('market/orderbook/level2_20', 'public', 'GET', {'cost': 1})
    public_get_market_orderbook_level2_100 = publicGetMarketOrderbookLevel2100 = Entry('market/orderbook/level2_100', 'public', 'GET', {'cost': 1})
    public_get_market_histories = publicGetMarketHistories = Entry('market/histories', 'public', 'GET', {'cost': 1})
    public_get_market_candles = publicGetMarketCandles = Entry('market/candles', 'public', 'GET', {'cost': 1})
    public_get_market_stats = publicGetMarketStats = Entry('market/stats', 'public', 'GET', {'cost': 1})
    public_get_currencies = publicGetCurrencies = Entry('currencies', 'public', 'GET', {'cost': 1})
    public_get_currencies_currency = publicGetCurrenciesCurrency = Entry('currencies/{currency}', 'public', 'GET', {'cost': 1})
    public_get_prices = publicGetPrices = Entry('prices', 'public', 'GET', {'cost': 1})
    public_get_mark_price_symbol_current = publicGetMarkPriceSymbolCurrent = Entry('mark-price/{symbol}/current', 'public', 'GET', {'cost': 1})
    public_get_margin_config = publicGetMarginConfig = Entry('margin/config', 'public', 'GET', {'cost': 1})
    public_get_margin_trade_last = publicGetMarginTradeLast = Entry('margin/trade/last', 'public', 'GET', {'cost': 1})
    public_post_bullet_public = publicPostBulletPublic = Entry('bullet-public', 'public', 'POST', {'cost': 1})
    private_get_market_orderbook_level_level = privateGetMarketOrderbookLevelLevel = Entry('market/orderbook/level{level}', 'private', 'GET', {'cost': 1})
    private_get_market_orderbook_level2 = privateGetMarketOrderbookLevel2 = Entry('market/orderbook/level2', 'private', 'GET', {'v3': 2})
    private_get_market_orderbook_level3 = privateGetMarketOrderbookLevel3 = Entry('market/orderbook/level3', 'private', 'GET', {'cost': 1})
    private_get_accounts = privateGetAccounts = Entry('accounts', 'private', 'GET', {'cost': 1})
    private_get_accounts_accountid = privateGetAccountsAccountId = Entry('accounts/{accountId}', 'private', 'GET', {'cost': 1})
    private_get_accounts_ledgers = privateGetAccountsLedgers = Entry('accounts/ledgers', 'private', 'GET', {'cost': 3.333})
    private_get_accounts_accountid_holds = privateGetAccountsAccountIdHolds = Entry('accounts/{accountId}/holds', 'private', 'GET', {'cost': 1})
    private_get_accounts_transferable = privateGetAccountsTransferable = Entry('accounts/transferable', 'private', 'GET', {'cost': 1})
    private_get_base_fee = privateGetBaseFee = Entry('base-fee', 'private', 'GET', {'cost': 1})
    private_get_sub_user = privateGetSubUser = Entry('sub/user', 'private', 'GET', {'cost': 1})
    private_get_user_info = privateGetUserInfo = Entry('user-info', 'private', 'GET', {'cost': 1})
    private_get_sub_api_key = privateGetSubApiKey = Entry('sub/api-key', 'private', 'GET', {'cost': 1})
    private_get_sub_accounts = privateGetSubAccounts = Entry('sub-accounts', 'private', 'GET', {'cost': 1})
    private_get_sub_accounts_subuserid = privateGetSubAccountsSubUserId = Entry('sub-accounts/{subUserId}', 'private', 'GET', {'cost': 1})
    private_get_deposit_addresses = privateGetDepositAddresses = Entry('deposit-addresses', 'private', 'GET', {'cost': 1})
    private_get_deposits = privateGetDeposits = Entry('deposits', 'private', 'GET', {'cost': 10})
    private_get_hist_deposits = privateGetHistDeposits = Entry('hist-deposits', 'private', 'GET', {'cost': 10})
    private_get_hist_withdrawals = privateGetHistWithdrawals = Entry('hist-withdrawals', 'private', 'GET', {'cost': 10})
    private_get_withdrawals = privateGetWithdrawals = Entry('withdrawals', 'private', 'GET', {'cost': 10})
    private_get_withdrawals_quotas = privateGetWithdrawalsQuotas = Entry('withdrawals/quotas', 'private', 'GET', {'cost': 1})
    private_get_orders = privateGetOrders = Entry('orders', 'private', 'GET', {'cost': 2})
    private_get_order_client_order_clientoid = privateGetOrderClientOrderClientOid = Entry('order/client-order/{clientOid}', 'private', 'GET', {'cost': 1})
    private_get_orders_orderid = privateGetOrdersOrderId = Entry('orders/{orderId}', 'private', 'GET', {'cost': 1})
    private_get_limit_orders = privateGetLimitOrders = Entry('limit/orders', 'private', 'GET', {'cost': 1})
    private_get_fills = privateGetFills = Entry('fills', 'private', 'GET', {'cost': 6.66667})
    private_get_limit_fills = privateGetLimitFills = Entry('limit/fills', 'private', 'GET', {'cost': 1})
    private_get_isolated_accounts = privateGetIsolatedAccounts = Entry('isolated/accounts', 'private', 'GET', {'cost': 2})
    private_get_isolated_account_symbol = privateGetIsolatedAccountSymbol = Entry('isolated/account/{symbol}', 'private', 'GET', {'cost': 2})
    private_get_isolated_borrow_outstanding = privateGetIsolatedBorrowOutstanding = Entry('isolated/borrow/outstanding', 'private', 'GET', {'cost': 2})
    private_get_isolated_borrow_repaid = privateGetIsolatedBorrowRepaid = Entry('isolated/borrow/repaid', 'private', 'GET', {'cost': 2})
    private_get_isolated_symbols = privateGetIsolatedSymbols = Entry('isolated/symbols', 'private', 'GET', {'cost': 2})
    private_get_margin_account = privateGetMarginAccount = Entry('margin/account', 'private', 'GET', {'cost': 1})
    private_get_margin_borrow = privateGetMarginBorrow = Entry('margin/borrow', 'private', 'GET', {'cost': 1})
    private_get_margin_borrow_outstanding = privateGetMarginBorrowOutstanding = Entry('margin/borrow/outstanding', 'private', 'GET', {'cost': 1})
    private_get_margin_borrow_repaid = privateGetMarginBorrowRepaid = Entry('margin/borrow/repaid', 'private', 'GET', {'cost': 1})
    private_get_margin_lend_active = privateGetMarginLendActive = Entry('margin/lend/active', 'private', 'GET', {'cost': 1})
    private_get_margin_lend_done = privateGetMarginLendDone = Entry('margin/lend/done', 'private', 'GET', {'cost': 1})
    private_get_margin_lend_trade_unsettled = privateGetMarginLendTradeUnsettled = Entry('margin/lend/trade/unsettled', 'private', 'GET', {'cost': 1})
    private_get_margin_lend_trade_settled = privateGetMarginLendTradeSettled = Entry('margin/lend/trade/settled', 'private', 'GET', {'cost': 1})
    private_get_margin_lend_assets = privateGetMarginLendAssets = Entry('margin/lend/assets', 'private', 'GET', {'cost': 1})
    private_get_margin_market = privateGetMarginMarket = Entry('margin/market', 'private', 'GET', {'cost': 1})
    private_get_stop_order_orderid = privateGetStopOrderOrderId = Entry('stop-order/{orderId}', 'private', 'GET', {'cost': 1})
    private_get_stop_order = privateGetStopOrder = Entry('stop-order', 'private', 'GET', {'cost': 1})
    private_get_stop_order_queryorderbyclientoid = privateGetStopOrderQueryOrderByClientOid = Entry('stop-order/queryOrderByClientOid', 'private', 'GET', {'cost': 1})
    private_get_trade_fees = privateGetTradeFees = Entry('trade-fees', 'private', 'GET', {'cost': 1.3333})
    private_get_hf_accounts_ledgers = privateGetHfAccountsLedgers = Entry('hf/accounts/ledgers', 'private', 'GET', {'cost': 3.33})
    private_get_hf_orders_active = privateGetHfOrdersActive = Entry('hf/orders/active', 'private', 'GET', {'cost': 2})
    private_get_hf_orders_active_symbols = privateGetHfOrdersActiveSymbols = Entry('hf/orders/active/symbols', 'private', 'GET', {'cost': 20})
    private_get_hf_orders_done = privateGetHfOrdersDone = Entry('hf/orders/done', 'private', 'GET', {'cost': 2})
    private_get_hf_orders_orderid = privateGetHfOrdersOrderId = Entry('hf/orders/{orderId}', 'private', 'GET', {'cost': 1})
    private_get_hf_orders_client_order_clientoid = privateGetHfOrdersClientOrderClientOid = Entry('hf/orders/client-order/{clientOid}', 'private', 'GET', {'cost': 2})
    private_get_hf_fills = privateGetHfFills = Entry('hf/fills', 'private', 'GET', {'cost': 6.67})
    private_post_accounts = privatePostAccounts = Entry('accounts', 'private', 'POST', {'cost': 1})
    private_post_accounts_inner_transfer = privatePostAccountsInnerTransfer = Entry('accounts/inner-transfer', 'private', 'POST', {'v2': 1})
    private_post_accounts_sub_transfer = privatePostAccountsSubTransfer = Entry('accounts/sub-transfer', 'private', 'POST', {'v2': 25})
    private_post_deposit_addresses = privatePostDepositAddresses = Entry('deposit-addresses', 'private', 'POST', {'cost': 1})
    private_post_withdrawals = privatePostWithdrawals = Entry('withdrawals', 'private', 'POST', {'cost': 1})
    private_post_orders = privatePostOrders = Entry('orders', 'private', 'POST', {'cost': 4})
    private_post_orders_multi = privatePostOrdersMulti = Entry('orders/multi', 'private', 'POST', {'cost': 20})
    private_post_isolated_borrow = privatePostIsolatedBorrow = Entry('isolated/borrow', 'private', 'POST', {'cost': 2})
    private_post_isolated_repay_all = privatePostIsolatedRepayAll = Entry('isolated/repay/all', 'private', 'POST', {'cost': 2})
    private_post_isolated_repay_single = privatePostIsolatedRepaySingle = Entry('isolated/repay/single', 'private', 'POST', {'cost': 2})
    private_post_margin_borrow = privatePostMarginBorrow = Entry('margin/borrow', 'private', 'POST', {'cost': 1})
    private_post_margin_order = privatePostMarginOrder = Entry('margin/order', 'private', 'POST', {'cost': 1})
    private_post_margin_repay_all = privatePostMarginRepayAll = Entry('margin/repay/all', 'private', 'POST', {'cost': 1})
    private_post_margin_repay_single = privatePostMarginRepaySingle = Entry('margin/repay/single', 'private', 'POST', {'cost': 1})
    private_post_margin_lend = privatePostMarginLend = Entry('margin/lend', 'private', 'POST', {'cost': 1})
    private_post_margin_toggle_auto_lend = privatePostMarginToggleAutoLend = Entry('margin/toggle-auto-lend', 'private', 'POST', {'cost': 1})
    private_post_bullet_private = privatePostBulletPrivate = Entry('bullet-private', 'private', 'POST', {'cost': 1})
    private_post_stop_order = privatePostStopOrder = Entry('stop-order', 'private', 'POST', {'cost': 1})
    private_post_sub_user = privatePostSubUser = Entry('sub/user', 'private', 'POST', {'cost': 1})
    private_post_sub_api_key = privatePostSubApiKey = Entry('sub/api-key', 'private', 'POST', {'cost': 1})
    private_post_sub_api_key_update = privatePostSubApiKeyUpdate = Entry('sub/api-key/update', 'private', 'POST', {'cost': 1})
    private_post_hf_orders = privatePostHfOrders = Entry('hf/orders', 'private', 'POST', {'cost': 0.4})
    private_post_hf_orders_sync = privatePostHfOrdersSync = Entry('hf/orders/sync', 'private', 'POST', {'cost': 1.33})
    private_post_hf_orders_multi = privatePostHfOrdersMulti = Entry('hf/orders/multi', 'private', 'POST', {'cost': 20})
    private_post_hf_orders_multi_sync = privatePostHfOrdersMultiSync = Entry('hf/orders/multi/sync', 'private', 'POST', {'cost': 20})
    private_post_hf_orders_alter = privatePostHfOrdersAlter = Entry('hf/orders/alter', 'private', 'POST', {'cost': 1})
    private_delete_withdrawals_withdrawalid = privateDeleteWithdrawalsWithdrawalId = Entry('withdrawals/{withdrawalId}', 'private', 'DELETE', {'cost': 1})
    private_delete_orders = privateDeleteOrders = Entry('orders', 'private', 'DELETE', {'cost': 20})
    private_delete_order_client_order_clientoid = privateDeleteOrderClientOrderClientOid = Entry('order/client-order/{clientOid}', 'private', 'DELETE', {'cost': 1})
    private_delete_orders_orderid = privateDeleteOrdersOrderId = Entry('orders/{orderId}', 'private', 'DELETE', {'cost': 1})
    private_delete_margin_lend_orderid = privateDeleteMarginLendOrderId = Entry('margin/lend/{orderId}', 'private', 'DELETE', {'cost': 1})
    private_delete_stop_order_cancelorderbyclientoid = privateDeleteStopOrderCancelOrderByClientOid = Entry('stop-order/cancelOrderByClientOid', 'private', 'DELETE', {'cost': 1})
    private_delete_stop_order_orderid = privateDeleteStopOrderOrderId = Entry('stop-order/{orderId}', 'private', 'DELETE', {'cost': 1})
    private_delete_stop_order_cancel = privateDeleteStopOrderCancel = Entry('stop-order/cancel', 'private', 'DELETE', {'cost': 1})
    private_delete_sub_api_key = privateDeleteSubApiKey = Entry('sub/api-key', 'private', 'DELETE', {'cost': 1})
    private_delete_hf_orders_orderid = privateDeleteHfOrdersOrderId = Entry('hf/orders/{orderId}', 'private', 'DELETE', {'cost': 0.4})
    private_delete_hf_orders_sync_orderid = privateDeleteHfOrdersSyncOrderId = Entry('hf/orders/sync/{orderId}', 'private', 'DELETE', {'cost': 0.4})
    private_delete_hf_orders_client_order_clientoid = privateDeleteHfOrdersClientOrderClientOid = Entry('hf/orders/client-order/{clientOid}', 'private', 'DELETE', {'cost': 0.4})
    private_delete_hf_orders_sync_client_order_clientoid = privateDeleteHfOrdersSyncClientOrderClientOid = Entry('hf/orders/sync/client-order/{clientOid}', 'private', 'DELETE', {'cost': 0.4})
    private_delete_hf_orders_cancel_orderid = privateDeleteHfOrdersCancelOrderId = Entry('hf/orders/cancel/{orderId}', 'private', 'DELETE', {'cost': 1})
    private_delete_hf_orders = privateDeleteHfOrders = Entry('hf/orders', 'private', 'DELETE', {'cost': 20})
    futurespublic_get_contracts_active = futuresPublicGetContractsActive = Entry('contracts/active', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_contracts_symbol = futuresPublicGetContractsSymbol = Entry('contracts/{symbol}', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_ticker = futuresPublicGetTicker = Entry('ticker', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_level2_snapshot = futuresPublicGetLevel2Snapshot = Entry('level2/snapshot', 'futuresPublic', 'GET', {'cost': 1.33})
    futurespublic_get_level2_depth20 = futuresPublicGetLevel2Depth20 = Entry('level2/depth20', 'futuresPublic', 'GET', {'cost': 1.3953})
    futurespublic_get_level2_depth100 = futuresPublicGetLevel2Depth100 = Entry('level2/depth100', 'futuresPublic', 'GET', {'cost': 1.3953})
    futurespublic_get_level2_message_query = futuresPublicGetLevel2MessageQuery = Entry('level2/message/query', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_level3_message_query = futuresPublicGetLevel3MessageQuery = Entry('level3/message/query', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_level3_snapshot = futuresPublicGetLevel3Snapshot = Entry('level3/snapshot', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_trade_history = futuresPublicGetTradeHistory = Entry('trade/history', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_interest_query = futuresPublicGetInterestQuery = Entry('interest/query', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_index_query = futuresPublicGetIndexQuery = Entry('index/query', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_mark_price_symbol_current = futuresPublicGetMarkPriceSymbolCurrent = Entry('mark-price/{symbol}/current', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_premium_query = futuresPublicGetPremiumQuery = Entry('premium/query', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_funding_rate_symbol_current = futuresPublicGetFundingRateSymbolCurrent = Entry('funding-rate/{symbol}/current', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_timestamp = futuresPublicGetTimestamp = Entry('timestamp', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_status = futuresPublicGetStatus = Entry('status', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_kline_query = futuresPublicGetKlineQuery = Entry('kline/query', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_contracts_risk_limit_symbol = futuresPublicGetContractsRiskLimitSymbol = Entry('contracts/risk-limit/{symbol}', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_get_level2_depth_limit = futuresPublicGetLevel2DepthLimit = Entry('level2/depth{limit}', 'futuresPublic', 'GET', {'cost': 1})
    futurespublic_post_bullet_public = futuresPublicPostBulletPublic = Entry('bullet-public', 'futuresPublic', 'POST', {'cost': 1})
    futuresprivate_get_account_overview = futuresPrivateGetAccountOverview = Entry('account-overview', 'futuresPrivate', 'GET', {'cost': 1.33})
    futuresprivate_get_transaction_history = futuresPrivateGetTransactionHistory = Entry('transaction-history', 'futuresPrivate', 'GET', {'cost': 4.44})
    futuresprivate_get_deposit_address = futuresPrivateGetDepositAddress = Entry('deposit-address', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_deposit_list = futuresPrivateGetDepositList = Entry('deposit-list', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_withdrawals_quotas = futuresPrivateGetWithdrawalsQuotas = Entry('withdrawals/quotas', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_withdrawal_list = futuresPrivateGetWithdrawalList = Entry('withdrawal-list', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_transfer_list = futuresPrivateGetTransferList = Entry('transfer-list', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_orders = futuresPrivateGetOrders = Entry('orders', 'futuresPrivate', 'GET', {'cost': 1.33})
    futuresprivate_get_stoporders = futuresPrivateGetStopOrders = Entry('stopOrders', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_recentdoneorders = futuresPrivateGetRecentDoneOrders = Entry('recentDoneOrders', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_orders_orderid = futuresPrivateGetOrdersOrderId = Entry('orders/{orderId}', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_orders_byclientoid = futuresPrivateGetOrdersByClientOid = Entry('orders/byClientOid', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_fills = futuresPrivateGetFills = Entry('fills', 'futuresPrivate', 'GET', {'cost': 4.44})
    futuresprivate_get_recentfills = futuresPrivateGetRecentFills = Entry('recentFills', 'futuresPrivate', 'GET', {'cost': 4.44})
    futuresprivate_get_openorderstatistics = futuresPrivateGetOpenOrderStatistics = Entry('openOrderStatistics', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_position = futuresPrivateGetPosition = Entry('position', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_get_positions = futuresPrivateGetPositions = Entry('positions', 'futuresPrivate', 'GET', {'cost': 4.44})
    futuresprivate_get_funding_history = futuresPrivateGetFundingHistory = Entry('funding-history', 'futuresPrivate', 'GET', {'cost': 4.44})
    futuresprivate_get_sub_api_key = futuresPrivateGetSubApiKey = Entry('sub/api-key', 'futuresPrivate', 'GET', {'cost': 1})
    futuresprivate_post_withdrawals = futuresPrivatePostWithdrawals = Entry('withdrawals', 'futuresPrivate', 'POST', {'cost': 1})
    futuresprivate_post_transfer_out = futuresPrivatePostTransferOut = Entry('transfer-out', 'futuresPrivate', 'POST', {'cost': 1})
    futuresprivate_post_orders = futuresPrivatePostOrders = Entry('orders', 'futuresPrivate', 'POST', {'cost': 1.33})
    futuresprivate_post_position_margin_auto_deposit_status = futuresPrivatePostPositionMarginAutoDepositStatus = Entry('position/margin/auto-deposit-status', 'futuresPrivate', 'POST', {'cost': 1})
    futuresprivate_post_position_margin_deposit_margin = futuresPrivatePostPositionMarginDepositMargin = Entry('position/margin/deposit-margin', 'futuresPrivate', 'POST', {'cost': 1})
    futuresprivate_post_bullet_private = futuresPrivatePostBulletPrivate = Entry('bullet-private', 'futuresPrivate', 'POST', {'cost': 1})
    futuresprivate_post_transfer_in = futuresPrivatePostTransferIn = Entry('transfer-in', 'futuresPrivate', 'POST', {'cost': 1})
    futuresprivate_post_position_risk_limit_level_change = futuresPrivatePostPositionRiskLimitLevelChange = Entry('position/risk-limit-level/change', 'futuresPrivate', 'POST', {'cost': 1})
    futuresprivate_post_sub_api_key = futuresPrivatePostSubApiKey = Entry('sub/api-key', 'futuresPrivate', 'POST', {'cost': 1})
    futuresprivate_post_sub_api_key_update = futuresPrivatePostSubApiKeyUpdate = Entry('sub/api-key/update', 'futuresPrivate', 'POST', {'cost': 1})
    futuresprivate_delete_withdrawals_withdrawalid = futuresPrivateDeleteWithdrawalsWithdrawalId = Entry('withdrawals/{withdrawalId}', 'futuresPrivate', 'DELETE', {'cost': 1})
    futuresprivate_delete_cancel_transfer_out = futuresPrivateDeleteCancelTransferOut = Entry('cancel/transfer-out', 'futuresPrivate', 'DELETE', {'cost': 1})
    futuresprivate_delete_orders_orderid = futuresPrivateDeleteOrdersOrderId = Entry('orders/{orderId}', 'futuresPrivate', 'DELETE', {'cost': 1})
    futuresprivate_delete_orders = futuresPrivateDeleteOrders = Entry('orders', 'futuresPrivate', 'DELETE', {'cost': 4.44})
    futuresprivate_delete_stoporders = futuresPrivateDeleteStopOrders = Entry('stopOrders', 'futuresPrivate', 'DELETE', {'cost': 1})
    futuresprivate_delete_sub_api_key = futuresPrivateDeleteSubApiKey = Entry('sub/api-key', 'futuresPrivate', 'DELETE', {'cost': 1})
    webfront_get_contract_symbol_funding_rates = webFrontGetContractSymbolFundingRates = Entry('contract/{symbol}/funding-rates', 'webFront', 'GET', {'cost': 1})