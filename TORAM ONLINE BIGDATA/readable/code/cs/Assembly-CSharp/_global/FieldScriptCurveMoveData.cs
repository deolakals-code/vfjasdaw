// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptCurveMoveData : FieldScriptMoveData // TypeDefIndex: 4679
{
	// Fields
	protected Vector3 moveControlPosition; // 0x88
	protected Vector3 TmpPos; // 0x94

	// Methods

	// RVA: 0x258C520 Offset: 0x2588520 VA: 0x258C520
	public void .ctor(FieldScriptCharacterMove mo) { }

	// RVA: 0x258C590 Offset: 0x2588590 VA: 0x258C590
	public void init(Vector3 startPos, Vector3 endPos, Vector3 pos, float time, FieldScriptBaias.TimeFlag tf, Action endCallBack) { }

	// RVA: 0x258F3BC Offset: 0x258B3BC VA: 0x258F3BC Slot: 8
	public override bool Move(Transform charaTransform, out Vector3 move, out Vector3 vr) { }

	// RVA: 0x258F5BC Offset: 0x258B5BC VA: 0x258F5BC Slot: 9
	public override void Skip(Transform transform) { }

	// RVA: 0x258F53C Offset: 0x258B53C VA: 0x258F53C
	private Vector3 SampleCurve(Vector3 start, Vector3 end, Vector3 control, float t) { }

	// RVA: 0x258F6A0 Offset: 0x258B6A0 VA: 0x258F6A0
	private Quaternion SampleCurve(Quaternion start, Quaternion end, Quaternion control, float t) { }
}
