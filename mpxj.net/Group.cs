﻿using System.Collections.Generic;
using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class Group : IJavaObjectProxy<net.sf.mpxj.Group>
    {
        private readonly ProxyManager _proxyManager;
        public net.sf.mpxj.Group JavaObject { get; }

        internal Group(ProxyManager proxyManager, net.sf.mpxj.Group javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public int ID => JavaObject.getID().ConvertType().Value;

        public string Name => JavaObject.getName();

        public bool ShowSummaryTasks => JavaObject.getShowSummaryTasks();

        public IList<GroupClause> GroupClauses => _proxyManager.ProxyList<net.sf.mpxj.GroupClause, GroupClause>(_proxyManager.ProxyObject, value => value.JavaObject, JavaObject.getGroupClauses());

        public override string ToString() => JavaObject.toString();
    }
}

