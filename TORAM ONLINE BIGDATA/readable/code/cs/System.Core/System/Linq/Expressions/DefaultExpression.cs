// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.DefaultExpressionProxy))]
public sealed class DefaultExpression : Expression // TypeDefIndex: 15280
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x3133828 Offset: 0x312F828 VA: 0x3133828
	internal void .ctor(Type type) { }

	[CompilerGenerated]
	// RVA: 0x313389C Offset: 0x312F89C VA: 0x313389C Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x31338A4 Offset: 0x312F8A4 VA: 0x31338A4 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x31338AC Offset: 0x312F8AC VA: 0x31338AC Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }
}
