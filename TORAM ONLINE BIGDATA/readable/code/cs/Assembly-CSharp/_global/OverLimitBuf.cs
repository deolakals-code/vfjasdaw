// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class OverLimitBuf : SkillBufferDataBase // TypeDefIndex: 3262
{
	// Fields
	private PlayerStatusBase playerStatus; // 0x20

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2340308 Offset: 0x233C308 VA: 0x2340308 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2340310 Offset: 0x233C310 VA: 0x2340310 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2340318 Offset: 0x233C318 VA: 0x2340318
	public void .ctor(byte lv, PlayerStatusBase status) { }

	// RVA: 0x2340368 Offset: 0x233C368 VA: 0x2340368 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2340498 Offset: 0x233C498 VA: 0x2340498 Slot: 11
	public override void Updata() { }
}
