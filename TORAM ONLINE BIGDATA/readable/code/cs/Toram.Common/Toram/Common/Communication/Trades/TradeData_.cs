// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Trades
public class TradeData_ : BinaryBase // TypeDefIndex: 13015
{
	// Fields
	[CompilerGenerated]
	private int <MemberId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x28
	[CompilerGenerated]
	private ItemDatav2[] <Items>k__BackingField; // 0x30
	[CompilerGenerated]
	private StarGemData[] <StarGems>k__BackingField; // 0x38

	// Properties
	public int MemberId { get; set; }
	public string Name { get; set; }
	public int Gold { get; set; }
	public ItemDatav2[] Items { get; set; }
	public StarGemData[] StarGems { get; set; }

	// Methods

	// RVA: 0x368E530 Offset: 0x368A530 VA: 0x368E530
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x368E538 Offset: 0x368A538 VA: 0x368E538
	public int get_MemberId() { }

	[CompilerGenerated]
	// RVA: 0x368E540 Offset: 0x368A540 VA: 0x368E540
	public void set_MemberId(int value) { }

	[CompilerGenerated]
	// RVA: 0x368E548 Offset: 0x368A548 VA: 0x368E548
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x368E550 Offset: 0x368A550 VA: 0x368E550
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x368E558 Offset: 0x368A558 VA: 0x368E558
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x368E560 Offset: 0x368A560 VA: 0x368E560
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x368E568 Offset: 0x368A568 VA: 0x368E568
	public ItemDatav2[] get_Items() { }

	[CompilerGenerated]
	// RVA: 0x368E570 Offset: 0x368A570 VA: 0x368E570
	public void set_Items(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x368E578 Offset: 0x368A578 VA: 0x368E578
	public StarGemData[] get_StarGems() { }

	[CompilerGenerated]
	// RVA: 0x368E580 Offset: 0x368A580 VA: 0x368E580
	public void set_StarGems(StarGemData[] value) { }

	// RVA: 0x368E588 Offset: 0x368A588 VA: 0x368E588 Slot: 3
	public override string ToString() { }

	// RVA: 0x368E768 Offset: 0x368A768 VA: 0x368E768 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368E828 Offset: 0x368A828 VA: 0x368E828 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
