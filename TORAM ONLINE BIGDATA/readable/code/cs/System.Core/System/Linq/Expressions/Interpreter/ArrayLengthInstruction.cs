// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ArrayLengthInstruction : Instruction // TypeDefIndex: 15385
{
	// Fields
	public static readonly ArrayLengthInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3146B20 Offset: 0x3142B20 VA: 0x3146B20 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3146B28 Offset: 0x3142B28 VA: 0x3146B28 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3146B30 Offset: 0x3142B30 VA: 0x3146B30 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3146B70 Offset: 0x3142B70 VA: 0x3146B70
	private void .ctor() { }

	// RVA: 0x3146B78 Offset: 0x3142B78 VA: 0x3146B78 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3146C1C Offset: 0x3142C1C VA: 0x3146C1C
	private static void .cctor() { }
}
