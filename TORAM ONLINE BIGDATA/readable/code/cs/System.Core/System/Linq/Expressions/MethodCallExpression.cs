// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.MethodCallExpressionProxy))]
public class MethodCallExpression : Expression, IArgumentProvider // TypeDefIndex: 15321
{
	// Fields
	[CompilerGenerated]
	private readonly MethodInfo <Method>k__BackingField; // 0x10

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public MethodInfo Method { get; }
	public Expression Object { get; }
	[ExcludeFromCodeCoverage]
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x313EF20 Offset: 0x313AF20 VA: 0x313EF20
	internal void .ctor(MethodInfo method) { }

	// RVA: 0x313EF94 Offset: 0x313AF94 VA: 0x313EF94 Slot: 12
	internal virtual Expression GetInstance() { }

	// RVA: 0x313EF9C Offset: 0x313AF9C VA: 0x313EF9C Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x313EFA4 Offset: 0x313AFA4 VA: 0x313EFA4 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x313EFC8 Offset: 0x313AFC8 VA: 0x313EFC8
	public MethodInfo get_Method() { }

	// RVA: 0x313AF1C Offset: 0x3136F1C VA: 0x313AF1C
	public Expression get_Object() { }

	// RVA: 0x313EFD0 Offset: 0x313AFD0 VA: 0x313EFD0 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313EFFC Offset: 0x313AFFC VA: 0x313EFFC Slot: 13
	internal virtual MethodCallExpression Rewrite(Expression instance, IReadOnlyList<Expression> args) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313F024 Offset: 0x313B024 VA: 0x313F024 Slot: 14
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x313F04C Offset: 0x313B04C VA: 0x313F04C Slot: 15
	public virtual int get_ArgumentCount() { }
}
