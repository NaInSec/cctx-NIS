# -*- coding: utf-8 -*-

# PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
# https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

from ccxt.pro.hitbtc import hitbtc

import ccxt.async_support.bequant as bequantRest


class bequant(hitbtc):

    def describe(self):
        # eslint-disable-next-line new-cap
        restInstance = bequantRest()
        restDescribe = restInstance.describe()
        extended = self.deep_extend(super(bequant, self).describe(), restDescribe)
        return self.deep_extend(extended, {
            'id': 'bequant',
            'name': 'Bequant',
            'countries': ['MT'],  # Malta
            'pro': True,
            'urls': {
                'logo': 'https://user-images.githubusercontent.com/1294454/55248342-a75dfe00-525a-11e9-8aa2-05e9dca943c6.jpg',
                'api': {
                    'public': 'https://api.bequant.io/api/3',
                    'private': 'https://api.bequant.io/api/3',
                },
                'www': 'https://bequant.io',
                'doc': [
                    'https://api.bequant.io/',
                ],
                'fees': [
                    'https://bequant.io/fees-and-limits',
                ],
                'referral': 'https://bequant.io',
            },
        })
