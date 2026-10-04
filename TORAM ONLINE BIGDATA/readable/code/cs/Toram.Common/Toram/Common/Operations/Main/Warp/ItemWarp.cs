// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Warp
public class ItemWarp : PacketBase // TypeDefIndex: 11936
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376A4B4 Offset: 0x37664B4 VA: 0x376A4B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376A4BC Offset: 0x37664BC VA: 0x376A4BC
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x376A4C4 Offset: 0x37664C4 VA: 0x376A4C4
	public void set_AvatarUuid(int value) { }

	// RVA: 0x376A4CC Offset: 0x37664CC VA: 0x376A4CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376A4D4 Offset: 0x37664D4 VA: 0x376A4D4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376A5F4 Offset: 0x37665F4 VA: 0x376A5F4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
