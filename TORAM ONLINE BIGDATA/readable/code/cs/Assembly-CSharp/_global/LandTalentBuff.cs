// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LandTalentBuff : GemCartBufferBase, ITalentGemCartBuff // TypeDefIndex: 2259
{
	// Fields
	private byte slotNo; // 0x16

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x2175EDC Offset: 0x2171EDC VA: 0x2175EDC
	public void .ctor(short lv) { }

	// RVA: 0x2179484 Offset: 0x2175484 VA: 0x2179484 Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x217948C Offset: 0x217548C VA: 0x217948C Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }

	// RVA: 0x2179494 Offset: 0x2175494 VA: 0x2179494 Slot: 13
	public ElementType GetElementType() { }

	// RVA: 0x217949C Offset: 0x217549C VA: 0x217949C Slot: 12
	public byte GetSlotNo() { }

	// RVA: 0x21794A4 Offset: 0x21754A4 VA: 0x21794A4 Slot: 11
	public void SetSlotNo(byte slotNo) { }
}
