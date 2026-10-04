// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AndInstruction : Instruction // TypeDefIndex: 15379
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

	// RVA: 0x3145644 Offset: 0x3141644 VA: 0x3145644 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314564C Offset: 0x314164C VA: 0x314564C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3145654 Offset: 0x3141654 VA: 0x3145654 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3145694 Offset: 0x3141694 VA: 0x3145694
	private void .ctor() { }

	// RVA: 0x314569C Offset: 0x314169C VA: 0x314569C
	public static Instruction Create(Type type) { }
}
