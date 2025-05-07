using System.Globalization;
using System.Linq;

namespace MPXJ.Net
{
    public class MPXReader : AbstractProjectReader
    {
        internal MPXReader(org.mpxj.mpx.MPXReader reader) : base(reader) { }

        public MPXReader() : base(new org.mpxj.mpx.MPXReader()) { }

        public new org.mpxj.mpx.MPXReader JavaObject => (org.mpxj.mpx.MPXReader)base.JavaObject;

        public bool IgnoreTextModels
        {
            get => JavaObject.getIgnoreTextModels();
            set => JavaObject.setIgnoreTextModels(value);
        }

        public CultureInfo Culture
        {
            get => JavaObject.getLocale().ConvertType();
            set => value.ConvertType();
        }

        public static CultureInfo[] SupportedCultures => org.mpxj.mpx.MPXReader.getSupportedLocales().ToList().Select(l => l.ConvertType()).ToArray();
    }
}
