// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LeftShiftInstruction : Instruction // TypeDefIndex: 15526
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

	// RVA: 0x315B4F0 Offset: 0x31574F0 VA: 0x315B4F0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x315B4F8 Offset: 0x31574F8 VA: 0x315B4F8 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x315B500 Offset: 0x3157500 VA: 0x315B500 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x315B540 Offset: 0x3157540 VA: 0x315B540
	private void .ctor() { }

	// RVA: 0x315626C Offset: 0x315226C VA: 0x315626C
	public static Instruction Create(Type type) { }
}
