// Assembly: Toram.Common.dll
// Namespace: Toram.Common.ScoreAttack
public class ScoreAttackRewardData : BinaryBase // TypeDefIndex: 11273
{
	// Fields
	[CompilerGenerated]
	private byte <RotationId>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <BossId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <RankingType>k__BackingField; // 0x1B
	[CompilerGenerated]
	private byte <Tier>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsReceived>k__BackingField; // 0x1D

	// Properties
	public byte RotationId { get; set; }
	public byte BossId { get; set; }
	public byte RankingType { get; set; }
	public byte Tier { get; set; }
	public bool IsReceived { get; set; }

	// Methods

	// RVA: 0x36D561C Offset: 0x36D161C VA: 0x36D561C
	public void .ctor() { }

	// RVA: 0x36D5624 Offset: 0x36D1624 VA: 0x36D5624
	public void .ctor(byte rotationId, byte bossId, byte rankingType, byte tier, bool isReceive) { }

	[CompilerGenerated]
	// RVA: 0x36D5680 Offset: 0x36D1680 VA: 0x36D5680
	public byte get_RotationId() { }

	[CompilerGenerated]
	// RVA: 0x36D5688 Offset: 0x36D1688 VA: 0x36D5688
	private void set_RotationId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D5690 Offset: 0x36D1690 VA: 0x36D5690
	public byte get_BossId() { }

	[CompilerGenerated]
	// RVA: 0x36D5698 Offset: 0x36D1698 VA: 0x36D5698
	private void set_BossId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D56A0 Offset: 0x36D16A0 VA: 0x36D56A0
	public byte get_RankingType() { }

	[CompilerGenerated]
	// RVA: 0x36D56A8 Offset: 0x36D16A8 VA: 0x36D56A8
	private void set_RankingType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D56B0 Offset: 0x36D16B0 VA: 0x36D56B0
	public byte get_Tier() { }

	[CompilerGenerated]
	// RVA: 0x36D56B8 Offset: 0x36D16B8 VA: 0x36D56B8
	private void set_Tier(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D56C0 Offset: 0x36D16C0 VA: 0x36D56C0
	public bool get_IsReceived() { }

	[CompilerGenerated]
	// RVA: 0x36D56C8 Offset: 0x36D16C8 VA: 0x36D56C8
	private void set_IsReceived(bool value) { }

	// RVA: 0x36D56D4 Offset: 0x36D16D4 VA: 0x36D56D4 Slot: 3
	public override string ToString() { }

	// RVA: 0x36D5938 Offset: 0x36D1938 VA: 0x36D5938 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D59A4 Offset: 0x36D19A4 VA: 0x36D59A4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
