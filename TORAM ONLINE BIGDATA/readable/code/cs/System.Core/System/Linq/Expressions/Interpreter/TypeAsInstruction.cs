// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeAsInstruction : Instruction // TypeDefIndex: 15717
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317E91C Offset: 0x317A91C VA: 0x317E91C
	internal void .ctor(Type type) { }

	// RVA: 0x317E94C Offset: 0x317A94C VA: 0x317E94C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317E954 Offset: 0x317A954 VA: 0x317E954 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317E95C Offset: 0x317A95C VA: 0x317E95C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317E99C Offset: 0x317A99C VA: 0x317E99C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x317EA08 Offset: 0x317AA08 VA: 0x317EA08 Slot: 3
	public override string ToString() { }
}
