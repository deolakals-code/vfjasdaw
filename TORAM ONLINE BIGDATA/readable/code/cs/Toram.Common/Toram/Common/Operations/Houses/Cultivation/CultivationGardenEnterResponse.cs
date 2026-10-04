// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationGardenEnterResponse : OperationResponseBase // TypeDefIndex: 12196
{
	// Fields
	[CompilerGenerated]
	private CultivationSendData[] <CultivationList>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<int, short> <PriceList>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 213)]
	public CultivationSendData[] CultivationList { get; set; }
	[PacketClass(Code = 132)]
	public Dictionary<int, short> PriceList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35DF068 Offset: 0x35DB068 VA: 0x35DF068
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35DF070 Offset: 0x35DB070 VA: 0x35DF070
	public CultivationSendData[] get_CultivationList() { }

	[CompilerGenerated]
	// RVA: 0x35DF078 Offset: 0x35DB078 VA: 0x35DF078
	public void set_CultivationList(CultivationSendData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DF080 Offset: 0x35DB080 VA: 0x35DF080
	public Dictionary<int, short> get_PriceList() { }

	[CompilerGenerated]
	// RVA: 0x35DF088 Offset: 0x35DB088 VA: 0x35DF088
	public void set_PriceList(Dictionary<int, short> value) { }

	// RVA: 0x35DF090 Offset: 0x35DB090 VA: 0x35DF090
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DF15C Offset: 0x35DB15C VA: 0x35DF15C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DF1E0 Offset: 0x35DB1E0 VA: 0x35DF1E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DF1E8 Offset: 0x35DB1E8 VA: 0x35DF1E8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DF1F0 Offset: 0x35DB1F0 VA: 0x35DF1F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DF33C Offset: 0x35DB33C VA: 0x35DF33C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
