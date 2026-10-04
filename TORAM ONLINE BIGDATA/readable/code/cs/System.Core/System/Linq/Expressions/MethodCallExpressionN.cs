// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpressionN : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15323
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x18

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313F0A8 Offset: 0x313B0A8 VA: 0x313F0A8
	public void .ctor(MethodInfo method, IReadOnlyList<Expression> args) { }

	// RVA: 0x313F0D4 Offset: 0x313B0D4 VA: 0x313F0D4 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x313F17C Offset: 0x313B17C VA: 0x313F17C Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x313F21C Offset: 0x313B21C VA: 0x313F21C Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
