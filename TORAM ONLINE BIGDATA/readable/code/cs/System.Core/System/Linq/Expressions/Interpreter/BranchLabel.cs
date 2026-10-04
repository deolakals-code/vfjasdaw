// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchLabel // TypeDefIndex: 15388
{
	// Fields
	private int _targetIndex; // 0x10
	private int _stackDepth; // 0x14
	private int _continuationStackDepth; // 0x18
	private List<int> _forwardBranchFixups; // 0x20
	[CompilerGenerated]
	private int <LabelIndex>k__BackingField; // 0x28

	// Properties
	internal int LabelIndex { get; set; }
	internal bool HasRuntimeLabel { get; }
	internal int TargetIndex { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3146D8C Offset: 0x3142D8C VA: 0x3146D8C
	internal int get_LabelIndex() { }

	[CompilerGenerated]
	// RVA: 0x3146D94 Offset: 0x3142D94 VA: 0x3146D94
	internal void set_LabelIndex(int value) { }

	// RVA: 0x3146D9C Offset: 0x3142D9C VA: 0x3146D9C
	internal bool get_HasRuntimeLabel() { }

	// RVA: 0x3146DB0 Offset: 0x3142DB0 VA: 0x3146DB0
	internal int get_TargetIndex() { }

	// RVA: 0x3146DB8 Offset: 0x3142DB8 VA: 0x3146DB8
	internal RuntimeLabel ToRuntimeLabel() { }

	// RVA: 0x3146DC4 Offset: 0x3142DC4 VA: 0x3146DC4
	internal void Mark(InstructionList instructions) { }

	// RVA: 0x3146F7C Offset: 0x3142F7C VA: 0x3146F7C
	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x3146F50 Offset: 0x3142F50 VA: 0x3146F50
	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x31470B0 Offset: 0x31430B0 VA: 0x31470B0
	public void .ctor() { }
}
