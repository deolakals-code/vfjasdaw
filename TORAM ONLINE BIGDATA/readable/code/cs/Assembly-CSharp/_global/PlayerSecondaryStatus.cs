// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PlayerSecondaryStatus : IPlayerStatusCalculator // TypeDefIndex: 1465
{
	// Fields
	private PlayerStatusBase playerStatus; // 0x10
	private GuildBoosterType guildStatusBoostType; // 0x18
	private int guildStatusBoostRate; // 0x1C
	private int levelLimit; // 0x20
	private int prevCspd; // 0x24

	// Properties
	public int Lv { get; }
	public int Str { get; }
	public int Int { get; }
	public int Vit { get; }
	public int Agi { get; }
	public int Dex { get; }
	public int Crt { get; }
	public int Luk { get; }
	public int Men { get; }
	public int Tec { get; }
	public int MaxHp { get; }
	public int MaxMp { get; }
	public int EqAtk { get; }
	public int SubEqAtk { get; }
	public int Atk { get; }
	public int Stable { get; }
	public int Matk { get; }
	public int Hit { get; }
	public int CurrectHit { get; }
	public int Flee { get; }
	public int Def { get; }
	public int Mdef { get; }
	public int EqDef { get; }
	public int Aspd { get; }
	public int Cspd { get; }
	public int HpRecovery { get; }
	public int MpRecovery { get; }
	public int AtkMpRecovery { get; }
	public int Critical { get; }
	public int CriticalDmg { get; }
	public int CriticalMagicDmg { get; }
	public int ElementPower { get; }
	public int AntiVirus { get; }
	public int GuardDelay { get; }
	public int GuardPower { get; }
	public int GuardSpeed { get; }
	public int AvoidSpeed { get; }
	public int AvoidStack { get; }
	public int AvoidDelay { get; }
	public int Respawn { get; }
	public int SubAtk { get; }
	public int SubStable { get; }
	public int SubMatk { get; }

	// Methods

	[IteratorStateMachine(typeof(PlayerSecondaryStatus.<GetParam>d__5))]
	// RVA: 0x204B894 Offset: 0x2047894 VA: 0x204B894
	public IEnumerable<string> GetParam() { }

	[IteratorStateMachine(typeof(PlayerSecondaryStatus.<GetItemBonusParam>d__6))]
	// RVA: 0x204B8EC Offset: 0x20478EC VA: 0x204B8EC
	public IEnumerable<string> GetItemBonusParam() { }

	[IteratorStateMachine(typeof(PlayerSecondaryStatus.<GetDurationBonusTime>d__7))]
	// RVA: 0x204B944 Offset: 0x2047944 VA: 0x204B944
	public IEnumerable<string> GetDurationBonusTime() { }

	// RVA: 0x204B99C Offset: 0x204799C VA: 0x204B99C
	public void .ctor(PlayerStatusBase status) { }

	// RVA: 0x204B9CC Offset: 0x20479CC VA: 0x204B9CC Slot: 4
	public int get_Lv() { }

	// RVA: 0x204B9F8 Offset: 0x20479F8 VA: 0x204B9F8 Slot: 5
	public int get_Str() { }

	// RVA: 0x204BAF0 Offset: 0x2047AF0 VA: 0x204BAF0 Slot: 6
	public int get_Int() { }

	// RVA: 0x204BB2C Offset: 0x2047B2C VA: 0x204BB2C Slot: 7
	public int get_Vit() { }

	// RVA: 0x204BBC0 Offset: 0x2047BC0 VA: 0x204BBC0 Slot: 8
	public int get_Agi() { }

	// RVA: 0x204BC90 Offset: 0x2047C90 VA: 0x204BC90 Slot: 9
	public int get_Dex() { }

	// RVA: 0x204BCCC Offset: 0x2047CCC VA: 0x204BCCC Slot: 10
	public int get_Crt() { }

	// RVA: 0x204BCF8 Offset: 0x2047CF8 VA: 0x204BCF8 Slot: 11
	public int get_Luk() { }

	// RVA: 0x204BD24 Offset: 0x2047D24 VA: 0x204BD24 Slot: 12
	public int get_Men() { }

	// RVA: 0x204BD50 Offset: 0x2047D50 VA: 0x204BD50 Slot: 13
	public int get_Tec() { }

	// RVA: 0x204BD7C Offset: 0x2047D7C VA: 0x204BD7C Slot: 14
	public int get_MaxHp() { }

	// RVA: 0x204C20C Offset: 0x204820C VA: 0x204C20C Slot: 15
	public int get_MaxMp() { }

	// RVA: 0x204C508 Offset: 0x2048508 VA: 0x204C508 Slot: 16
	public int get_EqAtk() { }

	// RVA: 0x204C5C8 Offset: 0x20485C8 VA: 0x204C5C8 Slot: 17
	public int get_SubEqAtk() { }

	// RVA: 0x204C608 Offset: 0x2048608 VA: 0x204C608 Slot: 18
	public int get_Atk() { }

	// RVA: 0x204C670 Offset: 0x2048670 VA: 0x204C670 Slot: 19
	public int get_Stable() { }

	// RVA: 0x204C9D8 Offset: 0x20489D8 VA: 0x204C9D8 Slot: 20
	public int get_Matk() { }

	// RVA: 0x204CA40 Offset: 0x2048A40 VA: 0x204CA40 Slot: 21
	public int get_Hit() { }

	// RVA: 0x204D0B0 Offset: 0x20490B0 VA: 0x204D0B0
	public int get_CurrectHit() { }

	// RVA: 0x204D224 Offset: 0x2049224 VA: 0x204D224 Slot: 22
	public int get_Flee() { }

	// RVA: 0x204D258 Offset: 0x2049258 VA: 0x204D258 Slot: 23
	public int get_Def() { }

	// RVA: 0x204D28C Offset: 0x204928C VA: 0x204D28C Slot: 24
	public int get_Mdef() { }

	// RVA: 0x204D2C0 Offset: 0x20492C0 VA: 0x204D2C0 Slot: 25
	public int get_EqDef() { }

	// RVA: 0x204D2F4 Offset: 0x20492F4 VA: 0x204D2F4 Slot: 26
	public int get_Aspd() { }

	// RVA: 0x204D330 Offset: 0x2049330 VA: 0x204D330 Slot: 27
	public int get_Cspd() { }

	// RVA: 0x204D8E0 Offset: 0x20498E0 VA: 0x204D8E0 Slot: 28
	public int get_HpRecovery() { }

	// RVA: 0x204D9C4 Offset: 0x20499C4 VA: 0x204D9C4 Slot: 29
	public int get_MpRecovery() { }

	// RVA: 0x204DAA0 Offset: 0x2049AA0 VA: 0x204DAA0 Slot: 30
	public int get_AtkMpRecovery() { }

	// RVA: 0x204DF48 Offset: 0x2049F48 VA: 0x204DF48 Slot: 31
	public int get_Critical() { }

	// RVA: 0x204ED44 Offset: 0x204AD44 VA: 0x204ED44 Slot: 32
	public int get_CriticalDmg() { }

	// RVA: 0x204F074 Offset: 0x204B074 VA: 0x204F074 Slot: 33
	public int get_CriticalMagicDmg() { }

	// RVA: 0x204F1DC Offset: 0x204B1DC VA: 0x204F1DC Slot: 34
	public int get_ElementPower() { }

	// RVA: 0x204F2FC Offset: 0x204B2FC VA: 0x204F2FC Slot: 35
	public int get_AntiVirus() { }

	// RVA: 0x204F58C Offset: 0x204B58C VA: 0x204F58C Slot: 36
	public int get_GuardDelay() { }

	// RVA: 0x204F594 Offset: 0x204B594 VA: 0x204F594 Slot: 37
	public int get_GuardPower() { }

	// RVA: 0x204F974 Offset: 0x204B974 VA: 0x204F974 Slot: 38
	public int get_GuardSpeed() { }

	// RVA: 0x204FEB4 Offset: 0x204BEB4 VA: 0x204FEB4 Slot: 39
	public int get_AvoidSpeed() { }

	// RVA: 0x2050304 Offset: 0x204C304 VA: 0x2050304 Slot: 40
	public int get_AvoidStack() { }

	// RVA: 0x20506AC Offset: 0x204C6AC VA: 0x20506AC Slot: 41
	public int get_AvoidDelay() { }

	// RVA: 0x20506B4 Offset: 0x204C6B4 VA: 0x20506B4 Slot: 42
	public int get_Respawn() { }

	// RVA: 0x2050764 Offset: 0x204C764 VA: 0x2050764 Slot: 43
	public int get_SubAtk() { }

	// RVA: 0x20507A4 Offset: 0x204C7A4 VA: 0x20507A4 Slot: 44
	public int get_SubStable() { }

	// RVA: 0x20507F8 Offset: 0x204C7F8 VA: 0x20507F8 Slot: 45
	public int get_SubMatk() { }

	// RVA: 0x205083C Offset: 0x204C83C VA: 0x205083C Slot: 46
	public int GetDefFact(int def) { }

	// RVA: 0x20508E0 Offset: 0x204C8E0 VA: 0x20508E0 Slot: 47
	public int GetMdefFact(int mdef) { }

	// RVA: 0x204ECDC Offset: 0x204ACDC VA: 0x204ECDC
	public int CalcCritical(float rate, int constant) { }

	// RVA: 0x204E3A8 Offset: 0x204A3A8 VA: 0x204E3A8
	public int GetCrtConstant(bool isNormalAttack) { }

	// RVA: 0x204DFD0 Offset: 0x2049FD0 VA: 0x204DFD0
	public float GetCrtRate() { }

	// RVA: 0x2050984 Offset: 0x204C984 VA: 0x2050984 Slot: 49
	public float GetNextAtkTime(int aspd) { }

	// RVA: 0x20509AC Offset: 0x204C9AC VA: 0x20509AC Slot: 50
	public int GetMotionSpeed(int aspd) { }

	// RVA: 0x20509D0 Offset: 0x204C9D0 VA: 0x20509D0
	public int GetCalcMotionSpeed(int aspd) { }

	// RVA: 0x2050C7C Offset: 0x204CC7C VA: 0x2050C7C Slot: 51
	public int GetSkillDelayRate1(int cspd) { }

	// RVA: 0x2050CBC Offset: 0x204CCBC VA: 0x2050CBC Slot: 52
	public int GetSkillDelayRate2(int cspd) { }

	// RVA: 0x2050D04 Offset: 0x204CD04 VA: 0x2050D04 Slot: 48
	public int GetDamageCut(int damage) { }

	// RVA: 0x2050E80 Offset: 0x204CE80 VA: 0x2050E80 Slot: 53
	public void SetGuildStatusBoost(byte type, int rate) { }

	// RVA: 0x204BA34 Offset: 0x2047A34 VA: 0x204BA34
	private int CalcBaseSecondaryStatus(int baseStatus, BonusType rateType, BonusType constType) { }

	// RVA: 0x204F7C0 Offset: 0x204B7C0 VA: 0x204F7C0 Slot: 54
	public int CalcBaseGuardPower() { }

	// RVA: 0x204C22C Offset: 0x204822C VA: 0x204C22C
	public int CalcBaseMaxMp() { }

	// RVA: 0x204BD9C Offset: 0x2047D9C VA: 0x204BD9C
	public int CalcBaseMaxHp() { }

	// RVA: 0x204ED68 Offset: 0x204AD68 VA: 0x204ED68
	public int CalcCriticalDmg() { }

	// RVA: 0x2050EF4 Offset: 0x204CEF4 VA: 0x2050EF4
	public int CalcMagicCritical() { }

	// RVA: 0x2050FC8 Offset: 0x204CFC8 VA: 0x2050FC8
	public int GetbAvoid() { }

	// RVA: 0x2051150 Offset: 0x204D150 VA: 0x2051150
	public int GetbGuardSpeed() { }

	// RVA: 0x20513F4 Offset: 0x204D3F4 VA: 0x20513F4
	public int GetbGuardPower() { }

	// RVA: 0x20514EC Offset: 0x204D4EC VA: 0x20514EC
	public int GetRespawnRate() { }

	// RVA: 0x2051580 Offset: 0x204D580 VA: 0x2051580
	public int GetDisplayBonusCalcHate() { }

	// RVA: 0x20519EC Offset: 0x204D9EC VA: 0x20519EC
	public int GetExpBonus() { }

	// RVA: 0x2051BDC Offset: 0x204DBDC VA: 0x2051BDC
	public int GetDropBonus() { }

	// RVA: 0x2051D14 Offset: 0x204DD14 VA: 0x2051D14
	public int CalcHpRecovery(bool isBattle) { }

	// RVA: 0x2051FE0 Offset: 0x204DFE0 VA: 0x2051FE0
	public int CalcMpRecovery(bool isBattle) { }

	// RVA: 0x204F318 Offset: 0x204B318 VA: 0x204F318
	public int CalcAntiVirus() { }
}
