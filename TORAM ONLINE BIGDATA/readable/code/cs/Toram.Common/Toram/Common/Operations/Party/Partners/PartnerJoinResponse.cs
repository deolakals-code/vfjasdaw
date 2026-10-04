// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Partners
public class PartnerJoinResponse : OperationResponseBase // TypeDefIndex: 11477
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28

	// Properties
	public int ArchetypeId { get; set; }
	public byte ArchetypeType { get; set; }
	public string Name { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3710298 Offset: 0x370C298 VA: 0x3710298
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37102A0 Offset: 0x370C2A0 VA: 0x37102A0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x37102A8 Offset: 0x370C2A8 VA: 0x37102A8
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37102B0 Offset: 0x370C2B0 VA: 0x37102B0
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x37102B8 Offset: 0x370C2B8 VA: 0x37102B8
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37102C0 Offset: 0x370C2C0 VA: 0x37102C0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x37102C8 Offset: 0x370C2C8 VA: 0x37102C8
	public void set_Name(string value) { }

	// RVA: 0x37102D0 Offset: 0x370C2D0 VA: 0x37102D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37102D8 Offset: 0x370C2D8 VA: 0x37102D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37102E0 Offset: 0x370C2E0 VA: 0x37102E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37104B0 Offset: 0x370C4B0 VA: 0x37104B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
