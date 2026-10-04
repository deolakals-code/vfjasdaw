// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LabelInfo // TypeDefIndex: 15515
{
	// Fields
	private readonly LabelTarget _node; // 0x10
	private BranchLabel _label; // 0x18
	private object _definitions; // 0x20
	private readonly List<LabelScopeInfo> _references; // 0x28
	private bool _acrossBlockJump; // 0x30

	// Properties
	private bool HasDefinitions { get; }
	private bool HasMultipleDefinitions { get; }

	// Methods

	// RVA: 0x315A724 Offset: 0x3156724 VA: 0x315A724
	internal void .ctor(LabelTarget node) { }

	// RVA: 0x315A7C0 Offset: 0x31567C0 VA: 0x315A7C0
	internal BranchLabel GetLabel(LightCompiler compiler) { }

	// RVA: 0x315A818 Offset: 0x3156818 VA: 0x315A818
	internal void Reference(LabelScopeInfo block) { }

	// RVA: 0x315AB94 Offset: 0x3156B94 VA: 0x315AB94
	internal void Define(LabelScopeInfo block) { }

	// RVA: 0x315A8F0 Offset: 0x31568F0 VA: 0x315A8F0
	private void ValidateJump(LabelScopeInfo reference) { }

	// RVA: 0x315B318 Offset: 0x3157318 VA: 0x315B318
	internal void ValidateFinish() { }

	// RVA: 0x315A7D8 Offset: 0x31567D8 VA: 0x315A7D8
	private void EnsureLabel(LightCompiler compiler) { }

	// RVA: 0x315B078 Offset: 0x3157078 VA: 0x315B078
	private bool DefinedIn(LabelScopeInfo scope) { }

	// RVA: 0x315A8E0 Offset: 0x31568E0 VA: 0x315A8E0
	private bool get_HasDefinitions() { }

	// RVA: 0x315B138 Offset: 0x3157138 VA: 0x315B138
	private LabelScopeInfo FirstDefinition() { }

	// RVA: 0x315AE04 Offset: 0x3156E04 VA: 0x315AE04
	private void AddDefinition(LabelScopeInfo scope) { }

	// RVA: 0x315AFFC Offset: 0x3156FFC VA: 0x315AFFC
	private bool get_HasMultipleDefinitions() { }

	// RVA: -1 Offset: -1
	internal static T CommonNode<T>(T first, T second, Func<T, T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C7744 Offset: 0x26C3744 VA: 0x26C7744
	|-LabelInfo.CommonNode<object>
	*/
}
