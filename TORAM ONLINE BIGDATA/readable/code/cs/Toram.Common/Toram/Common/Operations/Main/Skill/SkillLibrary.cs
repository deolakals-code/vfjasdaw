// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class SkillLibrary : PacketBase // TypeDefIndex: 12115
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <SkillTreeType>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <SkillTreeLevel>k__BackingField; // 0x31
	[CompilerGenerated]
	private int <Cost>k__BackingField; // 0x34

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 136, IsOptional = True)]
	public int ShopId { get; set; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 103)]
	public byte SkillTreeType { get; set; }
	[PacketParameter(Code = 104)]
	public byte SkillTreeLevel { get; set; }
	[PacketParameter(Code = 149)]
	public int Cost { get; set; }

	// Methods

	// RVA: 0x378A3A8 Offset: 0x37863A8 VA: 0x378A3A8
	public void .ctor() { }

	// RVA: 0x378A3B0 Offset: 0x37863B0 VA: 0x378A3B0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x378A3B8 Offset: 0x37863B8 VA: 0x378A3B8
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x378A3C0 Offset: 0x37863C0 VA: 0x378A3C0
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378A3C8 Offset: 0x37863C8 VA: 0x378A3C8
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x378A3D0 Offset: 0x37863D0 VA: 0x378A3D0
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x378A3D8 Offset: 0x37863D8 VA: 0x378A3D8
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x378A3E0 Offset: 0x37863E0 VA: 0x378A3E0
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x378A3E8 Offset: 0x37863E8 VA: 0x378A3E8
	public byte get_SkillTreeType() { }

	[CompilerGenerated]
	// RVA: 0x378A3F0 Offset: 0x37863F0 VA: 0x378A3F0
	public void set_SkillTreeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378A3F8 Offset: 0x37863F8 VA: 0x378A3F8
	public byte get_SkillTreeLevel() { }

	[CompilerGenerated]
	// RVA: 0x378A400 Offset: 0x3786400 VA: 0x378A400
	public void set_SkillTreeLevel(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378A408 Offset: 0x3786408 VA: 0x378A408
	public int get_Cost() { }

	[CompilerGenerated]
	// RVA: 0x378A410 Offset: 0x3786410 VA: 0x378A410
	public void set_Cost(int value) { }

	// RVA: 0x378A418 Offset: 0x3786418 VA: 0x378A418 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x378A72C Offset: 0x378672C VA: 0x378A72C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
