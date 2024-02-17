using ccxt;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class testMainClass : BaseTest
{
    async static public Task testFetchTradingFees(Exchange exchange, object skippedProperties)
    {
        object method = "fetchTradingFees";
        object fees = await exchange.fetchTradingFees();
        object symbols = new List<object>(((IDictionary<string,object>)fees).Keys);
        for (object i = 0; isLessThan(i, getArrayLength(symbols)); postFixIncrement(ref i))
        {
            object symbol = getValue(symbols, i);
            testTradingFee(exchange, skippedProperties, method, symbol, getValue(fees, symbol));
        }
    }

}