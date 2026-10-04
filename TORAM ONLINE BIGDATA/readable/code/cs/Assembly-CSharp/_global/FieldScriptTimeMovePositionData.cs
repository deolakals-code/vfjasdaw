// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptTimeMovePositionData : FieldScriptMoveData // TypeDefIndex: 4670
{
	// Fields
	protected float MoveTmpDist; // 0x88
	protected float MoveDistance; // 0x8C

	// Methods

	// RVA: 0x258A960 Offset: 0x2586960 VA: 0x258A960
	public void .ctor(FieldScriptCharacterMove mo) { }

	// RVA: 0x258A97C Offset: 0x258697C VA: 0x258A97C
	public void init(Vector3 start, Vector3 end, float time, FieldScriptCharacterMove.TimeFlag tf, Action endCallBack) { }

	// RVA: 0x258CCF0 Offset: 0x2588CF0 VA: 0x258CCF0 Slot: 8
	public override bool Move(Transform charaTransform, out Vector3 move, out Vector3 vr) { }

	// RVA: 0x258CDBC Offset: 0x2588DBC VA: 0x258CDBC Slot: 9
	public override void Skip(Transform transform) { }

	// RVA: 0x258CECC Offset: 0x2588ECC VA: 0x258CECC Slot: 10
	public override void End() { }
}
