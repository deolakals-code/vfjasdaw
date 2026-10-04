// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression0 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15325
{
	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313F48C Offset: 0x313B48C VA: 0x313F48C
	public void .ctor(MethodInfo method) { }

	// RVA: 0x313F490 Offset: 0x313B490 VA: 0x313F490 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x313F4DC Offset: 0x313B4DC VA: 0x313F4DC Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x313F4E4 Offset: 0x313B4E4 VA: 0x313F4E4 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
