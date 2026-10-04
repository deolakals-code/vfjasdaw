// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.TryExpressionProxy))]
public sealed class TryExpression : Expression // TypeDefIndex: 15350
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ReadOnlyCollection<CatchBlock> <Handlers>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Expression <Finally>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Expression <Fault>k__BackingField; // 0x30

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Body { get; }
	public ReadOnlyCollection<CatchBlock> Handlers { get; }
	public Expression Finally { get; }
	public Expression Fault { get; }

	// Methods

	// RVA: 0x31418C0 Offset: 0x313D8C0 VA: 0x31418C0
	internal void .ctor(Type type, Expression body, Expression finally, Expression fault, ReadOnlyCollection<CatchBlock> handlers) { }

	[CompilerGenerated]
	// RVA: 0x3141994 Offset: 0x313D994 VA: 0x3141994 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x314199C Offset: 0x313D99C VA: 0x314199C Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x31419A4 Offset: 0x313D9A4 VA: 0x31419A4
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x31419AC Offset: 0x313D9AC VA: 0x31419AC
	public ReadOnlyCollection<CatchBlock> get_Handlers() { }

	[CompilerGenerated]
	// RVA: 0x31419B4 Offset: 0x313D9B4 VA: 0x31419B4
	public Expression get_Finally() { }

	[CompilerGenerated]
	// RVA: 0x31419BC Offset: 0x313D9BC VA: 0x31419BC
	public Expression get_Fault() { }

	// RVA: 0x31419C4 Offset: 0x313D9C4 VA: 0x31419C4 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x313D298 Offset: 0x3139298 VA: 0x313D298
	public TryExpression Update(Expression body, IEnumerable<CatchBlock> handlers, Expression finally, Expression fault) { }
}
