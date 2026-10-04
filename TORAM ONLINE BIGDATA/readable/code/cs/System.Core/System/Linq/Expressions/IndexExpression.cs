// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.IndexExpressionProxy))]
public sealed class IndexExpression : Expression, IArgumentProvider // TypeDefIndex: 15290
{
	// Fields
	private IReadOnlyList<Expression> _arguments; // 0x10
	[CompilerGenerated]
	private readonly Expression <Object>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly PropertyInfo <Indexer>k__BackingField; // 0x20

	// Properties
	public sealed override ExpressionType NodeType { get; }
	public sealed override Type Type { get; }
	public Expression Object { get; }
	public PropertyInfo Indexer { get; }
	public int ArgumentCount { get; }

	// Methods

	// RVA: 0x313D844 Offset: 0x3139844 VA: 0x313D844
	internal void .ctor(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments) { }

	// RVA: 0x313D8F8 Offset: 0x31398F8 VA: 0x313D8F8 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x313D900 Offset: 0x3139900 VA: 0x313D900 Slot: 5
	public sealed override Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x313D964 Offset: 0x3139964 VA: 0x313D964
	public Expression get_Object() { }

	[CompilerGenerated]
	// RVA: 0x313D96C Offset: 0x313996C VA: 0x313D96C
	public PropertyInfo get_Indexer() { }

	// RVA: 0x313C020 Offset: 0x3138020 VA: 0x313C020 Slot: 10
	public Expression GetArgument(int index) { }

	// RVA: 0x313BF80 Offset: 0x3137F80 VA: 0x313BF80 Slot: 11
	public int get_ArgumentCount() { }

	// RVA: 0x313D974 Offset: 0x3139974 VA: 0x313D974 Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x313CE60 Offset: 0x3138E60 VA: 0x313CE60
	internal Expression Rewrite(Expression instance, Expression[] arguments) { }
}
