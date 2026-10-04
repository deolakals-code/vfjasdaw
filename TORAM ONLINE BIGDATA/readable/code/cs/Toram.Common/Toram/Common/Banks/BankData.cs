// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Banks
public class BankData : UnityHashBase // TypeDefIndex: 13099
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <UseCount>k__BackingField; // 0x1C
	[CompilerGenerated]
	private DateTime <InitialDate>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FreeFee>k__BackingField; // 0x28

	// Properties
	public byte Type { get; set; }
	public int UseCount { get; set; }
	public DateTime InitialDate { get; set; }
	public int FreeFee { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36A12B8 Offset: 0x369D2B8 VA: 0x36A12B8
	public void .ctor() { }

	// RVA: 0x36A12C0 Offset: 0x369D2C0 VA: 0x36A12C0
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36A12C8 Offset: 0x369D2C8 VA: 0x36A12C8
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x36A12D0 Offset: 0x369D2D0 VA: 0x36A12D0
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A12D8 Offset: 0x369D2D8 VA: 0x36A12D8
	public int get_UseCount() { }

	[CompilerGenerated]
	// RVA: 0x36A12E0 Offset: 0x369D2E0 VA: 0x36A12E0
	public void set_UseCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x36A12E8 Offset: 0x369D2E8 VA: 0x36A12E8
	public DateTime get_InitialDate() { }

	[CompilerGenerated]
	// RVA: 0x36A12F0 Offset: 0x369D2F0 VA: 0x36A12F0
	public void set_InitialDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x36A12F8 Offset: 0x369D2F8 VA: 0x36A12F8
	public int get_FreeFee() { }

	[CompilerGenerated]
	// RVA: 0x36A1300 Offset: 0x369D300 VA: 0x36A1300
	public void set_FreeFee(int value) { }

	// RVA: 0x36A1308 Offset: 0x369D308 VA: 0x36A1308 Slot: 3
	public override string ToString() { }

	// RVA: 0x36A150C Offset: 0x369D50C VA: 0x36A150C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36A1514 Offset: 0x369D514 VA: 0x36A1514 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36A17AC Offset: 0x369D7AC VA: 0x36A17AC Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
