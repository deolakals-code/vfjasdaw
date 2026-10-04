// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpressionN : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 15324
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313F288 Offset: 0x313B288 VA: 0x313F288
	public void .ctor(MethodInfo method, Expression instance, IReadOnlyList<Expression> args) { }

	// RVA: 0x313F2C8 Offset: 0x313B2C8 VA: 0x313F2C8 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x313F370 Offset: 0x313B370 VA: 0x313F370 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x313F410 Offset: 0x313B410 VA: 0x313F410 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
