// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationGetListResponse : OperationResponseBase // TypeDefIndex: 12194
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

	// RVA: 0x35DEB34 Offset: 0x35DAB34 VA: 0x35DEB34
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35DEB3C Offset: 0x35DAB3C VA: 0x35DEB3C
	public CultivationSendData[] get_CultivationList() { }

	[CompilerGenerated]
	// RVA: 0x35DEB44 Offset: 0x35DAB44 VA: 0x35DEB44
	public void set_CultivationList(CultivationSendData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35DEB4C Offset: 0x35DAB4C VA: 0x35DEB4C
	public Dictionary<int, short> get_PriceList() { }

	[CompilerGenerated]
	// RVA: 0x35DEB54 Offset: 0x35DAB54 VA: 0x35DEB54
	public void set_PriceList(Dictionary<int, short> value) { }

	// RVA: 0x35DEB5C Offset: 0x35DAB5C VA: 0x35DEB5C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DEC28 Offset: 0x35DAC28 VA: 0x35DEC28
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DECAC Offset: 0x35DACAC VA: 0x35DECAC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DECB4 Offset: 0x35DACB4 VA: 0x35DECB4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DECBC Offset: 0x35DACBC VA: 0x35DECBC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DEE08 Offset: 0x35DAE08 VA: 0x35DEE08 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
