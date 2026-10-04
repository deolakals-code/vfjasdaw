// Assembly: Assembly-CSharp.dll
// Namespace: 
private class InstallationBlackHolePattern.HitTimerManager // TypeDefIndex: 764
{
	// Fields
	private readonly Transform transform; // 0x10
	private readonly PlayerActionManagerBase actionManager; // 0x18
	private readonly float suctionInterval; // 0x20
	private readonly float damageInterval; // 0x24
	private float suctionTimer; // 0x28
	private float damageTimer; // 0x2C
	private bool isSuction; // 0x30
	private bool isDamage; // 0x31

	// Methods

	// RVA: 0x1C7A578 Offset: 0x1C76578 VA: 0x1C7A578
	public void .ctor(Transform transform, float suctionInterval, float damageInterval) { }

	// RVA: 0x1C7A618 Offset: 0x1C76618 VA: 0x1C7A618
	public void Update() { }

	// RVA: 0x1C7B288 Offset: 0x1C77288 VA: 0x1C7B288
	public void Suction() { }

	// RVA: 0x1C7B298 Offset: 0x1C77298 VA: 0x1C7B298
	public void Damage() { }

	// RVA: 0x1C7B5C0 Offset: 0x1C775C0 VA: 0x1C7B5C0
	public bool CheckSuction() { }

	// RVA: 0x1C7B5C8 Offset: 0x1C775C8 VA: 0x1C7B5C8
	public bool CheckDamage() { }

	// RVA: 0x1C7B5D0 Offset: 0x1C775D0 VA: 0x1C7B5D0
	public PlayerActionManagerBase GetPlayerActionManger() { }
}
