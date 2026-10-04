// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression5 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15330
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30
	private readonly Expression _arg4; // 0x38

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x3140050 Offset: 0x313C050 VA: 0x3140050
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x31400DC Offset: 0x313C0DC VA: 0x31400DC Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x31401BC Offset: 0x313C1BC VA: 0x31401BC Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x31401C4 Offset: 0x313C1C4 VA: 0x31401C4 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
