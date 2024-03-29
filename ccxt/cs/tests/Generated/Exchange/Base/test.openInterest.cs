using ccxt;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class testMainClass : BaseTest
{
    public static void testOpenInterest(Exchange exchange, object skippedProperties, object method, object entry)
    {
        object format = new Dictionary<string, object>() {
            { "symbol", "BTC/USDT" },
            { "openInterestAmount", exchange.parseNumber("3544581864.598") },
            { "openInterestValue", exchange.parseNumber("3544581864.598") },
            { "timestamp", 1649373600000 },
            { "datetime", "2022-04-07T23:20:00.000Z" },
            { "info", new Dictionary<string, object>() {} },
        };
        object emptyAllowedFor = new List<object>() {"symbol", "timestamp", "openInterestAmount", "openInterestValue", "datetime"};
        testSharedMethods.assertStructure(exchange, skippedProperties, method, entry, format, emptyAllowedFor);
        testSharedMethods.assertSymbol(exchange, skippedProperties, method, entry, "symbol");
        testSharedMethods.assertTimestampAndDatetime(exchange, skippedProperties, method, entry);
        //
        testSharedMethods.assertGreater(exchange, skippedProperties, method, entry, "openInterestAmount", "0");
        testSharedMethods.assertGreater(exchange, skippedProperties, method, entry, "openInterestValue", "0");
    }

}