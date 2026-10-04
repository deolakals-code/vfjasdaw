// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class GetArrayItemInstruction : Instruction // TypeDefIndex: 15383
{
	// Fields
	internal static readonly GetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x314682C Offset: 0x314282C VA: 0x314682C
	private void .ctor() { }

	// RVA: 0x3146834 Offset: 0x3142834 VA: 0x3146834 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314683C Offset: 0x314283C VA: 0x314683C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3146844 Offset: 0x3142844 VA: 0x3146844 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3146884 Offset: 0x3142884 VA: 0x3146884 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3146940 Offset: 0x3142940 VA: 0x3146940
	private static void .cctor() { }
}
