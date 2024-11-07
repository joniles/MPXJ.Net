using System.IO;

namespace MPXJ.Net.Proxy
{
    public class ProxyInputStream : java.io.InputStream
    {
        private readonly Stream _stream;
        private long currentOffset;
        private long markedOffset = 0;

        public ProxyInputStream(Stream stream)
        {
            _stream = stream;
        }

        public override int read()
        {
            int i = _stream.ReadByte();
            if (i != -1)
            {
                currentOffset++;
                return i;
            }
            return -1;
        }

        public override int read(byte[] b, int off, int len)
        {
            int i = _stream.Read(b, off, len);
            if (i > 0)
            {
                currentOffset += i;
                return i;
            }
            return -1;
        }

        public override bool markSupported()
        {
            return _stream.CanSeek;
        }

        public override void mark(int readlimit)
        {
            markedOffset = currentOffset;
        }

        public override void reset()
        {
            currentOffset = markedOffset;
            _stream.Seek(markedOffset, SeekOrigin.Begin);
        }

        public override void close()
        {
            _stream.Close();
        }
    }
}