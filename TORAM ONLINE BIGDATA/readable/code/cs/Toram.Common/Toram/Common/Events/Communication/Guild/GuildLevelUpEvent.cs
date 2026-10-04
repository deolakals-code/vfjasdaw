// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildLevelUpEvent : PacketBase // TypeDefIndex: 12918
{
	// Fields
	[CompilerGenerated]
	private int <GuildId>k__BackingField; // 0x20
	[CompilerGenerated]
	private GuildLevelData <LevelData>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <BoosterType>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <BoosterRate>k__BackingField; // 0x34
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 219, IsOptional = True)]
	public int GuildId { get; set; }
	[PacketClass(Code = 199, IsOptional = True)]
	public GuildLevelData LevelData { get; set; }
	public byte BoosterType { get; set; }
	public int BoosterRate { get; set; }
	public GameStatusData GameStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3677FC4 Offset: 0x3673FC4 VA: 0x3677FC4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3677FCC Offset: 0x3673FCC VA: 0x3677FCC
	public int get_GuildId() { }

	[CompilerGenerated]
	// RVA: 0x3677FD4 Offset: 0x3673FD4 VA: 0x3677FD4
	public void set_GuildId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3677FDC Offset: 0x3673FDC VA: 0x3677FDC
	public GuildLevelData get_LevelData() { }

	[CompilerGenerated]
	// RVA: 0x3677FE4 Offset: 0x3673FE4 VA: 0x3677FE4
	public void set_LevelData(GuildLevelData value) { }

	[CompilerGenerated]
	// RVA: 0x3677FEC Offset: 0x3673FEC VA: 0x3677FEC
	public byte get_BoosterType() { }

	[CompilerGenerated]
	// RVA: 0x3677FF4 Offset: 0x3673FF4 VA: 0x3677FF4
	public void set_BoosterType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3677FFC Offset: 0x3673FFC VA: 0x3677FFC
	public int get_BoosterRate() { }

	[CompilerGenerated]
	// RVA: 0x3678004 Offset: 0x3674004 VA: 0x3678004
	public void set_BoosterRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x367800C Offset: 0x367400C VA: 0x367800C
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3678014 Offset: 0x3674014 VA: 0x3678014
	public void set_GameStatus(GameStatusData value) { }

	// RVA: 0x367801C Offset: 0x367401C VA: 0x367801C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36781FC Offset: 0x36741FC VA: 0x36781FC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36782A4 Offset: 0x36742A4 VA: 0x36782A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36782AC Offset: 0x36742AC VA: 0x36782AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36784EC Offset: 0x36744EC VA: 0x36784EC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
