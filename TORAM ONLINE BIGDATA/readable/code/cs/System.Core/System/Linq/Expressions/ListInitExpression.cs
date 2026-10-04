// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ListInitExpressionProxy))]
public sealed class ListInitExpression : Expression // TypeDefIndex: 15310
{
	// Fields
	[CompilerGenerated]
	private readonly NewExpression <NewExpression>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<ElementInit> <Initializers>k__BackingField; // 0x18

	// Properties
	public NewExpression NewExpression { get; }
	public ReadOnlyCollection<ElementInit> Initializers { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x313EAF0 Offset: 0x313AAF0 VA: 0x313EAF0
	public NewExpression get_NewExpression() { }

	[CompilerGenerated]
	// RVA: 0x313EAF8 Offset: 0x313AAF8 VA: 0x313EAF8
	public ReadOnlyCollection<ElementInit> get_Initializers() { }
}
