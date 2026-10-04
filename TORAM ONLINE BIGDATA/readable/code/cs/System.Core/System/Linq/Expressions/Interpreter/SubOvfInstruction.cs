// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class SubOvfInstruction : Instruction // TypeDefIndex: 15714
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

	// RVA: 0x317D604 Offset: 0x3179604 VA: 0x317D604 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317D60C Offset: 0x317960C VA: 0x317D60C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317D614 Offset: 0x3179614 VA: 0x317D614 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317D654 Offset: 0x3179654 VA: 0x317D654
	private void .ctor() { }

	// RVA: 0x317D65C Offset: 0x317965C VA: 0x317D65C
	public static Instruction Create(Type type) { }
}
