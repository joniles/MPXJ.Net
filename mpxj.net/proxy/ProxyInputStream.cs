using System.IO;

namespace MPXJ.Net.Proxy
{
    public class ProxyInputStream : java.io.InputStream
    {
        private readonly Stream _stream;
        private long _currentOffset;
        private long _markedOffset;

        public ProxyInputStream(Stream stream)
        {
            _stream = stream;
        }

        public override int read()
        {
            var i = _stream.ReadByte();
            if (i == -1) return -1;
            _currentOffset++;
            return i;
        }

        public override int read(byte[] b, int off, int len)
        {
            var i = _stream.Read(b, off, len);
            if (i <= 0) return -1;
            _currentOffset += i;
            return i;
        }

        public override bool markSupported()
        {
            return _stream.CanSeek;
        }

        public override void mark(int readlimit)
        {
            _markedOffset = _currentOffset;
        }

        public override void reset()
        {
            _currentOffset = _markedOffset;
            _stream.Seek(_markedOffset, SeekOrigin.Begin);
        }

        public override void close()
        {
            _stream.Close();
        }
    }
}