// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ConstantExpressionProxy))]
public class ConstantExpression : Expression // TypeDefIndex: 15277
{
	// Fields
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x10

	// Properties
	public override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x3133640 Offset: 0x312F640 VA: 0x3133640
	internal void .ctor(object value) { }

	// RVA: 0x31336B4 Offset: 0x312F6B4 VA: 0x31336B4 Slot: 5
	public override Type get_Type() { }

	// RVA: 0x313373C Offset: 0x312F73C VA: 0x313373C Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3133744 Offset: 0x312F744 VA: 0x3133744
	public object get_Value() { }

	// RVA: 0x313374C Offset: 0x312F74C VA: 0x313374C Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}
