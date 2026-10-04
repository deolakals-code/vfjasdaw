// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class Scope1 : ScopeExpression // TypeDefIndex: 15265
{
	// Fields
	private object _body; // 0x18

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x3132304 Offset: 0x312E304 VA: 0x3132304
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, Expression body) { }

	// RVA: 0x3132308 Offset: 0x312E308 VA: 0x3132308
	private void .ctor(IReadOnlyList<ParameterExpression> variables, object body) { }

	// RVA: 0x3132348 Offset: 0x312E348 VA: 0x3132348 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x31323C4 Offset: 0x312E3C4 VA: 0x31323C4 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x31323CC Offset: 0x312E3CC VA: 0x31323CC Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x31323D4 Offset: 0x312E3D4 VA: 0x31323D4 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
