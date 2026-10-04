// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class Block2 : BlockExpression // TypeDefIndex: 15259
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x3131888 Offset: 0x312D888 VA: 0x3131888
	internal void .ctor(Expression arg0, Expression arg1) { }

	// RVA: 0x31318C8 Offset: 0x312D8C8 VA: 0x31318C8 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x31319B8 Offset: 0x312D9B8 VA: 0x31319B8 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x31319C0 Offset: 0x312D9C0 VA: 0x31319C0 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x31319C8 Offset: 0x312D9C8 VA: 0x31319C8 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
