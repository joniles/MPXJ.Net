using System.Globalization;

namespace MPXJ.Net
{
    public class MPXWriter : AbstractProjectWriter
    {
        public new net.sf.mpxj.mpx.MPXWriter JavaObject => (net.sf.mpxj.mpx.MPXWriter)base.JavaObject;

        public MPXWriter() : base(new net.sf.mpxj.mpx.MPXWriter()) { }


        public CultureInfo Culture
        {
            get => JavaObject.getLocale().ConvertType();
            set => value.ConvertType();
        }

        public bool UseCultureDefaults
        {
            get => JavaObject.getUseLocaleDefaults();
            set => JavaObject.setUseLocaleDefaults(value);
        }
    }
}
