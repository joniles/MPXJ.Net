using System;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class CostRateTable : ProxyList<org.mpxj.CostRateTableEntry, CostRateTableEntry>
    {
        public new org.mpxj.CostRateTable JavaObject => (org.mpxj.CostRateTable)base.JavaObject;

        internal CostRateTable(ProxyManager proxyManager, org.mpxj.CostRateTable javaObject) : base(proxyManager.ProxyObject, value => value.JavaObject, javaObject) { }

        public CostRateTableEntry GetEntryByDate(DateTime date) => _fromJava(JavaObject.getEntryByDate(date.ConvertType()));

        public int GetIndexByDate(DateTime date) => JavaObject.getIndexByDate(date.ConvertType());

        public bool TableIsPopulated => JavaObject.tableIsPopulated();
    }
}

