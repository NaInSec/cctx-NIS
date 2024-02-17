<?php
namespace ccxt;

// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -----------------------------------------------------------------------------
use \ccxt\Precise;
include_once PATH_TO_CCXT . '/test/base/test_shared_methods.php';

function test_ticker($exchange, $skipped_properties, $method, $entry, $symbol) {
    $format = array(
        'info' => array(),
        'symbol' => 'ETH/BTC',
        'timestamp' => 1502962946216,
        'datetime' => '2017-09-01T00:00:00',
        'high' => $exchange->parse_number('1.234'),
        'low' => $exchange->parse_number('1.234'),
        'bid' => $exchange->parse_number('1.234'),
        'bidVolume' => $exchange->parse_number('1.234'),
        'ask' => $exchange->parse_number('1.234'),
        'askVolume' => $exchange->parse_number('1.234'),
        'vwap' => $exchange->parse_number('1.234'),
        'open' => $exchange->parse_number('1.234'),
        'close' => $exchange->parse_number('1.234'),
        'last' => $exchange->parse_number('1.234'),
        'previousClose' => $exchange->parse_number('1.234'),
        'change' => $exchange->parse_number('1.234'),
        'percentage' => $exchange->parse_number('1.234'),
        'average' => $exchange->parse_number('1.234'),
        'baseVolume' => $exchange->parse_number('1.234'),
        'quoteVolume' => $exchange->parse_number('1.234'),
    );
    // todo: atm, many exchanges fail, so temporarily decrease stict mode
    $empty_allowed_for = ['timestamp', 'datetime', 'open', 'high', 'low', 'close', 'last', 'ask', 'bid', 'bidVolume', 'askVolume', 'baseVolume', 'quoteVolume', 'previousClose', 'vwap', 'change', 'percentage', 'average'];
    assert_structure($exchange, $skipped_properties, $method, $entry, $format, $empty_allowed_for);
    assert_timestamp_and_datetime($exchange, $skipped_properties, $method, $entry);
    $log_text = log_template($exchange, $method, $entry);
    //
    assert_greater($exchange, $skipped_properties, $method, $entry, 'open', '0');
    assert_greater($exchange, $skipped_properties, $method, $entry, 'high', '0');
    assert_greater($exchange, $skipped_properties, $method, $entry, 'low', '0');
    assert_greater($exchange, $skipped_properties, $method, $entry, 'close', '0');
    assert_greater($exchange, $skipped_properties, $method, $entry, 'ask', '0');
    assert_greater_or_equal($exchange, $skipped_properties, $method, $entry, 'askVolume', '0');
    assert_greater($exchange, $skipped_properties, $method, $entry, 'bid', '0');
    assert_greater_or_equal($exchange, $skipped_properties, $method, $entry, 'bidVolume', '0');
    assert_greater($exchange, $skipped_properties, $method, $entry, 'vwap', '0');
    assert_greater($exchange, $skipped_properties, $method, $entry, 'average', '0');
    assert_greater_or_equal($exchange, $skipped_properties, $method, $entry, 'baseVolume', '0');
    assert_greater_or_equal($exchange, $skipped_properties, $method, $entry, 'quoteVolume', '0');
    $last_string = $exchange->safe_string($entry, 'last');
    $close_string = $exchange->safe_string($entry, 'close');
    assert((($close_string === null) && ($last_string === null)) || Precise::string_eq($last_string, $close_string), '`last` != `close`' . $log_text);
    $base_volume = $exchange->safe_string($entry, 'baseVolume');
    $quote_volume = $exchange->safe_string($entry, 'quoteVolume');
    $high = $exchange->safe_string($entry, 'high');
    $low = $exchange->safe_string($entry, 'low');
    if (!(is_array($skipped_properties) && array_key_exists('quoteVolume', $skipped_properties)) && !(is_array($skipped_properties) && array_key_exists('baseVolume', $skipped_properties))) {
        if (($base_volume !== null) && ($quote_volume !== null) && ($high !== null) && ($low !== null)) {
            assert(Precise::string_ge($quote_volume, Precise::string_mul($base_volume, $low)), 'quoteVolume >= baseVolume * low' . $log_text);
            assert(Precise::string_le($quote_volume, Precise::string_mul($base_volume, $high)), 'quoteVolume <= baseVolume * high' . $log_text);
        }
    }
    $vwap = $exchange->safe_string($entry, 'vwap');
    if ($vwap !== null) {
        // todo
        // assert (high !== undefined, 'vwap is defined, but high is not' + logText);
        // assert (low !== undefined, 'vwap is defined, but low is not' + logText);
        // assert (vwap >= low && vwap <= high)
        assert(Precise::string_ge($vwap, '0'), 'vwap is not greater than zero' . $log_text);
        if ($base_volume !== null) {
            assert($quote_volume !== null, 'baseVolume & vwap is defined, but quoteVolume is not' . $log_text);
        }
        if ($quote_volume !== null) {
            assert($base_volume !== null, 'quoteVolume & vwap is defined, but baseVolume is not' . $log_text);
        }
    }
    if (!(is_array($skipped_properties) && array_key_exists('ask', $skipped_properties)) && !(is_array($skipped_properties) && array_key_exists('bid', $skipped_properties))) {
        $ask_string = $exchange->safe_string($entry, 'ask');
        $bid_string = $exchange->safe_string($entry, 'bid');
        if (($ask_string !== null) && ($bid_string !== null)) {
            assert_greater($exchange, $skipped_properties, $method, $entry, 'ask', $exchange->safe_string($entry, 'bid'));
        }
    }
    assert_symbol($exchange, $skipped_properties, $method, $entry, 'symbol', $symbol);
}
