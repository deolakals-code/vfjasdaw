// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class GotoInstruction : IndexedBranchInstruction // TypeDefIndex: 15398
{
	// Fields
	private static readonly GotoInstruction[] s_cache; // 0x0
	private readonly bool _hasResult; // 0x14
	private readonly bool _hasValue; // 0x15
	private readonly bool _labelTargetGetsValue; // 0x16

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3149124 Offset: 0x3145124 VA: 0x3149124 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3149164 Offset: 0x3145164 VA: 0x3149164 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314916C Offset: 0x314516C VA: 0x314916C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3149174 Offset: 0x3145174 VA: 0x3149174
	private void .ctor(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x31491BC Offset: 0x31451BC VA: 0x31491BC
	internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x314932C Offset: 0x314532C VA: 0x314932C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x31493F4 Offset: 0x31453F4 VA: 0x31493F4
	private static void .cctor() { }
}
