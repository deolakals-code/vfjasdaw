// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.GotoExpressionProxy))]
public sealed class GotoExpression : Expression // TypeDefIndex: 15287
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Value>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly GotoExpressionKind <Kind>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Value { get; }
	public LabelTarget Target { get; }
	public GotoExpressionKind Kind { get; }

	// Methods

	// RVA: 0x313D748 Offset: 0x3139748 VA: 0x313D748
	internal void .ctor(GotoExpressionKind kind, LabelTarget target, Expression value, Type type) { }

	[CompilerGenerated]
	// RVA: 0x313D7F4 Offset: 0x31397F4 VA: 0x313D7F4 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x313D7FC Offset: 0x31397FC VA: 0x313D7FC Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x313D804 Offset: 0x3139804 VA: 0x313D804
	public Expression get_Value() { }

	[CompilerGenerated]
	// RVA: 0x313D80C Offset: 0x313980C VA: 0x313D80C
	public LabelTarget get_Target() { }

	[CompilerGenerated]
	// RVA: 0x313D814 Offset: 0x3139814 VA: 0x313D814
	public GotoExpressionKind get_Kind() { }

	// RVA: 0x313D81C Offset: 0x313981C VA: 0x313D81C Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x313C9C0 Offset: 0x31389C0 VA: 0x313C9C0
	public GotoExpression Update(LabelTarget target, Expression value) { }
}
