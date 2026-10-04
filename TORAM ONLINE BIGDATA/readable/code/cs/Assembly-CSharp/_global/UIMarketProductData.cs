// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketProductData // TypeDefIndex: 8431
{
	// Fields
	[CompilerGenerated]
	private MarketSalesState <State>k__BackingField; // 0x10
	[CompilerGenerated]
	private ItemData <Item>k__BackingField; // 0x18
	[CompilerGenerated]
	private long <Id>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ExhibitorId>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <Date>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <CountryRate>k__BackingField; // 0x3C
	[CompilerGenerated]
	private int <Fee>k__BackingField; // 0x40
	[CompilerGenerated]
	private StarGemData <StarGemData>k__BackingField; // 0x48

	// Properties
	public MarketSalesState State { get; set; }
	public ItemData Item { get; set; }
	public long Id { get; set; }
	public int ExhibitorId { get; set; }
	public DateTime Date { get; set; }
	public int Price { get; set; }
	public byte CountryRate { get; set; }
	public bool IsSale { get; }
	public int Fee { get; set; }
	public StarGemData StarGemData { get; set; }
	public bool IsStarGem { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D62284 Offset: 0x1D5E284 VA: 0x1D62284
	public MarketSalesState get_State() { }

	[CompilerGenerated]
	// RVA: 0x1D6228C Offset: 0x1D5E28C VA: 0x1D6228C
	private void set_State(MarketSalesState value) { }

	[CompilerGenerated]
	// RVA: 0x1D62294 Offset: 0x1D5E294 VA: 0x1D62294
	public ItemData get_Item() { }

	[CompilerGenerated]
	// RVA: 0x1D6229C Offset: 0x1D5E29C VA: 0x1D6229C
	private void set_Item(ItemData value) { }

	[CompilerGenerated]
	// RVA: 0x1D622A4 Offset: 0x1D5E2A4 VA: 0x1D622A4
	public long get_Id() { }

	[CompilerGenerated]
	// RVA: 0x1D622AC Offset: 0x1D5E2AC VA: 0x1D622AC
	private void set_Id(long value) { }

	[CompilerGenerated]
	// RVA: 0x1D622B4 Offset: 0x1D5E2B4 VA: 0x1D622B4
	public int get_ExhibitorId() { }

	[CompilerGenerated]
	// RVA: 0x1D622BC Offset: 0x1D5E2BC VA: 0x1D622BC
	private void set_ExhibitorId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D622C4 Offset: 0x1D5E2C4 VA: 0x1D622C4
	public DateTime get_Date() { }

	[CompilerGenerated]
	// RVA: 0x1D622CC Offset: 0x1D5E2CC VA: 0x1D622CC
	private void set_Date(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x1D622D4 Offset: 0x1D5E2D4 VA: 0x1D622D4
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x1D622DC Offset: 0x1D5E2DC VA: 0x1D622DC
	private void set_Price(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D622E4 Offset: 0x1D5E2E4 VA: 0x1D622E4
	public byte get_CountryRate() { }

	[CompilerGenerated]
	// RVA: 0x1D622EC Offset: 0x1D5E2EC VA: 0x1D622EC
	private void set_CountryRate(byte value) { }

	// RVA: 0x1D5B3C0 Offset: 0x1D573C0 VA: 0x1D5B3C0
	public bool get_IsSale() { }

	[CompilerGenerated]
	// RVA: 0x1D622F4 Offset: 0x1D5E2F4 VA: 0x1D622F4
	public int get_Fee() { }

	[CompilerGenerated]
	// RVA: 0x1D622FC Offset: 0x1D5E2FC VA: 0x1D622FC
	private void set_Fee(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D62304 Offset: 0x1D5E304 VA: 0x1D62304
	public StarGemData get_StarGemData() { }

	[CompilerGenerated]
	// RVA: 0x1D6230C Offset: 0x1D5E30C VA: 0x1D6230C
	private void set_StarGemData(StarGemData value) { }

	// RVA: 0x1D5B3D0 Offset: 0x1D573D0 VA: 0x1D5B3D0
	public bool get_IsStarGem() { }

	// RVA: 0x1D59374 Offset: 0x1D55374 VA: 0x1D59374
	public void .ctor(MarketData marketData, byte countryRate) { }

	// RVA: 0x1D62620 Offset: 0x1D5E620 VA: 0x1D62620
	public void .ctor(MarketData marketData, byte countryRate, int fee) { }

	// RVA: 0x1D62314 Offset: 0x1D5E314 VA: 0x1D62314
	private void initialize(MarketData marketData, byte countryRate, int fee) { }
}
