// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class InstanceMethodCallExpression2 : InstanceMethodCallExpression, IArgumentProvider // TypeDefIndex: 15333
{
	// Fields
	private object _arg0; // 0x20
	private readonly Expression _arg1; // 0x28

	// Properties
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x314077C Offset: 0x313C77C VA: 0x314077C
	public void .ctor(MethodInfo method, Expression instance, Expression arg0, Expression arg1) { }

	// RVA: 0x31407D8 Offset: 0x313C7D8 VA: 0x31407D8 Slot: 14
	public override Expression GetArgument(int index) { }

	// RVA: 0x3140888 Offset: 0x313C888 VA: 0x3140888 Slot: 15
	public override int get_ArgumentCount() { }

	// RVA: 0x3140890 Offset: 0x313C890 VA: 0x3140890 Slot: 13
	internal override MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }
}
