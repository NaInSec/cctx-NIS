using ccxt;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class testMainClass : BaseTest
{
    async static public Task testFetchFundingRateHistory(Exchange exchange, object skippedProperties, object symbol)
    {
        object method = "fetchFundingRateHistory";
        object fundingRatesHistory = await exchange.fetchFundingRateHistory(symbol);
        assert(((fundingRatesHistory is IList<object>) || (fundingRatesHistory.GetType().IsGenericType && fundingRatesHistory.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)))), add(add(add(add(add(add(exchange.id, " "), method), " "), symbol), " must return an array, returned "), exchange.json(fundingRatesHistory)));
        for (object i = 0; isLessThan(i, getArrayLength(fundingRatesHistory)); postFixIncrement(ref i))
        {
            testFundingRateHistory(exchange, skippedProperties, method, getValue(fundingRatesHistory, i), symbol);
        }
        testSharedMethods.assertTimestampOrder(exchange, method, symbol, fundingRatesHistory);
    }

}