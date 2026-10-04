// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
private abstract class MobBattlePlayer.MobPlayActionDataBase // TypeDefIndex: 727
{
	// Fields
	protected EnemyMobActionManagerBase mobActManager; // 0x10
	protected MobBattleManager mobBattleManager; // 0x18
	protected GameObject targetObject; // 0x20
	protected Vector3 targetPos; // 0x28
	protected CharacterMove charaMove; // 0x38
	protected bool isSkip; // 0x40
	[CompilerGenerated]
	private float <CreateTime>k__BackingField; // 0x44
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <EnableSkip>k__BackingField; // 0x49

	// Properties
	public float CreateTime { get; set; }
	public Vector3 TargetPos { get; }
	public bool IsEnd { get; set; }
	public bool EnableSkip { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B97434 Offset: 0x1B93434 VA: 0x1B97434
	public float get_CreateTime() { }

	[CompilerGenerated]
	// RVA: 0x1B9743C Offset: 0x1B9343C VA: 0x1B9743C
	private void set_CreateTime(float value) { }

	// RVA: 0x1B97444 Offset: 0x1B93444 VA: 0x1B97444
	public Vector3 get_TargetPos() { }

	[CompilerGenerated]
	// RVA: 0x1B97450 Offset: 0x1B93450 VA: 0x1B97450
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x1B97458 Offset: 0x1B93458 VA: 0x1B97458
	private void set_IsEnd(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1B97464 Offset: 0x1B93464 VA: 0x1B97464
	public bool get_EnableSkip() { }

	[CompilerGenerated]
	// RVA: 0x1B9746C Offset: 0x1B9346C VA: 0x1B9746C
	private void set_EnableSkip(bool value) { }

	// RVA: 0x1B97478 Offset: 0x1B93478 VA: 0x1B97478
	public void .ctor(EnemyMobActionManagerBase mobAct, GameObject target, Vector3 targetPos, bool skip) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Start();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Cancel();

	// RVA: 0x1B94918 Offset: 0x1B90918 VA: 0x1B94918
	public void Skip() { }

	// RVA: 0x1B94AB0 Offset: 0x1B90AB0 VA: 0x1B94AB0
	public void End() { }
}
