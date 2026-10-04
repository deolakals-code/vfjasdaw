// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptTimeRotateData : FieldScriptMoveData // TypeDefIndex: 4671
{
	// Fields
	protected float RotateEnd; // 0x88

	// Methods

	// RVA: 0x258AD40 Offset: 0x2586D40 VA: 0x258AD40
	public void .ctor(FieldScriptCharacterMove mo) { }

	// RVA: 0x258AD5C Offset: 0x2586D5C VA: 0x258AD5C
	public void init(Quaternion start_q, float end_r, float time, FieldScriptCharacterMove.TimeFlag tf, Action endCallBack) { }

	// RVA: 0x258CED0 Offset: 0x2588ED0 VA: 0x258CED0 Slot: 8
	public override bool Move(Transform charaTransform, out Vector3 move, out Vector3 vr) { }

	// RVA: 0x258CFA8 Offset: 0x2588FA8 VA: 0x258CFA8 Slot: 9
	public override void Skip(Transform transform) { }

	// RVA: 0x258CFE0 Offset: 0x2588FE0 VA: 0x258CFE0 Slot: 10
	public override void End() { }
}
