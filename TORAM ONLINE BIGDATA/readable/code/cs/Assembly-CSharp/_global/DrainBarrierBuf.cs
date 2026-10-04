// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DrainBarrierBuf : SkillBufferDataBase // TypeDefIndex: 3131
{
	// Fields
	private readonly byte skillLocalId; // 0x1D
	private readonly int damageCut; // 0x20
	private readonly int mpHeal; // 0x24
	private readonly int bonusMpHeal; // 0x28
	private readonly int maxStackMpHeal; // 0x2C
	private int stackMpHeal; // 0x30
	private List<MobAttackBase> damageCutAttackList; // 0x38

	// Properties
	public override SkillId SkillId { get; }
	public byte SkillLocalId { get; }

	// Methods

	// RVA: 0x2329B90 Offset: 0x2325B90 VA: 0x2329B90
	public void .ctor(byte lv, PlayerStatusBase status, byte localId) { }

	// RVA: 0x2329D14 Offset: 0x2325D14 VA: 0x2329D14 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2329D1C Offset: 0x2325D1C VA: 0x2329D1C
	public byte get_SkillLocalId() { }

	// RVA: 0x2329D24 Offset: 0x2325D24 VA: 0x2329D24 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2329D4C Offset: 0x2325D4C VA: 0x2329D4C Slot: 11
	public override void Updata() { }

	// RVA: 0x2329D50 Offset: 0x2325D50 VA: 0x2329D50
	public int GetMpHeal(bool magicAttack) { }

	// RVA: 0x2329D7C Offset: 0x2325D7C VA: 0x2329D7C
	public void Stack(int mpHealValue) { }

	// RVA: 0x2329D94 Offset: 0x2325D94 VA: 0x2329D94
	public int GetTotalMpHealValue() { }

	// RVA: 0x2329D9C Offset: 0x2325D9C VA: 0x2329D9C
	public void SuccessDamageCut(MobAttackBase mobAttack) { }

	// RVA: 0x2329E48 Offset: 0x2325E48 VA: 0x2329E48
	public bool CheckDamageCutMobAttack(MobAttackBase mobAttack) { }
}
