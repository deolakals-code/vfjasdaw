// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public class CubicBezierCurveAction : EventActionBase // TypeDefIndex: 3808
{
	// Fields
	[SerializeField]
	protected Vector3 bezierCurve1; // 0xA0
	[SerializeField]
	protected Vector3 bezierCurve2; // 0xAC
	[SerializeField]
	protected CubicBezierCurveAction.BezierCurveBitFlag bezierCurveBitFlag; // 0xB8

	// Properties
	protected bool startSettingPosition { get; }

	// Methods

	// RVA: 0x23E97F0 Offset: 0x23E57F0 VA: 0x23E97F0
	protected bool get_startSettingPosition() { }

	// RVA: 0x23E97FC Offset: 0x23E57FC VA: 0x23E97FC Slot: 4
	protected override EventActionBase.EventActionDataBase AddActionEvent(GameObject obj) { }

	// RVA: 0x23E9A38 Offset: 0x23E5A38 VA: 0x23E9A38
	public Vector3 CalcPosition(float t) { }

	// RVA: 0x23E9AC8 Offset: 0x23E5AC8 VA: 0x23E9AC8
	public float CalcLength() { }

	// RVA: 0x23E9C70 Offset: 0x23E5C70 VA: 0x23E9C70
	public void .ctor() { }
}
