namespace MPXJ.Net
{
    public class PrimaveraPMFileWriter : AbstractProjectWriter
    {
        public new net.sf.mpxj.primavera.PrimaveraPMFileWriter JavaObject => (net.sf.mpxj.primavera.PrimaveraPMFileWriter)base.JavaObject;

        public bool WriteBaselines
        {
            get => JavaObject.getWriteBaselines();
            set => JavaObject.setWriteBaselines(value);
        }
    }
}
