// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LightTalentBuff : GemCartBufferBase, ITalentGemCartBuff // TypeDefIndex: 2261
{
	// Fields
	private byte slotNo; // 0x16

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x2175F04 Offset: 0x2171F04 VA: 0x2175F04
	public void .ctor(short lv) { }

	// RVA: 0x21794BC Offset: 0x21754BC VA: 0x21794BC Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x21794C4 Offset: 0x21754C4 VA: 0x21794C4 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }

	// RVA: 0x21794CC Offset: 0x21754CC VA: 0x21794CC Slot: 13
	public ElementType GetElementType() { }

	// RVA: 0x21794D4 Offset: 0x21754D4 VA: 0x21794D4 Slot: 12
	public byte GetSlotNo() { }

	// RVA: 0x21794DC Offset: 0x21754DC VA: 0x21794DC Slot: 11
	public void SetSlotNo(byte slotNo) { }
}
