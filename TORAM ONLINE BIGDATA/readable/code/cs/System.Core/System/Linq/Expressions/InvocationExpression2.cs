// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression2 : InvocationExpression // TypeDefIndex: 15295
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313DF00 Offset: 0x3139F00 VA: 0x313DF00
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1) { }

	// RVA: 0x313DF40 Offset: 0x3139F40 VA: 0x313DF40 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x313DFF0 Offset: 0x3139FF0 VA: 0x313DFF0 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x313DFF8 Offset: 0x3139FF8 VA: 0x313DFF8 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
