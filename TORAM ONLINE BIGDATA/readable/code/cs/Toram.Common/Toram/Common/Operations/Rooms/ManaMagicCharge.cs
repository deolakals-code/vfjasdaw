// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class ManaMagicCharge : PacketBase // TypeDefIndex: 11742
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ManaCharge>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 205)]
	public byte ManaCharge { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37401B4 Offset: 0x373C1B4 VA: 0x37401B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37401BC Offset: 0x373C1BC VA: 0x37401BC
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x37401C4 Offset: 0x373C1C4 VA: 0x37401C4
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37401CC Offset: 0x373C1CC VA: 0x37401CC
	public byte get_ManaCharge() { }

	[CompilerGenerated]
	// RVA: 0x37401D4 Offset: 0x373C1D4 VA: 0x37401D4
	public void set_ManaCharge(byte value) { }

	// RVA: 0x37401DC Offset: 0x373C1DC VA: 0x37401DC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37401E4 Offset: 0x373C1E4 VA: 0x37401E4 Slot: 3
	public override string ToString() { }

	// RVA: 0x3740268 Offset: 0x373C268 VA: 0x3740268 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37403E0 Offset: 0x373C3E0 VA: 0x37403E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
