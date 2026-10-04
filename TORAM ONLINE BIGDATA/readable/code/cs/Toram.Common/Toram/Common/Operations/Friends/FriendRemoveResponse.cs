// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Friends
public class FriendRemoveResponse : PacketBase // TypeDefIndex: 11640
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 98)]
	public string TargetName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3729CDC Offset: 0x3725CDC VA: 0x3729CDC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3729CE4 Offset: 0x3725CE4 VA: 0x3729CE4
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x3729CEC Offset: 0x3725CEC VA: 0x3729CEC
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3729CF4 Offset: 0x3725CF4 VA: 0x3729CF4
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x3729CFC Offset: 0x3725CFC VA: 0x3729CFC
	public void set_TargetName(string value) { }

	// RVA: 0x3729D04 Offset: 0x3725D04 VA: 0x3729D04 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3729D0C Offset: 0x3725D0C VA: 0x3729D0C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3729E84 Offset: 0x3725E84 VA: 0x3729E84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
