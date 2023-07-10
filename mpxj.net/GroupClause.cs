﻿using org.mpxj.proxy;

namespace org.mpxj
{
    // TODO: Look at recreating this class as a hierarchy to allow the differt types to be expressed correctly
    public class GroupClause : IJavaObjectProxy<net.sf.mpxj.GroupClause>
    {
        public net.sf.mpxj.GroupClause JavaObject { get; }

        internal GroupClause(net.sf.mpxj.GroupClause javaObject)
        {
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

        public net.sf.mpxj.FieldType Field
        {
            get => JavaObject.getField();
            set => JavaObject.setField(value);
        }

        public net.sf.mpxj.mpp.FontStyle Font
        {
            get => JavaObject.getFont();
            set => JavaObject.setFont(value);
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

        public net.sf.mpxj.mpp.BackgroundPattern Pattern
        {
            get => JavaObject.getPattern();
            set => JavaObject.setPattern(value);
        }

        public object StartAt
        {
            get => JavaObject.getStartAt();
            set => JavaObject.setStartAt(value);
        }

        public new string ToString()
        {
            return JavaObject.toString();
        }
    }
}
