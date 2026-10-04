// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.Mahjong.Game
public class MahjongPlayerSituationData : BinaryBase // TypeDefIndex: 12568
{
	// Fields
	[CompilerGenerated]
	private byte <Jikaze>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <HarvestDanceTileId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <HarvestDanceStackTileId>k__BackingField; // 0x20

	// Properties
	public byte Jikaze { get; set; }
	public byte Flag { get; set; }
	public int HarvestDanceTileId { get; set; }
	public int HarvestDanceStackTileId { get; set; }
	public bool IsParent { get; }

	// Methods

	// RVA: 0x3622570 Offset: 0x361E570 VA: 0x3622570
	public void .ctor() { }

	// RVA: 0x3622590 Offset: 0x361E590 VA: 0x3622590
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x3622598 Offset: 0x361E598 VA: 0x3622598
	public byte get_Jikaze() { }

	[CompilerGenerated]
	// RVA: 0x36225A0 Offset: 0x361E5A0 VA: 0x36225A0
	protected void set_Jikaze(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36225A8 Offset: 0x361E5A8 VA: 0x36225A8
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36225B0 Offset: 0x361E5B0 VA: 0x36225B0
	protected void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36225B8 Offset: 0x361E5B8 VA: 0x36225B8
	public int get_HarvestDanceTileId() { }

	[CompilerGenerated]
	// RVA: 0x36225C0 Offset: 0x361E5C0 VA: 0x36225C0
	protected void set_HarvestDanceTileId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36225C8 Offset: 0x361E5C8 VA: 0x36225C8
	public int get_HarvestDanceStackTileId() { }

	[CompilerGenerated]
	// RVA: 0x36225D0 Offset: 0x361E5D0 VA: 0x36225D0
	protected void set_HarvestDanceStackTileId(int value) { }

	// RVA: 0x36225D8 Offset: 0x361E5D8 VA: 0x36225D8
	public bool get_IsParent() { }

	// RVA: 0x36225E8 Offset: 0x361E5E8 VA: 0x36225E8
	public bool HasFlag(byte type) { }

	// RVA: 0x36225F8 Offset: 0x361E5F8 VA: 0x36225F8
	public void SetFlag(byte type, bool isActive) { }

	// RVA: 0x362261C Offset: 0x361E61C VA: 0x362261C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3622678 Offset: 0x361E678 VA: 0x3622678 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
