// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Mails
public class MailHeaderData : BinaryBase // TypeDefIndex: 13013
{
	// Fields
	[CompilerGenerated]
	private long <UniqueId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MailType>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x29
	[CompilerGenerated]
	private DateTime <Date>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <FromName>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x40

	// Properties
	public long UniqueId { get; set; }
	public byte MailType { get; set; }
	public byte State { get; set; }
	public DateTime Date { get; set; }
	public string FromName { get; set; }
	public string Title { get; set; }

	// Methods

	// RVA: 0x368DAE4 Offset: 0x3689AE4 VA: 0x368DAE4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x368DAEC Offset: 0x3689AEC VA: 0x368DAEC
	public long get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x368DAF4 Offset: 0x3689AF4 VA: 0x368DAF4
	public void set_UniqueId(long value) { }

	[CompilerGenerated]
	// RVA: 0x368DAFC Offset: 0x3689AFC VA: 0x368DAFC
	public byte get_MailType() { }

	[CompilerGenerated]
	// RVA: 0x368DB04 Offset: 0x3689B04 VA: 0x368DB04
	public void set_MailType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368DB0C Offset: 0x3689B0C VA: 0x368DB0C
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x368DB14 Offset: 0x3689B14 VA: 0x368DB14
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368DB1C Offset: 0x3689B1C VA: 0x368DB1C
	public DateTime get_Date() { }

	[CompilerGenerated]
	// RVA: 0x368DB24 Offset: 0x3689B24 VA: 0x368DB24
	public void set_Date(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x368DB2C Offset: 0x3689B2C VA: 0x368DB2C
	public string get_FromName() { }

	[CompilerGenerated]
	// RVA: 0x368DB34 Offset: 0x3689B34 VA: 0x368DB34
	public void set_FromName(string value) { }

	[CompilerGenerated]
	// RVA: 0x368DB3C Offset: 0x3689B3C VA: 0x368DB3C
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x368DB44 Offset: 0x3689B44 VA: 0x368DB44
	public void set_Title(string value) { }

	// RVA: 0x368DB4C Offset: 0x3689B4C VA: 0x368DB4C Slot: 3
	public override string ToString() { }

	// RVA: 0x368DD9C Offset: 0x3689D9C VA: 0x368DD9C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368DF10 Offset: 0x3689F10 VA: 0x368DF10 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
