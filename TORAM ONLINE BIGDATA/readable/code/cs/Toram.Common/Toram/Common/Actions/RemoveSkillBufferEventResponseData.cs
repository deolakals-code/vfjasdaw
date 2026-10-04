// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class RemoveSkillBufferEventResponseData : PacketBase // TypeDefIndex: 13133
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <TargetArchetypeType>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <TargetArchetypeId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short[] <SkillIds>k__BackingField; // 0x30
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x38

	// Properties
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public byte TargetArchetypeType { get; set; }
	public int TargetArchetypeId { get; set; }
	public short[] SkillIds { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36AF244 Offset: 0x36AB244 VA: 0x36AF244
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36AF24C Offset: 0x36AB24C VA: 0x36AF24C
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AF254 Offset: 0x36AB254 VA: 0x36AF254
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36AF25C Offset: 0x36AB25C VA: 0x36AF25C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36AF264 Offset: 0x36AB264 VA: 0x36AF264
	public byte get_TargetArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x36AF26C Offset: 0x36AB26C VA: 0x36AF26C
	public void set_TargetArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36AF274 Offset: 0x36AB274 VA: 0x36AF274
	public int get_TargetArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x36AF27C Offset: 0x36AB27C VA: 0x36AF27C
	public void set_TargetArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36AF284 Offset: 0x36AB284 VA: 0x36AF284
	public short[] get_SkillIds() { }

	[CompilerGenerated]
	// RVA: 0x36AF28C Offset: 0x36AB28C VA: 0x36AF28C
	public void set_SkillIds(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36AF294 Offset: 0x36AB294 VA: 0x36AF294
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36AF29C Offset: 0x36AB29C VA: 0x36AF29C
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x36AF2A4 Offset: 0x36AB2A4 VA: 0x36AF2A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36AF2AC Offset: 0x36AB2AC VA: 0x36AF2AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36AF2B4 Offset: 0x36AB2B4 VA: 0x36AF2B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36AF614 Offset: 0x36AB614 VA: 0x36AF614 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
