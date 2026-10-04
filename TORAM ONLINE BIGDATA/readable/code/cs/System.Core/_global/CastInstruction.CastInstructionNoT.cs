// Assembly: System.Core.dll
// Namespace: 
private abstract class CastInstruction.CastInstructionNoT : CastInstruction // TypeDefIndex: 15730
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x317FAF8 Offset: 0x317BAF8 VA: 0x317FAF8
	protected void .ctor(Type t) { }

	// RVA: 0x317FA24 Offset: 0x317BA24 VA: 0x317FA24
	public static CastInstruction Create(Type t) { }

	// RVA: 0x317FB88 Offset: 0x317BB88 VA: 0x317FB88 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void ConvertNull(InterpretedFrame frame);
}
