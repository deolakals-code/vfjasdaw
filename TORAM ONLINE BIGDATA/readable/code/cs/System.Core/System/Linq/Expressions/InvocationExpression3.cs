// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression3 : InvocationExpression // TypeDefIndex: 15296
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313E0C0 Offset: 0x313A0C0 VA: 0x313E0C0
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x313E11C Offset: 0x313A11C VA: 0x313E11C Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x313E1DC Offset: 0x313A1DC VA: 0x313E1DC Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x313E1E4 Offset: 0x313A1E4 VA: 0x313E1E4 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
