// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class SystemRespawn : PacketBase // TypeDefIndex: 12089
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }

	// Methods

	// RVA: 0x3785284 Offset: 0x3781284 VA: 0x3785284
	public void .ctor() { }

	// RVA: 0x378528C Offset: 0x378128C VA: 0x378528C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3785294 Offset: 0x3781294 VA: 0x3785294
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x378529C Offset: 0x378129C VA: 0x378529C
	public void set_AvatarUuid(int value) { }

	// RVA: 0x37852A4 Offset: 0x37812A4 VA: 0x37852A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37853C4 Offset: 0x37813C4 VA: 0x37853C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
