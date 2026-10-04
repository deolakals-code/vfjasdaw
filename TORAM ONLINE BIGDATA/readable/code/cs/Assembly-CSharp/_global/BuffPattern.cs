// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BuffPattern : MobPatternBase // TypeDefIndex: 755
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private bool isAttackSoundTiming; // 0x78
	[CompilerGenerated]
	private MobBuffBase <Buff>k__BackingField; // 0x80
	[CompilerGenerated]
	private int <MobUid>k__BackingField; // 0x88

	// Properties
	public MobBuffBase Buff { get; set; }
	public int MobUid { get; set; }
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1C74D18 Offset: 0x1C70D18 VA: 0x1C74D18
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	[CompilerGenerated]
	// RVA: 0x1C74E5C Offset: 0x1C70E5C VA: 0x1C74E5C
	public MobBuffBase get_Buff() { }

	[CompilerGenerated]
	// RVA: 0x1C74E64 Offset: 0x1C70E64 VA: 0x1C74E64
	private void set_Buff(MobBuffBase value) { }

	[CompilerGenerated]
	// RVA: 0x1C74E6C Offset: 0x1C70E6C VA: 0x1C74E6C
	public int get_MobUid() { }

	[CompilerGenerated]
	// RVA: 0x1C74E74 Offset: 0x1C70E74 VA: 0x1C74E74
	private void set_MobUid(int value) { }

	// RVA: 0x1C74E7C Offset: 0x1C70E7C VA: 0x1C74E7C Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1C74E84 Offset: 0x1C70E84 VA: 0x1C74E84 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1C74E8C Offset: 0x1C70E8C VA: 0x1C74E8C Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1C74EFC Offset: 0x1C70EFC VA: 0x1C74EFC Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C74F34 Offset: 0x1C70F34 VA: 0x1C74F34 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1C74F78 Offset: 0x1C70F78 VA: 0x1C74F78 Slot: 24
	protected override PatternCommand OnPostUpdate() { }
}
