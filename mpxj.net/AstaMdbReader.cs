namespace MPXJ.Net
{
    public class AstaMdbReader : AbstractProjectReader
    {
        internal AstaMdbReader(org.mpxj.asta.AstaMdbReader reader) : base(reader) { }

        public AstaMdbReader() : base(new org.mpxj.asta.AstaMdbReader()) { }

        public new org.mpxj.asta.AstaMdbReader JavaObject => (org.mpxj.asta.AstaMdbReader)base.JavaObject;
    }
}
