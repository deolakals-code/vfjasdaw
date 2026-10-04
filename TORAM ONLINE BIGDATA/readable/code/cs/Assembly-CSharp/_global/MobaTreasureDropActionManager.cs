// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(MobAnimation))]
public class MobaTreasureDropActionManager : MobaMobActionManagerBase, IMobaTreasureEquip // TypeDefIndex: 913
{
	// Fields
	private const float maxMeter = 5;
	[CompilerGenerated]
	private short <ItemId>k__BackingField; // 0x158
	private MobaMobBattleStatus battleStatus; // 0x160
	private UIMobaTreasureDropLabel label; // 0x168
	private byte state; // 0x170
	private GameObject iconUI; // 0x178

	// Properties
	public override IMobStatusCalculator MobBattleStatus { get; }
	public override bool IsBoss { get; }
	public override bool IsLocalDead { get; }
	public override bool IsDead { get; }
	public bool IsPopLabel { get; }
	public short ItemId { get; set; }
	public byte TreasureEquipLevel { get; }
	public byte TreasureLevel { get; }

	// Methods

	// RVA: 0x1F02C20 Offset: 0x1EFEC20 VA: 0x1F02C20
	public static bool CheckChestMob(int mobId) { }

	// RVA: 0x1F02C38 Offset: 0x1EFEC38 VA: 0x1F02C38 Slot: 62
	public override IMobStatusCalculator get_MobBattleStatus() { }

	// RVA: 0x1F02C40 Offset: 0x1EFEC40 VA: 0x1F02C40 Slot: 64
	public override bool get_IsBoss() { }

	// RVA: 0x1F02C48 Offset: 0x1EFEC48 VA: 0x1F02C48 Slot: 5
	public override bool get_IsLocalDead() { }

	// RVA: 0x1F02C58 Offset: 0x1EFEC58 VA: 0x1F02C58 Slot: 7
	public override bool get_IsDead() { }

	// RVA: 0x1F02C64 Offset: 0x1EFEC64 VA: 0x1F02C64
	public bool get_IsPopLabel() { }

	[CompilerGenerated]
	// RVA: 0x1F02E14 Offset: 0x1EFEE14 VA: 0x1F02E14
	public short get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x1F02E1C Offset: 0x1EFEE1C VA: 0x1F02E1C
	private void set_ItemId(short value) { }

	// RVA: 0x1F02E24 Offset: 0x1EFEE24 VA: 0x1F02E24 Slot: 108
	public byte get_TreasureEquipLevel() { }

	// RVA: 0x1F02E60 Offset: 0x1EFEE60 VA: 0x1F02E60 Slot: 109
	public byte get_TreasureLevel() { }

	// RVA: 0x1F02E68 Offset: 0x1EFEE68 VA: 0x1F02E68 Slot: 96
	public override void AttackTargetObject(int targetId, bool isAttackControl, bool isEventAttack) { }

	// RVA: 0x1F02E6C Offset: 0x1EFEE6C VA: 0x1F02E6C Slot: 101
	public override void ChangeBattleAI() { }

	// RVA: 0x1F02E70 Offset: 0x1EFEE70 VA: 0x1F02E70 Slot: 97
	public override void ChangeTargetObject(int targetId) { }

	// RVA: 0x1F02E74 Offset: 0x1EFEE74 VA: 0x1F02E74 Slot: 102
	public override bool CheckAssistMove(GameObject target) { }

	// RVA: 0x1F02E7C Offset: 0x1EFEE7C VA: 0x1F02E7C Slot: 99
	public override void ReceiveMove(Vector3 pos, float UpdateTime, bool isReconnect) { }

	// RVA: 0x1F02ED8 Offset: 0x1EFEED8 VA: 0x1F02ED8 Slot: 98
	protected override void Rematch(GameObject target) { }

	// RVA: 0x1F02EDC Offset: 0x1EFEEDC VA: 0x1F02EDC Slot: 105
	public override void UnmanagedEnemey(GameObject actor) { }

	// RVA: 0x1F02EE0 Offset: 0x1EFEEE0 VA: 0x1F02EE0 Slot: 72
	protected override void Awake() { }

	// RVA: 0x1F02FB8 Offset: 0x1EFEFB8 VA: 0x1F02FB8
	private void OnDestroy() { }

	// RVA: 0x1F03048 Offset: 0x1EFF048 VA: 0x1F03048 Slot: 75
	public override void AddNameLabel() { }

	// RVA: 0x1F030DC Offset: 0x1EFF0DC VA: 0x1F030DC Slot: 73
	protected override void Update() { }

	// RVA: 0x1F03164 Offset: 0x1EFF164 VA: 0x1F03164 Slot: 76
	protected override void OnSetStatus() { }

	// RVA: 0x1F034C8 Offset: 0x1EFF4C8 VA: 0x1F034C8 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1F034CC Offset: 0x1EFF4CC VA: 0x1F034CC
	public void PickUp(byte equipNo) { }

	// RVA: 0x1F035C8 Offset: 0x1EFF5C8 VA: 0x1F035C8
	public void SetItemId(short itemId) { }

	// RVA: 0x1F03660 Offset: 0x1EFF660 VA: 0x1F03660
	private void GetItem() { }

	// RVA: 0x1F0366C Offset: 0x1EFF66C VA: 0x1F0366C
	public void .ctor() { }

	// RVA: 0x1F03674 Offset: 0x1EFF674 VA: 0x1F03674 Slot: 110
	private Transform IMobaTreasureEquip.get_transform() { }
}
