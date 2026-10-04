// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal class ScopeN : ScopeExpression // TypeDefIndex: 15266
{
	// Fields
	private IReadOnlyList<Expression> _body; // 0x18

	// Properties
	protected IReadOnlyList<Expression> Body { get; }
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x31324B4 Offset: 0x312E4B4 VA: 0x31324B4
	internal void .ctor(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body) { }

	// RVA: 0x31324F4 Offset: 0x312E4F4 VA: 0x31324F4
	protected IReadOnlyList<Expression> get_Body() { }

	// RVA: 0x31324FC Offset: 0x312E4FC VA: 0x31324FC Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x31325A4 Offset: 0x312E5A4 VA: 0x31325A4 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x3132644 Offset: 0x312E644 VA: 0x3132644 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x313268C Offset: 0x312E68C VA: 0x313268C Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
