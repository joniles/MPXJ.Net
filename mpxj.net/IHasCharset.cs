using System.Text;

namespace MPXJ.Net
{
    public interface IHasCharset
    {
       Encoding Charset { get; set; }
    }
}
