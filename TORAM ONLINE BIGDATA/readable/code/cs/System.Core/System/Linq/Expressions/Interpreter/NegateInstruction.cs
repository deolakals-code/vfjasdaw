// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NegateInstruction : Instruction // TypeDefIndex: 15628
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_Single; // 0x18
	private static Instruction s_Double; // 0x20

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317470C Offset: 0x317070C VA: 0x317470C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3174714 Offset: 0x3170714 VA: 0x3174714 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317471C Offset: 0x317071C VA: 0x317471C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317475C Offset: 0x317075C VA: 0x317475C
	private void .ctor() { }

	// RVA: 0x3174764 Offset: 0x3170764 VA: 0x3174764
	public static Instruction Create(Type type) { }
}
