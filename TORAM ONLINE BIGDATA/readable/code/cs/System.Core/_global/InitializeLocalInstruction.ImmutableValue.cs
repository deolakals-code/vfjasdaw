// Assembly: System.Core.dll
// Namespace: 
internal sealed class InitializeLocalInstruction.ImmutableValue : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 15585
{
	// Fields
	private readonly object _defaultValue; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3170270 Offset: 0x316C270 VA: 0x3170270
	internal void .ctor(int index, object defaultValue) { }

	// RVA: 0x31702A8 Offset: 0x316C2A8 VA: 0x31702A8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x317031C Offset: 0x316C31C VA: 0x317031C Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x31703DC Offset: 0x316C3DC VA: 0x31703DC Slot: 9
	public override string get_InstructionName() { }
}
