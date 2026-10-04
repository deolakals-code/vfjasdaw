// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeEqualsInstruction : Instruction // TypeDefIndex: 15718
{
	// Fields
	public static readonly TypeEqualsInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317EA70 Offset: 0x317AA70 VA: 0x317EA70 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317EA78 Offset: 0x317AA78 VA: 0x317EA78 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317EA80 Offset: 0x317AA80 VA: 0x317EA80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317EAC0 Offset: 0x317AAC0 VA: 0x317EAC0
	private void .ctor() { }

	// RVA: 0x317EAC8 Offset: 0x317AAC8 VA: 0x317EAC8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x317EB28 Offset: 0x317AB28 VA: 0x317EB28
	private static void .cctor() { }
}
