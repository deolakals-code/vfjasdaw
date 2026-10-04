// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SierramBuf : SkillBufferDataBase // TypeDefIndex: 3308
{
	// Fields
	private readonly int reducePoisonDamage; // 0x20
	private readonly int reduceIgnitionDamage; // 0x24
	private bool isViewSelfIcon; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override bool IsViewSelfIcon { get; }

	// Methods

	// RVA: 0x234527C Offset: 0x234127C VA: 0x234527C Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2345284 Offset: 0x2341284 VA: 0x2345284 Slot: 5
	public override bool get_IsViewSelfIcon() { }

	// RVA: 0x234528C Offset: 0x234128C VA: 0x234528C
	public void .ctor(byte lv, bool self, int subWeaponType) { }

	// RVA: 0x2345344 Offset: 0x2341344 VA: 0x2345344 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2345374 Offset: 0x2341374 VA: 0x2345374 Slot: 11
	public override void Updata() { }

	// RVA: 0x23453BC Offset: 0x23413BC VA: 0x23453BC
	public void SetViewSelfIcon(bool flag) { }
}
