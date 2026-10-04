// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class MulOvfInstruction : Instruction // TypeDefIndex: 15622
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

	// RVA: 0x31736F4 Offset: 0x316F6F4 VA: 0x31736F4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31736FC Offset: 0x316F6FC VA: 0x31736FC Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3173704 Offset: 0x316F704 VA: 0x3173704 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3173744 Offset: 0x316F744 VA: 0x3173744
	private void .ctor() { }

	// RVA: 0x317374C Offset: 0x316F74C VA: 0x317374C
	public static Instruction Create(Type type) { }
}
