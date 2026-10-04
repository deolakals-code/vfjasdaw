// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class BossResultTopRankData : PacketBase // TypeDefIndex: 13150
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Lv>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, object> <NewProperties>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public string Name { get; set; }
	public short Lv { get; set; }
	public Dictionary<byte, object> NewProperties { get; set; }

	// Methods

	// RVA: 0x36B5070 Offset: 0x36B1070 VA: 0x36B5070
	public void .ctor() { }

	// RVA: 0x36B5078 Offset: 0x36B1078 VA: 0x36B5078 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36B5080 Offset: 0x36B1080 VA: 0x36B5080
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x36B5088 Offset: 0x36B1088 VA: 0x36B5088
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x36B5090 Offset: 0x36B1090 VA: 0x36B5090
	public short get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x36B5098 Offset: 0x36B1098 VA: 0x36B5098
	public void set_Lv(short value) { }

	[CompilerGenerated]
	// RVA: 0x36B50A0 Offset: 0x36B10A0 VA: 0x36B50A0
	public Dictionary<byte, object> get_NewProperties() { }

	[CompilerGenerated]
	// RVA: 0x36B50A8 Offset: 0x36B10A8 VA: 0x36B50A8
	public void set_NewProperties(Dictionary<byte, object> value) { }

	// RVA: 0x36B50B0 Offset: 0x36B10B0 VA: 0x36B50B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36B5308 Offset: 0x36B1308 VA: 0x36B5308 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
