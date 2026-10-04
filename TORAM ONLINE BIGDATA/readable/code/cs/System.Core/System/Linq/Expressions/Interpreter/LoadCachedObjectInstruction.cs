// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadCachedObjectInstruction : Instruction // TypeDefIndex: 15696
{
	// Fields
	private readonly uint _index; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317C2A0 Offset: 0x31782A0 VA: 0x317C2A0
	internal void .ctor(uint index) { }

	// RVA: 0x317C2C8 Offset: 0x31782C8 VA: 0x317C2C8 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317C2D0 Offset: 0x31782D0 VA: 0x317C2D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317C310 Offset: 0x3178310 VA: 0x317C310 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x317C3B0 Offset: 0x31783B0 VA: 0x317C3B0 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x317C4F4 Offset: 0x31784F4 VA: 0x317C4F4 Slot: 3
	public override string ToString() { }
}
