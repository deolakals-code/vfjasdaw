// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemExchange : OperationRequestBase // TypeDefIndex: 11841
{
	// Fields
	[CompilerGenerated]
	private bool <IsDirect>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UseShard>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x2C

	// Properties
	public bool IsDirect { get; set; }
	public int UseShard { get; set; }
	public short SkillId { get; set; }
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3754A28 Offset: 0x3750A28 VA: 0x3754A28
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3754A30 Offset: 0x3750A30 VA: 0x3754A30
	public bool get_IsDirect() { }

	[CompilerGenerated]
	// RVA: 0x3754A38 Offset: 0x3750A38 VA: 0x3754A38
	public void set_IsDirect(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3754A44 Offset: 0x3750A44 VA: 0x3754A44
	public int get_UseShard() { }

	[CompilerGenerated]
	// RVA: 0x3754A4C Offset: 0x3750A4C VA: 0x3754A4C
	public void set_UseShard(int value) { }

	[CompilerGenerated]
	// RVA: 0x3754A54 Offset: 0x3750A54 VA: 0x3754A54
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x3754A5C Offset: 0x3750A5C VA: 0x3754A5C
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3754A64 Offset: 0x3750A64 VA: 0x3754A64
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3754A6C Offset: 0x3750A6C VA: 0x3754A6C
	public void set_Orb(int value) { }

	// RVA: 0x3754A74 Offset: 0x3750A74 VA: 0x3754A74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3754A7C Offset: 0x3750A7C VA: 0x3754A7C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3754A84 Offset: 0x3750A84 VA: 0x3754A84 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3754CA0 Offset: 0x3750CA0 VA: 0x3754CA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
