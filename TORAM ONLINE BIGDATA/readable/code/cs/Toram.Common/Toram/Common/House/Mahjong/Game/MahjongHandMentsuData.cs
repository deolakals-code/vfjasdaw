// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong.Game
public class MahjongHandMentsuData : PacketBase // TypeDefIndex: 12566
{
	// Fields
	[CompilerGenerated]
	private List<MahjongMentsuData> <MentsuList>k__BackingField; // 0x20
	[CompilerGenerated]
	private MahjongTileData <Last>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsJusanmenmachi>k__BackingField; // 0x30
	[CompilerGenerated]
	private MahjongYakuData[] <YakuList>k__BackingField; // 0x38

	// Properties
	public List<MahjongMentsuData> MentsuList { get; set; }
	public MahjongTileData Last { get; set; }
	public bool IsKokushimuso { get; }
	public bool IsJusanmenmachi { get; set; }
	public MahjongYakuData[] YakuList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3621E54 Offset: 0x361DE54 VA: 0x3621E54
	public void .ctor(List<MahjongMentsuData> mentsuList, MahjongTileData last) { }

	// RVA: 0x3621E98 Offset: 0x361DE98 VA: 0x3621E98
	public void .ctor(MahjongTileData last, bool isJusanmenmachi) { }

	[CompilerGenerated]
	// RVA: 0x3621EE8 Offset: 0x361DEE8 VA: 0x3621EE8
	public List<MahjongMentsuData> get_MentsuList() { }

	[CompilerGenerated]
	// RVA: 0x3621EF0 Offset: 0x361DEF0 VA: 0x3621EF0
	private void set_MentsuList(List<MahjongMentsuData> value) { }

	[CompilerGenerated]
	// RVA: 0x3621EF8 Offset: 0x361DEF8 VA: 0x3621EF8
	public MahjongTileData get_Last() { }

	[CompilerGenerated]
	// RVA: 0x3621F00 Offset: 0x361DF00 VA: 0x3621F00
	private void set_Last(MahjongTileData value) { }

	// RVA: 0x3621F08 Offset: 0x361DF08 VA: 0x3621F08
	public bool get_IsKokushimuso() { }

	[CompilerGenerated]
	// RVA: 0x3621F18 Offset: 0x361DF18 VA: 0x3621F18
	public bool get_IsJusanmenmachi() { }

	[CompilerGenerated]
	// RVA: 0x3621F20 Offset: 0x361DF20 VA: 0x3621F20
	private void set_IsJusanmenmachi(bool value) { }

	[CompilerGenerated]
	// RVA: 0x3621F2C Offset: 0x361DF2C VA: 0x3621F2C
	public MahjongYakuData[] get_YakuList() { }

	[CompilerGenerated]
	// RVA: 0x3621F34 Offset: 0x361DF34 VA: 0x3621F34
	protected void set_YakuList(MahjongYakuData[] value) { }

	// RVA: 0x3621F3C Offset: 0x361DF3C VA: 0x3621F3C
	public byte GetHan() { }

	// RVA: 0x362215C Offset: 0x361E15C VA: 0x362215C
	public void SetYakuList(MahjongYakuData[] yakuList) { }

	// RVA: 0x3622164 Offset: 0x361E164 VA: 0x3622164 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362216C Offset: 0x361E16C VA: 0x362216C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3622260 Offset: 0x361E260 VA: 0x3622260 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
