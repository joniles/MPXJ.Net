using System.Globalization;
using System.Linq;

namespace MPXJ.Net
{
    public class MPXReader : AbstractProjectReader
    {
        public MPXReader()
        {
            base.JavaObject = new net.sf.mpxj.mpx.MPXReader();
        }

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

        public static CultureInfo[] SupportedCultures
        {
            get => net.sf.mpxj.mpx.MPXReader.getSupportedLocales().ToList().Select(l => l.ConvertType()).ToArray();
        }
    }
}
