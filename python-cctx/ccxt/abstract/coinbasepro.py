from ccxt.base.types import Entry


class ImplicitAPI:
    public_get_currencies = publicGetCurrencies = Entry('currencies', 'public', 'GET', {})
    public_get_products = publicGetProducts = Entry('products', 'public', 'GET', {})
    public_get_products_id = publicGetProductsId = Entry('products/{id}', 'public', 'GET', {})
    public_get_products_id_book = publicGetProductsIdBook = Entry('products/{id}/book', 'public', 'GET', {})
    public_get_products_id_candles = publicGetProductsIdCandles = Entry('products/{id}/candles', 'public', 'GET', {})
    public_get_products_id_stats = publicGetProductsIdStats = Entry('products/{id}/stats', 'public', 'GET', {})
    public_get_products_id_ticker = publicGetProductsIdTicker = Entry('products/{id}/ticker', 'public', 'GET', {})
    public_get_products_id_trades = publicGetProductsIdTrades = Entry('products/{id}/trades', 'public', 'GET', {})
    public_get_time = publicGetTime = Entry('time', 'public', 'GET', {})
    public_get_products_spark_lines = publicGetProductsSparkLines = Entry('products/spark-lines', 'public', 'GET', {})
    private_get_accounts = privateGetAccounts = Entry('accounts', 'private', 'GET', {})
    private_get_accounts_id = privateGetAccountsId = Entry('accounts/{id}', 'private', 'GET', {})
    private_get_accounts_id_holds = privateGetAccountsIdHolds = Entry('accounts/{id}/holds', 'private', 'GET', {})
    private_get_accounts_id_ledger = privateGetAccountsIdLedger = Entry('accounts/{id}/ledger', 'private', 'GET', {})
    private_get_accounts_id_transfers = privateGetAccountsIdTransfers = Entry('accounts/{id}/transfers', 'private', 'GET', {})
    private_get_coinbase_accounts = privateGetCoinbaseAccounts = Entry('coinbase-accounts', 'private', 'GET', {})
    private_get_fills = privateGetFills = Entry('fills', 'private', 'GET', {})
    private_get_funding = privateGetFunding = Entry('funding', 'private', 'GET', {})
    private_get_fees = privateGetFees = Entry('fees', 'private', 'GET', {})
    private_get_margin_profile_information = privateGetMarginProfileInformation = Entry('margin/profile_information', 'private', 'GET', {})
    private_get_margin_buying_power = privateGetMarginBuyingPower = Entry('margin/buying_power', 'private', 'GET', {})
    private_get_margin_withdrawal_power = privateGetMarginWithdrawalPower = Entry('margin/withdrawal_power', 'private', 'GET', {})
    private_get_margin_withdrawal_power_all = privateGetMarginWithdrawalPowerAll = Entry('margin/withdrawal_power_all', 'private', 'GET', {})
    private_get_margin_exit_plan = privateGetMarginExitPlan = Entry('margin/exit_plan', 'private', 'GET', {})
    private_get_margin_liquidation_history = privateGetMarginLiquidationHistory = Entry('margin/liquidation_history', 'private', 'GET', {})
    private_get_margin_position_refresh_amounts = privateGetMarginPositionRefreshAmounts = Entry('margin/position_refresh_amounts', 'private', 'GET', {})
    private_get_margin_status = privateGetMarginStatus = Entry('margin/status', 'private', 'GET', {})
    private_get_oracle = privateGetOracle = Entry('oracle', 'private', 'GET', {})
    private_get_orders = privateGetOrders = Entry('orders', 'private', 'GET', {})
    private_get_orders_id = privateGetOrdersId = Entry('orders/{id}', 'private', 'GET', {})
    private_get_orders_client_client_oid = privateGetOrdersClientClientOid = Entry('orders/client:{client_oid}', 'private', 'GET', {})
    private_get_otc_orders = privateGetOtcOrders = Entry('otc/orders', 'private', 'GET', {})
    private_get_payment_methods = privateGetPaymentMethods = Entry('payment-methods', 'private', 'GET', {})
    private_get_position = privateGetPosition = Entry('position', 'private', 'GET', {})
    private_get_profiles = privateGetProfiles = Entry('profiles', 'private', 'GET', {})
    private_get_profiles_id = privateGetProfilesId = Entry('profiles/{id}', 'private', 'GET', {})
    private_get_reports_report_id = privateGetReportsReportId = Entry('reports/{report_id}', 'private', 'GET', {})
    private_get_transfers = privateGetTransfers = Entry('transfers', 'private', 'GET', {})
    private_get_transfers_transfer_id = privateGetTransfersTransferId = Entry('transfers/{transfer_id}', 'private', 'GET', {})
    private_get_users_self_exchange_limits = privateGetUsersSelfExchangeLimits = Entry('users/self/exchange-limits', 'private', 'GET', {})
    private_get_users_self_hold_balances = privateGetUsersSelfHoldBalances = Entry('users/self/hold-balances', 'private', 'GET', {})
    private_get_users_self_trailing_volume = privateGetUsersSelfTrailingVolume = Entry('users/self/trailing-volume', 'private', 'GET', {})
    private_get_withdrawals_fee_estimate = privateGetWithdrawalsFeeEstimate = Entry('withdrawals/fee-estimate', 'private', 'GET', {})
    private_get_conversions_conversion_id = privateGetConversionsConversionId = Entry('conversions/{conversion_id}', 'private', 'GET', {})
    private_post_conversions = privatePostConversions = Entry('conversions', 'private', 'POST', {})
    private_post_deposits_coinbase_account = privatePostDepositsCoinbaseAccount = Entry('deposits/coinbase-account', 'private', 'POST', {})
    private_post_deposits_payment_method = privatePostDepositsPaymentMethod = Entry('deposits/payment-method', 'private', 'POST', {})
    private_post_coinbase_accounts_id_addresses = privatePostCoinbaseAccountsIdAddresses = Entry('coinbase-accounts/{id}/addresses', 'private', 'POST', {})
    private_post_funding_repay = privatePostFundingRepay = Entry('funding/repay', 'private', 'POST', {})
    private_post_orders = privatePostOrders = Entry('orders', 'private', 'POST', {})
    private_post_position_close = privatePostPositionClose = Entry('position/close', 'private', 'POST', {})
    private_post_profiles_margin_transfer = privatePostProfilesMarginTransfer = Entry('profiles/margin-transfer', 'private', 'POST', {})
    private_post_profiles_transfer = privatePostProfilesTransfer = Entry('profiles/transfer', 'private', 'POST', {})
    private_post_reports = privatePostReports = Entry('reports', 'private', 'POST', {})
    private_post_withdrawals_coinbase = privatePostWithdrawalsCoinbase = Entry('withdrawals/coinbase', 'private', 'POST', {})
    private_post_withdrawals_coinbase_account = privatePostWithdrawalsCoinbaseAccount = Entry('withdrawals/coinbase-account', 'private', 'POST', {})
    private_post_withdrawals_crypto = privatePostWithdrawalsCrypto = Entry('withdrawals/crypto', 'private', 'POST', {})
    private_post_withdrawals_payment_method = privatePostWithdrawalsPaymentMethod = Entry('withdrawals/payment-method', 'private', 'POST', {})
    private_delete_orders = privateDeleteOrders = Entry('orders', 'private', 'DELETE', {})
    private_delete_orders_client_client_oid = privateDeleteOrdersClientClientOid = Entry('orders/client:{client_oid}', 'private', 'DELETE', {})
    private_delete_orders_id = privateDeleteOrdersId = Entry('orders/{id}', 'private', 'DELETE', {})
