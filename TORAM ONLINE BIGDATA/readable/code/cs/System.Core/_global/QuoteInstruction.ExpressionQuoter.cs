// Assembly: System.Core.dll
// Namespace: 
private sealed class QuoteInstruction.ExpressionQuoter : ExpressionVisitor // TypeDefIndex: 15734
{
	// Fields
	private readonly Dictionary<ParameterExpression, LocalVariable> _variables; // 0x10
	private readonly InterpretedFrame _frame; // 0x18
	private readonly Stack<HashSet<ParameterExpression>> _shadowedVars; // 0x20

	// Methods

	// RVA: 0x3180428 Offset: 0x317C428 VA: 0x3180428
	internal void .ctor(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x270A834 Offset: 0x2706834 VA: 0x270A834
	|-QuoteInstruction.ExpressionQuoter.VisitLambda<object>
	|
	|-RVA: 0x270AA08 Offset: 0x2706A08 VA: 0x270AA08
	|-QuoteInstruction.ExpressionQuoter.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x31804E0 Offset: 0x317C4E0 VA: 0x31804E0 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x3180674 Offset: 0x317C674 VA: 0x3180674 Slot: 22
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x3180810 Offset: 0x317C810 VA: 0x3180810 Slot: 21
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x31808DC Offset: 0x317C8DC VA: 0x31808DC
	private IStrongBox GetBox(ParameterExpression variable) { }
}
