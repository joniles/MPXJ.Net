using org.mpxj.proxy;

namespace org.mpxj
{
    public class CostRateTable : ProxyList<net.sf.mpxj.CostRateTableEntry, CostRateTableEntry>
    {
        public new net.sf.mpxj.CostRateTable JavaObject { get => (net.sf.mpxj.CostRateTable)base.JavaObject; }

        internal CostRateTable(ProxyManager proxyManager, net.sf.mpxj.CostRateTable javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }

        public CostRateTableEntry GetEntryByDate(java.time.LocalDateTime date)
        {
            return _fromJava(JavaObject.getEntryByDate(date));
        }

        public int GetIndexByDate(java.time.LocalDateTime date)
        {
            return JavaObject.getIndexByDate(date);
        }

        public bool TableIsPopulated
        {
            get => JavaObject.tableIsPopulated();
        }
    }
}

