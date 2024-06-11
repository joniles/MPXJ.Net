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
            get => CultureInfo.GetCultureInfoByIetfLanguageTag(JavaObject.getLocale().toLanguageTag());
            set => java.util.Locale.forLanguageTag(value.IetfLanguageTag);
        }

        public static CultureInfo[] SupportedCultures
        {
            get => net.sf.mpxj.mpx.MPXReader.getSupportedLocales().ToList().Select(l => CultureInfo.GetCultureInfoByIetfLanguageTag(l.toLanguageTag())).ToArray();
        }
    }
}
