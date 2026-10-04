// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression1 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 15332
{
	// Fields
	private object _arg0; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x3140588 Offset: 0x313C588 VA: 0x3140588
	public void .ctor(MethodInfo method, Expression instance, Expression arg0) { }

	// RVA: 0x31405C8 Offset: 0x313C5C8 VA: 0x31405C8 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3140660 Offset: 0x313C660 VA: 0x3140660 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x3140668 Offset: 0x313C668 VA: 0x3140668 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
