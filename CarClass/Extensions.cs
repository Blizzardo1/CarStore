using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SalesKingAuto; 

internal static class Extensions {
    /// <summary>
    /// Whether or not a string is empty
    /// </summary>
    /// <param name="s"></param>
    /// <returns>True if the string is empty or filled with whitespaces</returns>
    public static bool IsEmpty(this string s) {
        return string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s);
    }

    /// <summary>
    /// Gets the <see cref="T"/> type Attribute
    /// </summary>
    /// <typeparam name="T">The specific type constrained to <see cref="Attribute"/></typeparam>
    /// <typeparam name="TU">An Enumeration object conforming with the <see cref="Enum"/> type.</typeparam>
    /// <param name="value"></param>
    /// <returns></returns>
    private static T GetAttribute< T, TU >(this TU value) where T : Attribute where TU : Enum {
        FieldInfo? field = value.GetType().GetField(value.ToString());
        return (T)field?.GetCustomAttributes(typeof(T), false).FirstOrDefault()!;
    }

    /// <summary>
    /// Gets the short name of an attribute
    /// </summary>
    /// <typeparam name="T">An Enumeration object conforming with the <see cref="DisplayAttribute"/>.</typeparam>
    /// <param name="value"></param>
    /// <returns>The short name</returns>
    public static string GetShortName< T >(this T value) where T : Enum {
        return value.GetAttribute< DisplayAttribute, T >().ShortName ?? "N/A";
    }

    /// <summary>
    /// Gets the name of an attribute
    /// </summary>
    /// <typeparam name="T">An Enumeration object conforming with the <see cref="DisplayAttribute"/>.</typeparam>
    /// <param name="value"></param>
    /// <returns>The name</returns>
    public static string GetName< T >(this T value) where T : Enum {
        return value.GetAttribute< DisplayAttribute, T >().Name ?? "N/A";
    }

    /// <summary>
    /// Packs the <see cref="DateTime"/> object into a number
    /// </summary>
    /// <param name="dt"></param>
    /// <returns>A "packed" number </returns>
    public static ulong Pack(this DateTime dt) {
        return ( (ulong)dt.Year << 48 ) // 16-bits
               + ( (ulong)dt.Month << 40 ) //  8-bits
               + ( (ulong)dt.Day << 32 ) //  8-bits
               + ( (ulong)dt.Hour << 24 ) //  8-bits
               + ( (ulong)dt.Minute << 16 ) //  8-bits
               + ( (ulong)dt.Second << 8 ); //  8-bits
    }
}