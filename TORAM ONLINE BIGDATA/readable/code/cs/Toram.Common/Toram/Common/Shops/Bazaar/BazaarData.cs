// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Shops.Bazaar
public class BazaarData : BinaryBase // TypeDefIndex: 11079
{
	// Fields
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Slot>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <Sales>k__BackingField; // 0x1C
	[CompilerGenerated]
	private BazaarItemData[] <BazaarItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Title>k__BackingField; // 0x28

	// Properties
	public byte Flag { get; set; }
	public byte Slot { get; set; }
	public int Sales { get; set; }
	public BazaarItemData[] BazaarItemList { get; set; }
	public string Title { get; set; }

	// Methods

	// RVA: 0x35B3D80 Offset: 0x35AFD80 VA: 0x35B3D80
	public void .ctor() { }

	// RVA: 0x35B3D88 Offset: 0x35AFD88 VA: 0x35B3D88
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35B3D90 Offset: 0x35AFD90 VA: 0x35B3D90
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x35B3D98 Offset: 0x35AFD98 VA: 0x35B3D98
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B3DA0 Offset: 0x35AFDA0 VA: 0x35B3DA0
	public byte get_Slot() { }

	[CompilerGenerated]
	// RVA: 0x35B3DA8 Offset: 0x35AFDA8 VA: 0x35B3DA8
	public void set_Slot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B3DB0 Offset: 0x35AFDB0 VA: 0x35B3DB0
	public int get_Sales() { }

	[CompilerGenerated]
	// RVA: 0x35B3DB8 Offset: 0x35AFDB8 VA: 0x35B3DB8
	public void set_Sales(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B3DC0 Offset: 0x35AFDC0 VA: 0x35B3DC0
	public BazaarItemData[] get_BazaarItemList() { }

	[CompilerGenerated]
	// RVA: 0x35B3DC8 Offset: 0x35AFDC8 VA: 0x35B3DC8
	public void set_BazaarItemList(BazaarItemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35B3DD0 Offset: 0x35AFDD0 VA: 0x35B3DD0
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x35B3DD8 Offset: 0x35AFDD8 VA: 0x35B3DD8
	public void set_Title(string value) { }

	// RVA: 0x35B3DE0 Offset: 0x35AFDE0 VA: 0x35B3DE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x35B3FBC Offset: 0x35AFFBC VA: 0x35B3FBC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B4060 Offset: 0x35B0060 VA: 0x35B4060 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B41A4 Offset: 0x35B01A4 VA: 0x35B41A4
	public bool GetFlag(BazaarFlagType type) { }
}
