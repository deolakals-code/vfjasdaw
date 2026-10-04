// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Market
public class MarketUserSalesListResponse : OperationResponseBase // TypeDefIndex: 11928
{
	// Fields
	[CompilerGenerated]
	private int <SalesMax>k__BackingField; // 0x20
	[CompilerGenerated]
	private SalesData[] <SalesList>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <SkillFeeRate>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <CourseFeeRate>k__BackingField; // 0x31
	[CompilerGenerated]
	private byte <CountryTariffRate>k__BackingField; // 0x32

	// Properties
	[PacketParameter(Code = 195)]
	public int SalesMax { get; set; }
	[PacketClass(Code = 213, IsOptional = True)]
	public SalesData[] SalesList { get; set; }
	[PacketParameter(Code = 40)]
	public byte SkillFeeRate { get; set; }
	[PacketParameter(Code = 229)]
	public byte CourseFeeRate { get; set; }
	[PacketParameter(Code = 145)]
	public byte CountryTariffRate { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37675E4 Offset: 0x37635E4 VA: 0x37675E4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37675EC Offset: 0x37635EC VA: 0x37675EC
	public int get_SalesMax() { }

	[CompilerGenerated]
	// RVA: 0x37675F4 Offset: 0x37635F4 VA: 0x37675F4
	public void set_SalesMax(int value) { }

	[CompilerGenerated]
	// RVA: 0x37675FC Offset: 0x37635FC VA: 0x37675FC
	public SalesData[] get_SalesList() { }

	[CompilerGenerated]
	// RVA: 0x3767604 Offset: 0x3763604 VA: 0x3767604
	public void set_SalesList(SalesData[] value) { }

	[CompilerGenerated]
	// RVA: 0x376760C Offset: 0x376360C VA: 0x376760C
	public byte get_SkillFeeRate() { }

	[CompilerGenerated]
	// RVA: 0x3767614 Offset: 0x3763614 VA: 0x3767614
	public void set_SkillFeeRate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376761C Offset: 0x376361C VA: 0x376761C
	public byte get_CourseFeeRate() { }

	[CompilerGenerated]
	// RVA: 0x3767624 Offset: 0x3763624 VA: 0x3767624
	public void set_CourseFeeRate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376762C Offset: 0x376362C VA: 0x376762C
	public byte get_CountryTariffRate() { }

	[CompilerGenerated]
	// RVA: 0x3767634 Offset: 0x3763634 VA: 0x3767634
	public void set_CountryTariffRate(byte value) { }

	// RVA: 0x376763C Offset: 0x376363C VA: 0x376763C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376773C Offset: 0x376373C VA: 0x376773C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37677C8 Offset: 0x37637C8 VA: 0x37677C8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37677D0 Offset: 0x37637D0 VA: 0x37677D0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37677D8 Offset: 0x37637D8 VA: 0x37677D8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37679F0 Offset: 0x37639F0 VA: 0x37679F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
