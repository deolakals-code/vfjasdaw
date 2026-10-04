// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Npc
public class NpcAvatarRejoinResponse : PacketBase // TypeDefIndex: 11909
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<byte, object> <NewProperties>k__BackingField; // 0x38
	[CompilerGenerated]
	private NpcData <NpcData>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <FirstSkill>k__BackingField; // 0x48
	[CompilerGenerated]
	private short <RespawnTime>k__BackingField; // 0x4A

	// Properties
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public GameStatusData GameStatus { get; set; }
	public Dictionary<byte, object> NewProperties { get; set; }
	public NpcData NpcData { get; set; }
	public byte FirstSkill { get; set; }
	public short RespawnTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3762FC8 Offset: 0x375EFC8 VA: 0x3762FC8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3762FD0 Offset: 0x375EFD0 VA: 0x3762FD0
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3762FD8 Offset: 0x375EFD8 VA: 0x3762FD8
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3762FE0 Offset: 0x375EFE0 VA: 0x3762FE0
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3762FE8 Offset: 0x375EFE8 VA: 0x3762FE8
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3762FF0 Offset: 0x375EFF0 VA: 0x3762FF0
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3762FF8 Offset: 0x375EFF8 VA: 0x3762FF8
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3763000 Offset: 0x375F000 VA: 0x3763000
	public Dictionary<byte, object> get_NewProperties() { }

	[CompilerGenerated]
	// RVA: 0x3763008 Offset: 0x375F008 VA: 0x3763008
	public void set_NewProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x3763010 Offset: 0x375F010 VA: 0x3763010
	public NpcData get_NpcData() { }

	[CompilerGenerated]
	// RVA: 0x3763018 Offset: 0x375F018 VA: 0x3763018
	public void set_NpcData(NpcData value) { }

	[CompilerGenerated]
	// RVA: 0x3763020 Offset: 0x375F020 VA: 0x3763020
	public byte get_FirstSkill() { }

	[CompilerGenerated]
	// RVA: 0x3763028 Offset: 0x375F028 VA: 0x3763028
	public void set_FirstSkill(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3763030 Offset: 0x375F030 VA: 0x3763030
	public short get_RespawnTime() { }

	[CompilerGenerated]
	// RVA: 0x3763038 Offset: 0x375F038 VA: 0x3763038
	public void set_RespawnTime(short value) { }

	// RVA: 0x3763040 Offset: 0x375F040 VA: 0x3763040 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3763048 Offset: 0x375F048 VA: 0x3763048 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37634BC Offset: 0x375F4BC VA: 0x37634BC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
