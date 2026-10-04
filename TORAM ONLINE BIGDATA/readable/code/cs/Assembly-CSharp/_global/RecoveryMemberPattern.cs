// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RecoveryMemberPattern : MobPatternBase // TypeDefIndex: 822
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private int healValue; // 0x78
	private int healPercentValue; // 0x7C
	private int flag; // 0x80
	private int mobUuid; // 0x84
	private bool isAttackSoundTiming; // 0x88

	// Properties
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }
	public int Heal { get; }
	public int HealPercent { get; }
	public bool IsBossRecovery { get; }
	public bool IsFollwerRecovery { get; }
	public bool IsSelfRecovery { get; }
	public int RecoveryMobUId { get; }

	// Methods

	// RVA: 0x1E1D97C Offset: 0x1E1997C VA: 0x1E1D97C Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E1D984 Offset: 0x1E19984 VA: 0x1E1D984 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E1D98C Offset: 0x1E1998C VA: 0x1E1D98C
	public int get_Heal() { }

	// RVA: 0x1E1D994 Offset: 0x1E19994 VA: 0x1E1D994
	public int get_HealPercent() { }

	// RVA: 0x1E1D99C Offset: 0x1E1999C VA: 0x1E1D99C
	public bool get_IsBossRecovery() { }

	// RVA: 0x1E1D9A8 Offset: 0x1E199A8 VA: 0x1E1D9A8
	public bool get_IsFollwerRecovery() { }

	// RVA: 0x1E1D9B4 Offset: 0x1E199B4 VA: 0x1E1D9B4
	public bool get_IsSelfRecovery() { }

	// RVA: 0x1E1D9C0 Offset: 0x1E199C0 VA: 0x1E1D9C0
	public int get_RecoveryMobUId() { }

	// RVA: 0x1E1D9C8 Offset: 0x1E199C8 VA: 0x1E1D9C8
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1DB00 Offset: 0x1E19B00 VA: 0x1E1DB00 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E1DBCC Offset: 0x1E19BCC VA: 0x1E1DBCC Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E1DC04 Offset: 0x1E19C04 VA: 0x1E1DC04 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E1DC48 Offset: 0x1E19C48 VA: 0x1E1DC48 Slot: 24
	protected override PatternCommand OnPostUpdate() { }
}
