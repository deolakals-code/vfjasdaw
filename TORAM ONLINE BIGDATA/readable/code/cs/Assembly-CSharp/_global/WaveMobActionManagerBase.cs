// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class WaveMobActionManagerBase : ServerMobActionManagerBase // TypeDefIndex: 1161
{
	// Fields
	protected Vector3 moveDirection; // 0x154
	protected GameObject discardPlayer; // 0x160
	public short mapPointId; // 0x168
	public int targetId; // 0x16C

	// Methods

	// RVA: -1 Offset: -1 Slot: 106
	public abstract void ChangeTargetAttackAI();

	// RVA: 0x1F72818 Offset: 0x1F6E818 VA: 0x1F72818 Slot: 103
	public override void DiscardHate() { }

	// RVA: 0x1F7281C Offset: 0x1F6E81C VA: 0x1F7281C Slot: 102
	public override bool CheckAssistMove(GameObject target) { }

	// RVA: 0x1F72824 Offset: 0x1F6E824 VA: 0x1F72824
	public void SetWaveState(short mapPointId, int targetId) { }

	// RVA: -1 Offset: -1 Slot: 107
	public abstract void TargetAroundWarp();

	// RVA: 0x1F72740 Offset: 0x1F6E740 VA: 0x1F72740
	protected void .ctor() { }
}
