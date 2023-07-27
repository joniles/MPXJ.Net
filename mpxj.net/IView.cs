using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: implement view class hierarchy
    public interface IView : IJavaObjectProxy<net.sf.mpxj.View>
    {
        int? ID { get; }

        string Name { get; }

        ViewType Type { get; }

        string TableName { get; }

        Table Table { get; }
    }
}
