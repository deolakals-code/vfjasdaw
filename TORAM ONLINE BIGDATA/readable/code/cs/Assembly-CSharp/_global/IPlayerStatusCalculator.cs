// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IPlayerStatusCalculator // TypeDefIndex: 1387
{
	// Properties
	public abstract int Lv { get; }
	public abstract int Str { get; }
	public abstract int Int { get; }
	public abstract int Vit { get; }
	public abstract int Agi { get; }
	public abstract int Dex { get; }
	public abstract int Crt { get; }
	public abstract int Luk { get; }
	public abstract int Men { get; }
	public abstract int Tec { get; }
	public abstract int MaxHp { get; }
	public abstract int MaxMp { get; }
	public abstract int EqAtk { get; }
	public abstract int SubEqAtk { get; }
	public abstract int Atk { get; }
	public abstract int Stable { get; }
	public abstract int Matk { get; }
	public abstract int Hit { get; }
	public abstract int Flee { get; }
	public abstract int Def { get; }
	public abstract int Mdef { get; }
	public abstract int EqDef { get; }
	public abstract int Aspd { get; }
	public abstract int Cspd { get; }
	public abstract int HpRecovery { get; }
	public abstract int MpRecovery { get; }
	public abstract int AtkMpRecovery { get; }
	public abstract int Critical { get; }
	public abstract int CriticalDmg { get; }
	public abstract int CriticalMagicDmg { get; }
	public abstract int ElementPower { get; }
	public abstract int AntiVirus { get; }
	public abstract int GuardDelay { get; }
	public abstract int GuardPower { get; }
	public abstract int GuardSpeed { get; }
	public abstract int AvoidSpeed { get; }
	public abstract int AvoidStack { get; }
	public abstract int AvoidDelay { get; }
	public abstract int Respawn { get; }
	public abstract int SubAtk { get; }
	public abstract int SubStable { get; }
	public abstract int SubMatk { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Lv();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Str();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_Int();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_Vit();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_Agi();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_Dex();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Crt();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Luk();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Men();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract int get_Tec();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_MaxHp();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_MaxMp();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_EqAtk();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int get_SubEqAtk();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int get_Atk();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int get_Stable();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int get_Matk();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int get_Hit();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int get_Flee();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int get_Def();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract int get_Mdef();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int get_EqDef();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract int get_Aspd();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int get_Cspd();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int get_HpRecovery();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract int get_MpRecovery();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract int get_AtkMpRecovery();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract int get_Critical();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract int get_CriticalDmg();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int get_CriticalMagicDmg();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract int get_ElementPower();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract int get_AntiVirus();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int get_GuardDelay();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract int get_GuardPower();

	// RVA: -1 Offset: -1 Slot: 34
	public abstract int get_GuardSpeed();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract int get_AvoidSpeed();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract int get_AvoidStack();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract int get_AvoidDelay();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract int get_Respawn();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract int get_SubAtk();

	// RVA: -1 Offset: -1 Slot: 40
	public abstract int get_SubStable();

	// RVA: -1 Offset: -1 Slot: 41
	public abstract int get_SubMatk();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract int GetDefFact(int def);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract int GetMdefFact(int mdef);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract int GetDamageCut(int damage);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract float GetNextAtkTime(int aspd);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract int GetMotionSpeed(int aspd);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract int GetSkillDelayRate1(int cspd);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract int GetSkillDelayRate2(int cspd);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract void SetGuildStatusBoost(byte type, int rate);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract int CalcBaseGuardPower();
}
