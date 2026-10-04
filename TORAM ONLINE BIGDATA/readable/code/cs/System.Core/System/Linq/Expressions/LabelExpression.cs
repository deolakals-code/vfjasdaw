// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.LabelExpressionProxy))]
public sealed class LabelExpression : Expression // TypeDefIndex: 15299
{
	// Fields
	[CompilerGenerated]
	private readonly LabelTarget <Target>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <DefaultValue>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public LabelTarget Target { get; }
	public Expression DefaultValue { get; }

	// Methods

	// RVA: 0x313E7A4 Offset: 0x313A7A4 VA: 0x313E7A4
	internal void .ctor(LabelTarget label, Expression defaultValue) { }

	// RVA: 0x313E82C Offset: 0x313A82C VA: 0x313E82C Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x313E848 Offset: 0x313A848 VA: 0x313E848 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x313E850 Offset: 0x313A850 VA: 0x313E850
	public LabelTarget get_Target() { }

	[CompilerGenerated]
	// RVA: 0x313E858 Offset: 0x313A858 VA: 0x313E858
	public Expression get_DefaultValue() { }

	// RVA: 0x313E860 Offset: 0x313A860 VA: 0x313E860 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x313CB60 Offset: 0x3138B60 VA: 0x313CB60
	public LabelExpression Update(LabelTarget target, Expression defaultValue) { }
}
