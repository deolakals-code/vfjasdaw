// Assembly: System.Core.dll
// Namespace: 
[DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
[IsReadOnly]
internal struct InstructionList.DebugView.InstructionView // TypeDefIndex: 15508
{
	// Fields
	private readonly int _index; // 0x0
	private readonly int _stackDepth; // 0x4
	private readonly int _continuationsDepth; // 0x8
	private readonly string _name; // 0x10
	private readonly Instruction _instruction; // 0x18

	// Methods

	// RVA: 0x3159594 Offset: 0x3155594 VA: 0x3159594
	internal string GetValue() { }

	// RVA: 0x3159544 Offset: 0x3155544 VA: 0x3159544
	public void .ctor(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth) { }
}
