// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class MethodCallExpression2 : MethodCallExpression, IArgumentProvider // TypeDefIndex: 15327
{
	// Fields
	private object _arg0; // 0x18
	private readonly Expression _arg1; // 0x20

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x313F718 Offset: 0x313B718 VA: 0x313F718
	public void .ctor(MethodInfo method, Expression arg0, Expression arg1) { }

	// RVA: 0x313F758 Offset: 0x313B758 VA: 0x313F758 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x313F808 Offset: 0x313B808 VA: 0x313F808 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x313F810 Offset: 0x313B810 VA: 0x313F810 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
