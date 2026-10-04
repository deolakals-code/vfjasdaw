// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
private class MobBattlePlayer.MobPlayActionMove : MobBattlePlayer.MobPlayActionDataBase // TypeDefIndex: 729
{
	// Fields
	private Action correctionMove; // 0x50
	private bool isActionMoveStop; // 0x58
	[CompilerGenerated]
	private float <MoveTime>k__BackingField; // 0x5C

	// Properties
	public float MoveTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B97640 Offset: 0x1B93640 VA: 0x1B97640
	public float get_MoveTime() { }

	[CompilerGenerated]
	// RVA: 0x1B97648 Offset: 0x1B93648 VA: 0x1B97648
	private void set_MoveTime(float value) { }

	// RVA: 0x1B94FD8 Offset: 0x1B90FD8 VA: 0x1B94FD8
	public void .ctor(EnemyMobActionManagerBase mobAct, GameObject target, Vector3 targetPos, bool skip) { }

	// RVA: 0x1B97650 Offset: 0x1B93650 VA: 0x1B97650 Slot: 5
	public override void Start() { }

	// RVA: 0x1B978D4 Offset: 0x1B938D4 VA: 0x1B978D4 Slot: 4
	public override void Update() { }

	// RVA: 0x1B9796C Offset: 0x1B9396C VA: 0x1B9796C Slot: 6
	public override void Cancel() { }

	// RVA: 0x1B9552C Offset: 0x1B9152C VA: 0x1B9552C
	public void MoveStopToActionStart() { }

	// RVA: 0x1B95550 Offset: 0x1B91550 VA: 0x1B95550
	public void CurrentActionMoveStop() { }
}
