// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds
public class GuildUserData : BinaryBase // TypeDefIndex: 13027
{
	// Fields
	[CompilerGenerated]
	private byte <Post>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <FloorDepth>k__BackingField; // 0x1A
	[CompilerGenerated]
	private DateTime <DepthDate>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <JoinDate>k__BackingField; // 0x28

	// Properties
	public byte Post { get; set; }
	public byte FloorDepth { get; set; }
	public DateTime DepthDate { get; set; }
	public DateTime JoinDate { get; set; }

	// Methods

	// RVA: 0x368F528 Offset: 0x368B528 VA: 0x368F528
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x3691640 Offset: 0x368D640 VA: 0x3691640
	public byte get_Post() { }

	[CompilerGenerated]
	// RVA: 0x3691648 Offset: 0x368D648 VA: 0x3691648
	public void set_Post(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3691650 Offset: 0x368D650 VA: 0x3691650
	public byte get_FloorDepth() { }

	[CompilerGenerated]
	// RVA: 0x3691658 Offset: 0x368D658 VA: 0x3691658
	public void set_FloorDepth(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3691660 Offset: 0x368D660 VA: 0x3691660
	public DateTime get_DepthDate() { }

	[CompilerGenerated]
	// RVA: 0x3691668 Offset: 0x368D668 VA: 0x3691668
	public void set_DepthDate(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3691670 Offset: 0x368D670 VA: 0x3691670
	public DateTime get_JoinDate() { }

	[CompilerGenerated]
	// RVA: 0x3691678 Offset: 0x368D678 VA: 0x3691678
	public void set_JoinDate(DateTime value) { }

	// RVA: 0x3691680 Offset: 0x368D680 VA: 0x3691680 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36917B4 Offset: 0x368D7B4 VA: 0x36917B4 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
