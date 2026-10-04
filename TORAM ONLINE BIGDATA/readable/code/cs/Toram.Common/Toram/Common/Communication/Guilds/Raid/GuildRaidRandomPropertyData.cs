// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds.Raid
public class GuildRaidRandomPropertyData : BinaryBase // TypeDefIndex: 13032
{
	// Fields
	[CompilerGenerated]
	private byte <Index>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x1C
	[CompilerGenerated]
	private byte <Lv>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x21
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28

	// Properties
	public byte Index { get; set; }
	public int Id { get; set; }
	public byte Lv { get; set; }
	public byte Flag { get; set; }
	public string Name { get; set; }
	public bool IsOpen { get; }
	public bool IsInvalid { get; }

	// Methods

	// RVA: 0x369273C Offset: 0x368E73C VA: 0x369273C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3692744 Offset: 0x368E744 VA: 0x3692744
	public byte get_Index() { }

	[CompilerGenerated]
	// RVA: 0x369274C Offset: 0x368E74C VA: 0x369274C
	public void set_Index(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3692754 Offset: 0x368E754 VA: 0x3692754
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x369275C Offset: 0x368E75C VA: 0x369275C
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x3692764 Offset: 0x368E764 VA: 0x3692764
	public byte get_Lv() { }

	[CompilerGenerated]
	// RVA: 0x369276C Offset: 0x368E76C VA: 0x369276C
	public void set_Lv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3692774 Offset: 0x368E774 VA: 0x3692774
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x369277C Offset: 0x368E77C VA: 0x369277C
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3692784 Offset: 0x368E784 VA: 0x3692784
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x369278C Offset: 0x368E78C VA: 0x369278C
	public void set_Name(string value) { }

	// RVA: 0x3692794 Offset: 0x368E794 VA: 0x3692794
	public bool get_IsOpen() { }

	// RVA: 0x36927A0 Offset: 0x368E7A0 VA: 0x36927A0
	public bool get_IsInvalid() { }

	// RVA: 0x36927AC Offset: 0x368E7AC VA: 0x36927AC
	public void SetFlag(byte type, bool isActive) { }

	// RVA: 0x36927D0 Offset: 0x368E7D0 VA: 0x36927D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3692A60 Offset: 0x368EA60 VA: 0x3692A60 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3692ACC Offset: 0x368EACC VA: 0x3692ACC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
