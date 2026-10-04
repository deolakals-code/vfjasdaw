// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class DefenceMobActionManagerBase : ServerMobActionManagerBase, IMobLevelFluctuation // TypeDefIndex: 868
{
	// Fields
	protected DefenceSafeRoom targetCrystal; // 0x158
	protected GameObject discardPlayer; // 0x160
	[CompilerGenerated]
	private bool <IsInsideTargetCrystalRoom>k__BackingField; // 0x168
	[CompilerGenerated]
	private Vector3 <MoveCrystalDirection>k__BackingField; // 0x16C
	[CompilerGenerated]
	private DefencePoint2 <CheckCellPoint>k__BackingField; // 0x178

	// Properties
	public bool IsInsideTargetCrystalRoom { get; set; }
	public Vector3 MoveCrystalDirection { get; set; }
	public DefencePoint2 CheckCellPoint { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1EE512C Offset: 0x1EE112C VA: 0x1EE512C
	public bool get_IsInsideTargetCrystalRoom() { }

	[CompilerGenerated]
	// RVA: 0x1EE5134 Offset: 0x1EE1134 VA: 0x1EE5134
	protected void set_IsInsideTargetCrystalRoom(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1EE5140 Offset: 0x1EE1140 VA: 0x1EE5140
	public Vector3 get_MoveCrystalDirection() { }

	[CompilerGenerated]
	// RVA: 0x1EE5150 Offset: 0x1EE1150 VA: 0x1EE5150
	protected void set_MoveCrystalDirection(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x1EE5160 Offset: 0x1EE1160 VA: 0x1EE5160
	public DefencePoint2 get_CheckCellPoint() { }

	[CompilerGenerated]
	// RVA: 0x1EE5168 Offset: 0x1EE1168 VA: 0x1EE5168
	protected void set_CheckCellPoint(DefencePoint2 value) { }

	// RVA: -1 Offset: -1 Slot: 107
	public abstract void ChangeDefenceAI();

	// RVA: 0x1EE35BC Offset: 0x1EDF5BC VA: 0x1EE35BC
	public bool CheckMoveRoute() { }

	// RVA: 0x1EE5170 Offset: 0x1EE1170 VA: 0x1EE5170 Slot: 102
	public override bool CheckAssistMove(GameObject target) { }

	// RVA: 0x1EE5448 Offset: 0x1EE1448 VA: 0x1EE5448 Slot: 103
	public override void DiscardHate() { }

	// RVA: 0x1EE54BC Offset: 0x1EE14BC VA: 0x1EE54BC Slot: 104
	public override void ActionEnd() { }

	// RVA: 0x1EE56AC Offset: 0x1EE16AC VA: 0x1EE56AC Slot: 105
	public override void UnmanagedEnemey(GameObject actor) { }

	// RVA: -1 Offset: -1 Slot: 108
	public abstract void SetMobLevel(int level);

	// RVA: 0x1EE4ECC Offset: 0x1EE0ECC VA: 0x1EE4ECC
	protected void .ctor() { }
}
