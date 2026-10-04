// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ClearAndSereneBuf : NextAttackBufferBase // TypeDefIndex: 3100
{
	// Fields
	private int critical; // 0x2C
	private int criticalDamageRate; // 0x30
	private int def; // 0x34

	// Properties
	public override SkillId SkillId { get; }
	public override CountBufferBase.CountType BufferType { get; }

	// Methods

	// RVA: 0x23228C0 Offset: 0x231E8C0 VA: 0x23228C0 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x23228C8 Offset: 0x231E8C8 VA: 0x23228C8 Slot: 22
	public override CountBufferBase.CountType get_BufferType() { }

	// RVA: 0x23228D0 Offset: 0x231E8D0 VA: 0x23228D0
	public void .ctor(byte lv) { }

	// RVA: 0x2322934 Offset: 0x231E934 VA: 0x2322934 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2322988 Offset: 0x231E988 VA: 0x2322988 Slot: 11
	public override void Updata() { }

	// RVA: 0x23229D8 Offset: 0x231E9D8 VA: 0x23229D8
	public void SetEquipType(ItemDBData.ItemType type) { }
}
