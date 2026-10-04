// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class RespawnChangeField : PacketBase // TypeDefIndex: 12084
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }

	// Methods

	// RVA: 0x3784084 Offset: 0x3780084 VA: 0x3784084
	public void .ctor() { }

	// RVA: 0x378408C Offset: 0x378008C VA: 0x378408C Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x3784094 Offset: 0x3780094 VA: 0x3784094
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x378409C Offset: 0x378009C VA: 0x378409C
	public void set_AvatarUuid(int value) { }

	// RVA: 0x37840A4 Offset: 0x37800A4 VA: 0x37840A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37841C4 Offset: 0x37801C4 VA: 0x37841C4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
