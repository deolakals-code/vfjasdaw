// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DestroyerBuf : SkillBufferDataBase // TypeDefIndex: 3124
{
	// Fields
	private readonly PlayerStatusBase status; // 0x20
	private bool isMainKnuckleEquip; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public bool IsMainKnuckleEquip { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2329388 Offset: 0x2325388 VA: 0x2329388 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2329390 Offset: 0x2325390 VA: 0x2329390
	public bool get_IsMainKnuckleEquip() { }

	// RVA: 0x2329398 Offset: 0x2325398 VA: 0x2329398 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x23293A0 Offset: 0x23253A0 VA: 0x23293A0
	public void .ctor(byte lv, PlayerStatusBase status) { }

	// RVA: 0x23293E4 Offset: 0x23253E4 VA: 0x23293E4 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2329468 Offset: 0x2325468 VA: 0x2329468 Slot: 11
	public override void Updata() { }
}
