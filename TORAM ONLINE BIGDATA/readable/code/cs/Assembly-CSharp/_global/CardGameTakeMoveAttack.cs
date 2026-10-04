// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGameTakeMoveAttack : CardGameTakeBase // TypeDefIndex: 4259
{
	// Fields
	private const float moveSpeed = 15;
	private const float charaSize = 1;

	// Properties
	public override CardGameBattleCameraManager.BattleCameraMode CameraMode { get; }

	// Methods

	// RVA: 0x24B99E4 Offset: 0x24B59E4 VA: 0x24B99E4 Slot: 4
	public override CardGameBattleCameraManager.BattleCameraMode get_CameraMode() { }

	// RVA: 0x24B800C Offset: 0x24B400C VA: 0x24B800C
	public void .ctor(int take) { }

	// RVA: 0x24B99EC Offset: 0x24B59EC VA: 0x24B99EC Slot: 5
	public override void StartTake() { }

	// RVA: 0x24B99F0 Offset: 0x24B59F0 VA: 0x24B99F0
	private void MoveTargetStart() { }

	// RVA: 0x24B9AA4 Offset: 0x24B5AA4 VA: 0x24B9AA4
	private void MoveTarget(Action callback) { }

	// RVA: 0x24B9CD0 Offset: 0x24B5CD0 VA: 0x24B9CD0
	private void AttackStart() { }

	// RVA: 0x24B9D94 Offset: 0x24B5D94 VA: 0x24B9D94
	private void Attack(Action callback) { }

	// RVA: 0x24B9DC4 Offset: 0x24B5DC4 VA: 0x24B9DC4
	private void AttackEnd() { }

	// RVA: 0x24B9DC8 Offset: 0x24B5DC8 VA: 0x24B9DC8
	private void MoveHomeStart() { }

	// RVA: 0x24B9E54 Offset: 0x24B5E54 VA: 0x24B9E54
	private void MoveHome(Action callback) { }

	// RVA: 0x24BA068 Offset: 0x24B6068 VA: 0x24BA068
	private void MoveEnd() { }
}
