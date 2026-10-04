// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CreateDelegateInstruction : Instruction // TypeDefIndex: 15715
{
	// Fields
	private readonly LightDelegateCreator _creator; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317E5BC Offset: 0x317A5BC VA: 0x317E5BC
	internal void .ctor(LightDelegateCreator delegateCreator) { }

	// RVA: 0x317E5EC Offset: 0x317A5EC VA: 0x317E5EC Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317E610 Offset: 0x317A610 VA: 0x317E610 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317E618 Offset: 0x317A618 VA: 0x317E618 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317E658 Offset: 0x317A658 VA: 0x317E658 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
