// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TemporaryPlayerStatus : IPlayerStatusCalculator // TypeDefIndex: 1537
{
	// Fields
	private long checkInitStatusFlag; // 0x10
	private IPlayerStatusCalculator baseStatus; // 0x18
	private int _agi; // 0x20
	private int _antiVirus; // 0x24
	private int _aspd; // 0x28
	private int _atk; // 0x2C
	private int _atkMpRecovery; // 0x30
	private int _avoid; // 0x34
	private int _avoidTired; // 0x38
	private int _avoidSpeed; // 0x3C
	private int _critical; // 0x40
	private int _criticalDmg; // 0x44
	private int _criticalMagicDmg; // 0x48
	private int _elementPower; // 0x4C
	private int _crt; // 0x50
	private int _cspd; // 0x54
	private int _def; // 0x58
	private int _dex; // 0x5C
	private int _eqAtk; // 0x60
	private int _eqDef; // 0x64
	private int _flee; // 0x68
	private int _guard; // 0x6C
	private int _guardPower; // 0x70
	private int _guardSpeed; // 0x74
	private int _damageReductionRate; // 0x78
	private int _hit; // 0x7C
	private int _hpRecovery; // 0x80
	private int _int; // 0x84
	private int _luk; // 0x88
	private int _lv; // 0x8C
	private int _matk; // 0x90
	private int _maxHp; // 0x94
	private int _maxMp; // 0x98
	private int _mdef; // 0x9C
	private int _men; // 0xA0
	private int _mpRecovery; // 0xA4
	private int _respawn; // 0xA8
	private int _stable; // 0xAC
	private int _str; // 0xB0
	private int _subAtk; // 0xB4
	private int _subEqAtk; // 0xB8
	private int _subMatk; // 0xBC
	private int _subStable; // 0xC0
	private int _tec; // 0xC4
	private int _vit; // 0xC8
	private int _motionSpeed; // 0xCC
	private int _damageCut; // 0xD0
	private int _baseGuardPower; // 0xD4

	// Properties
	public int Agi { get; }
	public int AntiVirus { get; }
	public int Aspd { get; }
	public int Atk { get; }
	public int AtkMpRecovery { get; }
	public int AvoidSpeed { get; }
	public int AvoidStack { get; }
	public int AvoidDelay { get; }
	public int Critical { get; }
	public int CriticalDmg { get; }
	public int CriticalMagicDmg { get; }
	public int ElementPower { get; }
	public int Crt { get; }
	public int Cspd { get; }
	public int Def { get; }
	public int Dex { get; }
	public int EqAtk { get; }
	public int EqDef { get; }
	public int Flee { get; }
	public int GuardDelay { get; }
	public int GuardPower { get; }
	public int GuardSpeed { get; }
	public int Hit { get; }
	public int HpRecovery { get; }
	public int Int { get; }
	public int Luk { get; }
	public int Lv { get; }
	public int Matk { get; }
	public int MaxHp { get; }
	public int MaxMp { get; }
	public int Mdef { get; }
	public int Men { get; }
	public int MpRecovery { get; }
	public int Respawn { get; }
	public int Stable { get; }
	public int Str { get; }
	public int SubAtk { get; }
	public int SubEqAtk { get; }
	public int SubMatk { get; }
	public int SubStable { get; }
	public int Tec { get; }
	public int Vit { get; }

	// Methods

	// RVA: 0x2085318 Offset: 0x2081318 VA: 0x2085318 Slot: 8
	public int get_Agi() { }

	// RVA: 0x2085404 Offset: 0x2081404 VA: 0x2085404 Slot: 35
	public int get_AntiVirus() { }

	// RVA: 0x20854C8 Offset: 0x20814C8 VA: 0x20854C8 Slot: 26
	public int get_Aspd() { }

	// RVA: 0x208558C Offset: 0x208158C VA: 0x208558C Slot: 18
	public int get_Atk() { }

	// RVA: 0x2085650 Offset: 0x2081650 VA: 0x2085650 Slot: 30
	public int get_AtkMpRecovery() { }

	// RVA: 0x2085714 Offset: 0x2081714 VA: 0x2085714 Slot: 39
	public int get_AvoidSpeed() { }

	// RVA: 0x20857D8 Offset: 0x20817D8 VA: 0x20857D8 Slot: 40
	public int get_AvoidStack() { }

	// RVA: 0x208589C Offset: 0x208189C VA: 0x208589C Slot: 41
	public int get_AvoidDelay() { }

	// RVA: 0x2085960 Offset: 0x2081960 VA: 0x2085960 Slot: 31
	public int get_Critical() { }

	// RVA: 0x2085A24 Offset: 0x2081A24 VA: 0x2085A24 Slot: 32
	public int get_CriticalDmg() { }

	// RVA: 0x2085AE8 Offset: 0x2081AE8 VA: 0x2085AE8 Slot: 33
	public int get_CriticalMagicDmg() { }

	// RVA: 0x2085BAC Offset: 0x2081BAC VA: 0x2085BAC Slot: 34
	public int get_ElementPower() { }

	// RVA: 0x2085C70 Offset: 0x2081C70 VA: 0x2085C70 Slot: 10
	public int get_Crt() { }

	// RVA: 0x2085D34 Offset: 0x2081D34 VA: 0x2085D34 Slot: 27
	public int get_Cspd() { }

	// RVA: 0x2085DF8 Offset: 0x2081DF8 VA: 0x2085DF8 Slot: 23
	public int get_Def() { }

	// RVA: 0x2085EBC Offset: 0x2081EBC VA: 0x2085EBC Slot: 9
	public int get_Dex() { }

	// RVA: 0x2085F80 Offset: 0x2081F80 VA: 0x2085F80 Slot: 16
	public int get_EqAtk() { }

	// RVA: 0x2086044 Offset: 0x2082044 VA: 0x2086044 Slot: 25
	public int get_EqDef() { }

	// RVA: 0x2086108 Offset: 0x2082108 VA: 0x2086108 Slot: 22
	public int get_Flee() { }

	// RVA: 0x20861CC Offset: 0x20821CC VA: 0x20861CC Slot: 36
	public int get_GuardDelay() { }

	// RVA: 0x2086290 Offset: 0x2082290 VA: 0x2086290 Slot: 37
	public int get_GuardPower() { }

	// RVA: 0x2086354 Offset: 0x2082354 VA: 0x2086354 Slot: 38
	public int get_GuardSpeed() { }

	// RVA: 0x2086418 Offset: 0x2082418 VA: 0x2086418 Slot: 21
	public int get_Hit() { }

	// RVA: 0x20864DC Offset: 0x20824DC VA: 0x20864DC Slot: 28
	public int get_HpRecovery() { }

	// RVA: 0x20865A0 Offset: 0x20825A0 VA: 0x20865A0 Slot: 6
	public int get_Int() { }

	// RVA: 0x2086664 Offset: 0x2082664 VA: 0x2086664 Slot: 11
	public int get_Luk() { }

	// RVA: 0x2086728 Offset: 0x2082728 VA: 0x2086728 Slot: 4
	public int get_Lv() { }

	// RVA: 0x20867E8 Offset: 0x20827E8 VA: 0x20867E8 Slot: 20
	public int get_Matk() { }

	// RVA: 0x20868AC Offset: 0x20828AC VA: 0x20868AC Slot: 14
	public int get_MaxHp() { }

	// RVA: 0x2086970 Offset: 0x2082970 VA: 0x2086970 Slot: 15
	public int get_MaxMp() { }

	// RVA: 0x2086A34 Offset: 0x2082A34 VA: 0x2086A34 Slot: 24
	public int get_Mdef() { }

	// RVA: 0x2086AF8 Offset: 0x2082AF8 VA: 0x2086AF8 Slot: 12
	public int get_Men() { }

	// RVA: 0x2086BBC Offset: 0x2082BBC VA: 0x2086BBC Slot: 29
	public int get_MpRecovery() { }

	// RVA: 0x2086C80 Offset: 0x2082C80 VA: 0x2086C80 Slot: 42
	public int get_Respawn() { }

	// RVA: 0x2086D44 Offset: 0x2082D44 VA: 0x2086D44 Slot: 19
	public int get_Stable() { }

	// RVA: 0x2086E08 Offset: 0x2082E08 VA: 0x2086E08 Slot: 5
	public int get_Str() { }

	// RVA: 0x2086ECC Offset: 0x2082ECC VA: 0x2086ECC Slot: 43
	public int get_SubAtk() { }

	// RVA: 0x2086F90 Offset: 0x2082F90 VA: 0x2086F90 Slot: 17
	public int get_SubEqAtk() { }

	// RVA: 0x2087054 Offset: 0x2083054 VA: 0x2087054 Slot: 45
	public int get_SubMatk() { }

	// RVA: 0x2087118 Offset: 0x2083118 VA: 0x2087118 Slot: 44
	public int get_SubStable() { }

	// RVA: 0x20871DC Offset: 0x20831DC VA: 0x20871DC Slot: 13
	public int get_Tec() { }

	// RVA: 0x20872A0 Offset: 0x20832A0 VA: 0x20872A0 Slot: 7
	public int get_Vit() { }

	// RVA: 0x2087364 Offset: 0x2083364 VA: 0x2087364
	public void .ctor(IPlayerStatusCalculator status) { }

	// RVA: 0x2087394 Offset: 0x2083394 VA: 0x2087394 Slot: 48
	public int GetDamageCut(int damage) { }

	// RVA: 0x2087460 Offset: 0x2083460 VA: 0x2087460 Slot: 46
	public int GetDefFact(int def) { }

	// RVA: 0x2087504 Offset: 0x2083504 VA: 0x2087504 Slot: 47
	public int GetMdefFact(int mdef) { }

	// RVA: 0x20875A8 Offset: 0x20835A8 VA: 0x20875A8 Slot: 50
	public int GetMotionSpeed(int aspd) { }

	// RVA: 0x2087674 Offset: 0x2083674 VA: 0x2087674 Slot: 49
	public float GetNextAtkTime(int aspd) { }

	// RVA: 0x208769C Offset: 0x208369C VA: 0x208769C Slot: 51
	public int GetSkillDelayRate1(int cspd) { }

	// RVA: 0x20876DC Offset: 0x20836DC VA: 0x20876DC Slot: 52
	public int GetSkillDelayRate2(int cspd) { }

	// RVA: 0x2087724 Offset: 0x2083724 VA: 0x2087724 Slot: 53
	public void SetGuildStatusBoost(byte type, int rate) { }

	// RVA: 0x2087728 Offset: 0x2083728 VA: 0x2087728 Slot: 54
	public int CalcBaseGuardPower() { }

	// RVA: 0x20853DC Offset: 0x20813DC VA: 0x20853DC
	private bool CheckInitializeStatus(TemporaryPlayerStatus.Status type) { }
}
