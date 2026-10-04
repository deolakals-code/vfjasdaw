// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DualBringerBuf : SkillBufferDataBase // TypeDefIndex: 3134
{
	// Fields
	private readonly PlayerStatusBase status; // 0x20
	private readonly int amplificationFactor; // 0x28
	private readonly int criticalPercent; // 0x2C
	private readonly int criticalDamage; // 0x30
	private bool isIntBonus; // 0x34

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2329F84 Offset: 0x2325F84 VA: 0x2329F84
	public void .ctor(byte lv, PlayerStatusBase status) { }

	// RVA: 0x232A084 Offset: 0x2326084 VA: 0x232A084 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232A08C Offset: 0x232608C VA: 0x232A08C Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232A094 Offset: 0x2326094 VA: 0x232A094 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232A0C4 Offset: 0x23260C4 VA: 0x232A0C4 Slot: 11
	public override void Updata() { }

	// RVA: 0x232A118 Offset: 0x2326118 VA: 0x232A118
	public DualBringerBuf.ResultType CheckBonus() { }

	// RVA: 0x232A25C Offset: 0x232625C VA: 0x232A25C
	public int GetAmplificationFactor() { }

	// RVA: 0x232A270 Offset: 0x2326270 VA: 0x232A270
	public void CalcBaseAtk(PlayerStatusBase status, ref int atk, ref int matk) { }

	// RVA: 0x232A474 Offset: 0x2326474 VA: 0x232A474
	public int GetCriticalPercent() { }

	// RVA: 0x232A47C Offset: 0x232647C VA: 0x232A47C
	public int GetCriticalDamage() { }

	// RVA: 0x232A484 Offset: 0x2326484 VA: 0x232A484
	public void ValidIntBonus() { }

	// RVA: 0x232A490 Offset: 0x2326490 VA: 0x232A490
	public void InvalidIntBonus() { }

	// RVA: 0x232A498 Offset: 0x2326498 VA: 0x232A498
	public static bool CheckActive(PlayerAttackBase skill, PlayerStatusBase status) { }
}
