// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WindTalentBuff : GemCartBufferBase, ITalentGemCartBuff // TypeDefIndex: 2265
{
	// Fields
	private byte slotNo; // 0x16

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x2175EB4 Offset: 0x2171EB4 VA: 0x2175EB4
	public void .ctor(short lv) { }

	// RVA: 0x217953C Offset: 0x217553C VA: 0x217953C Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x2179544 Offset: 0x2175544 VA: 0x2179544 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }

	// RVA: 0x217954C Offset: 0x217554C VA: 0x217954C Slot: 13
	public ElementType GetElementType() { }

	// RVA: 0x2179554 Offset: 0x2175554 VA: 0x2179554 Slot: 12
	public byte GetSlotNo() { }

	// RVA: 0x217955C Offset: 0x217555C VA: 0x217955C Slot: 11
	public void SetSlotNo(byte slotNo) { }
}
