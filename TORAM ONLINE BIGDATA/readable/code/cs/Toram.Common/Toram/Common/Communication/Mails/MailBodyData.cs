// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Mails
public class MailBodyData : PacketBase // TypeDefIndex: 13010
{
	// Fields
	[CompilerGenerated]
	private long <UniqueId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FromAvatarUuid>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <FromUserName>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <Body>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <DeliveryType>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <DeliveryValue>k__BackingField; // 0x4C
	[CompilerGenerated]
	private int <DeliveryNum>k__BackingField; // 0x50
	[CompilerGenerated]
	private ItemDatav2 <Item>k__BackingField; // 0x58
	[CompilerGenerated]
	private DateTime <TimeLimit>k__BackingField; // 0x60
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x68

	// Properties
	public long UniqueId { get; set; }
	public int FromAvatarUuid { get; set; }
	public string FromUserName { get; set; }
	public string Title { get; set; }
	public string Body { get; set; }
	public byte DeliveryType { get; set; }
	public int DeliveryValue { get; set; }
	public int DeliveryNum { get; set; }
	public ItemDatav2 Item { get; set; }
	public DateTime TimeLimit { get; set; }
	public byte State { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x368CBA8 Offset: 0x3688BA8 VA: 0x368CBA8
	public void .ctor() { }

	// RVA: 0x368CBB0 Offset: 0x3688BB0 VA: 0x368CBB0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x368CBB8 Offset: 0x3688BB8 VA: 0x368CBB8
	public long get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x368CBC0 Offset: 0x3688BC0 VA: 0x368CBC0
	public void set_UniqueId(long value) { }

	[CompilerGenerated]
	// RVA: 0x368CBC8 Offset: 0x3688BC8 VA: 0x368CBC8
	public int get_FromAvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x368CBD0 Offset: 0x3688BD0 VA: 0x368CBD0
	public void set_FromAvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x368CBD8 Offset: 0x3688BD8 VA: 0x368CBD8
	public string get_FromUserName() { }

	[CompilerGenerated]
	// RVA: 0x368CBE0 Offset: 0x3688BE0 VA: 0x368CBE0
	public void set_FromUserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x368CBE8 Offset: 0x3688BE8 VA: 0x368CBE8
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x368CBF0 Offset: 0x3688BF0 VA: 0x368CBF0
	public void set_Title(string value) { }

	[CompilerGenerated]
	// RVA: 0x368CBF8 Offset: 0x3688BF8 VA: 0x368CBF8
	public string get_Body() { }

	[CompilerGenerated]
	// RVA: 0x368CC00 Offset: 0x3688C00 VA: 0x368CC00
	public void set_Body(string value) { }

	[CompilerGenerated]
	// RVA: 0x368CC08 Offset: 0x3688C08 VA: 0x368CC08
	public byte get_DeliveryType() { }

	[CompilerGenerated]
	// RVA: 0x368CC10 Offset: 0x3688C10 VA: 0x368CC10
	public void set_DeliveryType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x368CC18 Offset: 0x3688C18 VA: 0x368CC18
	public int get_DeliveryValue() { }

	[CompilerGenerated]
	// RVA: 0x368CC20 Offset: 0x3688C20 VA: 0x368CC20
	public void set_DeliveryValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x368CC28 Offset: 0x3688C28 VA: 0x368CC28
	public int get_DeliveryNum() { }

	[CompilerGenerated]
	// RVA: 0x368CC30 Offset: 0x3688C30 VA: 0x368CC30
	public void set_DeliveryNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x368CC38 Offset: 0x3688C38 VA: 0x368CC38
	public ItemDatav2 get_Item() { }

	[CompilerGenerated]
	// RVA: 0x368CC40 Offset: 0x3688C40 VA: 0x368CC40
	public void set_Item(ItemDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x368CC48 Offset: 0x3688C48 VA: 0x368CC48
	public DateTime get_TimeLimit() { }

	[CompilerGenerated]
	// RVA: 0x368CC50 Offset: 0x3688C50 VA: 0x368CC50
	public void set_TimeLimit(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x368CC58 Offset: 0x3688C58 VA: 0x368CC58
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x368CC60 Offset: 0x3688C60 VA: 0x368CC60
	public void set_State(byte value) { }

	// RVA: 0x368CC68 Offset: 0x3688C68 VA: 0x368CC68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x368CC70 Offset: 0x3688C70 VA: 0x368CC70 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x368D190 Offset: 0x3689190 VA: 0x368D190 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x368D430 Offset: 0x3689430 VA: 0x368D430 Slot: 3
	public override string ToString() { }
}
