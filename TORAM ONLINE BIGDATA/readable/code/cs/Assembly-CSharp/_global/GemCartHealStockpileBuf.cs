// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class GemCartHealStockpileBuf : CountBufferBase // TypeDefIndex: 3175
{
	// Fields
	private PlayerStatusBase status; // 0x28

	// Properties
	public override CountBufferBase.CountType BufferType { get; }
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x232F9D0 Offset: 0x232B9D0 VA: 0x232F9D0 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x232F9D8 Offset: 0x232B9D8 VA: 0x232F9D8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232F9E0 Offset: 0x232B9E0 VA: 0x232F9E0
	public void .ctor(byte lv, int count, PlayerStatusBase status) { }

	// RVA: 0x232FA20 Offset: 0x232BA20 VA: 0x232FA20 Slot: 11
	public override void Updata() { }

	// RVA: 0x232FA70 Offset: 0x232BA70 VA: 0x232FA70
	public void UseStock(int use) { }
}
