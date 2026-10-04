// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Warp
public class ChangeFieldSavePoint : PacketBase // TypeDefIndex: 11931
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3768698 Offset: 0x3764698 VA: 0x3768698
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37686A0 Offset: 0x37646A0 VA: 0x37686A0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37686A8 Offset: 0x37646A8 VA: 0x37686A8
	public void set_AvatarUuid(int value) { }

	// RVA: 0x37686B0 Offset: 0x37646B0 VA: 0x37686B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37686B8 Offset: 0x37646B8 VA: 0x37686B8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37687D8 Offset: 0x37647D8 VA: 0x37687D8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
