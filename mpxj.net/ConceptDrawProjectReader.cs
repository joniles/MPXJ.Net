﻿namespace MPXJ.Net
{
    public class ConceptDrawProjectReader : AbstractProjectReader
    {
        internal ConceptDrawProjectReader(net.sf.mpxj.conceptdraw.ConceptDrawProjectReader reader) : base(reader) { }

        public ConceptDrawProjectReader() : base(new net.sf.mpxj.conceptdraw.ConceptDrawProjectReader()) { }

        public new net.sf.mpxj.conceptdraw.ConceptDrawProjectReader JavaObject => (net.sf.mpxj.conceptdraw.ConceptDrawProjectReader)base.JavaObject;
    }
}
