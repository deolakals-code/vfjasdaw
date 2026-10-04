// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NegateCheckedInstruction : Instruction // TypeDefIndex: 15632
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3174D6C Offset: 0x3170D6C VA: 0x3174D6C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3174D74 Offset: 0x3170D74 VA: 0x3174D74 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3174D7C Offset: 0x3170D7C VA: 0x3174D7C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3174DBC Offset: 0x3170DBC VA: 0x3174DBC
	private void .ctor() { }

	// RVA: 0x3174DC4 Offset: 0x3170DC4 VA: 0x3174DC4
	public static Instruction Create(Type type) { }
}
