// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LocalVariables // TypeDefIndex: 15597
{
	// Fields
	private readonly HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope> _variables; // 0x10
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; // 0x18
	private int _localCount; // 0x20
	private int _maxLocalCount; // 0x24

	// Properties
	public int LocalCount { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x3171110 Offset: 0x316D110 VA: 0x3171110
	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	// RVA: 0x316BAE4 Offset: 0x3167AE4 VA: 0x316BAE4
	public void UndefineLocal(LocalDefinition definition, int end) { }

	// RVA: 0x31713F0 Offset: 0x316D3F0 VA: 0x31713F0
	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	// RVA: 0x3171544 Offset: 0x316D544 VA: 0x3171544
	public int get_LocalCount() { }

	// RVA: 0x317154C Offset: 0x316D54C VA: 0x317154C
	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	// RVA: 0x3171628 Offset: 0x316D628 VA: 0x3171628
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x3171630 Offset: 0x316D630 VA: 0x3171630
	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	// RVA: 0x317174C Offset: 0x316D74C VA: 0x317174C
	public void .ctor() { }
}
