// Assembly: Assembly-CSharp.dll
// Namespace: 
private class BezierCurveAction.BezierCurveActionData : EventActionBase.EventActionDataBase // TypeDefIndex: 3802
{
	// Fields
	private Vector3 startPosition; // 0x3C
	private Vector3 endPosition; // 0x48
	private Vector3 bezierCurve; // 0x54

	// Properties
	private BezierCurveAction action { get; }

	// Methods

	// RVA: 0x23E91C0 Offset: 0x23E51C0 VA: 0x23E91C0
	private BezierCurveAction get_action() { }

	// RVA: 0x23E8EC8 Offset: 0x23E4EC8 VA: 0x23E8EC8
	public void .ctor(Vector3 start, Vector3 end, Vector3 bezier) { }

	// RVA: 0x23E9248 Offset: 0x23E5248 VA: 0x23E9248 Slot: 4
	protected override Vector3 MoveAction() { }

	// RVA: 0x23E930C Offset: 0x23E530C VA: 0x23E930C Slot: 7
	public override void Skip() { }
}
