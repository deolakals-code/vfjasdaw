// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FireTalentBuff : GemCartBufferBase, ITalentGemCartBuff // TypeDefIndex: 2255
{
	// Fields
	private byte slotNo; // 0x16

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x2175E64 Offset: 0x2171E64 VA: 0x2175E64
	public void .ctor(short lv) { }

	// RVA: 0x217942C Offset: 0x217542C VA: 0x217942C Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x2179434 Offset: 0x2175434 VA: 0x2179434 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }

	// RVA: 0x217943C Offset: 0x217543C VA: 0x217943C Slot: 13
	public ElementType GetElementType() { }

	// RVA: 0x2179444 Offset: 0x2175444 VA: 0x2179444 Slot: 12
	public byte GetSlotNo() { }

	// RVA: 0x217944C Offset: 0x217544C VA: 0x217944C Slot: 11
	public void SetSlotNo(byte slotNo) { }
}
