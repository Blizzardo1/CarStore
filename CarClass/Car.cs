namespace SalesKingAuto; 

public record Car(string Make, string Model, int Year,
    string Color, TransferCase TransferCase, decimal Price,
    Condition Condition = Condition.New, EngineSize Engine = EngineSize.V4) : IComparable< Car >, IEquatable< Car > {
    public string Display => ToString();

    #region IComparable<Car> Members

    #region Relational members

    /// <inheritdoc />
    public int CompareTo(Car? other) {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        int makeComparison = string.Compare(Make, other.Make, StringComparison.Ordinal);
        if (makeComparison != 0) return makeComparison;
        int modelComparison = string.Compare(Model, other.Model, StringComparison.Ordinal);
        if (modelComparison != 0) return modelComparison;
        int yearComparison = Year.CompareTo(other.Year);
        if (yearComparison != 0) return yearComparison;
        int colorComparison = string.Compare(Color, other.Color, StringComparison.Ordinal);
        if (colorComparison != 0) return colorComparison;
        int transferCaseComparison = TransferCase.CompareTo(other.TransferCase);
        if (transferCaseComparison != 0) return transferCaseComparison;
        int priceComparison = Price.CompareTo(other.Price);
        if (priceComparison != 0) return priceComparison;
        int conditionComparison = Condition.CompareTo(other.Condition);
        return conditionComparison != 0 ? conditionComparison : Engine.CompareTo(other.Engine);
    }

    #endregion

    #endregion

    public override string ToString() {
        return
            $"{Condition.GetName()} {Year} {Make} {Model} {Engine.GetName()}, {Color} {TransferCase.GetShortName()}; Price {Price:C}";
    }

    #region Equality members

    /// <inheritdoc />
    public virtual bool Equals(Car? other) {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Make == other.Make
               && Model == other.Model
               && Year == other.Year
               && Color == other.Color
               && TransferCase == other.TransferCase
               && Price == other.Price
               && Condition == other.Condition
               && Engine == other.Engine;
    }

    /// <inheritdoc />
    public override int GetHashCode() {
        return HashCode.Combine(Make, Model, Year, Color, (int)TransferCase, Price, (int)Condition, (int)Engine);
    }

    #endregion
}