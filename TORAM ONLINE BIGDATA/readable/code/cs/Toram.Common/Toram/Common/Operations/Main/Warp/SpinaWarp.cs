// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Warp
public class SpinaWarp : PacketBase // TypeDefIndex: 11929
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 28)]
	public int Gold { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3767B30 Offset: 0x3763B30 VA: 0x3767B30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3767B38 Offset: 0x3763B38 VA: 0x3767B38
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3767B40 Offset: 0x3763B40 VA: 0x3767B40
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3767B48 Offset: 0x3763B48 VA: 0x3767B48
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3767B50 Offset: 0x3763B50 VA: 0x3767B50
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3767B58 Offset: 0x3763B58 VA: 0x3767B58
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3767B60 Offset: 0x3763B60 VA: 0x3767B60
	public void set_Gold(int value) { }

	// RVA: 0x3767B68 Offset: 0x3763B68 VA: 0x3767B68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3767B70 Offset: 0x3763B70 VA: 0x3767B70 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3767D20 Offset: 0x3763D20 VA: 0x3767D20 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
