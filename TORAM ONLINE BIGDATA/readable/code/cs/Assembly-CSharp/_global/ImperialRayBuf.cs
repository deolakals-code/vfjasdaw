// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ImperialRayBuf : SkillBufferDataBase // TypeDefIndex: 3206
{
	// Fields
	private const float Interval = 5;
	private Dictionary<int, bool> targetMobList; // 0x20
	private float timer; // 0x28

	// Properties
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x2335244 Offset: 0x2331244 VA: 0x2335244 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x233524C Offset: 0x233124C VA: 0x233524C
	public void .ctor() { }

	// RVA: 0x23352E8 Offset: 0x23312E8 VA: 0x23352E8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x23352F0 Offset: 0x23312F0 VA: 0x23352F0 Slot: 11
	public override void Updata() { }

	// RVA: 0x23358C4 Offset: 0x23318C4 VA: 0x23358C4
	public void RegisterMobUid(int mobUid, bool critical) { }

	// RVA: 0x2335968 Offset: 0x2331968 VA: 0x2335968
	public void RemoveMobUid(int mobUid) { }

	// RVA: 0x23359C0 Offset: 0x23319C0 VA: 0x23359C0
	public bool CheckMob(int mobUid) { }

	// RVA: 0x2335A18 Offset: 0x2331A18 VA: 0x2335A18
	public bool CheckMob(int mobUid, out bool critical) { }

	// RVA: 0x23353A0 Offset: 0x23313A0 VA: 0x23353A0
	private void UpdateMobUidList() { }
}
