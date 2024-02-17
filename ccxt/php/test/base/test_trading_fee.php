<?php
namespace ccxt;

// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------
include_once PATH_TO_CCXT . '/test/base/test_shared_methods.php';

function test_trading_fee($exchange, $skipped_properties, $method, $symbol, $entry) {
    $format = array(
        'info' => array(),
        'symbol' => 'ETH/BTC',
        'maker' => $exchange->parse_number('0.002'),
        'taker' => $exchange->parse_number('0.003'),
    );
    $empty_allowed_for = ['tierBased', 'percentage', 'symbol'];
    assert_structure($exchange, $skipped_properties, $method, $entry, $format, $empty_allowed_for);
    assert_symbol($exchange, $skipped_properties, $method, $entry, 'symbol', $symbol);
}
