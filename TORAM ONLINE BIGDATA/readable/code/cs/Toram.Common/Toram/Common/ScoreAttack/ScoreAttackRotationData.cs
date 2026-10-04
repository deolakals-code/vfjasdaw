// Assembly: Toram.Common.dll
// Namespace: Toram.Common.ScoreAttack
public class ScoreAttackRotationData : BinaryBase // TypeDefIndex: 11278
{
	// Fields
	[CompilerGenerated]
	private byte <RotationId>k__BackingField; // 0x19
	[CompilerGenerated]
	private ScoreAttackBossData[] <Bosses>k__BackingField; // 0x20

	// Properties
	public byte RotationId { get; set; }
	public ScoreAttackBossData[] Bosses { get; set; }

	// Methods

	// RVA: 0x36D62D8 Offset: 0x36D22D8 VA: 0x36D62D8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36D62E0 Offset: 0x36D22E0 VA: 0x36D62E0
	public byte get_RotationId() { }

	[CompilerGenerated]
	// RVA: 0x36D62E8 Offset: 0x36D22E8 VA: 0x36D62E8
	public void set_RotationId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D62F0 Offset: 0x36D22F0 VA: 0x36D62F0
	public ScoreAttackBossData[] get_Bosses() { }

	[CompilerGenerated]
	// RVA: 0x36D62F8 Offset: 0x36D22F8 VA: 0x36D62F8
	public void set_Bosses(ScoreAttackBossData[] value) { }

	// RVA: 0x36D6300 Offset: 0x36D2300 VA: 0x36D6300 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D6374 Offset: 0x36D2374 VA: 0x36D6374 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
