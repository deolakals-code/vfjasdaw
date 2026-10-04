// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class CustomerRedoConnectEvent : PacketBase // TypeDefIndex: 12604
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x24

	// Properties
	public int AvatarUuid { get; set; }
	public short ReturnCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362ED4C Offset: 0x362AD4C VA: 0x362ED4C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362ED54 Offset: 0x362AD54 VA: 0x362ED54
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x362ED5C Offset: 0x362AD5C VA: 0x362ED5C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x362ED64 Offset: 0x362AD64 VA: 0x362ED64
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x362ED6C Offset: 0x362AD6C VA: 0x362ED6C
	public void set_ReturnCode(short value) { }

	// RVA: 0x362ED74 Offset: 0x362AD74 VA: 0x362ED74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362ED7C Offset: 0x362AD7C VA: 0x362ED7C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x362EEF4 Offset: 0x362AEF4 VA: 0x362EEF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
