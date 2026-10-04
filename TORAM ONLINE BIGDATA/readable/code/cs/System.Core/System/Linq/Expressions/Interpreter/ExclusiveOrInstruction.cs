// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ExclusiveOrInstruction : Instruction // TypeDefIndex: 15466
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

	// RVA: 0x314E628 Offset: 0x314A628 VA: 0x314E628 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314E630 Offset: 0x314A630 VA: 0x314E630 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x314E638 Offset: 0x314A638 VA: 0x314E638 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314E678 Offset: 0x314A678 VA: 0x314E678
	private void .ctor() { }

	// RVA: 0x314E680 Offset: 0x314A680 VA: 0x314E680
	public static Instruction Create(Type type) { }
}
