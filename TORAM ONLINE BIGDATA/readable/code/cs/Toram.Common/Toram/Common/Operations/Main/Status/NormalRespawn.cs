// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class NormalRespawn : PacketBase // TypeDefIndex: 12082
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37838F0 Offset: 0x377F8F0 VA: 0x37838F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37838F8 Offset: 0x377F8F8 VA: 0x37838F8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3783900 Offset: 0x377F900 VA: 0x3783900
	public void set_AvatarUuid(int value) { }

	// RVA: 0x3783908 Offset: 0x377F908 VA: 0x3783908 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3783910 Offset: 0x377F910 VA: 0x3783910 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3783A30 Offset: 0x377FA30 VA: 0x3783A30 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
