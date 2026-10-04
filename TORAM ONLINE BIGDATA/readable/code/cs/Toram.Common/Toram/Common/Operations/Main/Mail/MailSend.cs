// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Mail
public class MailSend : OperationRequestBase // TypeDefIndex: 12027
{
	// Fields
	[CompilerGenerated]
	private int <ToAvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <MailType>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <TitleText>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <BodyText>k__BackingField; // 0x30
	[CompilerGenerated]
	private ItemSelectData <Item>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <SendType>k__BackingField; // 0x40

	// Properties
	public int ToAvatarUuid { get; set; }
	public byte MailType { get; set; }
	public string TitleText { get; set; }
	public string BodyText { get; set; }
	public ItemSelectData Item { get; set; }
	public byte SendType { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37794E8 Offset: 0x37754E8 VA: 0x37794E8
	public int get_ToAvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37794F0 Offset: 0x37754F0 VA: 0x37794F0
	public void set_ToAvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37794F8 Offset: 0x37754F8 VA: 0x37794F8
	public byte get_MailType() { }

	[CompilerGenerated]
	// RVA: 0x3779500 Offset: 0x3775500 VA: 0x3779500
	public void set_MailType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3779508 Offset: 0x3775508 VA: 0x3779508
	public string get_TitleText() { }

	[CompilerGenerated]
	// RVA: 0x3779510 Offset: 0x3775510 VA: 0x3779510
	public void set_TitleText(string value) { }

	[CompilerGenerated]
	// RVA: 0x3779518 Offset: 0x3775518 VA: 0x3779518
	public string get_BodyText() { }

	[CompilerGenerated]
	// RVA: 0x3779520 Offset: 0x3775520 VA: 0x3779520
	public void set_BodyText(string value) { }

	[CompilerGenerated]
	// RVA: 0x3779528 Offset: 0x3775528 VA: 0x3779528
	public ItemSelectData get_Item() { }

	[CompilerGenerated]
	// RVA: 0x3779530 Offset: 0x3775530 VA: 0x3779530
	public void set_Item(ItemSelectData value) { }

	[CompilerGenerated]
	// RVA: 0x3779538 Offset: 0x3775538 VA: 0x3779538
	public byte get_SendType() { }

	[CompilerGenerated]
	// RVA: 0x3779540 Offset: 0x3775540 VA: 0x3779540
	public void set_SendType(byte value) { }

	// RVA: 0x3779548 Offset: 0x3775548 VA: 0x3779548 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3779550 Offset: 0x3775550 VA: 0x3779550 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3779558 Offset: 0x3775558 VA: 0x3779558
	public void .ctor() { }

	// RVA: 0x3779560 Offset: 0x3775560 VA: 0x3779560 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37796BC Offset: 0x37756BC VA: 0x37796BC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
