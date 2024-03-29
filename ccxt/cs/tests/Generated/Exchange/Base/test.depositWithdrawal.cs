using ccxt;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class testMainClass : BaseTest
{
    public static void testDepositWithdrawal(Exchange exchange, object skippedProperties, object method, object entry, object requestedCode, object now)
    {
        object format = new Dictionary<string, object>() {
            { "info", new Dictionary<string, object>() {} },
            { "id", "1234" },
            { "txid", "0x1345FEG45EAEF7" },
            { "timestamp", 1502962946216 },
            { "datetime", "2017-08-17 12:42:48.000" },
            { "network", "ETH" },
            { "address", "0xEFE3487358AEF352345345" },
            { "addressTo", "0xEFE3487358AEF352345123" },
            { "addressFrom", "0xEFE3487358AEF352345456" },
            { "tag", "smth" },
            { "tagTo", "smth" },
            { "tagFrom", "smth" },
            { "type", "deposit" },
            { "amount", exchange.parseNumber("1.234") },
            { "currency", "USDT" },
            { "status", "ok" },
            { "updated", 1502962946233 },
            { "fee", new Dictionary<string, object>() {} },
        };
        object emptyAllowedFor = new List<object>() {"address", "addressTo", "addressFrom", "tag", "tagTo", "tagFrom"}; // below we still do assertion for to/from
        testSharedMethods.assertStructure(exchange, skippedProperties, method, entry, format, emptyAllowedFor);
        testSharedMethods.assertTimestampAndDatetime(exchange, skippedProperties, method, entry, now);
        testSharedMethods.assertCurrencyCode(exchange, skippedProperties, method, entry, getValue(entry, "currency"), requestedCode);
        //
        testSharedMethods.assertInArray(exchange, skippedProperties, method, entry, "status", new List<object>() {"ok", "pending", "failed", "rejected", "canceled"});
        testSharedMethods.assertInArray(exchange, skippedProperties, method, entry, "type", new List<object>() {"deposit", "withdrawal"});
        testSharedMethods.assertGreaterOrEqual(exchange, skippedProperties, method, entry, "amount", "0");
        testSharedMethods.assertFeeStructure(exchange, skippedProperties, method, entry, "fee");
        if (isTrue(isEqual(getValue(entry, "type"), "deposit")))
        {
            testSharedMethods.assertType(exchange, skippedProperties, entry, "addressFrom", format);
        } else
        {
            testSharedMethods.assertType(exchange, skippedProperties, entry, "addressTo", format);
        }
    }

}