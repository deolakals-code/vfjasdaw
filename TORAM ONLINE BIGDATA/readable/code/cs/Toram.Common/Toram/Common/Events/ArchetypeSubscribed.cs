// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ArchetypeSubscribed : PacketBase // TypeDefIndex: 12618
{
	// Fields
	[CompilerGenerated]
	private byte <InterestAreaId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x28
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x3C

	// Properties
	[PacketParameter(Code = 64)]
	public byte InterestAreaId { get; set; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 54)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 65, IsOptional = True)]
	public short Rotation { get; set; }
	[PacketParameter(Code = 56)]
	public int PropertiesRevision { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3632230 Offset: 0x362E230 VA: 0x3632230
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3632238 Offset: 0x362E238 VA: 0x3632238
	public byte get_InterestAreaId() { }

	[CompilerGenerated]
	// RVA: 0x3632240 Offset: 0x362E240 VA: 0x3632240
	public void set_InterestAreaId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3632248 Offset: 0x362E248 VA: 0x3632248
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3632250 Offset: 0x362E250 VA: 0x3632250
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3632258 Offset: 0x362E258 VA: 0x3632258
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3632260 Offset: 0x362E260 VA: 0x3632260
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3632268 Offset: 0x362E268 VA: 0x3632268
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3632270 Offset: 0x362E270 VA: 0x3632270
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3632278 Offset: 0x362E278 VA: 0x3632278
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3632280 Offset: 0x362E280 VA: 0x3632280
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3632288 Offset: 0x362E288 VA: 0x3632288
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x3632290 Offset: 0x362E290 VA: 0x3632290
	public void set_PropertiesRevision(int value) { }

	// RVA: 0x3632298 Offset: 0x362E298 VA: 0x3632298 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36322A0 Offset: 0x362E2A0 VA: 0x36322A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3632598 Offset: 0x362E598 VA: 0x3632598 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
