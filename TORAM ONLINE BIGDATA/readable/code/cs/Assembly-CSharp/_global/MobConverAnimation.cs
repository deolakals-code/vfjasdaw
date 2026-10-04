// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobConverAnimation : MobAnimation // TypeDefIndex: 295
{
	// Fields
	private Dictionary<int, int> convertMotion; // 0x40
	private bool init; // 0x48

	// Methods

	// RVA: 0x237F588 Offset: 0x237B588 VA: 0x237F588
	private void Start() { }

	// RVA: 0x237F6E4 Offset: 0x237B6E4 VA: 0x237F6E4
	private int convertMotionId(int id) { }

	// RVA: 0x237F76C Offset: 0x237B76C VA: 0x237F76C Slot: 10
	public override bool IsPlay(int id) { }

	// RVA: 0x237F7A0 Offset: 0x237B7A0 VA: 0x237F7A0 Slot: 13
	public override bool IsPlayEnd(int id) { }

	// RVA: 0x237F7BC Offset: 0x237B7BC VA: 0x237F7BC Slot: 25
	public override bool ExistClip(int id) { }

	// RVA: 0x237F7D8 Offset: 0x237B7D8 VA: 0x237F7D8 Slot: 26
	public override float GetAnimationTimeForTake(int id) { }

	// RVA: 0x237F7F4 Offset: 0x237B7F4 VA: 0x237F7F4 Slot: 27
	public override float GetAnimationLengthForTake(int id) { }

	// RVA: 0x237F810 Offset: 0x237B810 VA: 0x237F810 Slot: 28
	public override float GetAnimationSpeedForTake(int id) { }

	// RVA: 0x237F82C Offset: 0x237B82C VA: 0x237F82C Slot: 29
	public override void SetAnimationSpeedForTake(int id, float speed) { }

	// RVA: 0x237F858 Offset: 0x237B858 VA: 0x237F858 Slot: 31
	public override int GetCustomizedAnimationId(int id) { }

	// RVA: 0x237F85C Offset: 0x237B85C VA: 0x237F85C Slot: 32
	public override bool CheckPlayMode(int id, WrapMode mode) { }

	// RVA: 0x237F888 Offset: 0x237B888 VA: 0x237F888 Slot: 33
	public override void ChangePlayMode(int id, WrapMode mode) { }

	// RVA: 0x237F8B4 Offset: 0x237B8B4 VA: 0x237F8B4 Slot: 6
	public override void Play(int id, WrapMode mode, float speedRate, float fadeSecond) { }

	// RVA: 0x237F8F8 Offset: 0x237B8F8 VA: 0x237F8F8 Slot: 9
	public override void PlayNonCrossFade(int id, WrapMode mode, float speedRate, bool crossFadeLock) { }

	// RVA: 0x237F93C Offset: 0x237B93C VA: 0x237F93C Slot: 36
	protected override void playCrossFadeQueued(int id, WrapMode mode, float fadeSecond) { }

	// RVA: 0x237F978 Offset: 0x237B978 VA: 0x237F978
	public void .ctor() { }
}
