// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.SwitchExpressionProxy))]
public sealed class SwitchExpression : Expression // TypeDefIndex: 15348
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <SwitchValue>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<SwitchCase> <Cases>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <DefaultBody>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly MethodInfo <Comparison>k__BackingField; // 0x28

	// Properties
	public Expression SwitchValue { get; }
	public ReadOnlyCollection<SwitchCase> Cases { get; }
	public Expression DefaultBody { get; }
	public MethodInfo Comparison { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x31417F4 Offset: 0x313D7F4 VA: 0x31417F4
	public Expression get_SwitchValue() { }

	[CompilerGenerated]
	// RVA: 0x31417FC Offset: 0x313D7FC VA: 0x31417FC
	public ReadOnlyCollection<SwitchCase> get_Cases() { }

	[CompilerGenerated]
	// RVA: 0x3141804 Offset: 0x313D804 VA: 0x3141804
	public Expression get_DefaultBody() { }

	[CompilerGenerated]
	// RVA: 0x314180C Offset: 0x313D80C VA: 0x314180C
	public MethodInfo get_Comparison() { }
}
