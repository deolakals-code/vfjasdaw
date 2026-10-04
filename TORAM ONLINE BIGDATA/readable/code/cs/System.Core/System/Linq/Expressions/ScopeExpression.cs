// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
internal class ScopeExpression : BlockExpression // TypeDefIndex: 15264
{
	// Fields
	private IReadOnlyList<ParameterExpression> _variables; // 0x10

	// Properties
	protected IReadOnlyList<ParameterExpression> VariablesList { get; }

	// Methods

	// RVA: 0x31321FC Offset: 0x312E1FC VA: 0x31321FC
	internal void .ctor(IReadOnlyList<ParameterExpression> variables) { }

	// RVA: 0x3132228 Offset: 0x312E228 VA: 0x3132228 Slot: 13
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	// RVA: 0x3132270 Offset: 0x312E270 VA: 0x3132270
	protected IReadOnlyList<ParameterExpression> get_VariablesList() { }

	// RVA: 0x3132278 Offset: 0x312E278 VA: 0x3132278
	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) { }
}
