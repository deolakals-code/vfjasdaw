// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildTransferMasterEvent : PacketBase // TypeDefIndex: 12926
{
	// Fields
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <SenderName>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <SenderPost>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x34
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <TargetPost>k__BackingField; // 0x40

	// Properties
	public int SenderId { get; set; }
	public string SenderName { get; set; }
	public byte SenderPost { get; set; }
	public int TargetId { get; set; }
	public string TargetName { get; set; }
	public byte TargetPost { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3679F50 Offset: 0x3675F50 VA: 0x3679F50
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3679F58 Offset: 0x3675F58 VA: 0x3679F58
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x3679F60 Offset: 0x3675F60 VA: 0x3679F60
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3679F68 Offset: 0x3675F68 VA: 0x3679F68
	public string get_SenderName() { }

	[CompilerGenerated]
	// RVA: 0x3679F70 Offset: 0x3675F70 VA: 0x3679F70
	public void set_SenderName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3679F78 Offset: 0x3675F78 VA: 0x3679F78
	public byte get_SenderPost() { }

	[CompilerGenerated]
	// RVA: 0x3679F80 Offset: 0x3675F80 VA: 0x3679F80
	public void set_SenderPost(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3679F88 Offset: 0x3675F88 VA: 0x3679F88
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3679F90 Offset: 0x3675F90 VA: 0x3679F90
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3679F98 Offset: 0x3675F98 VA: 0x3679F98
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x3679FA0 Offset: 0x3675FA0 VA: 0x3679FA0
	public void set_TargetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3679FA8 Offset: 0x3675FA8 VA: 0x3679FA8
	public byte get_TargetPost() { }

	[CompilerGenerated]
	// RVA: 0x3679FB0 Offset: 0x3675FB0 VA: 0x3679FB0
	public void set_TargetPost(byte value) { }

	// RVA: 0x3679FB8 Offset: 0x3675FB8 VA: 0x3679FB8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3679FC0 Offset: 0x3675FC0 VA: 0x3679FC0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x367A26C Offset: 0x367626C VA: 0x367A26C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
