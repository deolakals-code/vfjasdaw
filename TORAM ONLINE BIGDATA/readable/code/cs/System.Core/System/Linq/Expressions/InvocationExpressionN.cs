// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class InvocationExpressionN : InvocationExpression // TypeDefIndex: 15292
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313DAE0 Offset: 0x3139AE0 VA: 0x313DAE0
	public void .ctor(Expression lambda, IReadOnlyList<Expression> arguments, Type returnType) { }

	// RVA: 0x313DB10 Offset: 0x3139B10 VA: 0x313DB10 Slot: 12
	public override Expression GetArgument(int index) { }

	// RVA: 0x313DBB8 Offset: 0x3139BB8 VA: 0x313DBB8 Slot: 13
	public override int get_ArgumentCount() { }

	// RVA: 0x313DC58 Offset: 0x3139C58 VA: 0x313DC58 Slot: 14
	internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
