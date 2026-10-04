// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LessThanInstruction : Instruction // TypeDefIndex: 15538
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

	// RVA: 0x315BCFC Offset: 0x3157CFC VA: 0x315BCFC Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x315BD04 Offset: 0x3157D04 VA: 0x315BD04 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x315BD0C Offset: 0x3157D0C VA: 0x315BD0C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x315BD4C Offset: 0x3157D4C VA: 0x315BD4C
	private void .ctor(object nullValue) { }

	// RVA: 0x3156688 Offset: 0x3152688 VA: 0x3156688
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}
