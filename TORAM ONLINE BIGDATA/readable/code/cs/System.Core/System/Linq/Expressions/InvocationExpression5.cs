// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class InvocationExpression5 : InvocationExpression // TypeDefIndex: 15298
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28
	private readonly Expression _arg2; // 0x30
	private readonly Expression _arg3; // 0x38
	private readonly Expression _arg4; // 0x40

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313E518 Offset: 0x313A518 VA: 0x313E518
	public void .ctor(Expression lambda, Type returnType, Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4) { }

	// RVA: 0x313E5A4 Offset: 0x313A5A4 VA: 0x313E5A4 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x313E684 Offset: 0x313A684 VA: 0x313E684 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x313E68C Offset: 0x313A68C VA: 0x313E68C Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
