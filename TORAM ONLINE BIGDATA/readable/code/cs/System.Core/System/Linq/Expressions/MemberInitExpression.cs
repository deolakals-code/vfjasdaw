// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.MemberInitExpressionProxy))]
public sealed class MemberInitExpression : Expression // TypeDefIndex: 15318
{
	// Fields
	[CompilerGenerated]
	private readonly NewExpression <NewExpression>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<MemberBinding> <Bindings>k__BackingField; // 0x18

	// Properties
	public NewExpression NewExpression { get; }
	public ReadOnlyCollection<MemberBinding> Bindings { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x313EF00 Offset: 0x313AF00 VA: 0x313EF00
	public NewExpression get_NewExpression() { }

	[CompilerGenerated]
	// RVA: 0x313EF08 Offset: 0x313AF08 VA: 0x313EF08
	public ReadOnlyCollection<MemberBinding> get_Bindings() { }
}
