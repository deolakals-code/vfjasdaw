// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AddInstruction : Instruction // TypeDefIndex: 15362
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

	// RVA: 0x3143774 Offset: 0x313F774 VA: 0x3143774 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314377C Offset: 0x313F77C VA: 0x314377C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3143784 Offset: 0x313F784 VA: 0x3143784 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31437C4 Offset: 0x313F7C4 VA: 0x31437C4
	private void .ctor() { }

	// RVA: 0x31437CC Offset: 0x313F7CC VA: 0x31437CC
	public static Instruction Create(Type type) { }
}
