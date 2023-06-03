using System.Security.Cryptography;
using System.Text;

namespace CarStore; 

internal static class Extensions {
    private static readonly Encoding Encoding = Encoding.ASCII;

    public static string Mask(this string s, char mask) {
        return new string(mask, s.Length);
    }

    public static string ToSha1(this string s) {
        using var sha = SHA1.Create();
        byte[] arr = s.Select(c => (byte)c).ToArray();
        byte[] bytes = sha.ComputeHash(arr);
        return bytes.Select(b => b.ToString("x2")).Aggregate((a, b) => a + b);
    }

    public static string ToHex(this string s) {
        return string.Concat(s.Select(x => ( (byte)x ).ToString("x2")));
    }
}