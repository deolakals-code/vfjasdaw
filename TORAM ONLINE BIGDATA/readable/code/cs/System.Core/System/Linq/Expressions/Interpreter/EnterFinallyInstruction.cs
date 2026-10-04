// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 15401
{
	// Fields
	private static readonly EnterFinallyInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedContinuations { get; }

	// Methods

	// RVA: 0x3149DAC Offset: 0x3145DAC VA: 0x3149DAC
	private void .ctor(int labelIndex) { }

	// RVA: 0x3149DD4 Offset: 0x3145DD4 VA: 0x3149DD4 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3149E14 Offset: 0x3145E14 VA: 0x3149E14 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3149E1C Offset: 0x3145E1C VA: 0x3149E1C Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x3149E24 Offset: 0x3145E24 VA: 0x3149E24
	internal static EnterFinallyInstruction Create(int labelIndex) { }

	// RVA: 0x3149F20 Offset: 0x3145F20 VA: 0x3149F20 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3149F8C Offset: 0x3145F8C VA: 0x3149F8C
	private static void .cctor() { }
}
