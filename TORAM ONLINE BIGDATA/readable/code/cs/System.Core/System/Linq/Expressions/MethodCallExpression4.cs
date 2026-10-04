// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression4 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15329
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28
	private readonly Expression _arg3; // 0x30

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313FC90 Offset: 0x313BC90 VA: 0x313FC90
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2, Expression arg3) { }

	// RVA: 0x313FD00 Offset: 0x313BD00 VA: 0x313FD00 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x313FDD8 Offset: 0x313BDD8 VA: 0x313FDD8 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x313FDE0 Offset: 0x313BDE0 VA: 0x313FDE0 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
