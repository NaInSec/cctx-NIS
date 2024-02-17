<?php
namespace ccxt;

// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------
include_once PATH_TO_CCXT . '/test/base/test_shared_methods.php';

function test_account($exchange, $skipped_properties, $method, $entry) {
    $format = array(
        'info' => array(),
        'code' => 'BTC',
        'type' => 'spot',
        'id' => '12345',
    );
    $empty_allowed_for = ['code', 'id'];
    assert_structure($exchange, $skipped_properties, $method, $entry, $format, $empty_allowed_for);
    assert_currency_code($exchange, $skipped_properties, $method, $entry, $entry['code']);
}