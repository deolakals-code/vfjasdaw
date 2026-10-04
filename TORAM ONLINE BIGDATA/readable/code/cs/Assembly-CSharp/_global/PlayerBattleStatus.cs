// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PlayerBattleStatus : IPlayerStatusCalculator // TypeDefIndex: 1454
{
	// Fields
	private readonly PlayerStatusBase playerStatus; // 0x10

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

	// RVA: 0x203DCC8 Offset: 0x2039CC8 VA: 0x203DCC8
	public void .ctor(PlayerStatusBase status) { }

	// RVA: 0x2042024 Offset: 0x203E024 VA: 0x2042024 Slot: 4
	public int get_Lv() { }

	// RVA: 0x20420D8 Offset: 0x203E0D8 VA: 0x20420D8 Slot: 5
	public int get_Str() { }

	// RVA: 0x2042190 Offset: 0x203E190 VA: 0x2042190 Slot: 6
	public int get_Int() { }

	// RVA: 0x2042248 Offset: 0x203E248 VA: 0x2042248 Slot: 7
	public int get_Vit() { }

	// RVA: 0x2042300 Offset: 0x203E300 VA: 0x2042300 Slot: 8
	public int get_Agi() { }

	// RVA: 0x20423B8 Offset: 0x203E3B8 VA: 0x20423B8 Slot: 9
	public int get_Dex() { }

	// RVA: 0x2042470 Offset: 0x203E470 VA: 0x2042470 Slot: 10
	public int get_Crt() { }

	// RVA: 0x2042528 Offset: 0x203E528 VA: 0x2042528 Slot: 11
	public int get_Luk() { }

	// RVA: 0x20425E0 Offset: 0x203E5E0 VA: 0x20425E0 Slot: 12
	public int get_Men() { }

	// RVA: 0x2042698 Offset: 0x203E698 VA: 0x2042698 Slot: 13
	public int get_Tec() { }

	// RVA: 0x2042750 Offset: 0x203E750 VA: 0x2042750 Slot: 14
	public int get_MaxHp() { }

	// RVA: 0x2042808 Offset: 0x203E808 VA: 0x2042808 Slot: 15
	public int get_MaxMp() { }

	// RVA: 0x20428C0 Offset: 0x203E8C0 VA: 0x20428C0 Slot: 16
	public int get_EqAtk() { }

	// RVA: 0x20429AC Offset: 0x203E9AC VA: 0x20429AC Slot: 17
	public int get_SubEqAtk() { }

	// RVA: 0x2042A64 Offset: 0x203EA64 VA: 0x2042A64 Slot: 18
	public int get_Atk() { }

	// RVA: 0x2042B1C Offset: 0x203EB1C VA: 0x2042B1C Slot: 19
	public int get_Stable() { }

	// RVA: 0x2042C2C Offset: 0x203EC2C VA: 0x2042C2C Slot: 20
	public int get_Matk() { }

	// RVA: 0x2042CE4 Offset: 0x203ECE4 VA: 0x2042CE4 Slot: 21
	public int get_Hit() { }

	// RVA: 0x2042D9C Offset: 0x203ED9C VA: 0x2042D9C Slot: 22
	public int get_Flee() { }

	// RVA: 0x2042E54 Offset: 0x203EE54 VA: 0x2042E54 Slot: 23
	public int get_Def() { }

	// RVA: 0x2042F0C Offset: 0x203EF0C VA: 0x2042F0C Slot: 24
	public int get_Mdef() { }

	// RVA: 0x2042FC4 Offset: 0x203EFC4 VA: 0x2042FC4 Slot: 25
	public int get_EqDef() { }

	// RVA: 0x20430DC Offset: 0x203F0DC VA: 0x20430DC Slot: 26
	public int get_Aspd() { }

	// RVA: 0x20432C8 Offset: 0x203F2C8 VA: 0x20432C8 Slot: 27
	public int get_Cspd() { }

	// RVA: 0x2043380 Offset: 0x203F380 VA: 0x2043380 Slot: 28
	public int get_HpRecovery() { }

	// RVA: 0x2043438 Offset: 0x203F438 VA: 0x2043438 Slot: 29
	public int get_MpRecovery() { }

	// RVA: 0x20434F0 Offset: 0x203F4F0 VA: 0x20434F0 Slot: 30
	public int get_AtkMpRecovery() { }

	// RVA: 0x20435A8 Offset: 0x203F5A8 VA: 0x20435A8 Slot: 31
	public int get_Critical() { }

	// RVA: 0x2043660 Offset: 0x203F660 VA: 0x2043660 Slot: 32
	public int get_CriticalDmg() { }

	// RVA: 0x204375C Offset: 0x203F75C VA: 0x204375C Slot: 33
	public int get_CriticalMagicDmg() { }

	// RVA: 0x2043858 Offset: 0x203F858 VA: 0x2043858 Slot: 34
	public int get_ElementPower() { }

	// RVA: 0x2043910 Offset: 0x203F910 VA: 0x2043910 Slot: 35
	public int get_AntiVirus() { }

	// RVA: 0x2043A24 Offset: 0x203FA24 VA: 0x2043A24 Slot: 36
	public int get_GuardDelay() { }

	// RVA: 0x2043ADC Offset: 0x203FADC VA: 0x2043ADC Slot: 37
	public int get_GuardPower() { }

	// RVA: 0x2043B94 Offset: 0x203FB94 VA: 0x2043B94 Slot: 38
	public int get_GuardSpeed() { }

	// RVA: 0x2043C4C Offset: 0x203FC4C VA: 0x2043C4C Slot: 39
	public int get_AvoidSpeed() { }

	// RVA: 0x2043D04 Offset: 0x203FD04 VA: 0x2043D04 Slot: 40
	public int get_AvoidStack() { }

	// RVA: 0x2043DBC Offset: 0x203FDBC VA: 0x2043DBC Slot: 41
	public int get_AvoidDelay() { }

	// RVA: 0x2043E74 Offset: 0x203FE74 VA: 0x2043E74 Slot: 42
	public int get_Respawn() { }

	// RVA: 0x2043F2C Offset: 0x203FF2C VA: 0x2043F2C Slot: 43
	public int get_SubAtk() { }

	// RVA: 0x2043FE4 Offset: 0x203FFE4 VA: 0x2043FE4 Slot: 44
	public int get_SubStable() { }

	// RVA: 0x204409C Offset: 0x204009C VA: 0x204409C Slot: 45
	public int get_SubMatk() { }

	// RVA: 0x2044154 Offset: 0x2040154 VA: 0x2044154 Slot: 46
	public int GetDefFact(int def) { }

	// RVA: 0x2044214 Offset: 0x2040214 VA: 0x2044214 Slot: 47
	public int GetMdefFact(int mdef) { }

	// RVA: 0x20442D4 Offset: 0x20402D4 VA: 0x20442D4 Slot: 49
	public float GetNextAtkTime(int aspd) { }

	// RVA: 0x2044394 Offset: 0x2040394 VA: 0x2044394 Slot: 50
	public int GetMotionSpeed(int aspd) { }

	// RVA: 0x2044454 Offset: 0x2040454 VA: 0x2044454 Slot: 51
	public int GetSkillDelayRate1(int cspd) { }

	// RVA: 0x2044514 Offset: 0x2040514 VA: 0x2044514 Slot: 52
	public int GetSkillDelayRate2(int cspd) { }

	// RVA: 0x20445D4 Offset: 0x20405D4 VA: 0x20445D4 Slot: 48
	public int GetDamageCut(int damage) { }

	// RVA: 0x2044694 Offset: 0x2040694 VA: 0x2044694 Slot: 53
	public void SetGuildStatusBoost(byte type, int rate) { }

	// RVA: 0x2044764 Offset: 0x2040764 VA: 0x2044764 Slot: 54
	public int CalcBaseGuardPower() { }
}
