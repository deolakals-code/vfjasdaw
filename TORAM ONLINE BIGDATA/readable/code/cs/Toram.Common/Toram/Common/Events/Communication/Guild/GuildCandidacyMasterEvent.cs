// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildCandidacyMasterEvent : PacketBase // TypeDefIndex: 12912
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

	// RVA: 0x36764E0 Offset: 0x36724E0 VA: 0x36764E0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36764E8 Offset: 0x36724E8 VA: 0x36764E8
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x36764F0 Offset: 0x36724F0 VA: 0x36764F0
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36764F8 Offset: 0x36724F8 VA: 0x36764F8
	public string get_SenderName() { }

	[CompilerGenerated]
	// RVA: 0x3676500 Offset: 0x3672500 VA: 0x3676500
	public void set_SenderName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3676508 Offset: 0x3672508 VA: 0x3676508
	public byte get_SenderPost() { }

	[CompilerGenerated]
	// RVA: 0x3676510 Offset: 0x3672510 VA: 0x3676510
	public void set_SenderPost(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3676518 Offset: 0x3672518 VA: 0x3676518
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3676520 Offset: 0x3672520 VA: 0x3676520
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3676528 Offset: 0x3672528 VA: 0x3676528
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x3676530 Offset: 0x3672530 VA: 0x3676530
	public void set_TargetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3676538 Offset: 0x3672538 VA: 0x3676538
	public byte get_TargetPost() { }

	[CompilerGenerated]
	// RVA: 0x3676540 Offset: 0x3672540 VA: 0x3676540
	public void set_TargetPost(byte value) { }

	// RVA: 0x3676548 Offset: 0x3672548 VA: 0x3676548 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3676550 Offset: 0x3672550 VA: 0x3676550 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36767FC Offset: 0x36727FC VA: 0x36767FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
