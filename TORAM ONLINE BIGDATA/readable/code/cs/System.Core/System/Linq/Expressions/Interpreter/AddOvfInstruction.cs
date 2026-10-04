// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AddOvfInstruction : Instruction // TypeDefIndex: 15369
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3144654 Offset: 0x3140654 VA: 0x3144654 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314465C Offset: 0x314065C VA: 0x314465C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3144664 Offset: 0x3140664 VA: 0x3144664 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31446A4 Offset: 0x31406A4 VA: 0x31446A4
	private void .ctor() { }

	// RVA: 0x31446AC Offset: 0x31406AC VA: 0x31446AC
	public static Instruction Create(Type type) { }
}
