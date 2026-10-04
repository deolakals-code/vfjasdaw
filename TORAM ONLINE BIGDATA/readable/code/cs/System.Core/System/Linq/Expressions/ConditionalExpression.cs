// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.ConditionalExpressionProxy))]
public class ConditionalExpression : Expression // TypeDefIndex: 15274
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Test>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <IfTrue>k__BackingField; // 0x18

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	public Expression Test { get; }
	public Expression IfTrue { get; }
	public Expression IfFalse { get; }

	// Methods

	// RVA: 0x3133198 Offset: 0x312F198 VA: 0x3133198
	internal void .ctor(Expression test, Expression ifTrue) { }

	// RVA: 0x3133220 Offset: 0x312F220 VA: 0x3133220
	internal static ConditionalExpression Make(Expression test, Expression ifTrue, Expression ifFalse, Type type) { }

	// RVA: 0x3133498 Offset: 0x312F498 VA: 0x3133498 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x31334A0 Offset: 0x312F4A0 VA: 0x31334A0 Slot: 5
	public override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x31334C0 Offset: 0x312F4C0 VA: 0x31334C0
	public Expression get_Test() { }

	[CompilerGenerated]
	// RVA: 0x31334C8 Offset: 0x312F4C8 VA: 0x31334C8
	public Expression get_IfTrue() { }

	// RVA: 0x31334D0 Offset: 0x312F4D0 VA: 0x31334D0
	public Expression get_IfFalse() { }

	// RVA: 0x31334DC Offset: 0x312F4DC VA: 0x31334DC Slot: 10
	internal virtual Expression GetFalse() { }

	// RVA: 0x3133534 Offset: 0x312F534 VA: 0x3133534 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x313355C Offset: 0x312F55C VA: 0x313355C
	public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse) { }
}
