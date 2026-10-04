// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.BinaryExpressionProxy))]
public class BinaryExpression : Expression // TypeDefIndex: 15223
{
	// Fields
	[CompilerGenerated]
	private readonly Expression <Right>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Left>k__BackingField; // 0x18

	// Properties
	public override bool CanReduce { get; }
	public Expression Right { get; }
	public Expression Left { get; }
	public MethodInfo Method { get; }
	public LambdaExpression Conversion { get; }
	public bool IsLifted { get; }
	public bool IsLiftedToNull { get; }
	internal bool IsLiftedLogical { get; }
	internal bool IsReferenceComparison { get; }

	// Methods

	// RVA: 0x3117698 Offset: 0x3113698 VA: 0x3117698
	internal void .ctor(Expression left, Expression right) { }

	// RVA: 0x3117728 Offset: 0x3113728 VA: 0x3117728 Slot: 6
	public override bool get_CanReduce() { }

	// RVA: 0x311774C Offset: 0x311374C VA: 0x311774C
	private static bool IsOpAssignment(ExpressionType op) { }

	[CompilerGenerated]
	// RVA: 0x311775C Offset: 0x311375C VA: 0x311775C
	public Expression get_Right() { }

	[CompilerGenerated]
	// RVA: 0x3117764 Offset: 0x3113764 VA: 0x3117764
	public Expression get_Left() { }

	// RVA: 0x311776C Offset: 0x311376C VA: 0x311776C
	public MethodInfo get_Method() { }

	// RVA: 0x3117778 Offset: 0x3113778 VA: 0x3117778 Slot: 10
	internal virtual MethodInfo GetMethod() { }

	// RVA: 0x3117780 Offset: 0x3113780 VA: 0x3117780
	public BinaryExpression Update(Expression left, LambdaExpression conversion, Expression right) { }

	// RVA: 0x3118790 Offset: 0x3114790 VA: 0x3118790 Slot: 7
	public override Expression Reduce() { }

	// RVA: 0x31191C4 Offset: 0x31151C4 VA: 0x31191C4
	private static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op) { }

	// RVA: 0x31190C0 Offset: 0x31150C0 VA: 0x31190C0
	private Expression ReduceVariable() { }

	// RVA: 0x3118808 Offset: 0x3114808 VA: 0x3118808
	private Expression ReduceMember() { }

	// RVA: 0x3118C64 Offset: 0x3114C64 VA: 0x3118C64
	private Expression ReduceIndex() { }

	// RVA: 0x31178E4 Offset: 0x31138E4 VA: 0x31178E4
	public LambdaExpression get_Conversion() { }

	// RVA: 0x3119A28 Offset: 0x3115A28 VA: 0x3119A28 Slot: 11
	internal virtual LambdaExpression GetConversion() { }

	// RVA: 0x3119A30 Offset: 0x3115A30 VA: 0x3119A30
	public bool get_IsLifted() { }

	// RVA: 0x3117CD4 Offset: 0x3113CD4 VA: 0x3117CD4
	public bool get_IsLiftedToNull() { }

	// RVA: 0x3119BC0 Offset: 0x3115BC0 VA: 0x3119BC0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x3119BE8 Offset: 0x3115BE8 VA: 0x3119BE8
	internal bool get_IsLiftedLogical() { }

	// RVA: 0x31178F0 Offset: 0x31138F0 VA: 0x31178F0
	internal bool get_IsReferenceComparison() { }

	// RVA: 0x3119D50 Offset: 0x3115D50 VA: 0x3119D50
	internal Expression ReduceUserdefinedLifted() { }
}
