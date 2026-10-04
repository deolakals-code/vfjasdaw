// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class TreasureHuntMobActionManagerBase : ServerMobActionManagerBase // TypeDefIndex: 1154
{
	// Fields
	private static Vector3[] correctionPos; // 0x0
	private PlayerActionManagerBase actManager; // 0x158
	private float addHateCoolTime; // 0x160
	[CompilerGenerated]
	private Vector3 <TargetPos>k__BackingField; // 0x164

	// Properties
	public Vector3 TargetPos { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F6A414 Offset: 0x1F66414 VA: 0x1F6A414
	public Vector3 get_TargetPos() { }

	[CompilerGenerated]
	// RVA: 0x1F6A424 Offset: 0x1F66424 VA: 0x1F6A424
	protected void set_TargetPos(Vector3 value) { }

	// RVA: 0x1F67960 Offset: 0x1F63960 VA: 0x1F67960
	public void CheckMobActiveBattle() { }

	// RVA: 0x1F6A434 Offset: 0x1F66434 VA: 0x1F6A434
	private bool CheckActive() { }

	// RVA: 0x1F683A8 Offset: 0x1F643A8 VA: 0x1F683A8
	protected void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1F6A634 Offset: 0x1F66634 VA: 0x1F6A634 Slot: 102
	public override bool CheckAssistMove(GameObject target) { }

	// RVA: 0x1F6A63C Offset: 0x1F6663C VA: 0x1F6A63C Slot: 105
	public override void UnmanagedEnemey(GameObject actor) { }

	// RVA: 0x1F6AA10 Offset: 0x1F66A10 VA: 0x1F6AA10 Slot: 98
	protected override void Rematch(GameObject target) { }

	// RVA: 0x1F6AA14 Offset: 0x1F66A14 VA: 0x1F6AA14 Slot: 104
	public override void ActionEnd() { }

	// RVA: 0x1F6AB34 Offset: 0x1F66B34 VA: 0x1F6AB34 Slot: 97
	public override void ChangeTargetObject(int targetId) { }

	// RVA: 0x1F6AB38 Offset: 0x1F66B38 VA: 0x1F6AB38 Slot: 99
	public override void ReceiveMove(Vector3 pos, float updateTime, bool isReconnect) { }

	// RVA: 0x1F6AEEC Offset: 0x1F66EEC VA: 0x1F6AEEC Slot: 101
	public override void ChangeBattleAI() { }

	// RVA: 0x1F6AFC4 Offset: 0x1F66FC4 VA: 0x1F6AFC4 Slot: 96
	public override void AttackTargetObject(int targetId, bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1F68350 Offset: 0x1F64350 VA: 0x1F68350
	protected void .ctor() { }

	// RVA: 0x1F6AFC8 Offset: 0x1F66FC8 VA: 0x1F6AFC8
	private static void .cctor() { }
}
