// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptRotateObject : FieldScriptMoveData // TypeDefIndex: 4675
{
	// Fields
	protected float rotateSpeed; // 0x88
	protected float temp_Rotate; // 0x8C
	private float defaultRotateSpeed; // 0x90

	// Methods

	// RVA: 0x2589DC8 Offset: 0x2585DC8 VA: 0x2589DC8
	public void .ctor(FieldScriptCharacterMove mo) { }

	// RVA: 0x2589DF0 Offset: 0x2585DF0 VA: 0x2589DF0
	public void Init(Transform transform, float rot, Action endCallBack) { }

	// RVA: 0x258DFDC Offset: 0x2589FDC VA: 0x258DFDC Slot: 8
	public override bool Move(Transform charaTransform, out Vector3 move, out Vector3 vr) { }

	// RVA: 0x258E120 Offset: 0x258A120 VA: 0x258E120 Slot: 9
	public override void Skip(Transform transform) { }
}
