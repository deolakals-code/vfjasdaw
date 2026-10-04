// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongController.MahjongPlayerTileDatas // TypeDefIndex: 4377
{
	// Fields
	private int archetypeId; // 0x10
	private MahjongSeatType seatType; // 0x14
	private MahjongHandTileAreaManager handTileAreaManager; // 0x18
	private MahjongDiscardAreaManager discardTileManager; // 0x20
	private MahjongOpenTileAreaManager openTileManager; // 0x28

	// Properties
	public int ArchetypeId { get; }
	public MahjongSeatType SeatType { get; }
	public MahjongHandTileAreaManager HandTileAreaManager { get; }
	public MahjongDiscardAreaManager DiscardTileManager { get; }
	public MahjongOpenTileAreaManager OpenTileManager { get; }

	// Methods

	// RVA: 0x24EA704 Offset: 0x24E6704 VA: 0x24EA704
	public void .ctor(int archetypeId, MahjongSeatType seatType, MahjongHandTileAreaManager handTileAreaManager, MahjongDiscardAreaManager discardTileManager, MahjongOpenTileAreaManager openTileManager) { }

	// RVA: 0x24EA778 Offset: 0x24E6778 VA: 0x24EA778
	public int get_ArchetypeId() { }

	// RVA: 0x24EA780 Offset: 0x24E6780 VA: 0x24EA780
	public MahjongSeatType get_SeatType() { }

	// RVA: 0x24EA788 Offset: 0x24E6788 VA: 0x24EA788
	public MahjongHandTileAreaManager get_HandTileAreaManager() { }

	// RVA: 0x24EA790 Offset: 0x24E6790 VA: 0x24EA790
	public MahjongDiscardAreaManager get_DiscardTileManager() { }

	// RVA: 0x24EA798 Offset: 0x24E6798 VA: 0x24EA798
	public MahjongOpenTileAreaManager get_OpenTileManager() { }
}
