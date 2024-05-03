using System.Text;

namespace MPXJ.Net
{
    public class JsonWriter : AbstractProjectWriter
    {
        public new net.sf.mpxj.json.JsonWriter JavaObject => (net.sf.mpxj.json.JsonWriter)base.JavaObject;

        public Encoding Encoding
        {
            get => Encoding.GetEncoding(JavaObject.getEncoding().name());
            set => java.nio.charset.Charset.forName(value.EncodingName);
        }

        public bool IncludeLayoutData
        {
            get => JavaObject.getIncludeLayoutData();
            set => JavaObject.setIncludeLayoutData(value);
        }

        public bool Pretty
        {
            get => JavaObject.getPretty();
            set => JavaObject.setPretty(value);
        }

        public TimeUnit? TimeUnits
        {
            get => JavaObject.getTimeUnits().ConvertType();
            set => JavaObject.setTimeUnits(value.ConvertType());
        }
    }
}
