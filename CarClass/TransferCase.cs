#region Header

// CarStore >SalesKingAuto >TransferCase.cs\n Copyright (C) , 2023\nCreated 01 06, 2023

#endregion

using System.ComponentModel.DataAnnotations;

namespace SalesKingAuto;

public enum TransferCase {
    [Display(ShortName = "2x4", Name = "Two-Wheel Drive")]
    TwoWheelDrive,

    [Display(ShortName = "4x4", Name = "Four-Wheel Drive")]
    FourWheelDrive,

    [Display(ShortName = "AWD", Name = "All-Wheel Drive")]
    AllWheelDrive
}