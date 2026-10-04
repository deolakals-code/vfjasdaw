// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NotInstruction : Instruction // TypeDefIndex: 15669
{
	// Fields
	public static Instruction s_Boolean; // 0x0
	public static Instruction s_Int64; // 0x8
	public static Instruction s_Int32; // 0x10
	public static Instruction s_Int16; // 0x18
	public static Instruction s_UInt64; // 0x20
	public static Instruction s_UInt32; // 0x28
	public static Instruction s_UInt16; // 0x30
	public static Instruction s_Byte; // 0x38
	public static Instruction s_SByte; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3177980 Offset: 0x3173980 VA: 0x3177980
	private void .ctor() { }

	// RVA: 0x3177988 Offset: 0x3173988 VA: 0x3177988 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3177990 Offset: 0x3173990 VA: 0x3177990 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3177998 Offset: 0x3173998 VA: 0x3177998 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31779D8 Offset: 0x31739D8 VA: 0x31779D8
	public static Instruction Create(Type type) { }
}
