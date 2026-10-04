// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class GreaterThanInstruction : Instruction // TypeDefIndex: 15483
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x314FA0C Offset: 0x314BA0C VA: 0x314FA0C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314FA14 Offset: 0x314BA14 VA: 0x314FA14 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x314FA1C Offset: 0x314BA1C VA: 0x314FA1C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314FA5C Offset: 0x314BA5C VA: 0x314FA5C
	private void .ctor(object nullValue) { }

	// RVA: 0x314FA8C Offset: 0x314BA8C VA: 0x314FA8C
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}
