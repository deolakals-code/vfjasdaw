// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptTimeRotateExData : FieldScriptMoveData // TypeDefIndex: 4672
{
	// Fields
	protected float RotateEnd; // 0x88

	// Methods

	// RVA: 0x258B770 Offset: 0x2587770 VA: 0x258B770
	public void .ctor(FieldScriptCharacterMove mo) { }

	// RVA: 0x258CFE4 Offset: 0x2588FE4 VA: 0x258CFE4
	private float _roundEuler(float f) { }

	// RVA: 0x258B78C Offset: 0x258778C VA: 0x258B78C
	public void init(Quaternion start_q, Vector3 end_r, float time, FieldScriptCharacterMove.TimeFlag tf, Action endCallBack) { }

	// RVA: 0x258D004 Offset: 0x2589004 VA: 0x258D004 Slot: 8
	public override bool Move(Transform charaTransform, out Vector3 move, out Vector3 vr) { }

	// RVA: 0x258D10C Offset: 0x258910C VA: 0x258D10C Slot: 9
	public override void Skip(Transform transform) { }

	// RVA: 0x258D144 Offset: 0x2589144 VA: 0x258D144 Slot: 10
	public override void End() { }
}
