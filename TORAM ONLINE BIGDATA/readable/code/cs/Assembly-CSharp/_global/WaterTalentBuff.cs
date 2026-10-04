// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WaterTalentBuff : GemCartBufferBase, ITalentGemCartBuff // TypeDefIndex: 2264
{
	// Fields
	private byte slotNo; // 0x16

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x2175E8C Offset: 0x2171E8C VA: 0x2175E8C
	public void .ctor(short lv) { }

	// RVA: 0x2179514 Offset: 0x2175514 VA: 0x2179514 Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x217951C Offset: 0x217551C VA: 0x217951C Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }

	// RVA: 0x2179524 Offset: 0x2175524 VA: 0x2179524 Slot: 13
	public ElementType GetElementType() { }

	// RVA: 0x217952C Offset: 0x217552C VA: 0x217952C Slot: 12
	public byte GetSlotNo() { }

	// RVA: 0x2179534 Offset: 0x2175534 VA: 0x2179534 Slot: 11
	public void SetSlotNo(byte slotNo) { }
}
