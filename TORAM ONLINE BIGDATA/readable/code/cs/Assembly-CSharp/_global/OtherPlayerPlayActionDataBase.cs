// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class OtherPlayerPlayActionDataBase // TypeDefIndex: 1201
{
	// Fields
	[CompilerGenerated]
	private float <CreateTime>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsStart>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x15
	protected CharacterActionManagerBase otherActManager; // 0x18
	protected EmotionPlayer emotionPlayer; // 0x20
	protected TakeController takeController; // 0x28
	protected OtherPlayer otherPlayer; // 0x30
	protected GameObject targetObject; // 0x38
	protected Vector3 targetPos; // 0x40

	// Properties
	public float CreateTime { get; set; }
	public Vector3 TargetPos { get; }
	public bool IsStart { get; set; }
	public bool IsEnd { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F86B78 Offset: 0x1F82B78 VA: 0x1F86B78
	public float get_CreateTime() { }

	[CompilerGenerated]
	// RVA: 0x1F86B80 Offset: 0x1F82B80 VA: 0x1F86B80
	private void set_CreateTime(float value) { }

	// RVA: 0x1F86B88 Offset: 0x1F82B88 VA: 0x1F86B88
	public Vector3 get_TargetPos() { }

	[CompilerGenerated]
	// RVA: 0x1F86B94 Offset: 0x1F82B94 VA: 0x1F86B94
	public bool get_IsStart() { }

	[CompilerGenerated]
	// RVA: 0x1F86B9C Offset: 0x1F82B9C VA: 0x1F86B9C
	private void set_IsStart(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F86BA8 Offset: 0x1F82BA8 VA: 0x1F86BA8
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x1F86BB0 Offset: 0x1F82BB0 VA: 0x1F86BB0
	private void set_IsEnd(bool value) { }

	// RVA: 0x1F86BBC Offset: 0x1F82BBC VA: 0x1F86BBC
	public void .ctor(CharacterActionManagerBase actor, GameObject target, Vector3 targetPos) { }

	// RVA: 0x1F86D4C Offset: 0x1F82D4C VA: 0x1F86D4C
	public void Start() { }

	// RVA: 0x1F86D60 Offset: 0x1F82D60 VA: 0x1F86D60
	public void Update() { }

	// RVA: 0x1F86D78 Offset: 0x1F82D78 VA: 0x1F86D78
	public void Cancel() { }

	// RVA: 0x1F86DB8 Offset: 0x1F82DB8 VA: 0x1F86DB8
	public void End() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnStart();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnUpdate();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnCancel();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void OnEnd();
}
