// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AnimationSimple : AnimationBase // TypeDefIndex: 4615
{
	// Fields
	private int playedMotion; // 0x38

	// Properties
	public int LastPlayedAnimationId { get; }

	// Methods

	// RVA: 0x253AA80 Offset: 0x2536A80 VA: 0x253AA80
	public int get_LastPlayedAnimationId() { }

	// RVA: 0x253AA88 Offset: 0x2536A88 VA: 0x253AA88 Slot: 4
	public override void Play(int id, WrapMode mode) { }

	// RVA: 0x253AAA0 Offset: 0x2536AA0 VA: 0x253AAA0 Slot: 5
	public override void Play(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x253AAB4 Offset: 0x2536AB4 VA: 0x253AAB4 Slot: 6
	public override void Play(int id, WrapMode mode, float speedRate, float fadeSecond) { }

	// RVA: 0x253AE14 Offset: 0x2536E14 VA: 0x253AE14 Slot: 16
	public override void PlayNatural() { }

	// RVA: 0x253AE28 Offset: 0x2536E28 VA: 0x253AE28 Slot: 17
	public override void PlayBattleStart() { }

	// RVA: 0x253AE3C Offset: 0x2536E3C VA: 0x253AE3C Slot: 18
	public override void PlayBattleEnd() { }

	// RVA: 0x253AE50 Offset: 0x2536E50 VA: 0x253AE50 Slot: 19
	public override void PlayDead() { }

	// RVA: 0x253AE64 Offset: 0x2536E64 VA: 0x253AE64 Slot: 20
	public override void PlayWalk() { }

	// RVA: 0x253AE78 Offset: 0x2536E78 VA: 0x253AE78 Slot: 21
	public override void PlayRun() { }

	// RVA: 0x253AE8C Offset: 0x2536E8C VA: 0x253AE8C Slot: 7
	public override void PlayNonCrossFade(int id, WrapMode mode) { }

	// RVA: 0x253AEA0 Offset: 0x2536EA0 VA: 0x253AEA0 Slot: 8
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x253AEB0 Offset: 0x2536EB0 VA: 0x253AEB0 Slot: 9
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate, bool crossFadeLock) { }

	// RVA: 0x253B038 Offset: 0x2537038 VA: 0x253B038 Slot: 22
	public override void PlayBattleWait() { }

	// RVA: 0x253B04C Offset: 0x253704C VA: 0x253B04C Slot: 23
	public override void PlayBattleRun() { }

	// RVA: 0x253B060 Offset: 0x2537060 VA: 0x253B060
	private void playStepSound() { }

	// RVA: 0x253B110 Offset: 0x2537110 VA: 0x253B110
	public void .ctor() { }
}
