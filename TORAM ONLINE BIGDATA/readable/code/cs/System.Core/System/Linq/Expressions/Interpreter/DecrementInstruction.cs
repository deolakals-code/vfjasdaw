// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class DecrementInstruction : Instruction // TypeDefIndex: 15420
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

	// RVA: 0x314ACF0 Offset: 0x3146CF0 VA: 0x314ACF0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314ACF8 Offset: 0x3146CF8 VA: 0x314ACF8 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x314AD00 Offset: 0x3146D00 VA: 0x314AD00 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314AD40 Offset: 0x3146D40 VA: 0x314AD40
	private void .ctor() { }

	// RVA: 0x314AD48 Offset: 0x3146D48 VA: 0x314AD48
	public static Instruction Create(Type type) { }
}
