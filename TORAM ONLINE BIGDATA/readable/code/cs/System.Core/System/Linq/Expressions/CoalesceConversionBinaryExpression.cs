// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal sealed class CoalesceConversionBinaryExpression : BinaryExpression // TypeDefIndex: 15226
{
	// Fields
	private readonly LambdaExpression _conversion; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x311AFE8 Offset: 0x3116FE8 VA: 0x311AFE8
	internal void .ctor(Expression left, Expression right, LambdaExpression conversion) { }

	// RVA: 0x311B014 Offset: 0x3117014 VA: 0x311B014 Slot: 11
	internal override LambdaExpression GetConversion() { }

	// RVA: 0x311B01C Offset: 0x311701C VA: 0x311B01C Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x311B024 Offset: 0x3117024 VA: 0x311B024 Slot: 5
	public sealed override Type get_Type() { }
}
