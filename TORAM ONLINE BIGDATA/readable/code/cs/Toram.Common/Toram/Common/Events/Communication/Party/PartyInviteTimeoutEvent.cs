// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyInviteTimeoutEvent : PacketBase // TypeDefIndex: 12872
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <SenderName>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 94)]
	public int PartyId { get; set; }
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 98)]
	public string TargetName { get; set; }
	[PacketParameter(Code = 99)]
	public int SenderId { get; set; }
	[PacketParameter(Code = 100)]
	public string SenderName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366CE04 Offset: 0x3668E04 VA: 0x366CE04
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366CE0C Offset: 0x3668E0C VA: 0x366CE0C
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366CE14 Offset: 0x3668E14 VA: 0x366CE14
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366CE1C Offset: 0x3668E1C VA: 0x366CE1C
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x366CE24 Offset: 0x3668E24 VA: 0x366CE24
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366CE2C Offset: 0x3668E2C VA: 0x366CE2C
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x366CE34 Offset: 0x3668E34 VA: 0x366CE34
	public void set_TargetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x366CE3C Offset: 0x3668E3C VA: 0x366CE3C
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x366CE44 Offset: 0x3668E44 VA: 0x366CE44
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366CE4C Offset: 0x3668E4C VA: 0x366CE4C
	public string get_SenderName() { }

	[CompilerGenerated]
	// RVA: 0x366CE54 Offset: 0x3668E54 VA: 0x366CE54
	public void set_SenderName(string value) { }

	// RVA: 0x366CE5C Offset: 0x3668E5C VA: 0x366CE5C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366CE64 Offset: 0x3668E64 VA: 0x366CE64 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366D0B0 Offset: 0x36690B0 VA: 0x366D0B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
