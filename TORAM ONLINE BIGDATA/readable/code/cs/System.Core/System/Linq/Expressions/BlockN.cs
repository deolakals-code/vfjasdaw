// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal class BlockN : BlockExpression // TypeDefIndex: 15263
{
	// Fields
	private IReadOnlyList<Expression> _expressions; // 0x10

	// Properties
	internal override int ExpressionCount { get; }

	// Methods

	// RVA: 0x3131FDC Offset: 0x312DFDC VA: 0x3131FDC
	internal void .ctor(IReadOnlyList<Expression> expressions) { }

	// RVA: 0x3132008 Offset: 0x312E008 VA: 0x3132008 Slot: 10
	internal override Expression GetExpression(int index) { }

	// RVA: 0x31320B0 Offset: 0x312E0B0 VA: 0x31320B0 Slot: 11
	internal override int get_ExpressionCount() { }

	// RVA: 0x3132150 Offset: 0x312E150 VA: 0x3132150 Slot: 12
	internal override ReadOnlyCollection<Expression> GetOrMakeExpressions() { }

	// RVA: 0x3132198 Offset: 0x312E198 VA: 0x3132198 Slot: 14
	internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args) { }
}
