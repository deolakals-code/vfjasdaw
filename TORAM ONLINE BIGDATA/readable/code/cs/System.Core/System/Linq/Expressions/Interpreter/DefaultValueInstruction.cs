// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DefaultValueInstruction : Instruction // TypeDefIndex: 15421
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x314B664 Offset: 0x3147664 VA: 0x314B664
	internal void .ctor(Type type) { }

	// RVA: 0x314B694 Offset: 0x3147694 VA: 0x314B694 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x314B69C Offset: 0x314769C VA: 0x314B69C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314B6DC Offset: 0x31476DC VA: 0x314B6DC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x314B714 Offset: 0x3147714 VA: 0x314B714 Slot: 3
	public override string ToString() { }
}
