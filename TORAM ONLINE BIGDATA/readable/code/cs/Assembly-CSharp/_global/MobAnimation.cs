// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobAnimation : AnimationBase // TypeDefIndex: 293
{
	// Fields
	protected MobAnimationChangeManager animationChangeManager; // 0x38

	// Methods

	// RVA: 0x237F15C Offset: 0x237B15C VA: 0x237F15C
	private void Start() { }

	// RVA: 0x237F16C Offset: 0x237B16C VA: 0x237F16C
	public void PlayDamage() { }

	// RVA: 0x237F1B0 Offset: 0x237B1B0 VA: 0x237F1B0
	public void PlayAttack(int index) { }

	// RVA: 0x237F1D8 Offset: 0x237B1D8 VA: 0x237F1D8
	public void PlayCrossFadeQueued(int id, WrapMode mode, float fadeSecond) { }

	// RVA: 0x237F1E8 Offset: 0x237B1E8 VA: 0x237F1E8 Slot: 36
	protected virtual void playCrossFadeQueued(int id, WrapMode mode, float fadeSecond) { }

	// RVA: 0x237F260 Offset: 0x237B260 VA: 0x237F260
	private bool isRunning() { }

	// RVA: 0x237F270 Offset: 0x237B270 VA: 0x237F270 Slot: 10
	public override bool IsPlay(int id) { }

	// RVA: 0x237F298 Offset: 0x237B298 VA: 0x237F298 Slot: 4
	public override void Play(int id, WrapMode mode) { }

	// RVA: 0x237F2B0 Offset: 0x237B2B0 VA: 0x237F2B0 Slot: 5
	public override void Play(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x237F2C4 Offset: 0x237B2C4 VA: 0x237F2C4 Slot: 6
	public override void Play(int id, WrapMode mode, float speedRate, float fadeSecond) { }

	// RVA: 0x237F374 Offset: 0x237B374 VA: 0x237F374 Slot: 7
	public override void PlayNonCrossFade(int id, WrapMode mode) { }

	// RVA: 0x237F388 Offset: 0x237B388 VA: 0x237F388 Slot: 8
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x237F398 Offset: 0x237B398 VA: 0x237F398 Slot: 9
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate, bool crossFadeLock) { }

	// RVA: 0x237F418 Offset: 0x237B418 VA: 0x237F418 Slot: 16
	public override void PlayNatural() { }

	// RVA: 0x237F46C Offset: 0x237B46C VA: 0x237F46C Slot: 17
	public override void PlayBattleStart() { }

	// RVA: 0x237F470 Offset: 0x237B470 VA: 0x237F470 Slot: 18
	public override void PlayBattleEnd() { }

	// RVA: 0x237F480 Offset: 0x237B480 VA: 0x237F480 Slot: 19
	public override void PlayDead() { }

	// RVA: 0x237F494 Offset: 0x237B494 VA: 0x237F494 Slot: 20
	public override void PlayWalk() { }

	// RVA: 0x237F498 Offset: 0x237B498 VA: 0x237F498 Slot: 21
	public override void PlayRun() { }

	// RVA: 0x237F4AC Offset: 0x237B4AC VA: 0x237F4AC Slot: 22
	public override void PlayBattleWait() { }

	// RVA: 0x237F4BC Offset: 0x237B4BC VA: 0x237F4BC Slot: 23
	public override void PlayBattleRun() { }

	// RVA: 0x237F4CC Offset: 0x237B4CC VA: 0x237F4CC Slot: 37
	public virtual void CreateMobAnimationManager(EnemyMobActionManagerBase actionManager) { }

	// RVA: 0x237F53C Offset: 0x237B53C VA: 0x237F53C Slot: 38
	public virtual void ChangeStatus() { }

	// RVA: 0x237F550 Offset: 0x237B550 VA: 0x237F550 Slot: 39
	public virtual int GetChangeAnimationNo(int animationNo) { }

	// RVA: 0x237F568 Offset: 0x237B568 VA: 0x237F568
	protected bool CheckAnimationChanger() { }

	// RVA: 0x237F578 Offset: 0x237B578 VA: 0x237F578
	public void .ctor() { }
}
