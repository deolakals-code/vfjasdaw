// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Npc
public class NpcAvatarJoinResponse : PacketBase // TypeDefIndex: 11907
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

	// Properties
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public GameStatusData GameStatus { get; set; }
	public Dictionary<byte, object> NewProperties { get; set; }
	public NpcData NpcData { get; set; }
	public byte FirstSkill { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376259C Offset: 0x375E59C VA: 0x376259C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37625A4 Offset: 0x375E5A4 VA: 0x37625A4
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x37625AC Offset: 0x375E5AC VA: 0x37625AC
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x37625B4 Offset: 0x375E5B4 VA: 0x37625B4
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x37625BC Offset: 0x375E5BC VA: 0x37625BC
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x37625C4 Offset: 0x375E5C4 VA: 0x37625C4
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x37625CC Offset: 0x375E5CC VA: 0x37625CC
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x37625D4 Offset: 0x375E5D4 VA: 0x37625D4
	public Dictionary<byte, object> get_NewProperties() { }

	[CompilerGenerated]
	// RVA: 0x37625DC Offset: 0x375E5DC VA: 0x37625DC
	public void set_NewProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x37625E4 Offset: 0x375E5E4 VA: 0x37625E4
	public NpcData get_NpcData() { }

	[CompilerGenerated]
	// RVA: 0x37625EC Offset: 0x375E5EC VA: 0x37625EC
	public void set_NpcData(NpcData value) { }

	[CompilerGenerated]
	// RVA: 0x37625F4 Offset: 0x375E5F4 VA: 0x37625F4
	public byte get_FirstSkill() { }

	[CompilerGenerated]
	// RVA: 0x37625FC Offset: 0x375E5FC VA: 0x37625FC
	public void set_FirstSkill(byte value) { }

	// RVA: 0x3762604 Offset: 0x375E604 VA: 0x3762604 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376260C Offset: 0x375E60C VA: 0x376260C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3762A24 Offset: 0x375EA24 VA: 0x3762A24 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
