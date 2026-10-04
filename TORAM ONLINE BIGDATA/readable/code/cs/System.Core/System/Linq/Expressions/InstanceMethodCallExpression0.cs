// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression0 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 15331
{
	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x314049C Offset: 0x313C49C VA: 0x314049C
	public void .ctor(MethodInfo method, Expression instance) { }

	// RVA: 0x31404C8 Offset: 0x313C4C8 VA: 0x31404C8 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3140514 Offset: 0x313C514 VA: 0x3140514 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x314051C Offset: 0x313C51C VA: 0x314051C Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
