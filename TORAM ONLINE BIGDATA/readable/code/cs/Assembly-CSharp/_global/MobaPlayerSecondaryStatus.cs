// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaPlayerSecondaryStatus : IPlayerStatusCalculator // TypeDefIndex: 1427
{
	// Fields
	private MobaPlayerStatus playerStatus; // 0x10

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

	// RVA: 0x2039020 Offset: 0x2035020 VA: 0x2039020 Slot: 4
	public int get_Lv() { }

	// RVA: 0x20390BC Offset: 0x20350BC VA: 0x20390BC Slot: 5
	public int get_Str() { }

	// RVA: 0x20391C8 Offset: 0x20351C8 VA: 0x20391C8 Slot: 6
	public int get_Int() { }

	// RVA: 0x2039204 Offset: 0x2035204 VA: 0x2039204 Slot: 7
	public int get_Vit() { }

	// RVA: 0x2039298 Offset: 0x2035298 VA: 0x2039298 Slot: 8
	public int get_Agi() { }

	// RVA: 0x2039368 Offset: 0x2035368 VA: 0x2039368 Slot: 9
	public int get_Dex() { }

	// RVA: 0x20393A4 Offset: 0x20353A4 VA: 0x20393A4 Slot: 10
	public int get_Crt() { }

	// RVA: 0x20393D0 Offset: 0x20353D0 VA: 0x20393D0 Slot: 11
	public int get_Luk() { }

	// RVA: 0x20393FC Offset: 0x20353FC VA: 0x20393FC Slot: 12
	public int get_Men() { }

	// RVA: 0x2039428 Offset: 0x2035428 VA: 0x2039428 Slot: 13
	public int get_Tec() { }

	// RVA: 0x2039454 Offset: 0x2035454 VA: 0x2039454 Slot: 14
	public int get_MaxHp() { }

	// RVA: 0x2039A04 Offset: 0x2035A04 VA: 0x2039A04 Slot: 15
	public int get_MaxMp() { }

	// RVA: 0x2039D3C Offset: 0x2035D3C VA: 0x2039D3C Slot: 16
	public int get_EqAtk() { }

	// RVA: 0x2039D78 Offset: 0x2035D78 VA: 0x2039D78 Slot: 17
	public int get_SubEqAtk() { }

	// RVA: 0x2039DB8 Offset: 0x2035DB8 VA: 0x2039DB8 Slot: 18
	public int get_Atk() { }

	// RVA: 0x2039E20 Offset: 0x2035E20 VA: 0x2039E20 Slot: 19
	public int get_Stable() { }

	// RVA: 0x203A06C Offset: 0x203606C VA: 0x203A06C Slot: 20
	public int get_Matk() { }

	// RVA: 0x203A0D4 Offset: 0x20360D4 VA: 0x203A0D4 Slot: 21
	public int get_Hit() { }

	// RVA: 0x203A58C Offset: 0x203658C VA: 0x203A58C Slot: 22
	public int get_Flee() { }

	// RVA: 0x203A5C0 Offset: 0x20365C0 VA: 0x203A5C0 Slot: 23
	public int get_Def() { }

	// RVA: 0x203A5F4 Offset: 0x20365F4 VA: 0x203A5F4 Slot: 24
	public int get_Mdef() { }

	// RVA: 0x203A628 Offset: 0x2036628 VA: 0x203A628 Slot: 25
	public int get_EqDef() { }

	// RVA: 0x203A65C Offset: 0x203665C VA: 0x203A65C Slot: 26
	public int get_Aspd() { }

	// RVA: 0x203A698 Offset: 0x2036698 VA: 0x203A698 Slot: 27
	public int get_Cspd() { }

	// RVA: 0x203A9F8 Offset: 0x20369F8 VA: 0x203A9F8 Slot: 28
	public int get_HpRecovery() { }

	// RVA: 0x203AAF4 Offset: 0x2036AF4 VA: 0x203AAF4 Slot: 29
	public int get_MpRecovery() { }

	// RVA: 0x203ABF0 Offset: 0x2036BF0 VA: 0x203ABF0 Slot: 30
	public int get_AtkMpRecovery() { }

	// RVA: 0x203ADA4 Offset: 0x2036DA4 VA: 0x203ADA4 Slot: 31
	public int get_Critical() { }

	// RVA: 0x203BBA0 Offset: 0x2037BA0 VA: 0x203BBA0 Slot: 32
	public int get_CriticalDmg() { }

	// RVA: 0x203BEC0 Offset: 0x2037EC0 VA: 0x203BEC0 Slot: 33
	public int get_CriticalMagicDmg() { }

	// RVA: 0x203BFB0 Offset: 0x2037FB0 VA: 0x203BFB0 Slot: 34
	public int get_ElementPower() { }

	// RVA: 0x203C044 Offset: 0x2038044 VA: 0x203C044 Slot: 35
	public int get_AntiVirus() { }

	// RVA: 0x203C284 Offset: 0x2038284 VA: 0x203C284 Slot: 36
	public int get_GuardDelay() { }

	// RVA: 0x203C28C Offset: 0x203828C VA: 0x203C28C Slot: 37
	public int get_GuardPower() { }

	// RVA: 0x203C6CC Offset: 0x20386CC VA: 0x203C6CC Slot: 38
	public int get_GuardSpeed() { }

	// RVA: 0x203CB44 Offset: 0x2038B44 VA: 0x203CB44 Slot: 39
	public int get_AvoidSpeed() { }

	// RVA: 0x203CEA8 Offset: 0x2038EA8 VA: 0x203CEA8 Slot: 40
	public int get_AvoidStack() { }

	// RVA: 0x203D1BC Offset: 0x20391BC VA: 0x203D1BC Slot: 41
	public int get_AvoidDelay() { }

	// RVA: 0x203D1C4 Offset: 0x20391C4 VA: 0x203D1C4 Slot: 42
	public int get_Respawn() { }

	// RVA: 0x203D274 Offset: 0x2039274 VA: 0x203D274 Slot: 43
	public int get_SubAtk() { }

	// RVA: 0x203D2B4 Offset: 0x20392B4 VA: 0x203D2B4 Slot: 44
	public int get_SubStable() { }

	// RVA: 0x203D308 Offset: 0x2039308 VA: 0x203D308 Slot: 45
	public int get_SubMatk() { }

	// RVA: 0x203D34C Offset: 0x203934C VA: 0x203D34C
	public void .ctor(MobaPlayerStatus status) { }

	// RVA: 0x203D37C Offset: 0x203937C VA: 0x203D37C Slot: 48
	public int GetDamageCut(int damage) { }

	// RVA: 0x203D4F8 Offset: 0x20394F8 VA: 0x203D4F8 Slot: 46
	public int GetDefFact(int def) { }

	// RVA: 0x203D590 Offset: 0x2039590 VA: 0x203D590 Slot: 47
	public int GetMdefFact(int mdef) { }

	// RVA: 0x203D628 Offset: 0x2039628 VA: 0x203D628 Slot: 50
	public int GetMotionSpeed(int aspd) { }

	// RVA: 0x203D8B4 Offset: 0x20398B4 VA: 0x203D8B4 Slot: 49
	public float GetNextAtkTime(int aspd) { }

	// RVA: 0x203D8DC Offset: 0x20398DC VA: 0x203D8DC Slot: 51
	public int GetSkillDelayRate1(int cspd) { }

	// RVA: 0x203D91C Offset: 0x203991C VA: 0x203D91C Slot: 52
	public int GetSkillDelayRate2(int cspd) { }

	// RVA: 0x203D964 Offset: 0x2039964 VA: 0x203D964 Slot: 53
	public void SetGuildStatusBoost(byte type, int rate) { }

	// RVA: 0x203BB38 Offset: 0x2037B38 VA: 0x203BB38
	public int CalcCritical(float rate, int constant) { }

	// RVA: 0x203B204 Offset: 0x2037204 VA: 0x203B204
	public int GetCrtConstant(bool isNormalAttack) { }

	// RVA: 0x203AE2C Offset: 0x2036E2C VA: 0x203AE2C
	public float GetCrtRate() { }

	// RVA: 0x20390F8 Offset: 0x20350F8 VA: 0x20390F8
	private int CalcBaseSecondaryStatus(int baseStatus, BonusType rateType, BonusType constType) { }

	// RVA: 0x203C530 Offset: 0x2038530 VA: 0x203C530 Slot: 54
	public int CalcBaseGuardPower() { }
}
