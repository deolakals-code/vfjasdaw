// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Shops
public class SignboardPropertyData : BinaryBase // TypeDefIndex: 11076
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x20
	[CompilerGenerated]
	private BazaarItemData[] <BazaarItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x30
	[CompilerGenerated]
	private DateTime <Time>k__BackingField; // 0x38

	// Properties
	public byte Type { get; set; }
	public byte State { get; set; }
	public int ItemId { get; set; }
	public int Gold { get; set; }
	public BazaarItemData[] BazaarItemList { get; set; }
	public string Title { get; set; }
	public DateTime Time { get; set; }

	// Methods

	// RVA: 0x35B3118 Offset: 0x35AF118 VA: 0x35B3118
	public void .ctor() { }

	// RVA: 0x35B3120 Offset: 0x35AF120 VA: 0x35B3120
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35B3128 Offset: 0x35AF128 VA: 0x35B3128
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x35B3130 Offset: 0x35AF130 VA: 0x35B3130
	private void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B3138 Offset: 0x35AF138 VA: 0x35B3138
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x35B3140 Offset: 0x35AF140 VA: 0x35B3140
	private void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B3148 Offset: 0x35AF148 VA: 0x35B3148
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x35B3150 Offset: 0x35AF150 VA: 0x35B3150
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B3158 Offset: 0x35AF158 VA: 0x35B3158
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35B3160 Offset: 0x35AF160 VA: 0x35B3160
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B3168 Offset: 0x35AF168 VA: 0x35B3168
	public BazaarItemData[] get_BazaarItemList() { }

	[CompilerGenerated]
	// RVA: 0x35B3170 Offset: 0x35AF170 VA: 0x35B3170
	public void set_BazaarItemList(BazaarItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35B3178 Offset: 0x35AF178 VA: 0x35B3178
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x35B3180 Offset: 0x35AF180 VA: 0x35B3180
	public void set_Title(string value) { }

	[CompilerGenerated]
	// RVA: 0x35B3188 Offset: 0x35AF188 VA: 0x35B3188
	public DateTime get_Time() { }

	[CompilerGenerated]
	// RVA: 0x35B3190 Offset: 0x35AF190 VA: 0x35B3190
	public void set_Time(DateTime value) { }

	// RVA: 0x35B3198 Offset: 0x35AF198 VA: 0x35B3198 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B3544 Offset: 0x35AF544 VA: 0x35B3544 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
