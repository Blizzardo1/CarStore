namespace SalesKingAuto.Roles; 

internal class AdministratorRole : IUserRole {
    #region IUserRole Members

    /// <inheritdoc />
    public string Role => "Administrator";

    #endregion
}