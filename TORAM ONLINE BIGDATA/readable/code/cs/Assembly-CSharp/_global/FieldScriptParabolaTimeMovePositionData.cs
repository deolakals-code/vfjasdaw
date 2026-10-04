// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptParabolaTimeMovePositionData : FieldScriptMoveData // TypeDefIndex: 4673
{
	// Fields
	public float Rot; // 0x88
	private FieldScriptBaias Plane_Baias; // 0x90
	protected Vector3 TmpPos; // 0x98
	protected float MoveTmpDist; // 0xA4
	protected float MoveDistance; // 0xA8
	protected Quaternion Rotation; // 0xAC
	protected Quaternion Plane_Slope; // 0xBC
	protected Quaternion Plane_Direction; // 0xCC
	protected float Plane_MoveDistance; // 0xDC
	protected float Speed_Plane; // 0xE0
	protected float Speed_y; // 0xE4

	// Methods

	// RVA: 0x258B098 Offset: 0x2587098 VA: 0x258B098
	public void .ctor(FieldScriptCharacterMove mo) { }

	// RVA: 0x258B11C Offset: 0x258711C VA: 0x258B11C
	public void init(Vector3 start, Vector3 end, float time, float rot, FieldScriptCharacterMove.TimeFlag tf, Action endCallBack) { }

	// RVA: 0x258BADC Offset: 0x2587ADC VA: 0x258BADC
	public void init(Vector3 start, Vector3 vec, float cr, float h, float rot, FieldScriptCharacterMove.TimeFlag tf, Action endCallBack) { }

	// RVA: 0x258C020 Offset: 0x2588020 VA: 0x258C020
	public void init(Vector3 start, Quaternion quaternion, float cr, float h, float rot, FieldScriptCharacterMove.TimeFlag tf, Action endCallBack) { }

	// RVA: 0x258D148 Offset: 0x2589148 VA: 0x258D148 Slot: 8
	public override bool Move(Transform charaTransform, out Vector3 move, out Vector3 vr) { }

	// RVA: 0x258D7C4 Offset: 0x25897C4 VA: 0x258D7C4 Slot: 9
	public override void Skip(Transform transform) { }

	// RVA: 0x258D8B0 Offset: 0x25898B0 VA: 0x258D8B0 Slot: 10
	public override void End() { }
}
