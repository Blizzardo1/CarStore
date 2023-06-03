using System.ComponentModel;
using SalesKingAuto.Users;

namespace SalesKingAuto; 

[Description("Global Database")]
internal class Database {
    private static List< Car > Cars { get; set; }
    private static List< Order > Orders { get; set; }
    private static List< User > Users { get; set; }
}