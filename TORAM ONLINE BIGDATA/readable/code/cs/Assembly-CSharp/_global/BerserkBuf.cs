// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BerserkBuf : SkillBufferDataBase // TypeDefIndex: 3079
{
	// Fields
	private int normalAttackRate; // 0x20
	private int aspd; // 0x24
	private int aspdRate; // 0x28
	private int critical; // 0x2C
	private int stable; // 0x30
	private int defRate; // 0x34
	private int damageCount; // 0x38
	private byte reduceValue; // 0x3C

	// Properties
	public override SkillId SkillId { get; }

	// Methods

	// RVA: 0x231EB88 Offset: 0x231AB88 VA: 0x231EB88 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x231EB90 Offset: 0x231AB90 VA: 0x231EB90
	public void .ctor(byte lv) { }

	// RVA: 0x231EC60 Offset: 0x231AC60 VA: 0x231EC60
	public void .ctor(byte lv, byte gemCartValue, ItemDBData.ItemType mainWeapon, ItemDBData.ItemType subWeapon) { }

	// RVA: 0x231ED10 Offset: 0x231AD10 VA: 0x231ED10 Slot: 11
	public override void Updata() { }

	// RVA: 0x231ED64 Offset: 0x231AD64 VA: 0x231ED64 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x231EE08 Offset: 0x231AE08 VA: 0x231EE08 Slot: 13
	public override void OnDamage(PlayerActionManagerBase playerAction) { }
}
