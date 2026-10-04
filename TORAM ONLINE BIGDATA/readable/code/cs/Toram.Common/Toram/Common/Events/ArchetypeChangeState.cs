// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ArchetypeChangeState : PacketBase // TypeDefIndex: 12614
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <PropertiesRevision>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <State>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x34
	[CompilerGenerated]
	private short <RespawnTime>k__BackingField; // 0x36
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsGemCartTrriger>k__BackingField; // 0x42

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketParameter(Code = 56)]
	public int PropertiesRevision { get; set; }
	[PacketParameter(Code = 44, IsOptional = True)]
	public int State { get; set; }
	[PacketParameter(Code = 25, IsOptional = True)]
	public int Hp { get; set; }
	[PacketParameter(Code = 26, IsOptional = True)]
	public short Mp { get; set; }
	[PacketParameter(Code = 119, IsOptional = True)]
	public short RespawnTime { get; set; }
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 65, IsOptional = True)]
	public short Rotation { get; set; }
	[PacketParameter(Code = 43, IsOptional = True)]
	public bool IsGemCartTrriger { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3630BF0 Offset: 0x362CBF0 VA: 0x3630BF0
	public void .ctor() { }

	// RVA: 0x3630BF8 Offset: 0x362CBF8 VA: 0x3630BF8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3630C00 Offset: 0x362CC00 VA: 0x3630C00
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3630C08 Offset: 0x362CC08 VA: 0x3630C08
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3630C10 Offset: 0x362CC10 VA: 0x3630C10
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3630C18 Offset: 0x362CC18 VA: 0x3630C18
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3630C20 Offset: 0x362CC20 VA: 0x3630C20
	public int get_PropertiesRevision() { }

	[CompilerGenerated]
	// RVA: 0x3630C28 Offset: 0x362CC28 VA: 0x3630C28
	public void set_PropertiesRevision(int value) { }

	[CompilerGenerated]
	// RVA: 0x3630C30 Offset: 0x362CC30 VA: 0x3630C30
	public int get_State() { }

	[CompilerGenerated]
	// RVA: 0x3630C38 Offset: 0x362CC38 VA: 0x3630C38
	public void set_State(int value) { }

	[CompilerGenerated]
	// RVA: 0x3630C40 Offset: 0x362CC40 VA: 0x3630C40
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3630C48 Offset: 0x362CC48 VA: 0x3630C48
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3630C50 Offset: 0x362CC50 VA: 0x3630C50
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x3630C58 Offset: 0x362CC58 VA: 0x3630C58
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3630C60 Offset: 0x362CC60 VA: 0x3630C60
	public short get_RespawnTime() { }

	[CompilerGenerated]
	// RVA: 0x3630C68 Offset: 0x362CC68 VA: 0x3630C68
	public void set_RespawnTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x3630C70 Offset: 0x362CC70 VA: 0x3630C70
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3630C78 Offset: 0x362CC78 VA: 0x3630C78
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3630C80 Offset: 0x362CC80 VA: 0x3630C80
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3630C88 Offset: 0x362CC88 VA: 0x3630C88
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3630C90 Offset: 0x362CC90 VA: 0x3630C90
	public bool get_IsGemCartTrriger() { }

	[CompilerGenerated]
	// RVA: 0x3630C98 Offset: 0x362CC98 VA: 0x3630C98
	public void set_IsGemCartTrriger(bool value) { }

	// RVA: 0x3630CA4 Offset: 0x362CCA4 VA: 0x3630CA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3630CAC Offset: 0x362CCAC VA: 0x3630CAC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3631180 Offset: 0x362D180 VA: 0x3631180 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
