using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: implement view class hierarchy
    public interface IView : IJavaObjectProxy<net.sf.mpxj.View>
    {
        java.lang.Integer ID { get; }

        string Name { get; }

        net.sf.mpxj.ViewType Type { get; }

        string TableName { get; }

        net.sf.mpxj.Table Table { get; }
    }
}
