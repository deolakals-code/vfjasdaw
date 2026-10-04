// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ClonePlayerAnimation : PlayerAnimation // TypeDefIndex: 292
{
	// Fields
	[CompilerGenerated]
	private List<NpcSkillData> <SkillDataList>k__BackingField; // 0x50
	private Dictionary<int, int> customMotionId; // 0x58
	private Dictionary<AutoMemberCustomMotionType, List<int>> customAnimationId; // 0x60
	private Dictionary<SkillId, int> customSkillAnimationId; // 0x68
	private TakeController takeControl; // 0x70
	private BattleManagerBase battleManager; // 0x78
	private bool isFixedNormalAttack; // 0x80
	private int fixedNormalAttackIndex; // 0x84
	private bool stopPlaySE; // 0x88

	// Properties
	public List<NpcSkillData> SkillDataList { get; set; }
	public bool isDeadPlay { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x237C354 Offset: 0x2378354 VA: 0x237C354
	public List<NpcSkillData> get_SkillDataList() { }

	[CompilerGenerated]
	// RVA: 0x237C35C Offset: 0x237835C VA: 0x237C35C
	private void set_SkillDataList(List<NpcSkillData> value) { }

	// RVA: 0x237C364 Offset: 0x2378364 VA: 0x237C364 Slot: 39
	public override void playStepSound() { }

	// RVA: 0x237C3D4 Offset: 0x23783D4 VA: 0x237C3D4
	public void SetPlaySE(bool flag) { }

	// RVA: 0x237C3E4 Offset: 0x23783E4 VA: 0x237C3E4 Slot: 36
	public override void Initialize(int mainWeapon, int subWeapon, bool isMan) { }

	// RVA: 0x237C484 Offset: 0x2378484 VA: 0x237C484
	public void Initialize(Animation baseanime, int mainWeapon, int subWeapon, bool isMan) { }

	// RVA: 0x237C974 Offset: 0x2378974 VA: 0x237C974
	public void InitializeCustomizeAnimation(NPCPartySettingBase setting) { }

	// RVA: 0x237CEC8 Offset: 0x2378EC8 VA: 0x237CEC8
	public void InitializeCustomizeAnimation(NpcOtherData npc, NewArchetypeProperties properties, bool isMan) { }

	// RVA: 0x237D340 Offset: 0x2379340 VA: 0x237D340
	public void InitializeCustomizeAnimation(NpcMotionData[] custom) { }

	// RVA: 0x237D5A0 Offset: 0x23795A0 VA: 0x237D5A0
	public void CopyCloneAnimation(ClonePlayerAnimation clonePlayerAnimation) { }

	// RVA: 0x237D608 Offset: 0x2379608 VA: 0x237D608
	private void playCrossFadeQueued(int id, WrapMode mode, float fadeSec) { }

	// RVA: 0x237D6C0 Offset: 0x23796C0 VA: 0x237D6C0 Slot: 37
	public override void PlayRevival() { }

	// RVA: 0x237D734 Offset: 0x2379734 VA: 0x237D734 Slot: 38
	public override void PlayGuard() { }

	// RVA: 0x237D818 Offset: 0x2379818 VA: 0x237D818
	public void PlayFlinch() { }

	// RVA: 0x237D85C Offset: 0x237985C VA: 0x237D85C
	public void PlayTumble() { }

	// RVA: 0x237D8A0 Offset: 0x23798A0 VA: 0x237D8A0
	public void PlayStun() { }

	// RVA: 0x237D980 Offset: 0x2379980 VA: 0x237D980
	public void PlayKnockBack() { }

	// RVA: 0x237D9D0 Offset: 0x23799D0 VA: 0x237D9D0
	public void PlayKBackReturn() { }

	// RVA: 0x237D72C Offset: 0x237972C VA: 0x237D72C
	private bool tryGetCustomAnimationId(AutoMemberCustomMotionType type, ref int animId) { }

	// RVA: 0x237DAC4 Offset: 0x2379AC4 VA: 0x237DAC4
	private bool tryGetCustomAnimationId(AutoMemberCustomMotionType type, ref int animId, bool fromPlay) { }

	// RVA: 0x237DBF4 Offset: 0x2379BF4 VA: 0x237DBF4
	private bool tryGetCustomSkillAnimationId(ref int animId) { }

	// RVA: 0x237DBFC Offset: 0x2379BFC VA: 0x237DBFC
	private bool tryGetCustomSkillAnimationId(ref int animId, bool fromPlay) { }

	[IteratorStateMachine(typeof(ClonePlayerAnimation.<playCustomizedAnimation>d__32))]
	// RVA: 0x237E300 Offset: 0x237A300 VA: 0x237E300
	private IEnumerator playCustomizedAnimation(int id, WrapMode mode, float speedRate, float fadeSecond) { }

	// RVA: 0x237E3C4 Offset: 0x237A3C4 VA: 0x237E3C4 Slot: 4
	public override void Play(int id, WrapMode mode) { }

	// RVA: 0x237E3DC Offset: 0x237A3DC VA: 0x237E3DC Slot: 5
	public override void Play(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x237E3F0 Offset: 0x237A3F0 VA: 0x237E3F0 Slot: 6
	public override void Play(int id, WrapMode mode, float speedRate, float fadeSecond) { }

	// RVA: 0x237E674 Offset: 0x237A674 VA: 0x237E674 Slot: 16
	public override void PlayNatural() { }

	// RVA: 0x237E7E8 Offset: 0x237A7E8 VA: 0x237E7E8 Slot: 17
	public override void PlayBattleStart() { }

	// RVA: 0x237E84C Offset: 0x237A84C VA: 0x237E84C Slot: 18
	public override void PlayBattleEnd() { }

	// RVA: 0x237E8BC Offset: 0x237A8BC VA: 0x237E8BC Slot: 19
	public override void PlayDead() { }

	// RVA: 0x237E954 Offset: 0x237A954 VA: 0x237E954
	public bool get_isDeadPlay() { }

	// RVA: 0x237E9E4 Offset: 0x237A9E4 VA: 0x237E9E4 Slot: 21
	public override void PlayRun() { }

	// RVA: 0x237EA34 Offset: 0x237AA34 VA: 0x237EA34 Slot: 7
	public override void PlayNonCrossFade(int id, WrapMode mode) { }

	// RVA: 0x237EA44 Offset: 0x237AA44 VA: 0x237EA44 Slot: 8
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x237EB00 Offset: 0x237AB00 VA: 0x237EB00 Slot: 22
	public override void PlayBattleWait() { }

	// RVA: 0x237EB08 Offset: 0x237AB08 VA: 0x237EB08
	public void PlayBattleWait(bool force) { }

	// RVA: 0x237EBA0 Offset: 0x237ABA0 VA: 0x237EBA0 Slot: 23
	public override void PlayBattleRun() { }

	// RVA: 0x237EBF4 Offset: 0x237ABF4 VA: 0x237EBF4 Slot: 31
	public override int GetCustomizedAnimationId(int id) { }

	// RVA: 0x237D6A4 Offset: 0x23796A4 VA: 0x237D6A4
	private string getAnimName(PlayerAnimationType type) { }

	// RVA: 0x237D7DC Offset: 0x23797DC VA: 0x237D7DC
	private int getBattleAnimId(PlayerAnimationType type) { }

	// RVA: 0x237EC14 Offset: 0x237AC14 VA: 0x237EC14
	private string getBattleAnimName(PlayerAnimationType type) { }

	// RVA: 0x237E700 Offset: 0x237A700 VA: 0x237E700
	private bool isRunning() { }

	// RVA: 0x237EC64 Offset: 0x237AC64 VA: 0x237EC64 Slot: 41
	protected virtual int GetNaturalAnimationId() { }

	// RVA: 0x237EC70 Offset: 0x237AC70 VA: 0x237EC70
	public void .ctor() { }
}
