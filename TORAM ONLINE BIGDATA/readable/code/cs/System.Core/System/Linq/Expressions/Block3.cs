// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class Block3 : BlockExpression // TypeDefIndex: 15260
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x3131A44 Offset: 0x312DA44 VA: 0x3131A44
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x3131AA0 Offset: 0x312DAA0 VA: 0x3131AA0 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x3131B44 Offset: 0x312DB44 VA: 0x3131B44 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x3131B4C Offset: 0x312DB4C VA: 0x3131B4C Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x3131B54 Offset: 0x312DB54 VA: 0x3131B54 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
