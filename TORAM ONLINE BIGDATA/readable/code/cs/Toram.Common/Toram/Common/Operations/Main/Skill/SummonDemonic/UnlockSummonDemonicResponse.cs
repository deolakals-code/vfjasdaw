// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill.SummonDemonic
public class UnlockSummonDemonicResponse : OperationResponseBase // TypeDefIndex: 12121
{
	// Fields
	[CompilerGenerated]
	private long <Model>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x2C

	// Properties
	public long Model { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378BA94 Offset: 0x3787A94 VA: 0x378BA94
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378BA9C Offset: 0x3787A9C VA: 0x378BA9C
	public long get_Model() { }

	[CompilerGenerated]
	// RVA: 0x378BAA4 Offset: 0x3787AA4 VA: 0x378BAA4
	public void set_Model(long value) { }

	[CompilerGenerated]
	// RVA: 0x378BAAC Offset: 0x3787AAC VA: 0x378BAAC
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x378BAB4 Offset: 0x3787AB4 VA: 0x378BAB4
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x378BABC Offset: 0x3787ABC VA: 0x378BABC
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x378BAC4 Offset: 0x3787AC4 VA: 0x378BAC4
	public void set_PaidOrb(int value) { }

	// RVA: 0x378BACC Offset: 0x3787ACC VA: 0x378BACC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378BAD4 Offset: 0x3787AD4 VA: 0x378BAD4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378BADC Offset: 0x3787ADC VA: 0x378BADC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378BBE8 Offset: 0x3787BE8 VA: 0x378BBE8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
