using System.IO.Compression;
using System.Text;

public class StrGZip
{
    // https://stackoverflow.com/questions/7343465/compression-decompression-string-with-c-sharp
    public void CopyTo(Stream src, Stream dest)
    {
        byte[] bytes = new byte[4096];

        int cnt;

        while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
        {
            dest.Write(bytes, 0, cnt);
        }
    }

    public byte[] Zip(string str)
    {
        var bytes = Encoding.ASCII.GetBytes(str);

        using (var msi = new MemoryStream(bytes))
        using (var mso = new MemoryStream())
        {
            using (var gs = new GZipStream(mso, CompressionMode.Compress))
            {
                //msi.CopyTo(gs);
                CopyTo(msi, gs);
            }

            return mso.ToArray();
        }
    }

    public string Unzip(byte[] bytes)
    {
        using (var msi = new MemoryStream(bytes))
        using (var mso = new MemoryStream())
        {
            using (var gs = new GZipStream(msi, CompressionMode.Decompress))
            {
                //gs.CopyTo(mso);
                CopyTo(gs, mso);
            }

            return Encoding.ASCII.GetString(mso.ToArray());
        }
    }

// https://isanhsu.blogspot.com/2012/03/stringbyte-c.html
    public string ToHexString(byte[] bytes) // 0xae00cf => "AE00CF "
    {
        string hexString = string.Empty;
        if (bytes != null)
        {
            StringBuilder strB = new StringBuilder();

            for (int i = 0; i < bytes.Length; i++)
            {
                strB.Append(bytes[i].ToString("X2"));
            }
            hexString = strB.ToString();
        }
        return hexString;
    }


// https://jax-work-archive.blogspot.com/2019/07/c-gzip-base64.html
    public byte[] StringToByteArray(string hex)
    {
        return Enumerable.Range(0, hex.Length)
                        .Where(x => x % 2 == 0)
                        .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                        .ToArray();
    }
}