// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(PlayerAnimation))]
public class OtherPlayerActionManager : PlayerActionManagerBase, IOtherPlayerActionManager // TypeDefIndex: 1246
{
	// Fields
	private AbnormalStateManager abnormalStateManager; // 0x88
	[CompilerGenerated]
	private bool <IsPartyMember>k__BackingField; // 0x90
	[CompilerGenerated]
	private EmotionPlayer <EmotionPlayer>k__BackingField; // 0x98
	[CompilerGenerated]
	private byte <EmotionType>k__BackingField; // 0xA0
	public CrazyDaggerBuf crazyDagger; // 0xA8
	[CompilerGenerated]
	private int <MainWeapon>k__BackingField; // 0xB0
	[CompilerGenerated]
	private int <SubWeapon>k__BackingField; // 0xB4
	private bool isDead; // 0xB8
	private bool isActDead; // 0xB9
	private OtherPlayerPlayActionDataBase currentPlayAction; // 0xC0
	private List<OtherPlayerPlayActionDataBase> otherPlayerPlayActionList; // 0xC8
	private BufferEffectManager bufferEffectManager; // 0xD0
	private OtherPlayer otherPlayer; // 0xD8
	private OtherPlayerSkillActionPlayer skillActionPlayer; // 0xE0
	private GameObject dummyMobTareget; // 0xE8

	// Properties
	public override PlayerStatusBase PlayerStatus { get; }
	public GameObject DummyMobTareget { get; }
	public override BufferEffectManager BufferEffectManager { get; }
	public override AbnormalStateManager AbnormalStatusManager { get; }
	public OtherPlayer OtherPlayer { get; }
	public override bool IsDead { get; }
	public bool IsActDead { get; }
	public bool IsPartyMember { get; set; }
	public EmotionPlayer EmotionPlayer { get; set; }
	public byte EmotionType { get; set; }
	public override bool IsHideUser { get; }
	public int MainWeapon { get; set; }
	public int SubWeapon { get; set; }
	public ArchetypeUid ArchetypeUid { get; }
	public Transform ActorTransform { get; }
	public CharacterActionManagerBase ActionManager { get; }

	// Methods

	// RVA: 0x1FA2CD0 Offset: 0x1F9ECD0 VA: 0x1FA2CD0 Slot: 22
	public override PlayerStatusBase get_PlayerStatus() { }

	// RVA: 0x1FA2CD8 Offset: 0x1F9ECD8 VA: 0x1FA2CD8
	public GameObject get_DummyMobTareget() { }

	// RVA: 0x1FA2E54 Offset: 0x1F9EE54 VA: 0x1FA2E54 Slot: 24
	public override BufferEffectManager get_BufferEffectManager() { }

	// RVA: 0x1FA2E5C Offset: 0x1F9EE5C VA: 0x1FA2E5C Slot: 23
	public override AbnormalStateManager get_AbnormalStatusManager() { }

	// RVA: 0x1FA2E64 Offset: 0x1F9EE64 VA: 0x1FA2E64
	public OtherPlayer get_OtherPlayer() { }

	// RVA: 0x1FA2E6C Offset: 0x1F9EE6C VA: 0x1FA2E6C Slot: 7
	public override bool get_IsDead() { }

	// RVA: 0x1FA2E74 Offset: 0x1F9EE74 VA: 0x1FA2E74 Slot: 59
	public bool get_IsActDead() { }

	[CompilerGenerated]
	// RVA: 0x1FA2E7C Offset: 0x1F9EE7C VA: 0x1FA2E7C Slot: 55
	public bool get_IsPartyMember() { }

	[CompilerGenerated]
	// RVA: 0x1FA2E84 Offset: 0x1F9EE84 VA: 0x1FA2E84
	private void set_IsPartyMember(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1FA2E90 Offset: 0x1F9EE90 VA: 0x1FA2E90
	private void set_EmotionPlayer(EmotionPlayer value) { }

	[CompilerGenerated]
	// RVA: 0x1FA2E98 Offset: 0x1F9EE98 VA: 0x1FA2E98 Slot: 56
	public EmotionPlayer get_EmotionPlayer() { }

	[CompilerGenerated]
	// RVA: 0x1FA2EA0 Offset: 0x1F9EEA0 VA: 0x1FA2EA0 Slot: 58
	public byte get_EmotionType() { }

	[CompilerGenerated]
	// RVA: 0x1FA2EA8 Offset: 0x1F9EEA8 VA: 0x1FA2EA8
	private void set_EmotionType(byte value) { }

	// RVA: 0x1FA2EB0 Offset: 0x1F9EEB0 VA: 0x1FA2EB0 Slot: 21
	public override bool get_IsHideUser() { }

	[CompilerGenerated]
	// RVA: 0x1FA2ED4 Offset: 0x1F9EED4 VA: 0x1FA2ED4 Slot: 50
	public int get_MainWeapon() { }

	[CompilerGenerated]
	// RVA: 0x1FA2EDC Offset: 0x1F9EEDC VA: 0x1FA2EDC
	private void set_MainWeapon(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FA2EE4 Offset: 0x1F9EEE4 VA: 0x1FA2EE4 Slot: 51
	public int get_SubWeapon() { }

	[CompilerGenerated]
	// RVA: 0x1FA2EEC Offset: 0x1F9EEEC VA: 0x1FA2EEC
	private void set_SubWeapon(int value) { }

	// RVA: 0x1FA2EF4 Offset: 0x1F9EEF4 VA: 0x1FA2EF4 Slot: 52
	public ArchetypeUid get_ArchetypeUid() { }

	// RVA: 0x1FA2F74 Offset: 0x1F9EF74 VA: 0x1FA2F74 Slot: 53
	public Transform get_ActorTransform() { }

	// RVA: 0x1FA2F7C Offset: 0x1F9EF7C VA: 0x1FA2F7C Slot: 54
	public CharacterActionManagerBase get_ActionManager() { }

	// RVA: 0x1FA2F80 Offset: 0x1F9EF80 VA: 0x1FA2F80 Slot: 46
	protected override void Initialize(PlayerObjectBase playerObject) { }

	// RVA: 0x1FA3190 Offset: 0x1F9F190 VA: 0x1FA3190
	private void Update() { }

	// RVA: 0x1FA3720 Offset: 0x1F9F720 VA: 0x1FA3720
	public void OnChangePartyMember(bool party) { }

	// RVA: 0x1F9FCE8 Offset: 0x1F9BCE8 VA: 0x1F9FCE8
	public void GetCharacterAnimationComponent() { }

	// RVA: 0x1FA372C Offset: 0x1F9F72C VA: 0x1FA372C Slot: 17
	public override void OnDead() { }

	// RVA: 0x1FA3928 Offset: 0x1F9F928 VA: 0x1FA3928
	public void SetDeadState(int state) { }

	// RVA: 0x1FA3934 Offset: 0x1F9F934 VA: 0x1FA3934 Slot: 30
	public override void OnRespawn() { }

	// RVA: 0x1FA39D0 Offset: 0x1F9F9D0 VA: 0x1FA39D0
	public void OnLeave() { }

	// RVA: 0x1FA3CD4 Offset: 0x1F9FCD4 VA: 0x1FA3CD4
	public void OnEnter() { }

	// RVA: 0x1F9FD98 Offset: 0x1F9BD98 VA: 0x1F9FD98
	public void SetWeaponType(int main, int sub) { }

	// RVA: 0x1FA3ED4 Offset: 0x1F9FED4 VA: 0x1FA3ED4
	private int getWeaponType(int weapon) { }

	// RVA: 0x1FA3478 Offset: 0x1F9F478 VA: 0x1FA3478
	public void NextAction() { }

	// RVA: 0x1FA3F10 Offset: 0x1F9FF10 VA: 0x1FA3F10
	public void SetRespawnPosition(short[] position) { }

	// RVA: 0x1FA3FC4 Offset: 0x1F9FFC4 VA: 0x1FA3FC4
	public void OnActionSkillEnd(SkillActionBase action) { }

	// RVA: 0x1FA40F0 Offset: 0x1FA00F0 VA: 0x1FA40F0
	public void OnMove(Vector3 position, float rotation) { }

	// RVA: 0x1FA40F8 Offset: 0x1FA00F8 VA: 0x1FA40F8
	public void OnMove(Vector3 position, float rotation, float speed) { }

	// RVA: 0x1FA45B4 Offset: 0x1FA05B4 VA: 0x1FA45B4
	public void OnExtraMove(OtherPlayerPlayActionMove actionDataBase) { }

	// RVA: 0x1FA4750 Offset: 0x1FA0750 VA: 0x1FA4750
	public void OnFastMove(Vector3 movePos) { }

	// RVA: 0x1FA4778 Offset: 0x1FA0778 VA: 0x1FA4778
	public void OnExtraAction(OtherPlayerPlayActionDataBase actionDataBase) { }

	// RVA: 0x1FA4828 Offset: 0x1FA0828 VA: 0x1FA4828
	public void SetAttack(GameObject target, AttackStartEventData param) { }

	// RVA: 0x1FA536C Offset: 0x1FA136C VA: 0x1FA536C
	public void SetSupport(GameObject target, SupportStartEventData param) { }

	// RVA: 0x1FA58C4 Offset: 0x1FA18C4 VA: 0x1FA58C4
	public void SetAvoid(GameObject target, float angle) { }

	// RVA: 0x1FA59F8 Offset: 0x1FA19F8 VA: 0x1FA59F8
	public void ActionCancel(short skillId, byte localId) { }

	// RVA: 0x1FA5DDC Offset: 0x1FA1DDC VA: 0x1FA5DDC
	public void OnSkillEventReceive(SkillEventData skillEventData) { }

	// RVA: 0x1FA6CE8 Offset: 0x1FA2CE8 VA: 0x1FA6CE8
	public void OnEmotion(EmotionData emotionData) { }

	// RVA: 0x1FA790C Offset: 0x1FA390C VA: 0x1FA790C Slot: 37
	public override void ActionCancel() { }

	// RVA: 0x1FA7A54 Offset: 0x1FA3A54 VA: 0x1FA7A54
	public bool CheckActionReservation(short skillId) { }

	// RVA: 0x1FA7D28 Offset: 0x1FA3D28 VA: 0x1FA7D28
	public bool CheckFullyActionReservation(short skillId, byte localId) { }

	// RVA: 0x1FA8078 Offset: 0x1FA4078 VA: 0x1FA8078 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1FA8830 Offset: 0x1FA4830 VA: 0x1FA8830
	public bool AddAbnormalState(GameObject actor, MobAttackEventData eventData, bool force) { }

	// RVA: 0x1FA8BD0 Offset: 0x1FA4BD0 VA: 0x1FA8BD0
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1FA8F34 Offset: 0x1FA4F34 VA: 0x1FA8F34
	private bool IsEmotionMoveStop(Vector3 position) { }

	// RVA: 0x1FA8F44 Offset: 0x1FA4F44 VA: 0x1FA8F44
	private bool IsMoveRangeOver(Vector3 position, byte type) { }

	// RVA: 0x1FA4FA0 Offset: 0x1FA0FA0 VA: 0x1FA4FA0
	private void InterruptCurrentAction(SkillActionBase nextAction) { }

	// RVA: 0x1FA8F4C Offset: 0x1FA4F4C VA: 0x1FA8F4C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1FA8FD4 Offset: 0x1FA4FD4 VA: 0x1FA8FD4
	private void <AddAbnormalState>b__80_0(AbnormalData x) { }

	[CompilerGenerated]
	// RVA: 0x1FA90B8 Offset: 0x1FA50B8 VA: 0x1FA90B8
	private void <AddAbnormalState>b__80_1(AbnormalData x) { }
}
