// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression3 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 15334
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x3140A14 Offset: 0x313CA14 VA: 0x3140A14
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x3140A84 Offset: 0x313CA84 VA: 0x3140A84 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3140B44 Offset: 0x313CB44 VA: 0x3140B44 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x3140B4C Offset: 0x313CB4C VA: 0x3140B4C Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
