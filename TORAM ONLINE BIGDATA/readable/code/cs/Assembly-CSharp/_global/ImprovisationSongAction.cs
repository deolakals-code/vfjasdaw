// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ImprovisationSongAction : PlayerAttackBase // TypeDefIndex: 3688
{
	// Fields
	public const int TakeId = 202013000;
	public const int ResumeTakeId = 202013001;
	private SongBufferBase resumeSongBuf; // 0x120
	private bool isResumed; // 0x128
	private bool isDamaged; // 0x129
	private byte gemcartGuitaristLv; // 0x12A

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsSupportSetLocalId { get; }
	public override bool IsSupportChangeEndTiming { get; }

	// Methods

	// RVA: 0x23C5904 Offset: 0x23C1904 VA: 0x23C5904 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C590C Offset: 0x23C190C VA: 0x23C590C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C5914 Offset: 0x23C1914 VA: 0x23C5914 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C591C Offset: 0x23C191C VA: 0x23C591C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C5924 Offset: 0x23C1924 VA: 0x23C5924 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C592C Offset: 0x23C192C VA: 0x23C592C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C5934 Offset: 0x23C1934 VA: 0x23C5934 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C593C Offset: 0x23C193C VA: 0x23C593C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C5944 Offset: 0x23C1944 VA: 0x23C5944 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C594C Offset: 0x23C194C VA: 0x23C594C Slot: 16
	public override bool get_IsSupportSetLocalId() { }

	// RVA: 0x23C5954 Offset: 0x23C1954 VA: 0x23C5954 Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23C595C Offset: 0x23C195C VA: 0x23C595C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C5AA4 Offset: 0x23C1AA4 VA: 0x23C5AA4 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C63E4 Offset: 0x23C23E4 VA: 0x23C63E4 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C67E0 Offset: 0x23C27E0 VA: 0x23C67E0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23C69F0 Offset: 0x23C29F0 VA: 0x23C69F0 Slot: 49
	public override bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C64D8 Offset: 0x23C24D8 VA: 0x23C64D8
	private void ActiveResumeSong(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23C6D58 Offset: 0x23C2D58 VA: 0x23C6D58
	public bool CheckEquipGemCartGuitarist() { }

	// RVA: 0x23C6D68 Offset: 0x23C2D68 VA: 0x23C6D68 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C6D90 Offset: 0x23C2D90 VA: 0x23C6D90 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C7038 Offset: 0x23C3038 VA: 0x23C7038
	public static void Damaged(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23C63C0 Offset: 0x23C23C0 VA: 0x23C63C0
	private static int Encryption(SkillId resumeSongSkillId, bool isResumeTake) { }

	// RVA: 0x23C7010 Offset: 0x23C3010 VA: 0x23C7010
	private static void Decryption(int value, out SkillId resumeSongSkillId, out bool isResumeTake) { }

	// RVA: 0x23C7110 Offset: 0x23C3110 VA: 0x23C7110
	public void .ctor() { }
}
