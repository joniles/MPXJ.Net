using System;
using org.mpxj.proxy;

namespace org.mpxj
{
    public class CostRateTable : ProxyList<net.sf.mpxj.CostRateTableEntry, CostRateTableEntry>
    {
        public new net.sf.mpxj.CostRateTable JavaObject => (net.sf.mpxj.CostRateTable)base.JavaObject;

        internal CostRateTable(ProxyManager proxyManager, net.sf.mpxj.CostRateTable javaObject) : base(proxyManager.ProxyObject, (value) => value.JavaObject, javaObject) { }

        public CostRateTableEntry GetEntryByDate(DateTime date) => _fromJava(JavaObject.getEntryByDate(date.ConvertType()));

        public int GetIndexByDate(DateTime date) => JavaObject.getIndexByDate(date.ConvertType());

        public bool TableIsPopulated => JavaObject.tableIsPopulated();
    }
}

