// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class MailHistoryData : BinaryBase // TypeDefIndex: 12992
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <SendType>k__BackingField; // 0x1A
	[CompilerGenerated]
	private long <UniqueId>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <Date>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Body>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x40

	// Properties
	public byte No { get; set; }
	public byte SendType { get; set; }
	public long UniqueId { get; set; }
	public DateTime Date { get; set; }
	public string Title { get; set; }
	public string Body { get; set; }
	public string Name { get; set; }

	// Methods

	// RVA: 0x36899F8 Offset: 0x36859F8 VA: 0x36899F8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3689A00 Offset: 0x3685A00 VA: 0x3689A00
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x3689A08 Offset: 0x3685A08 VA: 0x3689A08
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3689A10 Offset: 0x3685A10 VA: 0x3689A10
	public byte get_SendType() { }

	[CompilerGenerated]
	// RVA: 0x3689A18 Offset: 0x3685A18 VA: 0x3689A18
	public void set_SendType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3689A20 Offset: 0x3685A20 VA: 0x3689A20
	public long get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3689A28 Offset: 0x3685A28 VA: 0x3689A28
	public void set_UniqueId(long value) { }

	[CompilerGenerated]
	// RVA: 0x3689A30 Offset: 0x3685A30 VA: 0x3689A30
	public DateTime get_Date() { }

	[CompilerGenerated]
	// RVA: 0x3689A38 Offset: 0x3685A38 VA: 0x3689A38
	public void set_Date(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3689A40 Offset: 0x3685A40 VA: 0x3689A40
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x3689A48 Offset: 0x3685A48 VA: 0x3689A48
	public void set_Title(string value) { }

	[CompilerGenerated]
	// RVA: 0x3689A50 Offset: 0x3685A50 VA: 0x3689A50
	public string get_Body() { }

	[CompilerGenerated]
	// RVA: 0x3689A58 Offset: 0x3685A58 VA: 0x3689A58
	public void set_Body(string value) { }

	[CompilerGenerated]
	// RVA: 0x3689A60 Offset: 0x3685A60 VA: 0x3689A60
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3689A68 Offset: 0x3685A68 VA: 0x3689A68
	public void set_Name(string value) { }

	// RVA: 0x3689A70 Offset: 0x3685A70 VA: 0x3689A70 Slot: 3
	public override string ToString() { }

	// RVA: 0x3689B64 Offset: 0x3685B64 VA: 0x3689B64 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3689CF8 Offset: 0x3685CF8 VA: 0x3689CF8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
