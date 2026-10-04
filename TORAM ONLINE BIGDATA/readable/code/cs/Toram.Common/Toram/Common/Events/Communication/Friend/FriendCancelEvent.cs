// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Friend
public class FriendCancelEvent : PacketBase // TypeDefIndex: 12851
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 98)]
	public string TargetName { get; set; }
	[PacketParameter(Code = 81, IsOptional = True)]
	public short ReturnCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3668D58 Offset: 0x3664D58 VA: 0x3668D58
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3668D60 Offset: 0x3664D60 VA: 0x3668D60
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3668D68 Offset: 0x3664D68 VA: 0x3668D68
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3668D70 Offset: 0x3664D70 VA: 0x3668D70
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x3668D78 Offset: 0x3664D78 VA: 0x3668D78
	public void set_TargetName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3668D80 Offset: 0x3664D80 VA: 0x3668D80
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3668D88 Offset: 0x3664D88 VA: 0x3668D88
	public void set_ReturnCode(short value) { }

	// RVA: 0x3668D90 Offset: 0x3664D90 VA: 0x3668D90 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3668D98 Offset: 0x3664D98 VA: 0x3668D98 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3668F94 Offset: 0x3664F94 VA: 0x3668F94 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
