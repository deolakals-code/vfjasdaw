// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ModuloInstruction : Instruction // TypeDefIndex: 15606
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31717D4 Offset: 0x316D7D4 VA: 0x31717D4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31717DC Offset: 0x316D7DC VA: 0x31717DC Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31717E4 Offset: 0x316D7E4 VA: 0x31717E4 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3171824 Offset: 0x316D824 VA: 0x3171824
	private void .ctor() { }

	// RVA: 0x317182C Offset: 0x316D82C VA: 0x317182C
	public static Instruction Create(Type type) { }
}
