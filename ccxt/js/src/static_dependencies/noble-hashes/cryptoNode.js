// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code
// EDIT THE CORRESPONDENT .ts FILE INSTEAD

import * as nc from 'node:crypto';
export const crypto = nc && typeof nc === 'object' && 'webcrypto' in nc ? nc.webcrypto : undefined;
