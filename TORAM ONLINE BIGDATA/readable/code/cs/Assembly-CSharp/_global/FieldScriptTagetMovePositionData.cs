// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptTagetMovePositionData : FieldScriptMoveData // TypeDefIndex: 4678
{
	// Fields
	private float MovePositionRange; // 0x88
	private float targetMoveSpeed; // 0x8C
	private float moveSpeed; // 0x90

	// Methods

	// RVA: 0x258A5C4 Offset: 0x25865C4 VA: 0x258A5C4
	public void .ctor(FieldScriptCharacterMove mo) { }

	// RVA: 0x258A5EC Offset: 0x25865EC VA: 0x258A5EC
	public void init(float speed, Vector3 startPos, Vector3 endPos, float range, Action endCallBack) { }

	// RVA: 0x258EC80 Offset: 0x258AC80 VA: 0x258EC80
	private Vector3 calcMoveUnit() { }

	// RVA: 0x258EF40 Offset: 0x258AF40 VA: 0x258EF40 Slot: 8
	public override bool Move(Transform charaTransform, out Vector3 move, out Vector3 vr) { }

	// RVA: 0x258F3B8 Offset: 0x258B3B8 VA: 0x258F3B8 Slot: 9
	public override void Skip(Transform transform) { }
}
