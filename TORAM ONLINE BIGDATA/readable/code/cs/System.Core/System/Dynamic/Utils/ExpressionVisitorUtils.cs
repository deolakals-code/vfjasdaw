// Assembly: System.Core.dll
// Namespace: System.Dynamic.Utils
internal static class ExpressionVisitorUtils // TypeDefIndex: 15798
{
	// Methods

	// RVA: 0x318A2C4 Offset: 0x31862C4 VA: 0x318A2C4
	public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block) { }

	// RVA: 0x318A484 Offset: 0x3186484 VA: 0x318A484
	public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName) { }

	// RVA: 0x318A748 Offset: 0x3186748 VA: 0x318A748
	public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes) { }
}
