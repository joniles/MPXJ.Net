using System.Globalization;
using System.Linq;

namespace MPXJ.Net
{
    public class MPXReader : AbstractProjectReader
    {
        internal MPXReader(net.sf.mpxj.mpx.MPXReader reader) : base(reader) { }

        public MPXReader() : base(new net.sf.mpxj.mpx.MPXReader()) { }

        public new net.sf.mpxj.mpx.MPXReader JavaObject => (net.sf.mpxj.mpx.MPXReader)base.JavaObject;

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

        public static CultureInfo[] SupportedCultures => net.sf.mpxj.mpx.MPXReader.getSupportedLocales().ToList().Select(l => l.ConvertType()).ToArray();
    }
}
