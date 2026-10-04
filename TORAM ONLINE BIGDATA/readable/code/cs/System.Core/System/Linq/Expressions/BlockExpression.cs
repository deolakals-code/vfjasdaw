// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.BlockExpressionProxy))]
public class BlockExpression : Expression // TypeDefIndex: 15258
{
	// Properties
	public ReadOnlyCollection<Expression> Expressions { get; }
	public ReadOnlyCollection<ParameterExpression> Variables { get; }
	public sealed override ExpressionType NodeType { get; }
	public override Type Type { get; }
	[ExcludeFromCodeCoverage]
	internal virtual int ExpressionCount { get; }

	// Methods

	// RVA: 0x3131528 Offset: 0x312D528 VA: 0x3131528
	public ReadOnlyCollection<Expression> get_Expressions() { }

	// RVA: 0x3131534 Offset: 0x312D534 VA: 0x3131534
	public ReadOnlyCollection<ParameterExpression> get_Variables() { }

	// RVA: 0x3131544 Offset: 0x312D544 VA: 0x3131544
	internal void .ctor() { }

	// RVA: 0x313159C Offset: 0x312D59C VA: 0x313159C Slot: 9
	protected internal override Expression Accept(ExpressionVisitor visitor) { }

	// RVA: 0x31315C4 Offset: 0x312D5C4 VA: 0x31315C4 Slot: 4
	public sealed override ExpressionType get_NodeType() { }

	// RVA: 0x31315CC Offset: 0x312D5CC VA: 0x31315CC Slot: 5
	public override Type get_Type() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313160C Offset: 0x312D60C VA: 0x313160C Slot: 10
	internal virtual Expression GetExpression(int index) { }

	// RVA: 0x3131634 Offset: 0x312D634 VA: 0x3131634 Slot: 11
	internal virtual int get_ExpressionCount() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x313165C Offset: 0x312D65C VA: 0x313165C Slot: 12
	internal virtual ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x3131684 Offset: 0x312D684 VA: 0x3131684 Slot: 13
	internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x31316DC Offset: 0x312D6DC VA: 0x31316DC Slot: 14
	internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }

	// RVA: 0x3131704 Offset: 0x312D704 VA: 0x3131704
	internal static ReadOnlyCollection<Expression> ReturnReadOnlyExpressions(BlockExpression provider, ref object collection) { }
}
