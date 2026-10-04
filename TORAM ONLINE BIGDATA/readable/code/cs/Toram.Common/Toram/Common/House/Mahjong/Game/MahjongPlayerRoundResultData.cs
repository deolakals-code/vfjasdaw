// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong.Game
public class MahjongPlayerRoundResultData : PacketBase // TypeDefIndex: 12586
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private MahjongHandData <HandData>k__BackingField; // 0x28
	[CompilerGenerated]
	private int[] <WaitTileList>k__BackingField; // 0x30
	[CompilerGenerated]
	private MahjongWinData <WinData>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <ChangeScore>k__BackingField; // 0x40
	[CompilerGenerated]
	private MahjongScoreData <ScoreData>k__BackingField; // 0x48

	// Properties
	public int ArchetypeId { get; set; }
	public MahjongHandData HandData { get; set; }
	public int[] WaitTileList { get; set; }
	public MahjongWinData WinData { get; set; }
	public int ChangeScore { get; set; }
	public MahjongScoreData ScoreData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3627CEC Offset: 0x3623CEC VA: 0x3627CEC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3627CF4 Offset: 0x3623CF4 VA: 0x3627CF4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3627CFC Offset: 0x3623CFC VA: 0x3627CFC
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3627D04 Offset: 0x3623D04 VA: 0x3627D04
	public MahjongHandData get_HandData() { }

	[CompilerGenerated]
	// RVA: 0x3627D0C Offset: 0x3623D0C VA: 0x3627D0C
	public void set_HandData(MahjongHandData value) { }

	[CompilerGenerated]
	// RVA: 0x3627D14 Offset: 0x3623D14 VA: 0x3627D14
	public int[] get_WaitTileList() { }

	[CompilerGenerated]
	// RVA: 0x3627D1C Offset: 0x3623D1C VA: 0x3627D1C
	public void set_WaitTileList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3627D24 Offset: 0x3623D24 VA: 0x3627D24
	public MahjongWinData get_WinData() { }

	[CompilerGenerated]
	// RVA: 0x3627D2C Offset: 0x3623D2C VA: 0x3627D2C
	public void set_WinData(MahjongWinData value) { }

	[CompilerGenerated]
	// RVA: 0x3627D34 Offset: 0x3623D34 VA: 0x3627D34
	public int get_ChangeScore() { }

	[CompilerGenerated]
	// RVA: 0x3627D3C Offset: 0x3623D3C VA: 0x3627D3C
	public void set_ChangeScore(int value) { }

	[CompilerGenerated]
	// RVA: 0x3627D44 Offset: 0x3623D44 VA: 0x3627D44
	public MahjongScoreData get_ScoreData() { }

	[CompilerGenerated]
	// RVA: 0x3627D4C Offset: 0x3623D4C VA: 0x3627D4C
	public void set_ScoreData(MahjongScoreData value) { }

	// RVA: 0x3627D54 Offset: 0x3623D54 VA: 0x3627D54 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3627D5C Offset: 0x3623D5C VA: 0x3627D5C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3627EE8 Offset: 0x3623EE8 VA: 0x3627EE8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
