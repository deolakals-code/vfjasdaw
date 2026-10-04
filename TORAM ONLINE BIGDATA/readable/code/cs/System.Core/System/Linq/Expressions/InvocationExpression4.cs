// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression4 : InvocationExpression // TypeDefIndex: 15297
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30
	private readonly Expression _arg3; // 0x38

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313E2CC Offset: 0x313A2CC VA: 0x313E2CC
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x313E33C Offset: 0x313A33C VA: 0x313E33C Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x313E414 Offset: 0x313A414 VA: 0x313E414 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x313E41C Offset: 0x313A41C VA: 0x313E41C Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
