namespace MPXJ.Net
{
    public class ConceptDrawProjectReader : AbstractProjectReader
    {
        internal ConceptDrawProjectReader(org.mpxj.conceptdraw.ConceptDrawProjectReader reader) : base(reader) { }

        public ConceptDrawProjectReader() : base(new org.mpxj.conceptdraw.ConceptDrawProjectReader()) { }

        public new org.mpxj.conceptdraw.ConceptDrawProjectReader JavaObject => (org.mpxj.conceptdraw.ConceptDrawProjectReader)base.JavaObject;
    }
}
