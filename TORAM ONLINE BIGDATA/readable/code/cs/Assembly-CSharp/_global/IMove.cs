// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IMove // TypeDefIndex: 594
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetLookObject(Transform targetTransform);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ClearLookObject();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RotateToPosition(Vector3 target, Action endCallBack);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ImmediateRotateToPosition(Vector3 target);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Rotate(float rot, Action endCallBack);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RotateToObject(GameObject target, Action endCallBack);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void TargetTimeMove(Vector3 target, float time, bool slowStart, bool slowStop, Action endCallBack);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void TimeRotate(float rot, float time, bool slowStart, bool slowStop, Action endCallBack);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void RotateStop();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void RotateSkip();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Move(Vector3 dir);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Move(Vector3 dir, float speed);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void MoveStop();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void TargetMove(float speed, Transform targetTransform, float range, Action endCallBack);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void TargetMoveSkip();
}
