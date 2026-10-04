// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression3 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15328
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20
	private readonly Expression _arg2; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313F98C Offset: 0x313B98C VA: 0x313F98C
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1, Expression arg2) { }

	// RVA: 0x313F9E8 Offset: 0x313B9E8 VA: 0x313F9E8 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x313FAA8 Offset: 0x313BAA8 VA: 0x313FAA8 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x313FAB0 Offset: 0x313BAB0 VA: 0x313FAB0 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
