namespace MPXJ.Net
{
    public class AstaSqliteReader : AbstractProjectReader
    {
        internal AstaSqliteReader(org.mpxj.asta.AstaSqliteReader reader) : base(reader) { }

        public AstaSqliteReader() : base(new org.mpxj.asta.AstaSqliteReader()) { }

        public new org.mpxj.asta.AstaSqliteReader JavaObject => (org.mpxj.asta.AstaSqliteReader)base.JavaObject;
    }
}
