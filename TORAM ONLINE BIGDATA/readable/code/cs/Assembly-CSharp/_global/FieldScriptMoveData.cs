// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class FieldScriptMoveData // TypeDefIndex: 4669
{
	// Fields
	protected FieldScriptCharacterMove.MoveType Type; // 0x10
	protected FieldScriptBaias baias; // 0x18
	protected Vector3 moveStartPosition; // 0x20
	protected Vector3 moveEndPosition; // 0x2C
	public Vector3 MoveDirection; // 0x38
	public Quaternion QuaternionStart; // 0x44
	public Quaternion QuaternionEnd; // 0x54
	protected float TotalTime; // 0x64
	protected float workProgressTime; // 0x68
	protected Action EndAction; // 0x70
	public bool isGravityCalc; // 0x78
	public bool fSkip; // 0x79
	protected bool EnableFrameSecMove; // 0x7A
	protected bool MoveHeightRangeCheck; // 0x7B
	protected FieldScriptCharacterMove moveObject; // 0x80

	// Properties
	public virtual Vector3 MoveStartPosition { get; set; }
	public virtual Vector3 MoveEndPosition { get; set; }

	// Methods

	// RVA: 0x258C8D4 Offset: 0x25888D4 VA: 0x258C8D4 Slot: 4
	public virtual Vector3 get_MoveStartPosition() { }

	// RVA: 0x258C8E0 Offset: 0x25888E0 VA: 0x258C8E0 Slot: 5
	protected virtual void set_MoveStartPosition(Vector3 value) { }

	// RVA: 0x258C8EC Offset: 0x25888EC VA: 0x258C8EC Slot: 6
	public virtual Vector3 get_MoveEndPosition() { }

	// RVA: 0x258C8F8 Offset: 0x25888F8 VA: 0x258C8F8 Slot: 7
	protected virtual void set_MoveEndPosition(Vector3 value) { }

	// RVA: 0x258C904 Offset: 0x2588904 VA: 0x258C904
	public void .ctor(FieldScriptCharacterMove mo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Move(Transform charaTransform, out Vector3 move, out Vector3 vr);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Skip(Transform transform);

	// RVA: 0x258CA40 Offset: 0x2588A40 VA: 0x258CA40 Slot: 10
	public virtual void End() { }

	// RVA: 0x258CA7C Offset: 0x2588A7C VA: 0x258CA7C
	public Vector3 getEndPosition() { }

	// RVA: 0x258CA9C Offset: 0x2588A9C VA: 0x258CA9C
	public Vector3 getEndPosition(Vector3 moveEndPos) { }
}
