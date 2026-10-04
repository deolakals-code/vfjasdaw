// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Channel
public class ReturnServer : PacketBase // TypeDefIndex: 12037
{
	// Fields
	[CompilerGenerated]
	private int <SelectWorldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <GameWorldId>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Region>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <AccountWorldType>k__BackingField; // 0x29
	[CompilerGenerated]
	private short <CustomerPlatform>k__BackingField; // 0x2A

	// Properties
	public int SelectWorldId { get; set; }
	public int GameWorldId { get; set; }
	public byte Region { get; set; }
	public byte AccountWorldType { get; set; }
	public short CustomerPlatform { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x377B654 Offset: 0x3777654 VA: 0x377B654
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377B65C Offset: 0x377765C VA: 0x377B65C
	public int get_SelectWorldId() { }

	[CompilerGenerated]
	// RVA: 0x377B664 Offset: 0x3777664 VA: 0x377B664
	public void set_SelectWorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377B66C Offset: 0x377766C VA: 0x377B66C
	public int get_GameWorldId() { }

	[CompilerGenerated]
	// RVA: 0x377B674 Offset: 0x3777674 VA: 0x377B674
	public void set_GameWorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x377B67C Offset: 0x377767C VA: 0x377B67C
	public byte get_Region() { }

	[CompilerGenerated]
	// RVA: 0x377B684 Offset: 0x3777684 VA: 0x377B684
	public void set_Region(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377B68C Offset: 0x377768C VA: 0x377B68C
	public byte get_AccountWorldType() { }

	[CompilerGenerated]
	// RVA: 0x377B694 Offset: 0x3777694 VA: 0x377B694
	public void set_AccountWorldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377B69C Offset: 0x377769C VA: 0x377B69C
	public short get_CustomerPlatform() { }

	[CompilerGenerated]
	// RVA: 0x377B6A4 Offset: 0x37776A4 VA: 0x377B6A4
	public void set_CustomerPlatform(short value) { }

	// RVA: 0x377B6AC Offset: 0x37776AC VA: 0x377B6AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377B6B4 Offset: 0x37776B4 VA: 0x377B6B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377B958 Offset: 0x3777958 VA: 0x377B958 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
