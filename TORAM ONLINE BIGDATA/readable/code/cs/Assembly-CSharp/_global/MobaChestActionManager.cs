// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(MobAnimation))]
[RequireComponent(typeof(FadeAnimationManager))]
public class MobaChestActionManager : MobaMobActionManagerBase, IMobaTreasureEquip // TypeDefIndex: 907
{
	// Fields
	private const float maxMeter = 5;
	private short openSec; // 0x158
	private float openTimer; // 0x15C
	private GameObject iconUI; // 0x160
	private MobaMobBattleStatus battleStatus; // 0x168
	private UIMobaChestLabel label; // 0x170
	private byte state; // 0x178

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override bool IsLocalDead { get; }
	public override bool IsDead { get; }
	public float TimerRate { get; }
	public bool IsPopLabel { get; }
	public byte TreasureEquipLevel { get; }
	public byte TreasureLevel { get; }

	// Methods

	// RVA: 0x1EFFEE4 Offset: 0x1EFBEE4 VA: 0x1EFFEE4
	public static bool CheckChestMob(int mobId) { }

	// RVA: 0x1EFFEFC Offset: 0x1EFBEFC VA: 0x1EFFEFC Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1EFFF04 Offset: 0x1EFBF04 VA: 0x1EFFF04 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1EFFF0C Offset: 0x1EFBF0C VA: 0x1EFFF0C Slot: 5
	public override bool get_IsLocalDead() { }

	// RVA: 0x1EFFF1C Offset: 0x1EFBF1C VA: 0x1EFFF1C Slot: 7
	public override bool get_IsDead() { }

	// RVA: 0x1EFFF28 Offset: 0x1EFBF28 VA: 0x1EFFF28
	public float get_TimerRate() { }

	// RVA: 0x1EFFF4C Offset: 0x1EFBF4C VA: 0x1EFFF4C
	public bool get_IsPopLabel() { }

	// RVA: 0x1EFFFF8 Offset: 0x1EFBFF8 VA: 0x1EFFFF8 Slot: 108
	public byte get_TreasureEquipLevel() { }

	// RVA: 0x1F00034 Offset: 0x1EFC034 VA: 0x1F00034 Slot: 109
	public byte get_TreasureLevel() { }

	// RVA: 0x1F0003C Offset: 0x1EFC03C VA: 0x1F0003C Slot: 96
	public override void AttackTargetObject(int targetId, bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1F00040 Offset: 0x1EFC040 VA: 0x1F00040 Slot: 101
	public override void ChangeBattleAI() { }

	// RVA: 0x1F00044 Offset: 0x1EFC044 VA: 0x1F00044 Slot: 97
	public override void ChangeTargetObject(int targetId) { }

	// RVA: 0x1F00048 Offset: 0x1EFC048 VA: 0x1F00048 Slot: 102
	public override bool CheckAssistMove(GameObject target) { }

	// RVA: 0x1F00050 Offset: 0x1EFC050 VA: 0x1F00050 Slot: 99
	public override void ReceiveMove(Vector3 pos, float UpdateTime, bool isReconnect) { }

	// RVA: 0x1F000AC Offset: 0x1EFC0AC VA: 0x1F000AC Slot: 98
	protected override void Rematch(GameObject target) { }

	// RVA: 0x1F000B0 Offset: 0x1EFC0B0 VA: 0x1F000B0 Slot: 105
	public override void UnmanagedEnemey(GameObject actor) { }

	// RVA: 0x1F000B4 Offset: 0x1EFC0B4 VA: 0x1F000B4 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F0018C Offset: 0x1EFC18C VA: 0x1F0018C Slot: 18
	protected override void OnDestroy() { }

	// RVA: 0x1F0021C Offset: 0x1EFC21C VA: 0x1F0021C Slot: 75
	public override void AddNameLabel() { }

	// RVA: 0x1F002B0 Offset: 0x1EFC2B0 VA: 0x1F002B0 Slot: 73
	protected override void Update() { }

	// RVA: 0x1F00628 Offset: 0x1EFC628 VA: 0x1F00628 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F00700 Offset: 0x1EFC700 VA: 0x1F00700 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1F00704 Offset: 0x1EFC704 VA: 0x1F00704
	private void ReceiveUpdateTimer(short openSec, long elapsedTicks) { }

	// RVA: 0x1F007C0 Offset: 0x1EFC7C0 VA: 0x1F007C0
	public bool ChestStart() { }

	// RVA: 0x1F004DC Offset: 0x1EFC4DC VA: 0x1F004DC
	public void ChestOpen() { }

	// RVA: 0x1F0039C Offset: 0x1EFC39C VA: 0x1F0039C
	private void ChestCancel() { }

	// RVA: 0x1F00A08 Offset: 0x1EFCA08 VA: 0x1F00A08
	private void OpenChest() { }

	// RVA: 0x1F00A50 Offset: 0x1EFCA50 VA: 0x1F00A50
	private void ResetChest() { }

	// RVA: 0x1F00A6C Offset: 0x1EFCA6C VA: 0x1F00A6C
	public void ReceiveMobaChestEvent(byte state) { }

	// RVA: 0x1F00AA4 Offset: 0x1EFCAA4 VA: 0x1F00AA4
	public void .ctor() { }

	// RVA: 0x1F00AC4 Offset: 0x1EFCAC4 VA: 0x1F00AC4 Slot: 110
	private Transform IMobaTreasureEquip.get_transform() { }
}
