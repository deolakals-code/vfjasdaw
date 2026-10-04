// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room
public class RoomNpcJoinEvent : EventSubBase // TypeDefIndex: 12743
{
	// Fields
	[CompilerGenerated]
	private int <AdminTeamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x38
	[CompilerGenerated]
	private Dictionary<byte, object> <NewProperties>k__BackingField; // 0x40
	[CompilerGenerated]
	private NpcData <NpcData>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte <FirstSkill>k__BackingField; // 0x50

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public int AdminTeamId { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public GameStatusData GameStatus { get; set; }
	public Dictionary<byte, object> NewProperties { get; set; }
	public NpcData NpcData { get; set; }
	public byte FirstSkill { get; set; }

	// Methods

	// RVA: 0x364EA6C Offset: 0x364AA6C VA: 0x364EA6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x364EA74 Offset: 0x364AA74 VA: 0x364EA74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364EA7C Offset: 0x364AA7C VA: 0x364EA7C Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x364EA84 Offset: 0x364AA84 VA: 0x364EA84
	public int get_AdminTeamId() { }

	[CompilerGenerated]
	// RVA: 0x364EA8C Offset: 0x364AA8C VA: 0x364EA8C
	public void set_AdminTeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x364EA94 Offset: 0x364AA94 VA: 0x364EA94
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x364EA9C Offset: 0x364AA9C VA: 0x364EA9C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x364EAA4 Offset: 0x364AAA4 VA: 0x364EAA4
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x364EAAC Offset: 0x364AAAC VA: 0x364EAAC
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x364EAB4 Offset: 0x364AAB4 VA: 0x364EAB4
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x364EABC Offset: 0x364AABC VA: 0x364EABC
	public void set_GameStatus(GameStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x364EAC4 Offset: 0x364AAC4 VA: 0x364EAC4
	public Dictionary<byte, object> get_NewProperties() { }

	[CompilerGenerated]
	// RVA: 0x364EACC Offset: 0x364AACC VA: 0x364EACC
	public void set_NewProperties(Dictionary<byte, object> value) { }

	[CompilerGenerated]
	// RVA: 0x364EAD4 Offset: 0x364AAD4 VA: 0x364EAD4
	public NpcData get_NpcData() { }

	[CompilerGenerated]
	// RVA: 0x364EADC Offset: 0x364AADC VA: 0x364EADC
	public void set_NpcData(NpcData value) { }

	[CompilerGenerated]
	// RVA: 0x364EAE4 Offset: 0x364AAE4 VA: 0x364EAE4
	public byte get_FirstSkill() { }

	[CompilerGenerated]
	// RVA: 0x364EAEC Offset: 0x364AAEC VA: 0x364EAEC
	public void set_FirstSkill(byte value) { }

	// RVA: 0x364EAF4 Offset: 0x364AAF4 VA: 0x364EAF4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x364EF64 Offset: 0x364AF64 VA: 0x364EF64 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
