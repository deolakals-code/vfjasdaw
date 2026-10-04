// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Boss
public class CheckBossSymbol : PacketBase // TypeDefIndex: 11782
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x25
	[CompilerGenerated]
	private byte <DetailFlag>k__BackingField; // 0x26

	// Properties
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 106)]
	public byte RoomId { get; set; }
	[PacketParameter(Code = 43)]
	public byte Flag { get; set; }
	[PacketParameter(Code = 157)]
	public byte DetailFlag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3749B48 Offset: 0x3745B48 VA: 0x3749B48
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3749B50 Offset: 0x3745B50 VA: 0x3749B50
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3749B58 Offset: 0x3745B58 VA: 0x3749B58
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3749B60 Offset: 0x3745B60 VA: 0x3749B60
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x3749B68 Offset: 0x3745B68 VA: 0x3749B68
	public void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3749B70 Offset: 0x3745B70 VA: 0x3749B70
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3749B78 Offset: 0x3745B78 VA: 0x3749B78
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3749B80 Offset: 0x3745B80 VA: 0x3749B80
	public byte get_DetailFlag() { }

	[CompilerGenerated]
	// RVA: 0x3749B88 Offset: 0x3745B88 VA: 0x3749B88
	public void set_DetailFlag(byte value) { }

	// RVA: 0x3749B90 Offset: 0x3745B90 VA: 0x3749B90
	public void SetForcibly(bool isForcibly) { }

	// RVA: 0x3749BA0 Offset: 0x3745BA0 VA: 0x3749BA0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3749BA8 Offset: 0x3745BA8 VA: 0x3749BA8 Slot: 3
	public override string ToString() { }

	// RVA: 0x3749C64 Offset: 0x3745C64 VA: 0x3749C64 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3749EB0 Offset: 0x3745EB0 VA: 0x3749EB0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
