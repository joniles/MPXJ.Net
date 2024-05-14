using System.IO;

namespace MPXJ.Net.Proxy
{
    internal class ProxyOutputStream : java.io.OutputStream
    {
        private readonly Stream stream;

        public ProxyOutputStream(Stream stream)
        {
            this.stream = stream;
        }

        public override void write(int b)
        {
            stream.WriteByte((byte)b);
        }

        public override void write(byte[] b, int off, int len)
        {
            stream.Write(b, off, len);
        }

        public override void write(byte[] b)
        {
            stream.Write(b, 0, b.Length);
        }

        public override void flush()
        {
            stream.Flush();
        }

        public override void close()
        {
            stream.Close();
        }
    }
}
