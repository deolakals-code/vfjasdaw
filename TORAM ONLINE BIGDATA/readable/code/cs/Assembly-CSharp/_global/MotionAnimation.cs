// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MotionAnimation : AnimationBase // TypeDefIndex: 302
{
	// Fields
	private Motion motionComp; // 0x38

	// Methods

	// RVA: 0x23826B4 Offset: 0x237E6B4 VA: 0x23826B4
	private void Awake() { }

	// RVA: 0x238270C Offset: 0x237E70C VA: 0x238270C Slot: 4
	public override void Play(int id, WrapMode mode) { }

	// RVA: 0x2382724 Offset: 0x237E724 VA: 0x2382724 Slot: 5
	public override void Play(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x2382738 Offset: 0x237E738 VA: 0x2382738 Slot: 6
	public override void Play(int id, WrapMode mode, float speedRate, float fadeSecond) { }

	// RVA: 0x238276C Offset: 0x237E76C VA: 0x238276C Slot: 7
	public override void PlayNonCrossFade(int id, WrapMode mode) { }

	// RVA: 0x2382780 Offset: 0x237E780 VA: 0x2382780 Slot: 8
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x2382790 Offset: 0x237E790 VA: 0x2382790 Slot: 9
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate, bool crossFadeLock) { }

	// RVA: 0x23827C0 Offset: 0x237E7C0 VA: 0x23827C0 Slot: 10
	public override bool IsPlay(int id) { }

	// RVA: 0x23827E4 Offset: 0x237E7E4 VA: 0x23827E4 Slot: 13
	public override bool IsPlayEnd(int id) { }

	// RVA: 0x238281C Offset: 0x237E81C VA: 0x238281C Slot: 14
	public override void Stop() { }

	// RVA: 0x238283C Offset: 0x237E83C VA: 0x238283C Slot: 15
	public override void AnimationCopy(Animation copyTarget) { }

	// RVA: 0x2382840 Offset: 0x237E840 VA: 0x2382840 Slot: 25
	public override bool ExistClip(int id) { }

	// RVA: 0x2382858 Offset: 0x237E858 VA: 0x2382858 Slot: 26
	public override float GetAnimationTimeForTake(int id) { }

	// RVA: 0x23828A0 Offset: 0x237E8A0 VA: 0x23828A0 Slot: 27
	public override float GetAnimationLengthForTake(int id) { }

	// RVA: 0x23828F0 Offset: 0x237E8F0 VA: 0x23828F0 Slot: 28
	public override float GetAnimationSpeedForTake(int id) { }

	// RVA: 0x2382928 Offset: 0x237E928 VA: 0x2382928 Slot: 29
	public override void SetAnimationSpeedForTake(int id, float speed) { }

	// RVA: 0x2382968 Offset: 0x237E968 VA: 0x2382968 Slot: 16
	public override void PlayNatural() { }

	// RVA: 0x238297C Offset: 0x237E97C VA: 0x238297C Slot: 17
	public override void PlayBattleStart() { }

	// RVA: 0x2382990 Offset: 0x237E990 VA: 0x2382990 Slot: 18
	public override void PlayBattleEnd() { }

	// RVA: 0x23829A4 Offset: 0x237E9A4 VA: 0x23829A4 Slot: 19
	public override void PlayDead() { }

	// RVA: 0x23829B8 Offset: 0x237E9B8 VA: 0x23829B8 Slot: 20
	public override void PlayWalk() { }

	// RVA: 0x23829CC Offset: 0x237E9CC VA: 0x23829CC Slot: 21
	public override void PlayRun() { }

	// RVA: 0x23829E0 Offset: 0x237E9E0 VA: 0x23829E0 Slot: 22
	public override void PlayBattleWait() { }

	// RVA: 0x23829F4 Offset: 0x237E9F4 VA: 0x23829F4 Slot: 23
	public override void PlayBattleRun() { }

	// RVA: 0x2382A08 Offset: 0x237EA08 VA: 0x2382A08
	public void .ctor() { }
}
