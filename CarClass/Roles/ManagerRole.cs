namespace SalesKingAuto.Roles; 

internal class ManagerRole : IUserRole {
    #region IUserRole Members

    /// <inheritdoc />
    public string Role => "Manager";

    #endregion
}