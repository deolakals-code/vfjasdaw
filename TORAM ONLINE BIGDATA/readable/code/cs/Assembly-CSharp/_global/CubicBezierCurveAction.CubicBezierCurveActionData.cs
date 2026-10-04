// Assembly: Assembly-CSharp.dll
// Namespace: 
private class CubicBezierCurveAction.CubicBezierCurveActionData : EventActionBase.EventActionDataBase // TypeDefIndex: 3807
{
	// Fields
	private Vector3 startPosition; // 0x3C
	private Vector3 endPosition; // 0x48
	private Vector3 bezierCurve1; // 0x54
	private Vector3 bezierCurve2; // 0x60

	// Properties
	private CubicBezierCurveAction action { get; }

	// Methods

	// RVA: 0x23E9CE0 Offset: 0x23E5CE0 VA: 0x23E9CE0
	private CubicBezierCurveAction get_action() { }

	// RVA: 0x23E99AC Offset: 0x23E59AC VA: 0x23E99AC
	public void .ctor(Vector3 start, Vector3 end, Vector3 bezier1, Vector3 bezier2) { }

	// RVA: 0x23E9D58 Offset: 0x23E5D58 VA: 0x23E9D58 Slot: 4
	protected override Vector3 MoveAction() { }

	// RVA: 0x23E9E4C Offset: 0x23E5E4C VA: 0x23E9E4C Slot: 7
	public override void Skip() { }
}
