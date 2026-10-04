// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Markets
public class SalesData : UnityHashBase // TypeDefIndex: 11178
{
	// Fields
	[CompilerGenerated]
	private byte <Id>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <MarketType>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <Fee>k__BackingField; // 0x1C
	[CompilerGenerated]
	private MarketData <MarketData>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 200)]
	public byte Id { get; set; }
	[UnityHash(Code = 245)]
	public byte MarketType { get; set; }
	[UnityHash(Code = 145)]
	public int Fee { get; set; }
	[UnityHash(Code = 199)]
	public MarketData MarketData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35D21F4 Offset: 0x35CE1F4 VA: 0x35D21F4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35D21FC Offset: 0x35CE1FC VA: 0x35D21FC
	public byte get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35D2204 Offset: 0x35CE204 VA: 0x35D2204
	protected void set_Id(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D220C Offset: 0x35CE20C VA: 0x35D220C
	public byte get_MarketType() { }

	[CompilerGenerated]
	// RVA: 0x35D2214 Offset: 0x35CE214 VA: 0x35D2214
	protected void set_MarketType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35D221C Offset: 0x35CE21C VA: 0x35D221C
	public int get_Fee() { }

	[CompilerGenerated]
	// RVA: 0x35D2224 Offset: 0x35CE224 VA: 0x35D2224
	protected void set_Fee(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D222C Offset: 0x35CE22C VA: 0x35D222C
	public MarketData get_MarketData() { }

	[CompilerGenerated]
	// RVA: 0x35D2234 Offset: 0x35CE234 VA: 0x35D2234
	protected void set_MarketData(MarketData value) { }

	// RVA: 0x35D223C Offset: 0x35CE23C VA: 0x35D223C
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35D2398 Offset: 0x35CE398 VA: 0x35D2398
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35D244C Offset: 0x35CE44C VA: 0x35D244C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35D2454 Offset: 0x35CE454 VA: 0x35D2454 Slot: 3
	public override string ToString() { }

	// RVA: 0x35D2564 Offset: 0x35CE564 VA: 0x35D2564 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35D2784 Offset: 0x35CE784 VA: 0x35D2784 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
