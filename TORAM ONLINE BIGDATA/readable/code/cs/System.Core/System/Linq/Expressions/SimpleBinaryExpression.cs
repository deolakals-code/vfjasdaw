// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal class SimpleBinaryExpression : BinaryExpression // TypeDefIndex: 15228
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x28

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }

	// Methods

	// RVA: 0x311B0D0 Offset: 0x31170D0 VA: 0x311B0D0
	internal void .ctor(ExpressionType nodeType, Expression left, Expression right, Type type) { }

	[CompilerGenerated]
	// RVA: 0x311B10C Offset: 0x311710C VA: 0x311B10C Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x311B114 Offset: 0x3117114 VA: 0x311B114 Slot: 5
	public sealed override Type get_Type() { }
}
