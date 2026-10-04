// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildInvitation : PacketBase // TypeDefIndex: 12393
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 83, IsOptional = True)]
	public string Message { get; set; }
	[PacketParameter(Code = 211, IsOptional = True)]
	public string TargetName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3600E04 Offset: 0x35FCE04 VA: 0x3600E04
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3600E0C Offset: 0x35FCE0C VA: 0x3600E0C
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3600E14 Offset: 0x35FCE14 VA: 0x3600E14
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3600E1C Offset: 0x35FCE1C VA: 0x3600E1C
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3600E24 Offset: 0x35FCE24 VA: 0x3600E24
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x3600E2C Offset: 0x35FCE2C VA: 0x3600E2C
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x3600E34 Offset: 0x35FCE34 VA: 0x3600E34
	public void set_TargetName(string value) { }

	// RVA: 0x3600E3C Offset: 0x35FCE3C VA: 0x3600E3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3600E44 Offset: 0x35FCE44 VA: 0x3600E44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3601054 Offset: 0x35FD054 VA: 0x3601054 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
