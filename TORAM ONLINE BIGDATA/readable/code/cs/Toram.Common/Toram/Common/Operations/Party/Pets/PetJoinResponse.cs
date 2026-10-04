// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Pets
public class PetJoinResponse : OperationResponseBase // TypeDefIndex: 11500
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

	// RVA: 0x3713E58 Offset: 0x370FE58 VA: 0x3713E58
	public void .ctor() { }

	// RVA: 0x3713E60 Offset: 0x370FE60 VA: 0x3713E60
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3713E68 Offset: 0x370FE68 VA: 0x3713E68
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3713E70 Offset: 0x370FE70 VA: 0x3713E70
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3713E78 Offset: 0x370FE78 VA: 0x3713E78
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3713E80 Offset: 0x370FE80 VA: 0x3713E80
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3713E88 Offset: 0x370FE88 VA: 0x3713E88
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3713E90 Offset: 0x370FE90 VA: 0x3713E90
	public void set_Name(string value) { }

	// RVA: 0x3713E98 Offset: 0x370FE98 VA: 0x3713E98 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3713EA0 Offset: 0x370FEA0 VA: 0x3713EA0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3713EA8 Offset: 0x370FEA8 VA: 0x3713EA8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3714078 Offset: 0x3710078 VA: 0x3714078 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
