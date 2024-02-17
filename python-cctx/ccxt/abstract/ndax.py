from ccxt.base.types import Entry


class ImplicitAPI:
    public_get_activate2fa = publicGetActivate2FA = Entry('Activate2FA', 'public', 'GET', {'cost': 1})
    public_get_authenticate2fa = publicGetAuthenticate2FA = Entry('Authenticate2FA', 'public', 'GET', {'cost': 1})
    public_get_authenticateuser = publicGetAuthenticateUser = Entry('AuthenticateUser', 'public', 'GET', {'cost': 1})
    public_get_getl2snapshot = publicGetGetL2Snapshot = Entry('GetL2Snapshot', 'public', 'GET', {'cost': 1})
    public_get_getlevel1 = publicGetGetLevel1 = Entry('GetLevel1', 'public', 'GET', {'cost': 1})
    public_get_getvalidate2farequiredendpoints = publicGetGetValidate2FARequiredEndpoints = Entry('GetValidate2FARequiredEndpoints', 'public', 'GET', {'cost': 1})
    public_get_logout = publicGetLogOut = Entry('LogOut', 'public', 'GET', {'cost': 1})
    public_get_gettickerhistory = publicGetGetTickerHistory = Entry('GetTickerHistory', 'public', 'GET', {'cost': 1})
    public_get_getproduct = publicGetGetProduct = Entry('GetProduct', 'public', 'GET', {'cost': 1})
    public_get_getproducts = publicGetGetProducts = Entry('GetProducts', 'public', 'GET', {'cost': 1})
    public_get_getinstrument = publicGetGetInstrument = Entry('GetInstrument', 'public', 'GET', {'cost': 1})
    public_get_getinstruments = publicGetGetInstruments = Entry('GetInstruments', 'public', 'GET', {'cost': 1})
    public_get_ping = publicGetPing = Entry('Ping', 'public', 'GET', {'cost': 1})
    public_get_trades = publicGetTrades = Entry('trades', 'public', 'GET', {'cost': 1})
    public_get_getlasttrades = publicGetGetLastTrades = Entry('GetLastTrades', 'public', 'GET', {'cost': 1})
    public_get_subscribelevel1 = publicGetSubscribeLevel1 = Entry('SubscribeLevel1', 'public', 'GET', {'cost': 1})
    public_get_subscribelevel2 = publicGetSubscribeLevel2 = Entry('SubscribeLevel2', 'public', 'GET', {'cost': 1})
    public_get_subscribeticker = publicGetSubscribeTicker = Entry('SubscribeTicker', 'public', 'GET', {'cost': 1})
    public_get_subscribetrades = publicGetSubscribeTrades = Entry('SubscribeTrades', 'public', 'GET', {'cost': 1})
    public_get_subscribeblocktrades = publicGetSubscribeBlockTrades = Entry('SubscribeBlockTrades', 'public', 'GET', {'cost': 1})
    public_get_unsubscribeblocktrades = publicGetUnsubscribeBlockTrades = Entry('UnsubscribeBlockTrades', 'public', 'GET', {'cost': 1})
    public_get_unsubscribelevel1 = publicGetUnsubscribeLevel1 = Entry('UnsubscribeLevel1', 'public', 'GET', {'cost': 1})
    public_get_unsubscribelevel2 = publicGetUnsubscribeLevel2 = Entry('UnsubscribeLevel2', 'public', 'GET', {'cost': 1})
    public_get_unsubscribeticker = publicGetUnsubscribeTicker = Entry('UnsubscribeTicker', 'public', 'GET', {'cost': 1})
    public_get_unsubscribetrades = publicGetUnsubscribeTrades = Entry('UnsubscribeTrades', 'public', 'GET', {'cost': 1})
    public_get_authenticate = publicGetAuthenticate = Entry('Authenticate', 'public', 'GET', {'cost': 1})
    private_get_getuseraccountinfos = privateGetGetUserAccountInfos = Entry('GetUserAccountInfos', 'private', 'GET', {'cost': 1})
    private_get_getuseraccounts = privateGetGetUserAccounts = Entry('GetUserAccounts', 'private', 'GET', {'cost': 1})
    private_get_getuseraffiliatecount = privateGetGetUserAffiliateCount = Entry('GetUserAffiliateCount', 'private', 'GET', {'cost': 1})
    private_get_getuseraffiliatetag = privateGetGetUserAffiliateTag = Entry('GetUserAffiliateTag', 'private', 'GET', {'cost': 1})
    private_get_getuserconfig = privateGetGetUserConfig = Entry('GetUserConfig', 'private', 'GET', {'cost': 1})
    private_get_getallunredacteduserconfigsforuser = privateGetGetAllUnredactedUserConfigsForUser = Entry('GetAllUnredactedUserConfigsForUser', 'private', 'GET', {'cost': 1})
    private_get_getunredacteduserconfigbykey = privateGetGetUnredactedUserConfigByKey = Entry('GetUnredactedUserConfigByKey', 'private', 'GET', {'cost': 1})
    private_get_getuserdevices = privateGetGetUserDevices = Entry('GetUserDevices', 'private', 'GET', {'cost': 1})
    private_get_getuserreporttickets = privateGetGetUserReportTickets = Entry('GetUserReportTickets', 'private', 'GET', {'cost': 1})
    private_get_getuserreportwriterresultrecords = privateGetGetUserReportWriterResultRecords = Entry('GetUserReportWriterResultRecords', 'private', 'GET', {'cost': 1})
    private_get_getaccountinfo = privateGetGetAccountInfo = Entry('GetAccountInfo', 'private', 'GET', {'cost': 1})
    private_get_getaccountpositions = privateGetGetAccountPositions = Entry('GetAccountPositions', 'private', 'GET', {'cost': 1})
    private_get_getallaccountconfigs = privateGetGetAllAccountConfigs = Entry('GetAllAccountConfigs', 'private', 'GET', {'cost': 1})
    private_get_gettreasuryproductsforaccount = privateGetGetTreasuryProductsForAccount = Entry('GetTreasuryProductsForAccount', 'private', 'GET', {'cost': 1})
    private_get_getaccounttrades = privateGetGetAccountTrades = Entry('GetAccountTrades', 'private', 'GET', {'cost': 1})
    private_get_getaccounttransactions = privateGetGetAccountTransactions = Entry('GetAccountTransactions', 'private', 'GET', {'cost': 1})
    private_get_getopentradereports = privateGetGetOpenTradeReports = Entry('GetOpenTradeReports', 'private', 'GET', {'cost': 1})
    private_get_getallopentradereports = privateGetGetAllOpenTradeReports = Entry('GetAllOpenTradeReports', 'private', 'GET', {'cost': 1})
    private_get_gettradeshistory = privateGetGetTradesHistory = Entry('GetTradesHistory', 'private', 'GET', {'cost': 1})
    private_get_getopenorders = privateGetGetOpenOrders = Entry('GetOpenOrders', 'private', 'GET', {'cost': 1})
    private_get_getopenquotes = privateGetGetOpenQuotes = Entry('GetOpenQuotes', 'private', 'GET', {'cost': 1})
    private_get_getorderfee = privateGetGetOrderFee = Entry('GetOrderFee', 'private', 'GET', {'cost': 1})
    private_get_getorderhistory = privateGetGetOrderHistory = Entry('GetOrderHistory', 'private', 'GET', {'cost': 1})
    private_get_getordershistory = privateGetGetOrdersHistory = Entry('GetOrdersHistory', 'private', 'GET', {'cost': 1})
    private_get_getorderstatus = privateGetGetOrderStatus = Entry('GetOrderStatus', 'private', 'GET', {'cost': 1})
    private_get_getomsfeetiers = privateGetGetOmsFeeTiers = Entry('GetOmsFeeTiers', 'private', 'GET', {'cost': 1})
    private_get_getaccountdeposittransactions = privateGetGetAccountDepositTransactions = Entry('GetAccountDepositTransactions', 'private', 'GET', {'cost': 1})
    private_get_getaccountwithdrawtransactions = privateGetGetAccountWithdrawTransactions = Entry('GetAccountWithdrawTransactions', 'private', 'GET', {'cost': 1})
    private_get_getalldepositrequestinfotemplates = privateGetGetAllDepositRequestInfoTemplates = Entry('GetAllDepositRequestInfoTemplates', 'private', 'GET', {'cost': 1})
    private_get_getdepositinfo = privateGetGetDepositInfo = Entry('GetDepositInfo', 'private', 'GET', {'cost': 1})
    private_get_getdepositrequestinfotemplate = privateGetGetDepositRequestInfoTemplate = Entry('GetDepositRequestInfoTemplate', 'private', 'GET', {'cost': 1})
    private_get_getdeposits = privateGetGetDeposits = Entry('GetDeposits', 'private', 'GET', {'cost': 1})
    private_get_getdepositticket = privateGetGetDepositTicket = Entry('GetDepositTicket', 'private', 'GET', {'cost': 1})
    private_get_getdeposittickets = privateGetGetDepositTickets = Entry('GetDepositTickets', 'private', 'GET', {'cost': 1})
    private_get_getomswithdrawfees = privateGetGetOMSWithdrawFees = Entry('GetOMSWithdrawFees', 'private', 'GET', {'cost': 1})
    private_get_getwithdrawfee = privateGetGetWithdrawFee = Entry('GetWithdrawFee', 'private', 'GET', {'cost': 1})
    private_get_getwithdraws = privateGetGetWithdraws = Entry('GetWithdraws', 'private', 'GET', {'cost': 1})
    private_get_getwithdrawtemplate = privateGetGetWithdrawTemplate = Entry('GetWithdrawTemplate', 'private', 'GET', {'cost': 1})
    private_get_getwithdrawtemplatetypes = privateGetGetWithdrawTemplateTypes = Entry('GetWithdrawTemplateTypes', 'private', 'GET', {'cost': 1})
    private_get_getwithdrawticket = privateGetGetWithdrawTicket = Entry('GetWithdrawTicket', 'private', 'GET', {'cost': 1})
    private_get_getwithdrawtickets = privateGetGetWithdrawTickets = Entry('GetWithdrawTickets', 'private', 'GET', {'cost': 1})
    private_post_adduseraffiliatetag = privatePostAddUserAffiliateTag = Entry('AddUserAffiliateTag', 'private', 'POST', {'cost': 1})
    private_post_canceluserreport = privatePostCancelUserReport = Entry('CancelUserReport', 'private', 'POST', {'cost': 1})
    private_post_registernewdevice = privatePostRegisterNewDevice = Entry('RegisterNewDevice', 'private', 'POST', {'cost': 1})
    private_post_subscribeaccountevents = privatePostSubscribeAccountEvents = Entry('SubscribeAccountEvents', 'private', 'POST', {'cost': 1})
    private_post_updateuseraffiliatetag = privatePostUpdateUserAffiliateTag = Entry('UpdateUserAffiliateTag', 'private', 'POST', {'cost': 1})
    private_post_generatetradeactivityreport = privatePostGenerateTradeActivityReport = Entry('GenerateTradeActivityReport', 'private', 'POST', {'cost': 1})
    private_post_generatetransactionactivityreport = privatePostGenerateTransactionActivityReport = Entry('GenerateTransactionActivityReport', 'private', 'POST', {'cost': 1})
    private_post_generatetreasuryactivityreport = privatePostGenerateTreasuryActivityReport = Entry('GenerateTreasuryActivityReport', 'private', 'POST', {'cost': 1})
    private_post_scheduletradeactivityreport = privatePostScheduleTradeActivityReport = Entry('ScheduleTradeActivityReport', 'private', 'POST', {'cost': 1})
    private_post_scheduletransactionactivityreport = privatePostScheduleTransactionActivityReport = Entry('ScheduleTransactionActivityReport', 'private', 'POST', {'cost': 1})
    private_post_scheduletreasuryactivityreport = privatePostScheduleTreasuryActivityReport = Entry('ScheduleTreasuryActivityReport', 'private', 'POST', {'cost': 1})
    private_post_cancelallorders = privatePostCancelAllOrders = Entry('CancelAllOrders', 'private', 'POST', {'cost': 1})
    private_post_cancelorder = privatePostCancelOrder = Entry('CancelOrder', 'private', 'POST', {'cost': 1})
    private_post_cancelquote = privatePostCancelQuote = Entry('CancelQuote', 'private', 'POST', {'cost': 1})
    private_post_cancelreplaceorder = privatePostCancelReplaceOrder = Entry('CancelReplaceOrder', 'private', 'POST', {'cost': 1})
    private_post_createquote = privatePostCreateQuote = Entry('CreateQuote', 'private', 'POST', {'cost': 1})
    private_post_modifyorder = privatePostModifyOrder = Entry('ModifyOrder', 'private', 'POST', {'cost': 1})
    private_post_sendorder = privatePostSendOrder = Entry('SendOrder', 'private', 'POST', {'cost': 1})
    private_post_submitblocktrade = privatePostSubmitBlockTrade = Entry('SubmitBlockTrade', 'private', 'POST', {'cost': 1})
    private_post_updatequote = privatePostUpdateQuote = Entry('UpdateQuote', 'private', 'POST', {'cost': 1})
    private_post_cancelwithdraw = privatePostCancelWithdraw = Entry('CancelWithdraw', 'private', 'POST', {'cost': 1})
    private_post_createdepositticket = privatePostCreateDepositTicket = Entry('CreateDepositTicket', 'private', 'POST', {'cost': 1})
    private_post_createwithdrawticket = privatePostCreateWithdrawTicket = Entry('CreateWithdrawTicket', 'private', 'POST', {'cost': 1})
    private_post_submitdepositticketcomment = privatePostSubmitDepositTicketComment = Entry('SubmitDepositTicketComment', 'private', 'POST', {'cost': 1})
    private_post_submitwithdrawticketcomment = privatePostSubmitWithdrawTicketComment = Entry('SubmitWithdrawTicketComment', 'private', 'POST', {'cost': 1})
    private_post_getorderhistorybyorderid = privatePostGetOrderHistoryByOrderId = Entry('GetOrderHistoryByOrderId', 'private', 'POST', {'cost': 1})