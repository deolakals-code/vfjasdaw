// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class IncrementInstruction : Instruction // TypeDefIndex: 15504
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

	// RVA: 0x3152724 Offset: 0x314E724 VA: 0x3152724 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x315272C Offset: 0x314E72C VA: 0x315272C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3152734 Offset: 0x314E734 VA: 0x3152734 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3152774 Offset: 0x314E774 VA: 0x3152774
	private void .ctor() { }

	// RVA: 0x315277C Offset: 0x314E77C VA: 0x315277C
	public static Instruction Create(Type type) { }
}
