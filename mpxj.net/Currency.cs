using MPXJ.Net.Proxy;

namespace MPXJ.Net;

public class Currency : IProjectEntityWithUniqueID, IJavaObjectProxy<net.sf.mpxj.Currency>
{
    public net.sf.mpxj.Currency JavaObject { get; }

    internal Currency(net.sf.mpxj.Currency javaObject)
    {
        JavaObject = javaObject;
    }

    public int? UniqueID => JavaObject.getUniqueID().ConvertType();

    public string CurrencyId => JavaObject.getCurrencyID();

    public string Name => JavaObject.getName();
    
    public string Symbol => JavaObject.getSymbol();

    public double? ExchangeRate => JavaObject.getExchangeRate().ConvertType();
    
    public string DecimalSymbol => JavaObject.getDecimalSymbol();
    
    public int? NumberOfDecimalPlaces => JavaObject.getNumberOfDecimalPlaces().ConvertType();
    
    public string DigitGroupingSymbol => JavaObject.getDigitGroupingSymbol();
    
    public string PositiveCurrencyFormat => JavaObject.getPositiveCurrencyFormat();
    
    public string NegativeCurrencyFormat => JavaObject.getNegativeCurrencyFormat();
    
    public class Builder : IJavaObjectProxy<net.sf.mpxj.Currency.Builder>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Currency.Builder JavaObject { get; }

        public Builder(ProjectFile file)
        {
            _proxyManager = file._proxyManager;
            JavaObject = new net.sf.mpxj.Currency.Builder(file.JavaObject);
        }

        public Builder UniqueID(int value)
        {
            JavaObject.uniqueID(value.ConvertType());
            return this;
        }

        public Builder CurrencyId(string value)
        {
            JavaObject.currencyID(value);
            return this;
        }

        public Builder Name(string value)
        {
            JavaObject.name(value);
            return this;
        }

        public Builder Symbol(string value)
        {
            JavaObject.symbol(value);
            return this;
        }

        public Builder ExchangeRate(double value)
        {
            JavaObject.exchangeRate(value.ConvertType());
            return this;
        }

        public Builder DecimalSymbol(string value)
        {
            JavaObject.decimalSymbol(value);
            return this;
        }

        public Builder NumberOfDecimalPlaces(int value)
        {
            JavaObject.numberOfDecimalPlaces(value.ConvertType());
            return this;
        }

        public Builder DigitGroupingSymbol(string value)
        {
            JavaObject.digitGroupingSymbol(value);
            return this;
        }

        public Builder PositiveCurrencyFormat(string value)
        {
            JavaObject.positiveCurrencyFormat(value);
            return this;
        }
        
        public Builder NegativeCurrencyFormat(string value)
        {
            JavaObject.negativeCurrencyFormat(value);
            return this;
        }
        
        public Currency Build() => _proxyManager.ProxyObject(JavaObject.build());
    }
}
