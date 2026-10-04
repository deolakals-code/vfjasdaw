// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemExchangeResponse : OperationResponseBase // TypeDefIndex: 11842
{
	// Fields
	[CompilerGenerated]
	private StarGemData <StarGem>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <GemShard>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x30

	// Properties
	public StarGemData StarGem { get; set; }
	public int GemShard { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3754DE8 Offset: 0x3750DE8 VA: 0x3754DE8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3754DF0 Offset: 0x3750DF0 VA: 0x3754DF0
	public StarGemData get_StarGem() { }

	[CompilerGenerated]
	// RVA: 0x3754DF8 Offset: 0x3750DF8 VA: 0x3754DF8
	public void set_StarGem(StarGemData value) { }

	[CompilerGenerated]
	// RVA: 0x3754E00 Offset: 0x3750E00 VA: 0x3754E00
	public int get_GemShard() { }

	[CompilerGenerated]
	// RVA: 0x3754E08 Offset: 0x3750E08 VA: 0x3754E08
	public void set_GemShard(int value) { }

	[CompilerGenerated]
	// RVA: 0x3754E10 Offset: 0x3750E10 VA: 0x3754E10
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3754E18 Offset: 0x3750E18 VA: 0x3754E18
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3754E20 Offset: 0x3750E20 VA: 0x3754E20
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x3754E28 Offset: 0x3750E28 VA: 0x3754E28
	public void set_PaidOrb(int value) { }

	// RVA: 0x3754E30 Offset: 0x3750E30 VA: 0x3754E30
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3754F4C Offset: 0x3750F4C VA: 0x3754F4C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3754FC8 Offset: 0x3750FC8 VA: 0x3754FC8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3754FD0 Offset: 0x3750FD0 VA: 0x3754FD0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3754FD8 Offset: 0x3750FD8 VA: 0x3754FD8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37551C4 Offset: 0x37511C4 VA: 0x37551C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
