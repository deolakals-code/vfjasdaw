// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Mails
public class MailDeliveryData : BinaryBase // TypeDefIndex: 13012
{
	// Fields
	[CompilerGenerated]
	private long <UniqueId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MailType>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <FromName>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x38
	[CompilerGenerated]
	private DateTime <Date>k__BackingField; // 0x40
	[CompilerGenerated]
	private DateTime <TimeLimit>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte <DeliveryType>k__BackingField; // 0x50
	[CompilerGenerated]
	private int <DeliveryValue>k__BackingField; // 0x54
	[CompilerGenerated]
	private int <DeliveryNum>k__BackingField; // 0x58
	[CompilerGenerated]
	private short <ItemType>k__BackingField; // 0x5C
	[CompilerGenerated]
	private byte <ItemAbility>k__BackingField; // 0x5E

	// Properties
	public long UniqueId { get; set; }
	public byte MailType { get; set; }
	public string FromName { get; set; }
	public string Title { get; set; }
	public DateTime Date { get; set; }
	public DateTime TimeLimit { get; set; }
	public byte DeliveryType { get; set; }
	public int DeliveryValue { get; set; }
	public int DeliveryNum { get; set; }
	public short ItemType { get; set; }
	public byte ItemAbility { get; set; }

	// Methods

	// RVA: 0x368D788 Offset: 0x3689788 VA: 0x368D788
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x368D790 Offset: 0x3689790 VA: 0x368D790
	public long get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x368D798 Offset: 0x3689798 VA: 0x368D798
	public void set_UniqueId(long value) { }

	[CompilerGenerated]
	// RVA: 0x368D7A0 Offset: 0x36897A0 VA: 0x368D7A0
	public byte get_MailType() { }

	[CompilerGenerated]
	// RVA: 0x368D7A8 Offset: 0x36897A8 VA: 0x368D7A8
	public void set_MailType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368D7B0 Offset: 0x36897B0 VA: 0x368D7B0
	public string get_FromName() { }

	[CompilerGenerated]
	// RVA: 0x368D7B8 Offset: 0x36897B8 VA: 0x368D7B8
	public void set_FromName(string value) { }

	[CompilerGenerated]
	// RVA: 0x368D7C0 Offset: 0x36897C0 VA: 0x368D7C0
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x368D7C8 Offset: 0x36897C8 VA: 0x368D7C8
	public void set_Title(string value) { }

	[CompilerGenerated]
	// RVA: 0x368D7D0 Offset: 0x36897D0 VA: 0x368D7D0
	public DateTime get_Date() { }

	[CompilerGenerated]
	// RVA: 0x368D7D8 Offset: 0x36897D8 VA: 0x368D7D8
	public void set_Date(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x368D7E0 Offset: 0x36897E0 VA: 0x368D7E0
	public DateTime get_TimeLimit() { }

	[CompilerGenerated]
	// RVA: 0x368D7E8 Offset: 0x36897E8 VA: 0x368D7E8
	public void set_TimeLimit(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x368D7F0 Offset: 0x36897F0 VA: 0x368D7F0
	public byte get_DeliveryType() { }

	[CompilerGenerated]
	// RVA: 0x368D7F8 Offset: 0x36897F8 VA: 0x368D7F8
	public void set_DeliveryType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368D800 Offset: 0x3689800 VA: 0x368D800
	public int get_DeliveryValue() { }

	[CompilerGenerated]
	// RVA: 0x368D808 Offset: 0x3689808 VA: 0x368D808
	public void set_DeliveryValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x368D810 Offset: 0x3689810 VA: 0x368D810
	public int get_DeliveryNum() { }

	[CompilerGenerated]
	// RVA: 0x368D818 Offset: 0x3689818 VA: 0x368D818
	public void set_DeliveryNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x368D820 Offset: 0x3689820 VA: 0x368D820
	public short get_ItemType() { }

	[CompilerGenerated]
	// RVA: 0x368D828 Offset: 0x3689828 VA: 0x368D828
	public void set_ItemType(short value) { }

	[CompilerGenerated]
	// RVA: 0x368D830 Offset: 0x3689830 VA: 0x368D830
	public byte get_ItemAbility() { }

	[CompilerGenerated]
	// RVA: 0x368D838 Offset: 0x3689838 VA: 0x368D838
	public void set_ItemAbility(byte value) { }

	// RVA: 0x368D840 Offset: 0x3689840 VA: 0x368D840 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x368DA18 Offset: 0x3689A18 VA: 0x368DA18 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
