namespace MPXJ.Net
{
    public class PrimaveraPMFileWriter : AbstractProjectWriter
    {
        public new org.mpxj.primavera.PrimaveraPMFileWriter JavaObject => (org.mpxj.primavera.PrimaveraPMFileWriter)base.JavaObject;

        public PrimaveraPMFileWriter() : base(new org.mpxj.primavera.PrimaveraPMFileWriter()) { }

        public bool WriteBaselines
        {
            get => JavaObject.getWriteBaselines();
            set => JavaObject.setWriteBaselines(value);
        }
    }
}
