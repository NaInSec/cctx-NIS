// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code
// EDIT THE CORRESPONDENT .ts FILE INSTEAD

import testBalance from '../../../test/Exchange/base/test.balance.js';
import testSharedMethods from '../../../test/Exchange/base/test.sharedMethods.js';
async function testWatchBalance(exchange, skippedProperties, code) {
    const method = 'watchBalance';
    let now = exchange.milliseconds();
    const ends = now + 15000;
    while (now < ends) {
        let response = undefined;
        try {
            response = await exchange.watchBalance();
        }
        catch (e) {
            if (!testSharedMethods.isTemporaryFailure(e)) {
                throw e;
            }
            now = exchange.milliseconds();
            continue;
        }
        testBalance(exchange, skippedProperties, method, response);
        now = exchange.milliseconds();
    }
}
export default testWatchBalance;
