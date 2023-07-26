﻿using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: Look at recreating this class as a hierarchy to allow the differt types to be expressed correctly
    public class GroupClause : IJavaObjectProxy<net.sf.mpxj.GroupClause>
    {
        internal readonly ProxyManager _proxyManager;
        public net.sf.mpxj.GroupClause JavaObject { get; }

        internal GroupClause(ProxyManager proxyManager, net.sf.mpxj.GroupClause javaObject)
        {
            _proxyManager = proxyManager;
            JavaObject = javaObject;
        }

        public GroupClause()
        {
            JavaObject = new net.sf.mpxj.GroupClause();
        }

        public bool Ascending
        {
            get => JavaObject.getAscending();
            set => JavaObject.setAscending(value);
        }

        public java.awt.Color CellBackgroundColor
        {
            get => JavaObject.getCellBackgroundColor();
            set => JavaObject.setCellBackgroundColor(value);
        }

        public IFieldType Field
        {
            get => _proxyManager.ProxyObject(JavaObject.getField());
            set => JavaObject.setField(value.JavaObject);
        }

        public FontStyle Font
        {
            get => _proxyManager.ProxyObject(JavaObject.getFont());
            set => JavaObject.setFont(value.JavaObject);
        }

        public object GroupInterval
        {            
            get => JavaObject.getGroupInterval();
            set => JavaObject.setGroupInterval(value);
        }

        public int GroupOn
        {
            get => JavaObject.getGroupOn();
            set => JavaObject.setGroupOn(value);
        }

        public BackgroundPattern? Pattern
        {
            get => JavaObject.getPattern().ConvertType();
            set => JavaObject.setPattern(value.ConvertType());
        }

        public object StartAt
        {
            get => JavaObject.getStartAt();
            set => JavaObject.setStartAt(value);
        }

        public override string ToString() => JavaObject.toString();
    }
}

