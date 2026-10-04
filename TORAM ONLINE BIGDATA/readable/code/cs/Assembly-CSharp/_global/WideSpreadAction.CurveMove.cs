// Assembly: Assembly-CSharp.dll
// Namespace: 
private class WideSpreadAction.CurveMove // TypeDefIndex: 3013
{
	// Fields
	private readonly Vector3 targetPos; // 0x10
	private readonly float maxAngle; // 0x1C
	private readonly float distance; // 0x20
	private readonly Vector3 direction; // 0x24
	private float totalFrame; // 0x30
	private float frame; // 0x34
	private Vector3 checkWallDirect; // 0x38
	private bool isMoveStop; // 0x44
	private FieldRayPick fieldRay; // 0x48

	// Methods

	// RVA: 0x2302474 Offset: 0x22FE474 VA: 0x2302474
	public void .ctor(GameObject actor, GameObject target, float angle) { }

	// RVA: 0x2302FCC Offset: 0x22FEFCC VA: 0x2302FCC
	public void SetParam(float motionTime) { }

	// RVA: 0x2302FE0 Offset: 0x22FEFE0 VA: 0x2302FE0
	public Vector3 FrameMove(Vector3 pos, out bool isMove) { }
}
