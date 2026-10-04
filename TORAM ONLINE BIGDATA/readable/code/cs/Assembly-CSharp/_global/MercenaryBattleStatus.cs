// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MercenaryBattleStatus : IPlayerStatusCalculator // TypeDefIndex: 698
{
	// Fields
	private StanceType stance; // 0x10
	private PlayerStatusBase managerStatus; // 0x18
	[CompilerGenerated]
	private CompanionStatusDataBase <PartnerStatus>k__BackingField; // 0x20
	[CompilerGenerated]
	private PlayerStatusBase <playerStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private MercenaryTirednessManager <TirednessManager>k__BackingField; // 0x30

	// Properties
	private CompanionStatusDataBase PartnerStatus { get; set; }
	private PlayerStatusBase playerStatus { get; set; }
	private MercenaryTirednessManager TirednessManager { get; set; }
	public StanceType StanceType { get; }
	public int AntiVirus { get; }
	public int Aspd { get; }
	public int AvoidStack { get; }
	public int AvoidDelay { get; }
	public int Agi { get; }
	public int Str { get; }
	public int Dex { get; }
	public int Lv { get; }
	public int MaxHp { get; }
	public int Atk { get; }
	public int CharateristicAtk { get; }
	public int Matk { get; }
	public int Def { get; }
	public int Mdef { get; }
	public int Hit { get; }
	public int Flee { get; }
	public int AtkMpRecovery { get; }
	public int AvoidSpeed { get; }
	public int Critical { get; }
	public int CriticalDmg { get; }
	public int CriticalMagicDmg { get; }
	public int ElementPower { get; }
	public int Crt { get; }
	public int Cspd { get; }
	public int EqAtk { get; }
	public int EqDef { get; }
	public int Guard { get; }
	public int GuardDelay { get; }
	public int GuardPower { get; }
	public int DamageReductionRate { get; }
	public int GuardSpeed { get; }
	public int HpRecovery { get; }
	public int Int { get; }
	public int Luk { get; }
	public int MaxMp { get; }
	public int Men { get; }
	public int MpRecovery { get; }
	public int Respawn { get; }
	public int Stable { get; }
	public int SubAtk { get; }
	public int SubEqAtk { get; }
	public int SubMatk { get; }
	public int SubStable { get; }
	public int Tec { get; }
	public int Vit { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1AC6964 Offset: 0x1AC2964 VA: 0x1AC6964
	private CompanionStatusDataBase get_PartnerStatus() { }

	[CompilerGenerated]
	// RVA: 0x1AC696C Offset: 0x1AC296C VA: 0x1AC696C
	public void set_PartnerStatus(CompanionStatusDataBase value) { }

	[CompilerGenerated]
	// RVA: 0x1AC6974 Offset: 0x1AC2974 VA: 0x1AC6974
	private PlayerStatusBase get_playerStatus() { }

	[CompilerGenerated]
	// RVA: 0x1AC697C Offset: 0x1AC297C VA: 0x1AC697C
	public void set_playerStatus(PlayerStatusBase value) { }

	[CompilerGenerated]
	// RVA: 0x1AC6984 Offset: 0x1AC2984 VA: 0x1AC6984
	private MercenaryTirednessManager get_TirednessManager() { }

	[CompilerGenerated]
	// RVA: 0x1AC698C Offset: 0x1AC298C VA: 0x1AC698C
	public void set_TirednessManager(MercenaryTirednessManager value) { }

	// RVA: 0x1AC6994 Offset: 0x1AC2994 VA: 0x1AC6994
	public StanceType get_StanceType() { }

	[IteratorStateMachine(typeof(MercenaryBattleStatus.<GetParam>d__16))]
	// RVA: 0x1AC699C Offset: 0x1AC299C VA: 0x1AC699C
	public IEnumerable<string> GetParam() { }

	// RVA: 0x1ABEF4C Offset: 0x1ABAF4C VA: 0x1ABEF4C
	public void .ctor(StanceType stance) { }

	// RVA: 0x1AC6A38 Offset: 0x1AC2A38 VA: 0x1AC6A38 Slot: 35
	public int get_AntiVirus() { }

	// RVA: 0x1AC6A40 Offset: 0x1AC2A40 VA: 0x1AC6A40 Slot: 26
	public int get_Aspd() { }

	// RVA: 0x1AC6AB0 Offset: 0x1AC2AB0 VA: 0x1AC6AB0 Slot: 40
	public int get_AvoidStack() { }

	// RVA: 0x1AC6AB8 Offset: 0x1AC2AB8 VA: 0x1AC6AB8 Slot: 41
	public int get_AvoidDelay() { }

	// RVA: 0x1AC6AC0 Offset: 0x1AC2AC0 VA: 0x1AC6AC0 Slot: 8
	public int get_Agi() { }

	// RVA: 0x1AC6AC8 Offset: 0x1AC2AC8 VA: 0x1AC6AC8 Slot: 5
	public int get_Str() { }

	// RVA: 0x1AC6AD0 Offset: 0x1AC2AD0 VA: 0x1AC6AD0 Slot: 9
	public int get_Dex() { }

	// RVA: 0x1AC6AD8 Offset: 0x1AC2AD8 VA: 0x1AC6AD8 Slot: 4
	public int get_Lv() { }

	// RVA: 0x1AC6AF4 Offset: 0x1AC2AF4 VA: 0x1AC6AF4 Slot: 14
	public int get_MaxHp() { }

	// RVA: 0x1AC6B6C Offset: 0x1AC2B6C VA: 0x1AC6B6C Slot: 18
	public int get_Atk() { }

	// RVA: 0x1AC6BB4 Offset: 0x1AC2BB4 VA: 0x1AC6BB4
	public int get_CharateristicAtk() { }

	// RVA: 0x1AC6CD0 Offset: 0x1AC2CD0 VA: 0x1AC6CD0 Slot: 20
	public int get_Matk() { }

	// RVA: 0x1AC6D18 Offset: 0x1AC2D18 VA: 0x1AC6D18 Slot: 23
	public int get_Def() { }

	// RVA: 0x1AC6E10 Offset: 0x1AC2E10 VA: 0x1AC6E10 Slot: 24
	public int get_Mdef() { }

	// RVA: 0x1AC6F08 Offset: 0x1AC2F08 VA: 0x1AC6F08 Slot: 21
	public int get_Hit() { }

	// RVA: 0x1AC6F50 Offset: 0x1AC2F50 VA: 0x1AC6F50 Slot: 22
	public int get_Flee() { }

	// RVA: 0x1AC6F98 Offset: 0x1AC2F98 VA: 0x1AC6F98 Slot: 30
	public int get_AtkMpRecovery() { }

	// RVA: 0x1AC6FA0 Offset: 0x1AC2FA0 VA: 0x1AC6FA0 Slot: 39
	public int get_AvoidSpeed() { }

	// RVA: 0x1AC6FA8 Offset: 0x1AC2FA8 VA: 0x1AC6FA8 Slot: 31
	public int get_Critical() { }

	// RVA: 0x1AC6FB0 Offset: 0x1AC2FB0 VA: 0x1AC6FB0 Slot: 32
	public int get_CriticalDmg() { }

	// RVA: 0x1AC6FF4 Offset: 0x1AC2FF4 VA: 0x1AC6FF4 Slot: 33
	public int get_CriticalMagicDmg() { }

	// RVA: 0x1AC7038 Offset: 0x1AC3038 VA: 0x1AC7038 Slot: 34
	public int get_ElementPower() { }

	// RVA: 0x1AC70CC Offset: 0x1AC30CC VA: 0x1AC70CC Slot: 10
	public int get_Crt() { }

	// RVA: 0x1AC70D4 Offset: 0x1AC30D4 VA: 0x1AC70D4 Slot: 27
	public int get_Cspd() { }

	// RVA: 0x1AC70DC Offset: 0x1AC30DC VA: 0x1AC70DC Slot: 16
	public int get_EqAtk() { }

	// RVA: 0x1AC70E4 Offset: 0x1AC30E4 VA: 0x1AC70E4 Slot: 25
	public int get_EqDef() { }

	// RVA: 0x1AC70EC Offset: 0x1AC30EC VA: 0x1AC70EC
	public int get_Guard() { }

	// RVA: 0x1AC70F4 Offset: 0x1AC30F4 VA: 0x1AC70F4 Slot: 36
	public int get_GuardDelay() { }

	// RVA: 0x1AC70FC Offset: 0x1AC30FC VA: 0x1AC70FC Slot: 37
	public int get_GuardPower() { }

	// RVA: 0x1AC7104 Offset: 0x1AC3104 VA: 0x1AC7104
	public int get_DamageReductionRate() { }

	// RVA: 0x1AC710C Offset: 0x1AC310C VA: 0x1AC710C Slot: 38
	public int get_GuardSpeed() { }

	// RVA: 0x1AC7114 Offset: 0x1AC3114 VA: 0x1AC7114 Slot: 28
	public int get_HpRecovery() { }

	// RVA: 0x1AC711C Offset: 0x1AC311C VA: 0x1AC711C Slot: 6
	public int get_Int() { }

	// RVA: 0x1AC7124 Offset: 0x1AC3124 VA: 0x1AC7124 Slot: 11
	public int get_Luk() { }

	// RVA: 0x1AC712C Offset: 0x1AC312C VA: 0x1AC712C Slot: 15
	public int get_MaxMp() { }

	// RVA: 0x1AC7134 Offset: 0x1AC3134 VA: 0x1AC7134 Slot: 12
	public int get_Men() { }

	// RVA: 0x1AC713C Offset: 0x1AC313C VA: 0x1AC713C Slot: 29
	public int get_MpRecovery() { }

	// RVA: 0x1AC7144 Offset: 0x1AC3144 VA: 0x1AC7144 Slot: 42
	public int get_Respawn() { }

	// RVA: 0x1AC714C Offset: 0x1AC314C VA: 0x1AC714C Slot: 19
	public int get_Stable() { }

	// RVA: 0x1AC7154 Offset: 0x1AC3154 VA: 0x1AC7154 Slot: 43
	public int get_SubAtk() { }

	// RVA: 0x1AC715C Offset: 0x1AC315C VA: 0x1AC715C Slot: 17
	public int get_SubEqAtk() { }

	// RVA: 0x1AC7164 Offset: 0x1AC3164 VA: 0x1AC7164 Slot: 45
	public int get_SubMatk() { }

	// RVA: 0x1AC716C Offset: 0x1AC316C VA: 0x1AC716C Slot: 44
	public int get_SubStable() { }

	// RVA: 0x1AC7174 Offset: 0x1AC3174 VA: 0x1AC7174 Slot: 13
	public int get_Tec() { }

	// RVA: 0x1AC717C Offset: 0x1AC317C VA: 0x1AC717C Slot: 7
	public int get_Vit() { }

	// RVA: 0x1AC7184 Offset: 0x1AC3184 VA: 0x1AC7184 Slot: 46
	public int GetDefFact(int def) { }

	// RVA: 0x1AC7228 Offset: 0x1AC3228 VA: 0x1AC7228 Slot: 47
	public int GetMdefFact(int mdef) { }

	// RVA: 0x1AC72CC Offset: 0x1AC32CC VA: 0x1AC72CC Slot: 49
	public float GetNextAtkTime(int aspd) { }

	// RVA: 0x1AC72F4 Offset: 0x1AC32F4 VA: 0x1AC72F4 Slot: 50
	public int GetMotionSpeed(int aspd) { }

	// RVA: 0x1AC7378 Offset: 0x1AC3378 VA: 0x1AC7378 Slot: 51
	public int GetSkillDelayRate1(int cspd) { }

	// RVA: 0x1AC73B8 Offset: 0x1AC33B8 VA: 0x1AC73B8 Slot: 52
	public int GetSkillDelayRate2(int cspd) { }

	// RVA: 0x1AC7400 Offset: 0x1AC3400 VA: 0x1AC7400
	public void GetAvoidAndGuard(out int avoid, out int guard) { }

	// RVA: 0x1AC7424 Offset: 0x1AC3424 VA: 0x1AC7424 Slot: 48
	public int GetDamageCut(int damage) { }

	// RVA: 0x1AC75A0 Offset: 0x1AC35A0 VA: 0x1AC75A0 Slot: 53
	public void SetGuildStatusBoost(byte type, int rate) { }

	// RVA: 0x1AC75A4 Offset: 0x1AC35A4 VA: 0x1AC75A4 Slot: 54
	public int CalcBaseGuardPower() { }
}
