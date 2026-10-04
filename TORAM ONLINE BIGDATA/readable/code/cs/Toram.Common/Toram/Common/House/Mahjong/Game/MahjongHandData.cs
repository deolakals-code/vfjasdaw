// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong.Game
public class MahjongHandData : PacketBase // TypeDefIndex: 12583
{
	// Fields
	[CompilerGenerated]
	private byte <TileCount>k__BackingField; // 0x20
	[CompilerGenerated]
	private MahjongTileData[] <Tiles>k__BackingField; // 0x28
	[CompilerGenerated]
	private MahjongMentsuData[] <CallMentsuList>k__BackingField; // 0x30

	// Properties
	public byte TileCount { get; set; }
	public MahjongTileData[] Tiles { get; set; }
	public MahjongMentsuData[] CallMentsuList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3626AB4 Offset: 0x3622AB4 VA: 0x3626AB4
	public void .ctor() { }

	// RVA: 0x3626ABC Offset: 0x3622ABC VA: 0x3626ABC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3626AC4 Offset: 0x3622AC4 VA: 0x3626AC4
	public byte get_TileCount() { }

	[CompilerGenerated]
	// RVA: 0x3626ACC Offset: 0x3622ACC VA: 0x3626ACC
	public void set_TileCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3626AD4 Offset: 0x3622AD4 VA: 0x3626AD4
	public MahjongTileData[] get_Tiles() { }

	[CompilerGenerated]
	// RVA: 0x3626ADC Offset: 0x3622ADC VA: 0x3626ADC
	public void set_Tiles(MahjongTileData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3626AE4 Offset: 0x3622AE4 VA: 0x3626AE4
	public MahjongMentsuData[] get_CallMentsuList() { }

	[CompilerGenerated]
	// RVA: 0x3626AEC Offset: 0x3622AEC VA: 0x3626AEC
	public void set_CallMentsuList(MahjongMentsuData[] value) { }

	// RVA: 0x3626AF4 Offset: 0x3622AF4 VA: 0x3626AF4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3626AFC Offset: 0x3622AFC VA: 0x3626AFC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3626C44 Offset: 0x3622C44 VA: 0x3626C44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
