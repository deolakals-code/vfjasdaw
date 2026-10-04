// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class RightShiftInstruction : Instruction // TypeDefIndex: 15693
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317B4D8 Offset: 0x31774D8 VA: 0x317B4D8 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317B4E0 Offset: 0x31774E0 VA: 0x317B4E0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317B4E8 Offset: 0x31774E8 VA: 0x317B4E8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317B528 Offset: 0x3177528 VA: 0x317B528
	private void .ctor() { }

	// RVA: 0x317B530 Offset: 0x3177530 VA: 0x317B530
	public static Instruction Create(Type type) { }
}
