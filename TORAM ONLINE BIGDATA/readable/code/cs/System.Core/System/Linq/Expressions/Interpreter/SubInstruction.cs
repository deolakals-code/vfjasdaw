// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class SubInstruction : Instruction // TypeDefIndex: 15707
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

	// RVA: 0x317C728 Offset: 0x3178728 VA: 0x317C728 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317C730 Offset: 0x3178730 VA: 0x317C730 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317C738 Offset: 0x3178738 VA: 0x317C738 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317C778 Offset: 0x3178778 VA: 0x317C778
	private void .ctor() { }

	// RVA: 0x317C780 Offset: 0x3178780 VA: 0x317C780
	public static Instruction Create(Type type) { }
}
