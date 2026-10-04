// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyInviteCancelEvent : PacketBase // TypeDefIndex: 12871
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 98)]
	public string TargetName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366CAF0 Offset: 0x3668AF0 VA: 0x366CAF0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366CAF8 Offset: 0x3668AF8 VA: 0x366CAF8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x366CB00 Offset: 0x3668B00 VA: 0x366CB00
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x366CB08 Offset: 0x3668B08 VA: 0x366CB08
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x366CB10 Offset: 0x3668B10 VA: 0x366CB10
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366CB18 Offset: 0x3668B18 VA: 0x366CB18
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x366CB20 Offset: 0x3668B20 VA: 0x366CB20
	public void set_TargetName(string value) { }

	// RVA: 0x366CB28 Offset: 0x3668B28 VA: 0x366CB28 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366CB30 Offset: 0x3668B30 VA: 0x366CB30 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366CCF4 Offset: 0x3668CF4 VA: 0x366CCF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
