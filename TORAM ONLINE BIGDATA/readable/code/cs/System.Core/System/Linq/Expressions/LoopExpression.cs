// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.LoopExpressionProxy))]
public sealed class LoopExpression : Expression // TypeDefIndex: 15311
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly LabelTarget <BreakLabel>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly LabelTarget <ContinueLabel>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public LabelTarget BreakLabel { get; }
	public LabelTarget ContinueLabel { get; }

	// Methods

	// RVA: 0x313EB00 Offset: 0x313AB00 VA: 0x313EB00
	internal void .ctor(Expression body, LabelTarget break, LabelTarget continue) { }

	// RVA: 0x313EBA4 Offset: 0x313ABA4 VA: 0x313EBA4 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x313EC2C Offset: 0x313AC2C VA: 0x313EC2C Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x313EC34 Offset: 0x313AC34 VA: 0x313EC34
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x313EC3C Offset: 0x313AC3C VA: 0x313EC3C
	public LabelTarget get_BreakLabel() { }

	[CompilerGenerated]
	// RVA: 0x313EC44 Offset: 0x313AC44 VA: 0x313EC44
	public LabelTarget get_ContinueLabel() { }

	// RVA: 0x313EC4C Offset: 0x313AC4C VA: 0x313EC4C Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x313CC7C Offset: 0x3138C7C VA: 0x313CC7C
	public LoopExpression Update(LabelTarget breakLabel, LabelTarget continueLabel, Expression body) { }
}
