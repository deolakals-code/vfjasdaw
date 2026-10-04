// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(MobAnimation))]
[RequireComponent(typeof(FadeAnimationManager))]
public class HalloweenMobActionManager : EnemyMobActionManagerBase // TypeDefIndex: 889
{
	// Fields
	private MobHalloweenAI halloweenAI; // 0x158
	private HalloweenEventGameRoomData roomData; // 0x160

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override string MobName { get; }
	public override float Size { get; }
	public override bool HideNameLabel { get; }
	public override bool IsTargetable { get; }

	// Methods

	// RVA: 0x1EF9C34 Offset: 0x1EF5C34 VA: 0x1EF9C34 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1EF9C6C Offset: 0x1EF5C6C VA: 0x1EF9C6C Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1EF9C74 Offset: 0x1EF5C74 VA: 0x1EF9C74 Slot: 70
	public override string get_MobName() { }

	// RVA: 0x1EF9CB4 Offset: 0x1EF5CB4 VA: 0x1EF9CB4 Slot: 4
	public override float get_Size() { }

	// RVA: 0x1EF9CBC Offset: 0x1EF5CBC VA: 0x1EF9CBC Slot: 68
	public override bool get_HideNameLabel() { }

	// RVA: 0x1EF9CC4 Offset: 0x1EF5CC4 VA: 0x1EF9CC4 Slot: 67
	public override bool get_IsTargetable() { }

	// RVA: 0x1EF9D4C Offset: 0x1EF5D4C VA: 0x1EF9D4C Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1EF9D50 Offset: 0x1EF5D50 VA: 0x1EF9D50
	private bool IsLookAtWall(Vector3 pos) { }

	// RVA: 0x1EF9F24 Offset: 0x1EF5F24 VA: 0x1EF9F24 Slot: 91
	public override bool CheckTargetMob(Vector3 pos, out GameObject target) { }

	// RVA: 0x1EF9FB0 Offset: 0x1EF5FB0 VA: 0x1EF9FB0 Slot: 92
	public override bool GetNearTargetDist(Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1EFA08C Offset: 0x1EF608C VA: 0x1EFA08C Slot: 93
	public override bool GetNearTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1EFA17C Offset: 0x1EF617C VA: 0x1EFA17C Slot: 94
	public override bool GetFarTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1EFA26C Offset: 0x1EF626C VA: 0x1EFA26C
	public void SetAIRoot(HalloweenEventGameRoomData roomData, byte index, bool isDead, int area, float delayTimer) { }

	// RVA: 0x1EFA3BC Offset: 0x1EF63BC VA: 0x1EFA3BC
	public void PlayerFieldHate(Vector3 pos) { }

	// RVA: 0x1EFA3D0 Offset: 0x1EF63D0 VA: 0x1EFA3D0
	public bool MoveHit(Vector3 pos, Vector3 move, out Vector3 addMove) { }

	// RVA: 0x1EFA574 Offset: 0x1EF6574 VA: 0x1EFA574
	public void Damaged(bool dead, int skillid) { }

	// RVA: 0x1EFA76C Offset: 0x1EF676C VA: 0x1EFA76C Slot: 17
	public override void OnDead() { }

	// RVA: 0x1EFA9A0 Offset: 0x1EF69A0 VA: 0x1EFA9A0
	public void .ctor() { }
}
