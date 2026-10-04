// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class DivInstruction : Instruction // TypeDefIndex: 15430
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

	// RVA: 0x314B780 Offset: 0x3147780 VA: 0x314B780 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314B788 Offset: 0x3147788 VA: 0x314B788 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x314B790 Offset: 0x3147790 VA: 0x314B790 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314B7D0 Offset: 0x31477D0 VA: 0x314B7D0
	private void .ctor() { }

	// RVA: 0x314B7D8 Offset: 0x31477D8 VA: 0x314B7D8
	public static Instruction Create(Type type) { }
}
