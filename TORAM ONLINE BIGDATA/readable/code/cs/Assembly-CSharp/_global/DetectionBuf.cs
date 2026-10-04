// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class DetectionBuf : SkillBufferDataBase // TypeDefIndex: 3125
{
	// Fields
	private int critical; // 0x20
	private int hateRate; // 0x24

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x23294E4 Offset: 0x23254E4 VA: 0x23294E4 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23294EC Offset: 0x23254EC VA: 0x23294EC Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x23294F4 Offset: 0x23254F4 VA: 0x23294F4
	public void .ctor(byte lv) { }

	// RVA: 0x2329534 Offset: 0x2325534 VA: 0x2329534 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232954C Offset: 0x232554C VA: 0x232954C Slot: 11
	public override void Updata() { }

	// RVA: 0x23295A0 Offset: 0x23255A0 VA: 0x23295A0
	public int GetHateBonus(PlayerStatusBase status) { }
}
