// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class SkillReusePermissioneEvent : PacketBase // TypeDefIndex: 12709
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 90)]
	public short SkillId { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3646AD0 Offset: 0x3642AD0 VA: 0x3646AD0
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3646AD8 Offset: 0x3642AD8 VA: 0x3646AD8
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3646AE0 Offset: 0x3642AE0 VA: 0x3646AE0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3646AE8 Offset: 0x3642AE8 VA: 0x3646AE8
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3646AF0 Offset: 0x3642AF0 VA: 0x3646AF0
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x3646AF8 Offset: 0x3642AF8 VA: 0x3646AF8
	public void set_SkillId(short value) { }

	// RVA: 0x3646B00 Offset: 0x3642B00 VA: 0x3646B00
	public void .ctor() { }

	// RVA: 0x3646B08 Offset: 0x3642B08 VA: 0x3646B08
	public void .ctor(Dictionary<byte, object> parameter) { }

	// RVA: 0x3646B10 Offset: 0x3642B10 VA: 0x3646B10 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3646B18 Offset: 0x3642B18 VA: 0x3646B18 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3646C64 Offset: 0x3642C64 VA: 0x3646C64 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
