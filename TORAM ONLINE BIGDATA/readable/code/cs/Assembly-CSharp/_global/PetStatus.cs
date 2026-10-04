// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetStatus : IPlayerStatusCalculator // TypeDefIndex: 1363
{
	// Fields
	private PlayerStatusBase playerStatus; // 0x10
	private PetPersonalityType personalityType; // 0x18
	private PetType type; // 0x1C
	private PetStatusCalculator statusCalc; // 0x20
	private PetMemberSettingBase setting; // 0x28

	// Properties
	public PlayerStatusBase PlayerStatus { set; }
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
	public float PartyPetDownRate { get; }

	// Methods

	// RVA: 0x1FDD984 Offset: 0x1FD9984 VA: 0x1FDD984
	public void set_PlayerStatus(PlayerStatusBase value) { }

	[IteratorStateMachine(typeof(PetStatus.<GetParam>d__7))]
	// RVA: 0x1FDD98C Offset: 0x1FD998C VA: 0x1FDD98C
	public IEnumerable<string> GetParam() { }

	[IteratorStateMachine(typeof(PetStatus.<GetItemBonusParam>d__8))]
	// RVA: 0x1FDDA28 Offset: 0x1FD9A28 VA: 0x1FDDA28
	public IEnumerable<string> GetItemBonusParam() { }

	// RVA: 0x1FDDAC4 Offset: 0x1FD9AC4 VA: 0x1FDDAC4
	public void .ctor(PetType type, PetPersonalityType personalityType, PetPotentialData potential) { }

	// RVA: 0x1FDDBE0 Offset: 0x1FD9BE0 VA: 0x1FDDBE0 Slot: 4
	public int get_Lv() { }

	// RVA: 0x1FDDC0C Offset: 0x1FD9C0C VA: 0x1FDDC0C Slot: 5
	public int get_Str() { }

	// RVA: 0x1FDDC7C Offset: 0x1FD9C7C VA: 0x1FDDC7C Slot: 6
	public int get_Int() { }

	// RVA: 0x1FDDCEC Offset: 0x1FD9CEC VA: 0x1FDDCEC Slot: 7
	public int get_Vit() { }

	// RVA: 0x1FDDD5C Offset: 0x1FD9D5C VA: 0x1FDDD5C Slot: 8
	public int get_Agi() { }

	// RVA: 0x1FDDDCC Offset: 0x1FD9DCC VA: 0x1FDDDCC Slot: 9
	public int get_Dex() { }

	// RVA: 0x1FDDE3C Offset: 0x1FD9E3C VA: 0x1FDDE3C Slot: 10
	public int get_Crt() { }

	// RVA: 0x1FDDE68 Offset: 0x1FD9E68 VA: 0x1FDDE68 Slot: 11
	public int get_Luk() { }

	// RVA: 0x1FDDE94 Offset: 0x1FD9E94 VA: 0x1FDDE94 Slot: 12
	public int get_Men() { }

	// RVA: 0x1FDDEC0 Offset: 0x1FD9EC0 VA: 0x1FDDEC0 Slot: 13
	public int get_Tec() { }

	// RVA: 0x1FDDEEC Offset: 0x1FD9EEC VA: 0x1FDDEEC Slot: 14
	public int get_MaxHp() { }

	// RVA: 0x1FDE1A0 Offset: 0x1FDA1A0 VA: 0x1FDE1A0 Slot: 15
	public int get_MaxMp() { }

	// RVA: 0x1FDE240 Offset: 0x1FDA240 VA: 0x1FDE240 Slot: 16
	public int get_EqAtk() { }

	// RVA: 0x1FDE27C Offset: 0x1FDA27C VA: 0x1FDE27C Slot: 17
	public int get_SubEqAtk() { }

	// RVA: 0x1FDE2BC Offset: 0x1FDA2BC VA: 0x1FDE2BC Slot: 18
	public int get_Atk() { }

	// RVA: 0x1FDE324 Offset: 0x1FDA324 VA: 0x1FDE324 Slot: 19
	public int get_Stable() { }

	// RVA: 0x1FDE3B0 Offset: 0x1FDA3B0 VA: 0x1FDE3B0 Slot: 20
	public int get_Matk() { }

	// RVA: 0x1FDE418 Offset: 0x1FDA418 VA: 0x1FDE418 Slot: 21
	public int get_Hit() { }

	// RVA: 0x1FDE60C Offset: 0x1FDA60C VA: 0x1FDE60C Slot: 22
	public int get_Flee() { }

	// RVA: 0x1FDE640 Offset: 0x1FDA640 VA: 0x1FDE640 Slot: 23
	public int get_Def() { }

	// RVA: 0x1FDE674 Offset: 0x1FDA674 VA: 0x1FDE674 Slot: 24
	public int get_Mdef() { }

	// RVA: 0x1FDE6A8 Offset: 0x1FDA6A8 VA: 0x1FDE6A8 Slot: 25
	public int get_EqDef() { }

	// RVA: 0x1FDE6DC Offset: 0x1FDA6DC VA: 0x1FDE6DC Slot: 26
	public int get_Aspd() { }

	// RVA: 0x1FDE8F4 Offset: 0x1FDA8F4 VA: 0x1FDE8F4 Slot: 27
	public int get_Cspd() { }

	// RVA: 0x1FDEB8C Offset: 0x1FDAB8C VA: 0x1FDEB8C Slot: 28
	public int get_HpRecovery() { }

	// RVA: 0x1FDECA0 Offset: 0x1FDACA0 VA: 0x1FDECA0 Slot: 29
	public int get_MpRecovery() { }

	// RVA: 0x1FDEF7C Offset: 0x1FDAF7C VA: 0x1FDEF7C Slot: 30
	public int get_AtkMpRecovery() { }

	// RVA: 0x1FDEFE8 Offset: 0x1FDAFE8 VA: 0x1FDEFE8 Slot: 31
	public int get_Critical() { }

	// RVA: 0x1FDF404 Offset: 0x1FDB404 VA: 0x1FDF404 Slot: 32
	public int get_CriticalDmg() { }

	// RVA: 0x1FDF5E4 Offset: 0x1FDB5E4 VA: 0x1FDF5E4 Slot: 33
	public int get_CriticalMagicDmg() { }

	// RVA: 0x1FDF70C Offset: 0x1FDB70C VA: 0x1FDF70C Slot: 34
	public int get_ElementPower() { }

	// RVA: 0x1FDF714 Offset: 0x1FDB714 VA: 0x1FDF714 Slot: 35
	public int get_AntiVirus() { }

	// RVA: 0x1FDF784 Offset: 0x1FDB784 VA: 0x1FDF784 Slot: 36
	public int get_GuardDelay() { }

	// RVA: 0x1FDFA00 Offset: 0x1FDBA00 VA: 0x1FDFA00 Slot: 37
	public int get_GuardPower() { }

	// RVA: 0x1FDFB68 Offset: 0x1FDBB68 VA: 0x1FDFB68 Slot: 38
	public int get_GuardSpeed() { }

	// RVA: 0x1FDFB70 Offset: 0x1FDBB70 VA: 0x1FDFB70 Slot: 39
	public int get_AvoidSpeed() { }

	// RVA: 0x1FDFD48 Offset: 0x1FDBD48 VA: 0x1FDFD48 Slot: 40
	public int get_AvoidStack() { }

	// RVA: 0x1FDFD50 Offset: 0x1FDBD50 VA: 0x1FDFD50 Slot: 41
	public int get_AvoidDelay() { }

	// RVA: 0x1FDFD58 Offset: 0x1FDBD58 VA: 0x1FDFD58 Slot: 42
	public int get_Respawn() { }

	// RVA: 0x1FDFE08 Offset: 0x1FDBE08 VA: 0x1FDFE08 Slot: 43
	public int get_SubAtk() { }

	// RVA: 0x1FDFE48 Offset: 0x1FDBE48 VA: 0x1FDFE48 Slot: 44
	public int get_SubStable() { }

	// RVA: 0x1FDFE88 Offset: 0x1FDBE88 VA: 0x1FDFE88 Slot: 45
	public int get_SubMatk() { }

	// RVA: 0x1FDE744 Offset: 0x1FDA744 VA: 0x1FDE744
	public float get_PartyPetDownRate() { }

	// RVA: 0x1FDFECC Offset: 0x1FDBECC VA: 0x1FDFECC Slot: 46
	public int GetDefFact(int def) { }

	// RVA: 0x1FDFF70 Offset: 0x1FDBF70 VA: 0x1FDFF70 Slot: 47
	public int GetMdefFact(int mdef) { }

	// RVA: 0x1FE0014 Offset: 0x1FDC014 VA: 0x1FE0014 Slot: 49
	public float GetNextAtkTime(int aspd) { }

	// RVA: 0x1FE003C Offset: 0x1FDC03C VA: 0x1FE003C Slot: 50
	public int GetMotionSpeed(int aspd) { }

	// RVA: 0x1FE00C0 Offset: 0x1FDC0C0 VA: 0x1FE00C0 Slot: 51
	public int GetSkillDelayRate1(int cspd) { }

	// RVA: 0x1FE0100 Offset: 0x1FDC100 VA: 0x1FE0100 Slot: 52
	public int GetSkillDelayRate2(int cspd) { }

	// RVA: 0x1FE0148 Offset: 0x1FDC148 VA: 0x1FE0148 Slot: 53
	public void SetGuildStatusBoost(byte type, int rate) { }

	// RVA: 0x1FE014C Offset: 0x1FDC14C VA: 0x1FE014C Slot: 48
	public int GetDamageCut(int damage) { }

	// RVA: 0x1FDF45C Offset: 0x1FDB45C VA: 0x1FDF45C
	private int CalcBaseCriticalDamage() { }

	// RVA: 0x1FE02C8 Offset: 0x1FDC2C8 VA: 0x1FE02C8 Slot: 54
	public int CalcBaseGuardPower() { }
}
