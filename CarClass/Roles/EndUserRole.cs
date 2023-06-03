namespace SalesKingAuto.Roles; 

internal class EndUserRole : IUserRole {
    #region IUserRole Members

    /// <inheritdoc />
    public string Role => "End User";

    #endregion
}