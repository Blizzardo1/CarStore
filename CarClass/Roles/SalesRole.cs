namespace SalesKingAuto.Roles; 

internal class SalesRole : IUserRole {
    #region IUserRole Members

    /// <inheritdoc />
    public string Role => "Sales";

    #endregion
}