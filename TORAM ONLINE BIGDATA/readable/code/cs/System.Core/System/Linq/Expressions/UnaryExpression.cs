// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.UnaryExpressionProxy))]
public sealed class UnaryExpression : Expression // TypeDefIndex: 15352
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ExpressionType <NodeType>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <Operand>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; // 0x28

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Operand { get; }
	public MethodInfo Method { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	public override bool CanReduce { get; }
	private bool IsPrefix { get; }

	// Methods

	// RVA: 0x3141B3C Offset: 0x313DB3C VA: 0x3141B3C
	internal void .ctor(ExpressionType nodeType, Expression expression, Type type, MethodInfo method) { }

	[CompilerGenerated]
	// RVA: 0x3141BE8 Offset: 0x313DBE8 VA: 0x3141BE8 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3141BF0 Offset: 0x313DBF0 VA: 0x3141BF0 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x3141BF8 Offset: 0x313DBF8 VA: 0x3141BF8
	public Expression get_Operand() { }

	[CompilerGenerated]
	// RVA: 0x3141C00 Offset: 0x313DC00 VA: 0x3141C00
	public MethodInfo get_Method() { }

	// RVA: 0x3141C08 Offset: 0x313DC08 VA: 0x3141C08
	public bool get_IsLifted() { }

	// RVA: 0x3141E2C Offset: 0x313DE2C VA: 0x3141E2C
	public bool get_IsLiftedToNull() { }

	// RVA: 0x3141EB8 Offset: 0x313DEB8 VA: 0x3141EB8 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x3141EE4 Offset: 0x313DEE4 VA: 0x3141EE4 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x3141F08 Offset: 0x313DF08 VA: 0x3141F08 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x3142E18 Offset: 0x313EE18 VA: 0x3142E18
	private bool get_IsPrefix() { }

	// RVA: 0x3142E5C Offset: 0x313EE5C VA: 0x3142E5C
	private UnaryExpression FunctionalOp(Expression operand) { }

	// RVA: 0x3142B20 Offset: 0x313EB20 VA: 0x3142B20
	private Expression ReduceVariable() { }

	// RVA: 0x31425D0 Offset: 0x313E5D0 VA: 0x31425D0
	private Expression ReduceMember() { }

	// RVA: 0x3141F78 Offset: 0x313DF78 VA: 0x3141F78
	private Expression ReduceIndex() { }

	// RVA: 0x313D4B0 Offset: 0x31394B0 VA: 0x313D4B0
	public UnaryExpression Update(Expression operand) { }
}
