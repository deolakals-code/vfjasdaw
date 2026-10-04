// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Markets
public class MarketStoreData : UnityHashBase // TypeDefIndex: 11176
{
	// Fields
	[CompilerGenerated]
	private MarketData[] <MarketList>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<byte, byte> <WorldTariffs>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <UpdateTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <MaxPage>k__BackingField; // 0x38

	// Properties
	[UnityHash(Code = 213, IsOptional = True)]
	public MarketData[] MarketList { get; set; }
	[UnityHash(Code = 145, IsOptional = True)]
	public Dictionary<byte, byte> WorldTariffs { get; set; }
	[UnityHash(Code = 172, IsOptional = True)]
	public DateTime UpdateTime { get; set; }
	[UnityHash(Code = 108, IsOptional = True)]
	public byte MaxPage { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35D1AC0 Offset: 0x35CDAC0 VA: 0x35D1AC0
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35D1AC8 Offset: 0x35CDAC8 VA: 0x35D1AC8
	public MarketData[] get_MarketList() { }

	[CompilerGenerated]
	// RVA: 0x35D1AD0 Offset: 0x35CDAD0 VA: 0x35D1AD0
	public void set_MarketList(MarketData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35D1AD8 Offset: 0x35CDAD8 VA: 0x35D1AD8
	public Dictionary<byte, byte> get_WorldTariffs() { }

	[CompilerGenerated]
	// RVA: 0x35D1AE0 Offset: 0x35CDAE0 VA: 0x35D1AE0
	public void set_WorldTariffs(Dictionary<byte, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x35D1AE8 Offset: 0x35CDAE8 VA: 0x35D1AE8
	public DateTime get_UpdateTime() { }

	[CompilerGenerated]
	// RVA: 0x35D1AF0 Offset: 0x35CDAF0 VA: 0x35D1AF0
	public void set_UpdateTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35D1AF8 Offset: 0x35CDAF8 VA: 0x35D1AF8
	public byte get_MaxPage() { }

	[CompilerGenerated]
	// RVA: 0x35D1B00 Offset: 0x35CDB00 VA: 0x35D1B00
	public void set_MaxPage(byte value) { }

	// RVA: 0x35D1B08 Offset: 0x35CDB08 VA: 0x35D1B08
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35D1C44 Offset: 0x35CDC44 VA: 0x35D1C44
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35D1D04 Offset: 0x35CDD04 VA: 0x35D1D04 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35D1D0C Offset: 0x35CDD0C VA: 0x35D1D0C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35D2028 Offset: 0x35CE028 VA: 0x35D2028 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
