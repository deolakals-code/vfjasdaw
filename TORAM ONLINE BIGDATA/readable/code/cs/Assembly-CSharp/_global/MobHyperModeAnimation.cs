// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobHyperModeAnimation : MobAnimation // TypeDefIndex: 296
{
	// Fields
	private Dictionary<int, MobAnimation> memberAnimation; // 0x40
	private int playModelId; // 0x48

	// Properties
	public override bool IsPlayMotion { get; }

	// Methods

	// RVA: 0x237F988 Offset: 0x237B988 VA: 0x237F988 Slot: 12
	public override bool get_IsPlayMotion() { }

	// RVA: 0x237FA28 Offset: 0x237BA28 VA: 0x237FA28
	public void Valid(int model) { }

	// RVA: 0x237FA8C Offset: 0x237BA8C VA: 0x237FA8C
	public void AddMobAnimation(int model, MobAnimation animation) { }

	// RVA: 0x237FB14 Offset: 0x237BB14 VA: 0x237FB14
	public bool CheckModel(int model) { }

	// RVA: 0x237FB88 Offset: 0x237BB88 VA: 0x237FB88 Slot: 36
	protected override void playCrossFadeQueued(int id, WrapMode mode, float fadeSecond) { }

	// RVA: 0x237FC5C Offset: 0x237BC5C VA: 0x237FC5C Slot: 10
	public override bool IsPlay(int id) { }

	// RVA: 0x237FCC8 Offset: 0x237BCC8 VA: 0x237FCC8 Slot: 11
	public override bool IsPlay(string id) { }

	// RVA: 0x237FD34 Offset: 0x237BD34 VA: 0x237FD34 Slot: 6
	public override void Play(int id, WrapMode mode, float speedRate, float fadeSecond) { }

	// RVA: 0x237FEB8 Offset: 0x237BEB8 VA: 0x237FEB8 Slot: 14
	public override void Stop() { }

	// RVA: 0x237FF54 Offset: 0x237BF54 VA: 0x237FF54 Slot: 7
	public override void PlayNonCrossFade(int id, WrapMode mode) { }

	// RVA: 0x237FFD8 Offset: 0x237BFD8 VA: 0x237FFD8 Slot: 8
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate) { }

	// RVA: 0x2380068 Offset: 0x237C068 VA: 0x2380068 Slot: 9
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate, bool crossFadeLock) { }

	// RVA: 0x2380138 Offset: 0x237C138 VA: 0x2380138
	public AnimationClip GetClip(string name) { }

	// RVA: 0x23801FC Offset: 0x237C1FC VA: 0x23801FC Slot: 26
	public override float GetAnimationTimeForTake(int id) { }

	// RVA: 0x23802AC Offset: 0x237C2AC VA: 0x23802AC Slot: 27
	public override float GetAnimationLengthForTake(int id) { }

	// RVA: 0x238035C Offset: 0x237C35C VA: 0x238035C Slot: 28
	public override float GetAnimationSpeedForTake(int id) { }

	// RVA: 0x238040C Offset: 0x237C40C VA: 0x238040C Slot: 33
	public override void ChangePlayMode(int id, WrapMode mode) { }

	// RVA: 0x23804CC Offset: 0x237C4CC VA: 0x23804CC Slot: 37
	public override void CreateMobAnimationManager(EnemyMobActionManagerBase actionManager) { }

	// RVA: 0x2380648 Offset: 0x237C648 VA: 0x2380648 Slot: 38
	public override void ChangeStatus() { }

	// RVA: 0x23807BC Offset: 0x237C7BC VA: 0x23807BC Slot: 39
	public override int GetChangeAnimationNo(int animationNo) { }

	// RVA: 0x2380844 Offset: 0x237C844 VA: 0x2380844
	public void .ctor() { }
}
