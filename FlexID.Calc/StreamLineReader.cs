using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace TextIO
{
    public class StreamLineReader : System.IO.TextReader
    {
        private const int DefaultFileStreamBufferSize = 4096;

        private Stream stream;
        private Encoding encoding;
        private Decoder decoder;
        private long position;
        private byte[] byteBuffer;
        private char[] charBuffer;
        private int charPos;
        private int charLen;
        private int crLen, lfLen;

        public StreamLineReader(string path)
            : this(path, Encoding.UTF8)
        { }

        public StreamLineReader(Stream stream)
            : this(stream, Encoding.UTF8)
        { }

        public StreamLineReader(string path, Encoding encoding)
            : this(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultFileStreamBufferSize), encoding)
        {
        }

        public StreamLineReader(Stream stream, Encoding encoding)
        {
            this.stream = stream;
            this.encoding = encoding;
            this.decoder = encoding.GetDecoder();

            this.position = stream.Position;
            this.byteBuffer = new byte[4096];

            this.charBuffer = new char[4096];
            this.charPos = 0;
            this.charLen = 0;
            this.crLen = encoding.GetByteCount("\r");
            this.lfLen = encoding.GetByteCount("\n");
        }

        private int ReadBuffer()
        {
            charPos = 0;
            charLen = 0;

            int byteLen = stream.Read(byteBuffer, 0, byteBuffer.Length);
            if (byteLen > 0)
            {
                charLen = decoder.GetChars(byteBuffer, 0, byteLen, charBuffer, charLen);
            }
            return charLen;
        }

        public bool EndOfStream
        {
            get
            {
                if (charPos < charLen)
                    return false;

                int numRead = ReadBuffer();
                return numRead == 0;
            }
        }

        public long Position { get { return position; } }

        public override string ReadLine()
        {
            Debug.Assert(stream != null);

            if (charPos == charLen)
            {
                if (ReadBuffer() == 0) return null;
            }

            StringBuilder sb = null;
            String s;
            do
            {
                int i = charPos;
                do
                {
                    char ch = charBuffer[i];
                    if (ch == '\r' || ch == '\n')
                    {
                        if (sb != null)
                        {
                            sb.Append(charBuffer, charPos, i - charPos);
                            s = sb.ToString();
                        }
                        else
                        {
                            s = new String(charBuffer, charPos, i - charPos);
                        }
                        charPos = i + 1;
                        position += encoding.GetByteCount(s) + (ch == '\r' ? crLen : lfLen);
                        if (ch == '\r' && (charPos < charLen || ReadBuffer() > 0))
                        {
                            if (charBuffer[charPos] == '\n')
                            {
                                charPos += 1;
                                position += lfLen;
                            }
                        }
                        return s;
                    }
                    i++;
                } while (i < charLen);
                i = charLen - charPos;
                if (sb == null) sb = new StringBuilder(i + 80);
                sb.Append(charBuffer, charPos, i);
            } while (ReadBuffer() > 0);

            s = sb.ToString();
            position += encoding.GetByteCount(s);
            return s;
        }

        public void Seek(long position)
        {
            stream.Seek(position, SeekOrigin.Begin);
            this.position = position;

            this.charPos = 0;
            this.charLen = 0;
        }
    }
}
