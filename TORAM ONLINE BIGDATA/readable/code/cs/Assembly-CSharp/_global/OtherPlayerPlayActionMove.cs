// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OtherPlayerPlayActionMove : OtherPlayerPlayActionDataBase // TypeDefIndex: 1203
{
	// Fields
	private CharacterMove charaMove; // 0x50
	private float speed; // 0x58
	[CompilerGenerated]
	private float <MoveTime>k__BackingField; // 0x5C

	// Properties
	public float MoveTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F86DCC Offset: 0x1F82DCC VA: 0x1F86DCC
	public float get_MoveTime() { }

	[CompilerGenerated]
	// RVA: 0x1F86DD4 Offset: 0x1F82DD4 VA: 0x1F86DD4
	private void set_MoveTime(float value) { }

	// RVA: 0x1F86DDC Offset: 0x1F82DDC VA: 0x1F86DDC
	public void .ctor(CharacterActionManagerBase actor, GameObject target, Vector3 targetPos, float speed) { }

	// RVA: 0x1F86E9C Offset: 0x1F82E9C VA: 0x1F86E9C Slot: 4
	protected override void OnStart() { }

	// RVA: 0x1F870A0 Offset: 0x1F830A0 VA: 0x1F870A0 Slot: 5
	protected override void OnUpdate() { }

	// RVA: 0x1F87110 Offset: 0x1F83110 VA: 0x1F87110 Slot: 6
	protected override void OnCancel() { }

	// RVA: 0x1F8712C Offset: 0x1F8312C VA: 0x1F8712C Slot: 7
	protected override void OnEnd() { }

	// RVA: 0x1F87130 Offset: 0x1F83130 VA: 0x1F87130 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F871F0 Offset: 0x1F831F0 VA: 0x1F871F0
	public void Skip() { }
}
