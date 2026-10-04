// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class SongActionBase : PlayerAttackBase // TypeDefIndex: 3751
{
	// Fields
	public const float SongEffectRange = 50;
	public static readonly SkillId[] SongSkillIds; // 0x0
	protected int costMp; // 0x120

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public override bool IsSupportSetLocalId { get; }
	public override int BaseMp { get; }
	protected abstract int BaseCostMp { get; }

	// Methods

	// RVA: 0x23DCA54 Offset: 0x23D8A54 VA: 0x23DCA54 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DCA5C Offset: 0x23D8A5C VA: 0x23DCA5C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DCA64 Offset: 0x23D8A64 VA: 0x23DCA64 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DCA6C Offset: 0x23D8A6C VA: 0x23DCA6C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DCA74 Offset: 0x23D8A74 VA: 0x23DCA74 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DCA7C Offset: 0x23D8A7C VA: 0x23DCA7C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DCA84 Offset: 0x23D8A84 VA: 0x23DCA84 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DCA8C Offset: 0x23D8A8C VA: 0x23DCA8C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DCA94 Offset: 0x23D8A94 VA: 0x23DCA94 Slot: 16
	public override bool get_IsSupportSetLocalId() { }

	// RVA: 0x23DCA9C Offset: 0x23D8A9C VA: 0x23DCA9C Slot: 23
	public override int get_BaseMp() { }

	// RVA: -1 Offset: -1 Slot: 91
	protected abstract int get_BaseCostMp();

	// RVA: 0x23D4068 Offset: 0x23D0068 VA: 0x23D4068
	public int CalcBaseCostMp(PlayerStatusBase status) { }

	// RVA: 0x23DCAA4 Offset: 0x23D8AA4 VA: 0x23DCAA4 Slot: 92
	public virtual void EffectiveSongBuffer(PlayerActionManagerBase playerAction) { }

	// RVA: 0x23DCAA8 Offset: 0x23D8AA8 VA: 0x23DCAA8
	public void StartSetlist(SetlistAction setlistAction) { }

	// RVA: 0x23D4194 Offset: 0x23D0194 VA: 0x23D4194
	public static bool CheckSongRange(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23DCAF0 Offset: 0x23D8AF0 VA: 0x23DCAF0
	public static void ReceiveSupport(short skillId, byte skillLv, byte targetArchetypeType, int targetArchetypeId, SupportResultData supportData) { }

	// RVA: 0x23DCEC8 Offset: 0x23D8EC8 VA: 0x23DCEC8
	public static bool IsSongSkillId(SkillId skillId) { }

	// RVA: 0x23DCF40 Offset: 0x23D8F40 VA: 0x23DCF40
	public static bool IsSongSkillId(int skillId) { }

	// RVA: 0x23DCCAC Offset: 0x23D8CAC VA: 0x23DCCAC
	public static void DecryptionReceiveValue(int value, out byte skillLocalId, out SongActionBase.Flag flag) { }

	// RVA: 0x23D493C Offset: 0x23D093C VA: 0x23D493C
	protected void .ctor() { }

	// RVA: 0x23DCF94 Offset: 0x23D8F94 VA: 0x23DCF94
	private static void .cctor() { }
}
