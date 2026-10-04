// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class OrInstruction : Instruction // TypeDefIndex: 15684
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
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317A758 Offset: 0x3176758 VA: 0x317A758 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317A760 Offset: 0x3176760 VA: 0x317A760 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317A768 Offset: 0x3176768 VA: 0x317A768 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317A7A8 Offset: 0x31767A8 VA: 0x317A7A8
	private void .ctor() { }

	// RVA: 0x317A7B0 Offset: 0x31767B0 VA: 0x317A7B0
	public static Instruction Create(Type type) { }
}
