using System.Globalization;
using System.Linq;

namespace MPXJ.Net
{
    public class MPXWriter : AbstractProjectWriter
    {
        public new org.mpxj.mpx.MPXWriter JavaObject => (org.mpxj.mpx.MPXWriter)base.JavaObject;

        public MPXWriter() : base(new org.mpxj.mpx.MPXWriter()) { }

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
        public static CultureInfo[] SupportedCultures => org.mpxj.mpx.MPXReader.getSupportedLocales().ToList().Select(l => l.ConvertType()).ToArray();
    }
}
