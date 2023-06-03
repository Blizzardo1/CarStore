namespace SalesKingAuto.Users; 

internal static class Nonce {
    public static string Generate() {
        return Guid.NewGuid().ToString();
    }
}