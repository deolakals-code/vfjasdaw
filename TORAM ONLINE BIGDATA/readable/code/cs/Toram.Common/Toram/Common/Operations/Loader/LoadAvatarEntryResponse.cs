// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Loader
public class LoadAvatarEntryResponse : PacketBase // TypeDefIndex: 11544
{
	// Fields
	[CompilerGenerated]
	private int <WaitingPerson>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x24

	// Properties
	public int WaitingPerson { get; set; }
	public short ReturnCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3717C98 Offset: 0x3713C98 VA: 0x3717C98
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3717CA0 Offset: 0x3713CA0 VA: 0x3717CA0
	public int get_WaitingPerson() { }

	[CompilerGenerated]
	// RVA: 0x3717CA8 Offset: 0x3713CA8 VA: 0x3717CA8
	public void set_WaitingPerson(int value) { }

	[CompilerGenerated]
	// RVA: 0x3717CB0 Offset: 0x3713CB0 VA: 0x3717CB0
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3717CB8 Offset: 0x3713CB8 VA: 0x3717CB8
	public void set_ReturnCode(short value) { }

	// RVA: 0x3717CC0 Offset: 0x3713CC0 VA: 0x3717CC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3717CC8 Offset: 0x3713CC8 VA: 0x3717CC8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3717E40 Offset: 0x3713E40 VA: 0x3717E40 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
