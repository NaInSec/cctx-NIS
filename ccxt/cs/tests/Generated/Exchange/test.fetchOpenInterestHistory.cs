using ccxt;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class testMainClass : BaseTest
{
    async static public Task testFetchOpenInterestHistory(Exchange exchange, object skippedProperties, object symbol)
    {
        object method = "fetchOpenInterestHistory";
        object openInterestHistory = await exchange.fetchOpenInterestHistory(symbol);
        assert(((openInterestHistory is IList<object>) || (openInterestHistory.GetType().IsGenericType && openInterestHistory.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)))), add(add(add(add(exchange.id, " "), method), " must return an array, returned "), exchange.json(openInterestHistory)));
        for (object i = 0; isLessThan(i, getArrayLength(openInterestHistory)); postFixIncrement(ref i))
        {
            testOpenInterest(exchange, skippedProperties, method, getValue(openInterestHistory, i));
        }
    }

}