using ccxt;
using ccxt.pro;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class testMainClass : BaseTest
{
    async static public Task testWatchTicker(Exchange exchange, object skippedProperties, object symbol)
    {
        object method = "watchTicker";
        object now = exchange.milliseconds();
        object ends = add(now, 15000);
        while (isLessThan(now, ends))
        {
            object response = null;
            try
            {
                response = await exchange.watchTicker(symbol);
            } catch(Exception e)
            {
                if (!isTrue(testSharedMethods.isTemporaryFailure(e)))
                {
                    throw e;
                }
                now = exchange.milliseconds();
                continue;
            }
            assert((response is IDictionary<string, object>), add(add(add(add(add(add(exchange.id, " "), method), " "), symbol), " must return an object. "), exchange.json(response)));
            now = exchange.milliseconds();
            testTicker(exchange, skippedProperties, method, response, symbol);
        }
    }

}