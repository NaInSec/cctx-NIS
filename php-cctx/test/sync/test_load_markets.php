<?php
namespace ccxt;
use \ccxt\Precise;

// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------
include_once __DIR__ . '/../base/test_market.php';

function test_load_markets($exchange, $skipped_properties) {
    $method = 'loadMarkets';
    $markets = $exchange->load_markets();
    $market_values = is_array($markets) ? array_values($markets) : array();
    for ($i = 0; $i < count($market_values); $i++) {
        test_market($exchange, $skipped_properties, $method, $market_values[$i]);
    }
}