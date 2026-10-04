// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildGetBoardResponse : PacketBase // TypeDefIndex: 12386
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildBoardData[] <BoardList>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, long> <BoardDateList>k__BackingField; // 0x30

	// Properties
	public int GuildId { get; set; }
	public GuildBoardData[] BoardList { get; set; }
	public Dictionary<byte, long> BoardDateList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FF7C0 Offset: 0x35FB7C0 VA: 0x35FF7C0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FF7C8 Offset: 0x35FB7C8 VA: 0x35FF7C8
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x35FF7D0 Offset: 0x35FB7D0 VA: 0x35FF7D0
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FF7D8 Offset: 0x35FB7D8 VA: 0x35FF7D8
	public GuildBoardData[] get_BoardList() { }

	[CompilerGenerated]
	// RVA: 0x35FF7E0 Offset: 0x35FB7E0 VA: 0x35FF7E0
	public void set_BoardList(GuildBoardData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35FF7E8 Offset: 0x35FB7E8 VA: 0x35FF7E8
	public Dictionary<byte, long> get_BoardDateList() { }

	[CompilerGenerated]
	// RVA: 0x35FF7F0 Offset: 0x35FB7F0 VA: 0x35FF7F0
	public void set_BoardDateList(Dictionary<byte, long> value) { }

	// RVA: 0x35FF7F8 Offset: 0x35FB7F8 VA: 0x35FF7F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FF800 Offset: 0x35FB800 VA: 0x35FF800 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FFA6C Offset: 0x35FBA6C VA: 0x35FFA6C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
