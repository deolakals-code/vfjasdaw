// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendRequest : PacketBase // TypeDefIndex: 11641
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

	// RVA: 0x3729F6C Offset: 0x3725F6C VA: 0x3729F6C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3729F74 Offset: 0x3725F74 VA: 0x3729F74
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3729F7C Offset: 0x3725F7C VA: 0x3729F7C
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3729F84 Offset: 0x3725F84 VA: 0x3729F84
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x3729F8C Offset: 0x3725F8C VA: 0x3729F8C
	public void set_Message(string value) { }

	[CompilerGenerated]
	// RVA: 0x3729F94 Offset: 0x3725F94 VA: 0x3729F94
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x3729F9C Offset: 0x3725F9C VA: 0x3729F9C
	public void set_TargetName(string value) { }

	// RVA: 0x3729FA4 Offset: 0x3725FA4 VA: 0x3729FA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3729FAC Offset: 0x3725FAC VA: 0x3729FAC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372A1BC Offset: 0x37261BC VA: 0x372A1BC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
