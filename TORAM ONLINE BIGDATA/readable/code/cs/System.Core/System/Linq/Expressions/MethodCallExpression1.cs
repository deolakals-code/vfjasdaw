// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression1 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15326
{
	// Fields
	private object _arg0; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313F540 Offset: 0x313B540 VA: 0x313F540
	public void .ctor(MethodInfo method, Expression arg0) { }

	// RVA: 0x313F56C Offset: 0x313B56C VA: 0x313F56C Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x313F604 Offset: 0x313B604 VA: 0x313F604 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x313F60C Offset: 0x313B60C VA: 0x313F60C Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
