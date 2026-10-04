// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptNormalMoveData : FieldScriptMoveData // TypeDefIndex: 4674
{
	// Fields
	protected float MovePositionRange; // 0x88
	protected float targetMoveSpeed; // 0x8C
	protected Transform targetTransform; // 0x90
	protected float moveSpeed; // 0x98

	// Methods

	// RVA: 0x2589A2C Offset: 0x2585A2C VA: 0x2589A2C
	public void .ctor(FieldScriptCharacterMove mo) { }

	// RVA: 0x2589A54 Offset: 0x2585A54 VA: 0x2589A54
	public void Init(Vector3 dir, float speed) { }

	// RVA: 0x258D8B4 Offset: 0x25898B4 VA: 0x258D8B4
	protected Vector3 calcMoveSpeed() { }

	// RVA: 0x258D9DC Offset: 0x25899DC VA: 0x258D9DC
	private Vector3 calcMoveUnit() { }

	// RVA: 0x258D9E0 Offset: 0x25899E0 VA: 0x258D9E0 Slot: 8
	public override bool Move(Transform charaTransform, out Vector3 move, out Vector3 vr) { }

	// RVA: 0x258DD70 Offset: 0x2589D70 VA: 0x258DD70 Slot: 9
	public override void Skip(Transform transform) { }
}
