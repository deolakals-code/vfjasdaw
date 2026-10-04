// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class Block5 : BlockExpression // TypeDefIndex: 15262
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28
	private readonly Expression _arg4; // 0x30

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x3131DC4 Offset: 0x312DDC4 VA: 0x3131DC4
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x3131E50 Offset: 0x312DE50 VA: 0x3131E50 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x3131F14 Offset: 0x312DF14 VA: 0x3131F14 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x3131F1C Offset: 0x312DF1C VA: 0x3131F1C Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x3131F24 Offset: 0x312DF24 VA: 0x3131F24 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
