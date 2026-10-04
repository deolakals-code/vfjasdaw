// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class RecreateStyle : PacketBase // TypeDefIndex: 11408
{
	// Fields
	[CompilerGenerated]
	private NewStyleData <NewStyleData>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<int, int> <RecreateList>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <UseOrb>k__BackingField; // 0x34

	// Properties
	public NewStyleData NewStyleData { get; set; }
	public Dictionary<int, int> RecreateList { get; set; }
	public int Orb { get; set; }
	public int UseOrb { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x37024A4 Offset: 0x36FE4A4 VA: 0x37024A4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37024AC Offset: 0x36FE4AC VA: 0x37024AC
	public NewStyleData get_NewStyleData() { }

	[CompilerGenerated]
	// RVA: 0x37024B4 Offset: 0x36FE4B4 VA: 0x37024B4
	public void set_NewStyleData(NewStyleData value) { }

	[CompilerGenerated]
	// RVA: 0x37024BC Offset: 0x36FE4BC VA: 0x37024BC
	public Dictionary<int, int> get_RecreateList() { }

	[CompilerGenerated]
	// RVA: 0x37024C4 Offset: 0x36FE4C4 VA: 0x37024C4
	public void set_RecreateList(Dictionary<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x37024CC Offset: 0x36FE4CC VA: 0x37024CC
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x37024D4 Offset: 0x36FE4D4 VA: 0x37024D4
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x37024DC Offset: 0x36FE4DC VA: 0x37024DC
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x37024E4 Offset: 0x36FE4E4 VA: 0x37024E4
	public void set_UseOrb(int value) { }

	// RVA: 0x37024EC Offset: 0x36FE4EC VA: 0x37024EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37024F4 Offset: 0x36FE4F4 VA: 0x37024F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3702834 Offset: 0x36FE834 VA: 0x3702834 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
