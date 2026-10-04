// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds
public class GuildStaffHireData : UnityHashBase // TypeDefIndex: 13024
{
	// Fields
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Support>k__BackingField; // 0x1A
	[CompilerGenerated]
	private int <HireLeftTime>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <ErrandLeftTime>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 20)]
	public byte Flag { get; set; }
	[UnityHash(Code = 10)]
	public byte Support { get; set; }
	[UnityHash(Code = 42)]
	public int HireLeftTime { get; set; }
	[UnityHash(Code = 43)]
	public int ErrandLeftTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36911BC Offset: 0x368D1BC VA: 0x36911BC
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36911C4 Offset: 0x368D1C4 VA: 0x36911C4
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x36911CC Offset: 0x368D1CC VA: 0x36911CC
	public void set_Flag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36911D4 Offset: 0x368D1D4 VA: 0x36911D4
	public byte get_Support() { }

	[CompilerGenerated]
	// RVA: 0x36911DC Offset: 0x368D1DC VA: 0x36911DC
	public void set_Support(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36911E4 Offset: 0x368D1E4 VA: 0x36911E4
	public int get_HireLeftTime() { }

	[CompilerGenerated]
	// RVA: 0x36911EC Offset: 0x368D1EC VA: 0x36911EC
	public void set_HireLeftTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x36911F4 Offset: 0x368D1F4 VA: 0x36911F4
	public int get_ErrandLeftTime() { }

	[CompilerGenerated]
	// RVA: 0x36911FC Offset: 0x368D1FC VA: 0x36911FC
	public void set_ErrandLeftTime(int value) { }

	// RVA: 0x3691204 Offset: 0x368D204 VA: 0x3691204 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369120C Offset: 0x368D20C VA: 0x369120C Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36913D4 Offset: 0x368D3D4 VA: 0x36913D4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
