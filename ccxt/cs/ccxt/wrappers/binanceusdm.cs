namespace ccxt;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class binanceusdm
{
    public async Task<Dictionary<string, object>> TransferIn(string code, object amount, Dictionary<string, object> parameters = null)
    {
        var res = await this.transferIn(code, amount, parameters);
        return ((Dictionary<string, object>)res);
    }
    public async Task<Dictionary<string, object>> TransferOut(string code, object amount, Dictionary<string, object> parameters = null)
    {
        var res = await this.transferOut(code, amount, parameters);
        return ((Dictionary<string, object>)res);
    }
}