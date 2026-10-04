// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptTagetMoveObjectData : FieldScriptMoveData // TypeDefIndex: 4677
{
	// Fields
	private float MovePositionRange; // 0x88
	private float targetMoveSpeed; // 0x8C
	private Transform targetTransform; // 0x90
	private float moveSpeed; // 0x98

	// Methods

	// RVA: 0x258A2E8 Offset: 0x25862E8 VA: 0x258A2E8
	public void .ctor(FieldScriptCharacterMove mo) { }

	// RVA: 0x258A310 Offset: 0x2586310 VA: 0x258A310
	public void init(float speed, Vector3 start, Transform target, float range, Action endCallBack) { }

	// RVA: 0x258E2B8 Offset: 0x258A2B8 VA: 0x258E2B8
	protected Vector3 calcMoveSpeed() { }

	// RVA: 0x258E3E0 Offset: 0x258A3E0 VA: 0x258E3E0
	private Vector3 calcMoveUnit() { }

	// RVA: 0x258E6E4 Offset: 0x258A6E4 VA: 0x258E6E4 Slot: 8
	public override bool Move(Transform charaTransform, out Vector3 move, out Vector3 vr) { }

	// RVA: 0x258EA70 Offset: 0x258AA70 VA: 0x258EA70 Slot: 9
	public override void Skip(Transform transform) { }
}
