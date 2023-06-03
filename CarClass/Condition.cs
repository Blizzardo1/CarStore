using System.ComponentModel.DataAnnotations;

namespace SalesKingAuto; 

public enum Condition {
    [Display(Name = "New", ShortName = "N")]
    New,

    [Display(Name = "Used", ShortName = "U")]
    Used,

    [Display(Name = "Certified", ShortName = "C")]
    Certified,

    [Display(Name = "Salvage", ShortName = "S")]
    Salvage,

    [Display(Name = "Parts", ShortName = "P")]
    Parts,

    [Display(Name = "Other", ShortName = "O")]
    Other
}