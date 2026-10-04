// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class AnimationBase : MonoBehaviour // TypeDefIndex: 290
{
	// Fields
	private Animation animationComponent; // 0x20
	protected bool nonCrossFadeMotion; // 0x28
	private byte initState; // 0x29
	private Motion motionComponent; // 0x30

	// Properties
	protected Animation animation { get; }
	protected Motion motion { get; }
	public virtual bool IsPlayMotion { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Play(int id, WrapMode mode);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Play(int id, WrapMode mode, float speedRate);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Play(int id, WrapMode mode, float speedRate, float fadeSecond);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void PlayNonCrossFade(int id, WrapMode mode);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void PlayNonCrossFade(int id, WrapMode mode, float speedRate);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void PlayNonCrossFade(int id, WrapMode mode, float speedRate, bool crossFadeLock);

	// RVA: 0x237A16C Offset: 0x237616C VA: 0x237A16C
	protected Animation get_animation() { }

	// RVA: 0x237A27C Offset: 0x237627C VA: 0x237A27C
	protected Motion get_motion() { }

	// RVA: 0x237A378 Offset: 0x2376378 VA: 0x237A378
	public void ClearSelectType() { }

	// RVA: 0x237A380 Offset: 0x2376380 VA: 0x237A380
	protected void SetMotion(Motion compenect) { }

	// RVA: 0x237A388 Offset: 0x2376388 VA: 0x237A388 Slot: 10
	public virtual bool IsPlay(int id) { }

	// RVA: 0x237A450 Offset: 0x2376450 VA: 0x237A450 Slot: 11
	public virtual bool IsPlay(string id) { }

	// RVA: 0x237A474 Offset: 0x2376474 VA: 0x237A474 Slot: 12
	public virtual bool get_IsPlayMotion() { }

	// RVA: 0x237A574 Offset: 0x2376574 VA: 0x237A574 Slot: 13
	public virtual bool IsPlayEnd(int id) { }

	// RVA: 0x237A70C Offset: 0x237670C VA: 0x237A70C Slot: 14
	public virtual void Stop() { }

	// RVA: 0x237A7F8 Offset: 0x23767F8 VA: 0x237A7F8 Slot: 15
	public virtual void AnimationCopy(Animation copyTarget) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void PlayNatural();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void PlayBattleStart();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void PlayBattleEnd();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void PlayDead();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void PlayWalk();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void PlayRun();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void PlayBattleWait();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void PlayBattleRun();

	// RVA: 0x237AB6C Offset: 0x2376B6C VA: 0x237AB6C Slot: 24
	public virtual void Shake() { }

	// RVA: 0x237ABA4 Offset: 0x2376BA4 VA: 0x237ABA4 Slot: 25
	public virtual bool ExistClip(int id) { }

	// RVA: 0x237AC88 Offset: 0x2376C88 VA: 0x237AC88
	private bool ExistAnimationClip(int id) { }

	// RVA: 0x237ABE0 Offset: 0x2376BE0 VA: 0x237ABE0
	private bool ExistMotionClip(int id) { }

	// RVA: 0x237ADCC Offset: 0x2376DCC VA: 0x237ADCC Slot: 26
	public virtual float GetAnimationTimeForTake(int id) { }

	// RVA: 0x237AE80 Offset: 0x2376E80 VA: 0x237AE80 Slot: 27
	public virtual float GetAnimationLengthForTake(int id) { }

	// RVA: 0x237AF94 Offset: 0x2376F94 VA: 0x237AF94 Slot: 28
	public virtual float GetAnimationSpeedForTake(int id) { }

	// RVA: 0x237B020 Offset: 0x2377020 VA: 0x237B020 Slot: 29
	public virtual void SetAnimationSpeedForTake(int id, float speed) { }

	// RVA: 0x237B0C8 Offset: 0x23770C8 VA: 0x237B0C8 Slot: 30
	public virtual void SetAnimationTimeForTake(int id, float time) { }

	// RVA: 0x237B170 Offset: 0x2377170 VA: 0x237B170 Slot: 31
	public virtual int GetCustomizedAnimationId(int id) { }

	// RVA: 0x237B178 Offset: 0x2377178 VA: 0x237B178 Slot: 32
	public virtual bool CheckPlayMode(int id, WrapMode mode) { }

	// RVA: 0x237B2C4 Offset: 0x23772C4 VA: 0x237B2C4 Slot: 33
	public virtual void ChangePlayMode(int id, WrapMode mode) { }

	// RVA: 0x237B464 Offset: 0x2377464 VA: 0x237B464
	protected void playNonCrossFade(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x237B6CC Offset: 0x23776CC VA: 0x237B6CC
	protected void play(int id, WrapMode mode, float speedRate, float fadeSecond) { }

	// RVA: 0x237B958 Offset: 0x2377958 VA: 0x237B958
	protected void playEndFrameStop(int id) { }

	// RVA: 0x237BAD8 Offset: 0x2377AD8 VA: 0x237BAD8
	public void SetPlayCrossFadeQueued(int id, WrapMode mode, float fadeSecond) { }

	// RVA: 0x237BADC Offset: 0x2377ADC VA: 0x237BADC
	protected void setPlayCrossFadeQueued(int id, WrapMode mode, float fadeSecond) { }

	// RVA: 0x237BC6C Offset: 0x2377C6C VA: 0x237BC6C
	protected void systemStop() { }

	// RVA: 0x237BD4C Offset: 0x2377D4C VA: 0x237BD4C Slot: 34
	public virtual void AnimationCopy(GameObject copyTarget) { }

	// RVA: 0x237C270 Offset: 0x2378270 VA: 0x237C270 Slot: 35
	public virtual void SetCullingType(AnimationCullingType type) { }

	// RVA: 0x237C344 Offset: 0x2378344 VA: 0x237C344
	protected void .ctor() { }
}
