// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.InvocationExpressionProxy))]
public class InvocationExpression : Expression, IArgumentProvider // TypeDefIndex: 15291
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18

	// Properties
	public sealed override Type Type { get; }
	public sealed override ExpressionType NodeType { get; }
	public Expression Expression { get; }
	[ExcludeFromCodeCoverage]
	public virtual int ArgumentCount { get; }

	// Methods

	// RVA: 0x313D9A0 Offset: 0x31399A0 VA: 0x313D9A0
	internal void .ctor(Expression expression, Type returnType) { }

	[CompilerGenerated]
	// RVA: 0x313DA28 Offset: 0x3139A28 VA: 0x313DA28 Slot: 5
	public sealed override Type get_Type() { }

	// RVA: 0x313DA30 Offset: 0x3139A30 VA: 0x313DA30 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	[CompilerGenerated]
	// RVA: 0x313DA38 Offset: 0x3139A38 VA: 0x313DA38
	public Expression get_Expression() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313DA40 Offset: 0x3139A40 VA: 0x313DA40 Slot: 12
	public virtual Expression GetArgument(int index) { }

	// RVA: 0x313DA68 Offset: 0x3139A68 VA: 0x313DA68 Slot: 13
	public virtual int get_ArgumentCount() { }

	// RVA: 0x313DA90 Offset: 0x3139A90 VA: 0x313DA90 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313DAB8 Offset: 0x3139AB8 VA: 0x313DAB8 Slot: 14
	internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments) { }
}
