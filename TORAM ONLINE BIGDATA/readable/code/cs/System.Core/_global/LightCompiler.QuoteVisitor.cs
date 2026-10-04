// Assembly: System.Core.dll
// Namespace: 
private sealed class LightCompiler.QuoteVisitor : ExpressionVisitor // TypeDefIndex: 15559
{
	// Fields
	private readonly Dictionary<ParameterExpression, int> _definedParameters; // 0x10
	public readonly HashSet<ParameterExpression> _hoistedParameters; // 0x18

	// Methods

	// RVA: 0x316AA70 Offset: 0x3166A70 VA: 0x316AA70 Slot: 21
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x316AAFC Offset: 0x3166AFC VA: 0x316AAFC Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x316B260 Offset: 0x3167260 VA: 0x316B260 Slot: 22
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270A460 Offset: 0x2706460 VA: 0x270A460
	|-LightCompiler.QuoteVisitor.VisitLambda<object>
	|
	|-RVA: 0x270A648 Offset: 0x2706648 VA: 0x270A648
	|-LightCompiler.QuoteVisitor.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x316AB64 Offset: 0x3166B64 VA: 0x316AB64
	private void PushParameters(IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x316AEE0 Offset: 0x3166EE0 VA: 0x316AEE0
	private void PopParameters(IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x316B3A8 Offset: 0x31673A8 VA: 0x316B3A8
	public void .ctor() { }
}
