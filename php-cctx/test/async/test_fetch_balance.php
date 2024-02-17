<?php
namespace ccxt;
use \ccxt\Precise;
use React\Async;
use React\Promise;

// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------
include_once __DIR__ . '/../base/test_balance.php';

function test_fetch_balance($exchange, $skipped_properties) {
    return Async\async(function () use ($exchange, $skipped_properties) {
        $method = 'fetchBalance';
        $response = Async\await($exchange->fetch_balance());
        test_balance($exchange, $skipped_properties, $method, $response);
    }) ();
}