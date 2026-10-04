// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NotEqualInstruction : Instruction // TypeDefIndex: 15659
{
	// Fields
	private static Instruction s_reference; // 0x0
	private static Instruction s_Boolean; // 0x8
	private static Instruction s_SByte; // 0x10
	private static Instruction s_Int16; // 0x18
	private static Instruction s_Char; // 0x20
	private static Instruction s_Int32; // 0x28
	private static Instruction s_Int64; // 0x30
	private static Instruction s_Byte; // 0x38
	private static Instruction s_UInt16; // 0x40
	private static Instruction s_UInt32; // 0x48
	private static Instruction s_UInt64; // 0x50
	private static Instruction s_Single; // 0x58
	private static Instruction s_Double; // 0x60
	private static Instruction s_SByteLiftedToNull; // 0x68
	private static Instruction s_Int16LiftedToNull; // 0x70
	private static Instruction s_CharLiftedToNull; // 0x78
	private static Instruction s_Int32LiftedToNull; // 0x80
	private static Instruction s_Int64LiftedToNull; // 0x88
	private static Instruction s_ByteLiftedToNull; // 0x90
	private static Instruction s_UInt16LiftedToNull; // 0x98
	private static Instruction s_UInt32LiftedToNull; // 0xA0
	private static Instruction s_UInt64LiftedToNull; // 0xA8
	private static Instruction s_SingleLiftedToNull; // 0xB0
	private static Instruction s_DoubleLiftedToNull; // 0xB8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3175AB0 Offset: 0x3171AB0 VA: 0x3175AB0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3175AB8 Offset: 0x3171AB8 VA: 0x3175AB8 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3175AC0 Offset: 0x3171AC0 VA: 0x3175AC0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3175B00 Offset: 0x3171B00 VA: 0x3175B00
	private void .ctor() { }

	// RVA: 0x3175B08 Offset: 0x3171B08 VA: 0x3175B08
	public static Instruction Create(Type type, bool liftedToNull) { }
}
