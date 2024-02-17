'use strict';

Object.defineProperty(exports, '__esModule', { value: true });

/* eslint-disable max-classes-per-file */
// import { errorHierarchy } from './errorHierarchy.js';
// Commented out since I'm not sure this is mandatory anymore
// and does not work out of the box with esm
// /*  ------------------------------------------------------------------------ */
// function subclass (BaseClass, classes, namespace = {}) {
//     for (const [className, subclasses] of Object.entries (classes)) {
//         const Class = Object.assign (namespace, {
//         /*  By creating a named property, we trick compiler to assign our class constructor function a name.
//             Otherwise, all our error constructors would be shown as [Function: Error] in the debugger! And
//             the super-useful `e.constructor.name` magic wouldn't work — we then would have no chance to
//             obtain a error type string from an error instance programmatically!                               */
//             [className]: class extends BaseClass {
//                 constructor (message) {
//                     super (message)
//                 /*  A workaround to make `instanceof` work on custom Error classes in transpiled ES5.
//                     See my blog post for the explanation of this hack:
//                     https://medium.com/@xpl/javascript-deriving-from-error-properly-8d2f8f315801        */
//                     this.constructor = Class
//                     this.__proto__   = Class.prototype
//                     this.name        = className
//                     this.message     = message
//                     // https://github.com/Microsoft/TypeScript/wiki/FAQ#why-doesnt-extending-built-ins-like-error-array-and-map-work
//                     Object.setPrototypeOf (this, Class.prototype)
//                 }
//             }
//         })[className]
//         subclass (Class, subclasses, namespace)
//     }
//     return namespace
// }
class BaseError extends Error {
    constructor(message) {
        super(message);
        this.name = 'BaseError';
    }
}
// Exchange Error errors
class ExchangeError extends Error {
    constructor(message) {
        super(message);
        this.name = 'ExchangeError';
    }
}
class ExchangeClosedByUser extends Error {
    constructor(message) {
        super(message);
        this.name = 'ExchangeClosedByUser';
    }
}
class AuthenticationError extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'AuthenticationError';
    }
}
class PermissionDenied extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'PermissionDenied';
    }
}
class AccountNotEnabled extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'AccountNotEnabled';
    }
}
class AccountSuspended extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'AccountSuspended';
    }
}
class ArgumentsRequired extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'ArgumentsRequired';
    }
}
class BadRequest extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'BadRequest';
    }
}
class OperationRejected extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'OperationRejected';
    }
}
class BadSymbol extends BadRequest {
    constructor(message) {
        super(message);
        this.name = 'BadSymbol';
    }
}
class NoChange extends OperationRejected {
    constructor(message) {
        super(message);
        this.name = 'NoChange';
    }
}
class MarginModeAlreadySet extends NoChange {
    constructor(message) {
        super(message);
        this.name = 'MarginModeAlreadySet';
    }
}
class BadResponse extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'BadResponse';
    }
}
class NullResponse extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'NullResponse';
    }
}
class InsufficientFunds extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'InsufficientFunds';
    }
}
class InvalidAddress extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'InvalidAddress';
    }
}
class AddressPending extends InvalidAddress {
    constructor(message) {
        super(message);
        this.name = 'AddressPending';
    }
}
class InvalidOrder extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'InvalidOrder';
    }
}
class ContractUnavailable extends InvalidOrder {
    constructor(message) {
        super(message);
        this.name = 'ContractUnavailable';
    }
}
class OrderNotFound extends InvalidOrder {
    constructor(message) {
        super(message);
        this.name = 'OrderNotFound';
    }
}
class OrderNotCached extends InvalidOrder {
    constructor(message) {
        super(message);
        this.name = 'OrderNotCached';
    }
}
class CancelPending extends InvalidOrder {
    constructor(message) {
        super(message);
        this.name = 'CancelPending';
    }
}
class OrderImmediatelyFillable extends InvalidOrder {
    constructor(message) {
        super(message);
        this.name = 'OrderImmediatelyFillable';
    }
}
class OrderNotFillable extends InvalidOrder {
    constructor(message) {
        super(message);
        this.name = 'OrderNotFillable';
    }
}
class DuplicateOrderId extends InvalidOrder {
    constructor(message) {
        super(message);
        this.name = 'DuplicateOrderId';
    }
}
class NotSupported extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'NotSupported';
    }
}
class OperationFailed extends BaseError {
    constructor(message) {
        super(message);
        this.name = 'OperationFailed';
    }
}
class ProxyError extends ExchangeError {
    constructor(message) {
        super(message);
        this.name = 'OperationFailed';
    }
}
// Network error
class NetworkError extends OperationFailed {
    constructor(message) {
        super(message);
        this.name = 'NetworkError';
    }
}
class DDoSProtection extends NetworkError {
    constructor(message) {
        super(message);
        this.name = 'DDoSProtection';
    }
}
class RateLimitExceeded extends NetworkError {
    constructor(message) {
        super(message);
        this.name = 'RateLimitExceeded';
    }
}
class ExchangeNotAvailable extends NetworkError {
    constructor(message) {
        super(message);
        this.name = 'ExchangeNotAvailable';
    }
}
class OnMaintenance extends ExchangeNotAvailable {
    constructor(message) {
        super(message);
        this.name = 'OnMaintenance';
    }
}
class InvalidNonce extends NetworkError {
    constructor(message) {
        super(message);
        this.name = 'InvalidNonce';
    }
}
class RequestTimeout extends NetworkError {
    constructor(message) {
        super(message);
        this.name = 'RequestTimeout';
    }
}
/*  ------------------------------------------------------------------------ */
// export default subclass (
//     // Root class
//     Error,
//     // Derived class hierarchy
//     errorHierarchy
// )
const errors = { BaseError, ExchangeClosedByUser, ExchangeError, PermissionDenied, AccountNotEnabled, AccountSuspended, ArgumentsRequired, BadRequest, BadSymbol, MarginModeAlreadySet, BadResponse, NullResponse, InsufficientFunds, InvalidAddress, InvalidOrder, OrderNotFound, OrderNotCached, CancelPending, OrderImmediatelyFillable, OrderNotFillable, DuplicateOrderId, NotSupported, NetworkError, DDoSProtection, RateLimitExceeded, ExchangeNotAvailable, OnMaintenance, InvalidNonce, RequestTimeout, AuthenticationError, AddressPending, ContractUnavailable, NoChange, OperationRejected, OperationFailed, ProxyError };

exports.AccountNotEnabled = AccountNotEnabled;
exports.AccountSuspended = AccountSuspended;
exports.AddressPending = AddressPending;
exports.ArgumentsRequired = ArgumentsRequired;
exports.AuthenticationError = AuthenticationError;
exports.BadRequest = BadRequest;
exports.BadResponse = BadResponse;
exports.BadSymbol = BadSymbol;
exports.BaseError = BaseError;
exports.CancelPending = CancelPending;
exports.ContractUnavailable = ContractUnavailable;
exports.DDoSProtection = DDoSProtection;
exports.DuplicateOrderId = DuplicateOrderId;
exports.ExchangeClosedByUser = ExchangeClosedByUser;
exports.ExchangeError = ExchangeError;
exports.ExchangeNotAvailable = ExchangeNotAvailable;
exports.InsufficientFunds = InsufficientFunds;
exports.InvalidAddress = InvalidAddress;
exports.InvalidNonce = InvalidNonce;
exports.InvalidOrder = InvalidOrder;
exports.MarginModeAlreadySet = MarginModeAlreadySet;
exports.NetworkError = NetworkError;
exports.NoChange = NoChange;
exports.NotSupported = NotSupported;
exports.NullResponse = NullResponse;
exports.OnMaintenance = OnMaintenance;
exports.OperationFailed = OperationFailed;
exports.OperationRejected = OperationRejected;
exports.OrderImmediatelyFillable = OrderImmediatelyFillable;
exports.OrderNotCached = OrderNotCached;
exports.OrderNotFillable = OrderNotFillable;
exports.OrderNotFound = OrderNotFound;
exports.PermissionDenied = PermissionDenied;
exports.ProxyError = ProxyError;
exports.RateLimitExceeded = RateLimitExceeded;
exports.RequestTimeout = RequestTimeout;
exports["default"] = errors;