﻿using MPXJ.Net.Proxy;

namespace MPXJ.Net
{
    public class RtfNotes : Notes, IJavaObjectProxy<net.sf.mpxj.RtfNotes>
    {
        public new net.sf.mpxj.RtfNotes JavaObject => (net.sf.mpxj.RtfNotes)base.JavaObject;

        internal RtfNotes(net.sf.mpxj.RtfNotes value) : base(value) { }

        public RtfNotes(string rtf) : base(new net.sf.mpxj.RtfNotes(rtf)) { }

        public string Rtf => JavaObject.getRtf();
    }
}
