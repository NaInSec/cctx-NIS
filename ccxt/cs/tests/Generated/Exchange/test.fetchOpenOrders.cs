using ccxt;
namespace Tests;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class testMainClass : BaseTest
{
    async static public Task testFetchOpenOrders(Exchange exchange, object skippedProperties, object symbol)
    {
        object method = "fetchOpenOrders";
        object orders = await exchange.fetchOpenOrders(symbol);
        assert(((orders is IList<object>) || (orders.GetType().IsGenericType && orders.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>)))), add(add(add(add(exchange.id, " "), method), " must return an array, returned "), exchange.json(orders)));
        object now = exchange.milliseconds();
        for (object i = 0; isLessThan(i, getArrayLength(orders)); postFixIncrement(ref i))
        {
            object order = getValue(orders, i);
            testOrder(exchange, skippedProperties, method, order, symbol, now);
            assert(isEqual(getValue(order, "status"), "open"), add(add(add(add(add(add(add(exchange.id, " "), method), " "), symbol), " returned an order with status "), getValue(order, "status")), " (expected \"open\")"));
        }
        testSharedMethods.assertTimestampOrder(exchange, method, symbol, orders);
    }

}