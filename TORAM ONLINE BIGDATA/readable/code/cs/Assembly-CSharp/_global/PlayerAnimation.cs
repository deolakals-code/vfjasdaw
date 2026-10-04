// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PlayerAnimation : AnimationBase // TypeDefIndex: 304
{
	// Fields
	private static Animation motionData; // 0x0
	private static Dictionary<int, PlayerAnimation.AnimationBaseId> animationBaseIdLink; // 0x8
	private static Dictionary<int, int> animationMotionIdLink; // 0x10
	private bool isPlayer; // 0x38
	protected bool isMan; // 0x39
	protected int mainWeapon; // 0x3C
	protected int subWeapon; // 0x40
	protected int animationBaseId; // 0x44
	[CompilerGenerated]
	private int <LastPlayedAnimationId>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsMerging>k__BackingField; // 0x4C

	// Properties
	protected static Animation Motion { get; }
	public bool IsMan { get; }
	public int MainWeapon { get; }
	public int SubWeapon { get; }
	public int LastPlayedAnimationId { get; set; }
	public bool IsMerging { get; set; }

	// Methods

	// RVA: 0x2382A18 Offset: 0x237EA18 VA: 0x2382A18
	protected static Animation get_Motion() { }

	// RVA: 0x2382B7C Offset: 0x237EB7C VA: 0x2382B7C
	public bool get_IsMan() { }

	// RVA: 0x2382B84 Offset: 0x237EB84 VA: 0x2382B84
	public int get_MainWeapon() { }

	// RVA: 0x2382B8C Offset: 0x237EB8C VA: 0x2382B8C
	public int get_SubWeapon() { }

	[CompilerGenerated]
	// RVA: 0x2382B94 Offset: 0x237EB94 VA: 0x2382B94
	public int get_LastPlayedAnimationId() { }

	[CompilerGenerated]
	// RVA: 0x2382B9C Offset: 0x237EB9C VA: 0x2382B9C
	protected void set_LastPlayedAnimationId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2382BA4 Offset: 0x237EBA4 VA: 0x2382BA4
	public bool get_IsMerging() { }

	[CompilerGenerated]
	// RVA: 0x2382BAC Offset: 0x237EBAC VA: 0x2382BAC
	public void set_IsMerging(bool value) { }

	// RVA: 0x2382BB8 Offset: 0x237EBB8 VA: 0x2382BB8
	private void Awake() { }

	// RVA: 0x2382BD8 Offset: 0x237EBD8 VA: 0x2382BD8
	private void Start() { }

	// RVA: 0x2382C60 Offset: 0x237EC60 VA: 0x2382C60
	private void Update() { }

	// RVA: 0x2382C64 Offset: 0x237EC64 VA: 0x2382C64 Slot: 36
	public virtual void Initialize(int mainWeapon, int subWeapon, bool isMan) { }

	// RVA: 0x2382DA0 Offset: 0x237EDA0 VA: 0x2382DA0
	public void InitializeBattleBaseId(int id, bool isMan) { }

	// RVA: 0x2382E6C Offset: 0x237EE6C VA: 0x2382E6C
	private void playCrossFadeQueued(int id, WrapMode mode, float fadeSec) { }

	// RVA: 0x2383030 Offset: 0x237F030 VA: 0x2383030 Slot: 37
	public virtual void PlayRevival() { }

	// RVA: 0x238307C Offset: 0x237F07C VA: 0x238307C Slot: 38
	public virtual void PlayGuard() { }

	// RVA: 0x23830F8 Offset: 0x237F0F8 VA: 0x23830F8 Slot: 39
	public virtual void playStepSound() { }

	// RVA: 0x23831B8 Offset: 0x237F1B8 VA: 0x23831B8 Slot: 14
	public override void Stop() { }

	// RVA: 0x23831BC Offset: 0x237F1BC VA: 0x23831BC
	public void CompleteStop() { }

	// RVA: 0x23831C0 Offset: 0x237F1C0 VA: 0x23831C0
	public void EnterAnimation(int id) { }

	// RVA: 0x23831E8 Offset: 0x237F1E8 VA: 0x23831E8 Slot: 25
	public override bool ExistClip(int id) { }

	// RVA: 0x2382F3C Offset: 0x237EF3C VA: 0x2382F3C
	private bool ExistClip(string animeName) { }

	// RVA: 0x2383220 Offset: 0x237F220 VA: 0x2383220 Slot: 27
	public override float GetAnimationLengthForTake(int id) { }

	// RVA: 0x2383290 Offset: 0x237F290 VA: 0x2383290 Slot: 15
	public override void AnimationCopy(Animation copyTarget) { }

	// RVA: 0x23833E0 Offset: 0x237F3E0 VA: 0x23833E0 Slot: 4
	public override void Play(int id, WrapMode mode) { }

	// RVA: 0x23833F8 Offset: 0x237F3F8 VA: 0x23833F8 Slot: 5
	public override void Play(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x238340C Offset: 0x237F40C VA: 0x238340C Slot: 6
	public override void Play(int id, WrapMode mode, float speedRate, float fadeSecond) { }

	// RVA: 0x2383718 Offset: 0x237F718 VA: 0x2383718
	public bool IsPlayBattleAnimation(PlayerAnimationType type) { }

	// RVA: 0x23837A4 Offset: 0x237F7A4 VA: 0x23837A4 Slot: 16
	public override void PlayNatural() { }

	// RVA: 0x2383930 Offset: 0x237F930 VA: 0x2383930 Slot: 17
	public override void PlayBattleStart() { }

	// RVA: 0x2383970 Offset: 0x237F970 VA: 0x2383970 Slot: 18
	public override void PlayBattleEnd() { }

	// RVA: 0x23839C0 Offset: 0x237F9C0 VA: 0x23839C0 Slot: 19
	public override void PlayDead() { }

	// RVA: 0x23839F8 Offset: 0x237F9F8 VA: 0x23839F8 Slot: 20
	public override void PlayWalk() { }

	// RVA: 0x2383A18 Offset: 0x237FA18 VA: 0x2383A18 Slot: 21
	public override void PlayRun() { }

	// RVA: 0x2383A38 Offset: 0x237FA38 VA: 0x2383A38 Slot: 7
	public override void PlayNonCrossFade(int id, WrapMode mode) { }

	// RVA: 0x2383A4C Offset: 0x237FA4C VA: 0x2383A4C Slot: 8
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x2383A5C Offset: 0x237FA5C VA: 0x2383A5C Slot: 9
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate, bool croosFadeLock) { }

	// RVA: 0x2383C04 Offset: 0x237FC04 VA: 0x2383C04 Slot: 22
	public override void PlayBattleWait() { }

	// RVA: 0x2383C64 Offset: 0x237FC64 VA: 0x2383C64 Slot: 23
	public override void PlayBattleRun() { }

	// RVA: 0x2383C88 Offset: 0x237FC88 VA: 0x2383C88
	public void PlayForceBattleWait() { }

	// RVA: 0x2383CAC Offset: 0x237FCAC VA: 0x2383CAC
	public void PlayForceDead() { }

	// RVA: 0x2383D48 Offset: 0x237FD48 VA: 0x2383D48
	public AnimationClip GetClip(string animeName) { }

	// RVA: 0x2382F20 Offset: 0x237EF20 VA: 0x2382F20
	private string getAnimName(PlayerAnimationType type) { }

	// RVA: 0x2382E30 Offset: 0x237EE30 VA: 0x2382E30
	private int getBattleAnimId(PlayerAnimationType type) { }

	// RVA: 0x2383E50 Offset: 0x237FE50 VA: 0x2383E50
	private string getBattleAnimName(PlayerAnimationType type) { }

	// RVA: 0x2383814 Offset: 0x237F814 VA: 0x2383814
	private bool isRunning() { }

	// RVA: 0x2383EA0 Offset: 0x237FEA0 VA: 0x2383EA0 Slot: 40
	protected virtual int GetNatualAnimationId() { }

	// RVA: 0x237C908 Offset: 0x2378908 VA: 0x237C908
	protected int getAnimationBaseId(int mainWeaponItemType, int subWeaponItemType) { }

	// RVA: 0x2383F9C Offset: 0x237FF9C VA: 0x2383F9C
	public static int GetModelBattleBaseAnimationId(int mainWeaponModelId, int subWeaponModelId) { }

	// RVA: 0x2383EAC Offset: 0x237FEAC VA: 0x2383EAC
	public static int GetBattleBaseAnimationId(int mainWeaponItemType, int subWeaponItemType) { }

	// RVA: 0x237EDE0 Offset: 0x237ADE0 VA: 0x237EDE0
	public void .ctor() { }

	// RVA: 0x23840D4 Offset: 0x23800D4 VA: 0x23840D4
	private static void .cctor() { }
}
