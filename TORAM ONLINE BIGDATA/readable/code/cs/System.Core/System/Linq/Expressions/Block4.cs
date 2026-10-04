// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class Block4 : BlockExpression // TypeDefIndex: 15261
{
	// Fields
	private object _arg0; // 0x10
	private readonly Expression _arg1; // 0x18
	private readonly Expression _arg2; // 0x20
	private readonly Expression _arg3; // 0x28

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x3131BE8 Offset: 0x312DBE8 VA: 0x3131BE8
	internal void .ctor(Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x3131C58 Offset: 0x312DC58 VA: 0x3131C58 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x3131D14 Offset: 0x312DD14 VA: 0x3131D14 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x3131D1C Offset: 0x312DD1C VA: 0x3131D1C Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x3131D24 Offset: 0x312DD24 VA: 0x3131D24 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
