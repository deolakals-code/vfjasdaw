// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DarkTalentBuff : GemCartBufferBase, ITalentGemCartBuff // TypeDefIndex: 2253
{
	// Fields
	private byte slotNo; // 0x16

	// Properties
	public override GemCartId Id { get; }

	// Methods

	// RVA: 0x2175F2C Offset: 0x2171F2C VA: 0x2175F2C
	public void .ctor(short lv) { }

	// RVA: 0x21793E0 Offset: 0x21753E0 VA: 0x21793E0 Slot: 4
	public override GemCartId get_Id() { }

	// RVA: 0x21793E8 Offset: 0x21753E8 VA: 0x21793E8 Slot: 10
	protected override int OnGetValue(GemCartBufferId id) { }

	// RVA: 0x21793F0 Offset: 0x21753F0 VA: 0x21793F0 Slot: 13
	public ElementType GetElementType() { }

	// RVA: 0x21793F8 Offset: 0x21753F8 VA: 0x21793F8 Slot: 12
	public byte GetSlotNo() { }

	// RVA: 0x2179400 Offset: 0x2175400 VA: 0x2179400 Slot: 11
	public void SetSlotNo(byte slotNo) { }
}
