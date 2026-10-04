// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class NewWaveMobActionManagerBase : ServerMobActionManagerBase, IMobLevelFluctuation // TypeDefIndex: 1049
{
	// Methods

	// RVA: 0x1F3DAEC Offset: 0x1F39AEC VA: 0x1F3DAEC Slot: 89
	public override bool MobToEnemy() { }

	// RVA: -1 Offset: -1 Slot: 107
	public abstract void SetMobLevel(int level);

	// RVA: 0x1F3DCB0 Offset: 0x1F39CB0 VA: 0x1F3DCB0 Slot: 101
	public override void ChangeBattleAI() { }

	// RVA: 0x1F3DD88 Offset: 0x1F39D88 VA: 0x1F3DD88 Slot: 96
	public override void AttackTargetObject(int targetId, bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1F3DF14 Offset: 0x1F39F14 VA: 0x1F3DF14 Slot: 97
	public override void ChangeTargetObject(int targetId) { }

	// RVA: 0x1F3DF18 Offset: 0x1F39F18 VA: 0x1F3DF18 Slot: 102
	public override bool CheckAssistMove(GameObject target) { }

	// RVA: 0x1F3DF20 Offset: 0x1F39F20 VA: 0x1F3DF20 Slot: 98
	protected override void Rematch(GameObject target) { }

	// RVA: 0x1F3DFFC Offset: 0x1F39FFC VA: 0x1F3DFFC Slot: 104
	public override void ActionEnd() { }

	// RVA: 0x1F3E110 Offset: 0x1F3A110 VA: 0x1F3E110 Slot: 105
	public override void UnmanagedEnemey(GameObject actor) { }

	// RVA: 0x1F3B8D0 Offset: 0x1F378D0 VA: 0x1F3B8D0
	protected void .ctor() { }
}
