// Assembly: Assembly-CSharp.dll
// Namespace: 
private class InstallationMoveBlackHolePattern.HitTimerManager // TypeDefIndex: 775
{
	// Fields
	private readonly PlayerActionManagerBase actionManager; // 0x10
	private readonly float suctionInterval; // 0x18
	private readonly float damageInterval; // 0x1C
	private float suctionTimer; // 0x20
	private float damageTimer; // 0x24
	private bool isSuction; // 0x28
	private bool isDamage; // 0x29

	// Methods

	// RVA: 0x1D465A8 Offset: 0x1D425A8 VA: 0x1D465A8
	public void .ctor(Transform transform, float suctionInterval, float damageInterval) { }

	// RVA: 0x1D46634 Offset: 0x1D42634 VA: 0x1D46634
	public void Update() { }

	// RVA: 0x1D4805C Offset: 0x1D4405C VA: 0x1D4805C
	public void Suction() { }

	// RVA: 0x1D480F0 Offset: 0x1D440F0 VA: 0x1D480F0
	public void Damage() { }

	// RVA: 0x1D48100 Offset: 0x1D44100 VA: 0x1D48100
	public bool CheckSuction() { }

	// RVA: 0x1D48108 Offset: 0x1D44108 VA: 0x1D48108
	public bool CheckDamage() { }

	// RVA: 0x1D48110 Offset: 0x1D44110 VA: 0x1D48110
	public PlayerActionManagerBase GetPlayerActionManger() { }
}
