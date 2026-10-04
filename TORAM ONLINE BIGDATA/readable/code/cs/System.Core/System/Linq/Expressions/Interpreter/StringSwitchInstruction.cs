// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StringSwitchInstruction : Instruction // TypeDefIndex: 15411
{
	// Fields
	private readonly Dictionary<string, int> _cases; // 0x10
	private readonly StrongBox<int> _nullCase; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x314AB98 Offset: 0x3146B98 VA: 0x314AB98
	internal void .ctor(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x314ABDC Offset: 0x3146BDC VA: 0x314ABDC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314AC1C Offset: 0x3146C1C VA: 0x314AC1C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314AC24 Offset: 0x3146C24 VA: 0x314AC24 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
