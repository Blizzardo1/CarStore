using System.ComponentModel.DataAnnotations;

namespace SalesKingAuto; 

public enum EngineSize {
    [Display(Name = "2.5L 4-Cylinder", ShortName = "4-Banger")]
    V4,

    [Display(Name = "3.4L V6", ShortName = "V6")]
    V6,

    [Display(Name = "4.0L V8", ShortName = "V8")]
    V8,

    [Display(Name = "4.7L V10", ShortName = "V10")]
    V10,

    [Display(Name = "5.5L V12", ShortName = "V12")]
    V12
}