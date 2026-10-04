// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationPlantResponse : OperationResponseBase // TypeDefIndex: 12202
{
	// Fields
	[CompilerGenerated]
	private short <Index>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x24
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 153)]
	public short Index { get; set; }
	[PacketParameter(Code = 200)]
	public int Id { get; set; }
	[PacketParameter(Code = 146)]
	public MaterialData[] MaterialList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E00F8 Offset: 0x35DC0F8 VA: 0x35E00F8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E0100 Offset: 0x35DC100 VA: 0x35E0100
	public short get_Index() { }

	[CompilerGenerated]
	// RVA: 0x35E0108 Offset: 0x35DC108 VA: 0x35E0108
	public void set_Index(short value) { }

	[CompilerGenerated]
	// RVA: 0x35E0110 Offset: 0x35DC110 VA: 0x35E0110
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35E0118 Offset: 0x35DC118 VA: 0x35E0118
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E0120 Offset: 0x35DC120 VA: 0x35E0120
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x35E0128 Offset: 0x35DC128 VA: 0x35E0128
	public void set_MaterialList(MaterialData[] value) { }

	// RVA: 0x35E0130 Offset: 0x35DC130 VA: 0x35E0130
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E0220 Offset: 0x35DC220 VA: 0x35E0220
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E02AC Offset: 0x35DC2AC VA: 0x35E02AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E02B4 Offset: 0x35DC2B4 VA: 0x35E02B4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E02BC Offset: 0x35DC2BC VA: 0x35E02BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E0444 Offset: 0x35DC444 VA: 0x35E0444 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
