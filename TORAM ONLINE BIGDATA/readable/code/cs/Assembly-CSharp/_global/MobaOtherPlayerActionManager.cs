// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaOtherPlayerActionManager : EnemyMobActionManagerBase, IOtherPlayerActionManager, IMobaCharacterAction // TypeDefIndex: 1221
{
	// Fields
	[CompilerGenerated]
	private TakeController <TakeController>k__BackingField; // 0x158
	[CompilerGenerated]
	private int <MainWeapon>k__BackingField; // 0x160
	[CompilerGenerated]
	private int <SubWeapon>k__BackingField; // 0x164
	[CompilerGenerated]
	private bool <IsPartyMember>k__BackingField; // 0x168
	[CompilerGenerated]
	private EmotionPlayer <EmotionPlayer>k__BackingField; // 0x170
	[CompilerGenerated]
	private byte <EmotionType>k__BackingField; // 0x178
	[CompilerGenerated]
	private bool <IsActDead>k__BackingField; // 0x179
	private const float MoveToleranceRange = 0.05;
	private MobaOtherPlayer otherPlayer; // 0x180
	private MobaOtherPlayerBattleStatus battleStatus; // 0x188
	private OtherPlayerPlayActionDataBase currentPlayAction; // 0x190
	private List<OtherPlayerPlayActionDataBase> otherPlayerPlayActionList; // 0x198
	private GameObject dummyMobTareget; // 0x1A0
	private byte hpRate; // 0x1A8
	private ElementType element; // 0x1AC
	private GhostPlayer ghostPlayer; // 0x1B0

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public byte ArchetypeType { get; }
	public int ArchetypeId { get; }
	public override string MobName { get; }
	public override float Size { get; }
	public override bool IsTargetable { get; }
	public override bool HideNameLabel { get; }
	public override bool IsLocalDead { get; }
	public override bool IsDead { get; }
	public TakeController TakeController { get; set; }
	public GameObject DummyMobTareget { get; }
	public override float UnTargetDist { get; }
	public PlayerStatusBase PlayerStatus { get; }
	public override ElementType Element { get; }
	public int MainWeapon { get; set; }
	public int SubWeapon { get; set; }
	public ArchetypeUid ArchetypeUid { get; }
	public Transform ActorTransform { get; }
	public CharacterActionManagerBase ActionManager { get; }
	public bool IsPartyMember { get; set; }
	public EmotionPlayer EmotionPlayer { get; set; }
	public byte EmotionType { get; set; }
	public bool IsActDead { get; set; }
	public byte HpRate { get; }
	private bool IsGhost { get; }

	// Methods

	// RVA: 0x1F8FADC Offset: 0x1F8BADC VA: 0x1F8FADC Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F8FAE4 Offset: 0x1F8BAE4 VA: 0x1F8FAE4 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F8FAEC Offset: 0x1F8BAEC VA: 0x1F8FAEC
	public byte get_ArchetypeType() { }

	// RVA: 0x1F8FB84 Offset: 0x1F8BB84 VA: 0x1F8FB84
	public int get_ArchetypeId() { }

	// RVA: 0x1F8FC1C Offset: 0x1F8BC1C VA: 0x1F8FC1C Slot: 70
	public override string get_MobName() { }

	// RVA: 0x1F8FCB8 Offset: 0x1F8BCB8 VA: 0x1F8FCB8 Slot: 4
	public override float get_Size() { }

	// RVA: 0x1F8FCC0 Offset: 0x1F8BCC0 VA: 0x1F8FCC0 Slot: 67
	public override bool get_IsTargetable() { }

	// RVA: 0x1F8FDE8 Offset: 0x1F8BDE8 VA: 0x1F8FDE8 Slot: 68
	public override bool get_HideNameLabel() { }

	// RVA: 0x1F8FE2C Offset: 0x1F8BE2C VA: 0x1F8FE2C Slot: 5
	public override bool get_IsLocalDead() { }

	// RVA: 0x1F8FE50 Offset: 0x1F8BE50 VA: 0x1F8FE50 Slot: 7
	public override bool get_IsDead() { }

	[CompilerGenerated]
	// RVA: 0x1F8FE74 Offset: 0x1F8BE74 VA: 0x1F8FE74
	public TakeController get_TakeController() { }

	[CompilerGenerated]
	// RVA: 0x1F8FE7C Offset: 0x1F8BE7C VA: 0x1F8FE7C
	private void set_TakeController(TakeController value) { }

	// RVA: 0x1F8FE8C Offset: 0x1F8BE8C VA: 0x1F8FE8C
	public GameObject get_DummyMobTareget() { }

	// RVA: 0x1F9000C Offset: 0x1F8C00C VA: 0x1F9000C Slot: 6
	public override float get_UnTargetDist() { }

	// RVA: 0x1F90018 Offset: 0x1F8C018 VA: 0x1F90018
	public PlayerStatusBase get_PlayerStatus() { }

	// RVA: 0x1F90020 Offset: 0x1F8C020 VA: 0x1F90020 Slot: 69
	public override ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x1F90028 Offset: 0x1F8C028 VA: 0x1F90028 Slot: 95
	public int get_MainWeapon() { }

	[CompilerGenerated]
	// RVA: 0x1F90030 Offset: 0x1F8C030 VA: 0x1F90030
	private void set_MainWeapon(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F90038 Offset: 0x1F8C038 VA: 0x1F90038 Slot: 96
	public int get_SubWeapon() { }

	[CompilerGenerated]
	// RVA: 0x1F90040 Offset: 0x1F8C040 VA: 0x1F90040
	private void set_SubWeapon(int value) { }

	// RVA: 0x1F90048 Offset: 0x1F8C048 VA: 0x1F90048 Slot: 97
	public ArchetypeUid get_ArchetypeUid() { }

	// RVA: 0x1F900C4 Offset: 0x1F8C0C4 VA: 0x1F900C4 Slot: 98
	public Transform get_ActorTransform() { }

	// RVA: 0x1F900CC Offset: 0x1F8C0CC VA: 0x1F900CC Slot: 99
	public CharacterActionManagerBase get_ActionManager() { }

	[CompilerGenerated]
	// RVA: 0x1F900D0 Offset: 0x1F8C0D0 VA: 0x1F900D0 Slot: 100
	public bool get_IsPartyMember() { }

	[CompilerGenerated]
	// RVA: 0x1F900D8 Offset: 0x1F8C0D8 VA: 0x1F900D8
	private void set_IsPartyMember(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F900E4 Offset: 0x1F8C0E4 VA: 0x1F900E4 Slot: 101
	public EmotionPlayer get_EmotionPlayer() { }

	[CompilerGenerated]
	// RVA: 0x1F900EC Offset: 0x1F8C0EC VA: 0x1F900EC
	private void set_EmotionPlayer(EmotionPlayer value) { }

	[CompilerGenerated]
	// RVA: 0x1F900FC Offset: 0x1F8C0FC VA: 0x1F900FC Slot: 103
	public byte get_EmotionType() { }

	[CompilerGenerated]
	// RVA: 0x1F90104 Offset: 0x1F8C104 VA: 0x1F90104
	private void set_EmotionType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1F9010C Offset: 0x1F8C10C VA: 0x1F9010C Slot: 104
	public bool get_IsActDead() { }

	[CompilerGenerated]
	// RVA: 0x1F90114 Offset: 0x1F8C114 VA: 0x1F90114
	private void set_IsActDead(bool value) { }

	// RVA: 0x1F90120 Offset: 0x1F8C120 VA: 0x1F90120
	public byte get_HpRate() { }

	// RVA: 0x1F90128 Offset: 0x1F8C128 VA: 0x1F90128
	private bool get_IsGhost() { }

	// RVA: 0x1F901B0 Offset: 0x1F8C1B0 VA: 0x1F901B0 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F90430 Offset: 0x1F8C430 VA: 0x1F90430 Slot: 73
	protected override void Update() { }

	// RVA: 0x1F905A4 Offset: 0x1F8C5A4 VA: 0x1F905A4
	private void MoveAnimationCheck() { }

	// RVA: 0x1F90848 Offset: 0x1F8C848 VA: 0x1F90848 Slot: 74
	public override bool CheckMultiFlag(MobMultiFlag flag) { }

	// RVA: 0x1F90860 Offset: 0x1F8C860 VA: 0x1F90860 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F90AF4 Offset: 0x1F8CAF4 VA: 0x1F90AF4 Slot: 17
	public override void OnDead() { }

	// RVA: 0x1F8B434 Offset: 0x1F87434 VA: 0x1F8B434
	public void SetDeadState(int state) { }

	// RVA: 0x1F8A210 Offset: 0x1F86210 VA: 0x1F8A210
	public void OnLeave() { }

	// RVA: 0x1F90D18 Offset: 0x1F8CD18 VA: 0x1F90D18
	public void OnEnter() { }

	// RVA: 0x1F8B440 Offset: 0x1F87440 VA: 0x1F8B440
	public void ChangeGhost() { }

	// RVA: 0x1F90F04 Offset: 0x1F8CF04 VA: 0x1F90F04 Slot: 79
	public override void UpdateHp(int hp) { }

	// RVA: 0x1F90F08 Offset: 0x1F8CF08 VA: 0x1F90F08
	public void UpdateHpRate(byte hpRate) { }

	// RVA: 0x1F8B128 Offset: 0x1F87128 VA: 0x1F8B128
	public void ReceiveProfileData(MobaPlayerOtherData otherData) { }

	// RVA: 0x1F90F10 Offset: 0x1F8CF10 VA: 0x1F90F10
	private bool IsLookAtWall(Vector3 pos) { }

	// RVA: 0x1F910E4 Offset: 0x1F8D0E4 VA: 0x1F910E4
	private bool TargettingSearchMode() { }

	// RVA: 0x1F91184 Offset: 0x1F8D184 VA: 0x1F91184 Slot: 91
	public override bool CheckTargetMob(Vector3 pos, out GameObject target) { }

	// RVA: 0x1F91210 Offset: 0x1F8D210 VA: 0x1F91210 Slot: 92
	public override bool GetNearTargetDist(Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1F912F4 Offset: 0x1F8D2F4 VA: 0x1F912F4 Slot: 93
	public override bool GetNearTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1F913EC Offset: 0x1F8D3EC VA: 0x1F913EC Slot: 94
	public override bool GetFarTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1F914E4 Offset: 0x1F8D4E4 VA: 0x1F914E4 Slot: 80
	public override void Invalidation() { }

	// RVA: 0x1F91588 Offset: 0x1F8D588 VA: 0x1F91588 Slot: 81
	public override void Validation() { }

	// RVA: 0x1F9162C Offset: 0x1F8D62C VA: 0x1F9162C Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1F8C894 Offset: 0x1F88894 VA: 0x1F8C894
	public void ReceiveDamagedToOther(GameObject actor, MobaMobResponseData responseData) { }

	// RVA: 0x1F917AC Offset: 0x1F8D7AC VA: 0x1F917AC
	public void ReceiveDamagedToPlayer(GameObject actor, MobaMobResponseData responseData, SkillActionBase skill) { }

	// RVA: 0x1F917B8 Offset: 0x1F8D7B8 VA: 0x1F917B8 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1F91EF4 Offset: 0x1F8DEF4 VA: 0x1F91EF4
	public void AbnormalSuction(Vector3 actorPos, float effectTime, byte localId, float range) { }

	// RVA: 0x1F91FEC Offset: 0x1F8DFEC VA: 0x1F91FEC
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1F9234C Offset: 0x1F8E34C VA: 0x1F9234C Slot: 78
	public override bool IsValidMatch(IMobIdData mobId) { }

	// RVA: 0x1F90E30 Offset: 0x1F8CE30 VA: 0x1F90E30
	protected void moveAnimationCheck() { }

	// RVA: 0x1F90668 Offset: 0x1F8C668 VA: 0x1F90668
	public void NextAction() { }

	// RVA: 0x1F8B450 Offset: 0x1F87450 VA: 0x1F8B450
	public void ActionCancel() { }

	// RVA: 0x1F8CF00 Offset: 0x1F88F00 VA: 0x1F8CF00
	public void ActionCancel(short skillId, byte localId) { }

	// RVA: 0x1F8A830 Offset: 0x1F86830 VA: 0x1F8A830
	public void SetWeaponType(int main, int sub) { }

	// RVA: 0x1F92488 Offset: 0x1F8E488 VA: 0x1F92488
	private int getWeaponType(int weapon) { }

	// RVA: 0x1F924C4 Offset: 0x1F8E4C4 VA: 0x1F924C4
	private void InterruptCurrentAction(SkillActionBase nextAction) { }

	// RVA: 0x1F926D0 Offset: 0x1F8E6D0 VA: 0x1F926D0
	private void DeadGhost() { }

	// RVA: 0x1F92820 Offset: 0x1F8E820 VA: 0x1F92820
	public void GhostRespawn() { }

	// RVA: 0x1F928D8 Offset: 0x1F8E8D8 VA: 0x1F928D8
	public void OnActionSkillEnd(SkillActionBase action) { }

	// RVA: 0x1F929CC Offset: 0x1F8E9CC VA: 0x1F929CC
	public void SetAvoid(GameObject target, float angle) { }

	// RVA: 0x1F8B880 Offset: 0x1F87880 VA: 0x1F8B880
	public void OnMove(Vector3 position, float rotation, float speed) { }

	// RVA: 0x1F8BF8C Offset: 0x1F87F8C VA: 0x1F8BF8C
	public void SetAttack(GameObject target, AttackStartEventData param) { }

	// RVA: 0x1F8E280 Offset: 0x1F8A280 VA: 0x1F8E280
	public void OnSkillEventReceive(SkillEventData skillEventData) { }

	// RVA: 0x1F8C9A4 Offset: 0x1F889A4 VA: 0x1F8C9A4
	public void SetSupport(GameObject target, SupportStartEventData param) { }

	// RVA: 0x1F8D3AC Offset: 0x1F893AC VA: 0x1F8D3AC
	public void OnEmotion(EmotionData emotionData) { }

	// RVA: 0x1F92B04 Offset: 0x1F8EB04 VA: 0x1F92B04 Slot: 86
	public override MobSendData CreateMobSendData() { }

	// RVA: 0x1F92C3C Offset: 0x1F8EC3C VA: 0x1F92C3C Slot: 87
	public override MobSendDataLight CreateMobSendDataLight() { }

	// RVA: 0x1F92D6C Offset: 0x1F8ED6C VA: 0x1F92D6C Slot: 88
	public override MobIdData CreateMobIdData() { }

	// RVA: 0x1F92E20 Offset: 0x1F8EE20 VA: 0x1F92E20 Slot: 105
	public void Subjugated(GameObject actar) { }

	// RVA: 0x1F92FF8 Offset: 0x1F8EFF8 VA: 0x1F92FF8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F93080 Offset: 0x1F8F080 VA: 0x1F93080
	private void <AddAbnormalState>b__99_0(AbnormalData x) { }

	[CompilerGenerated]
	// RVA: 0x1F93164 Offset: 0x1F8F164 VA: 0x1F93164
	private void <AddAbnormalState>b__99_1(AbnormalData x) { }
}
