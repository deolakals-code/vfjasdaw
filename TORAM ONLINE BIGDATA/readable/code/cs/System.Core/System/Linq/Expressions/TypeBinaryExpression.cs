// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.TypeBinaryExpressionProxy))]
public sealed class TypeBinaryExpression : Expression // TypeDefIndex: 15351
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Type <TypeOperand>k__BackingField; // 0x20

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Expression { get; }
	public Type TypeOperand { get; }

	// Methods

	// RVA: 0x31419F0 Offset: 0x313D9F0 VA: 0x31419F0
	internal void .ctor(Expression expression, Type typeOperand, ExpressionType nodeType) { }

	// RVA: 0x3141A8C Offset: 0x313DA8C VA: 0x3141A8C Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3141AF8 Offset: 0x313DAF8 VA: 0x3141AF8 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3141B00 Offset: 0x313DB00 VA: 0x3141B00
	public Expression get_Expression() { }

	[CompilerGenerated]
	// RVA: 0x3141B08 Offset: 0x313DB08 VA: 0x3141B08
	public Type get_TypeOperand() { }

	// RVA: 0x3141B10 Offset: 0x313DB10 VA: 0x3141B10 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x313D3C4 Offset: 0x31393C4 VA: 0x313D3C4
	public TypeBinaryExpression Update(Expression expression) { }
}
