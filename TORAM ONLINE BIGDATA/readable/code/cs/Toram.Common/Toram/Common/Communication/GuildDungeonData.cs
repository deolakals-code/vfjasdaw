// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class GuildDungeonData : UnityHashBase // TypeDefIndex: 12987
{
	// Fields
	[CompilerGenerated]
	private byte <FloorDepth>k__BackingField; // 0x19
	[CompilerGenerated]
	private DateTime <DepthDate>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 242)]
	public byte FloorDepth { get; set; }
	[UnityHash(Code = 172)]
	public DateTime DepthDate { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3688730 Offset: 0x3684730 VA: 0x3688730
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3688738 Offset: 0x3684738 VA: 0x3688738
	public byte get_FloorDepth() { }

	[CompilerGenerated]
	// RVA: 0x3688740 Offset: 0x3684740 VA: 0x3688740
	public void set_FloorDepth(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3688748 Offset: 0x3684748 VA: 0x3688748
	public DateTime get_DepthDate() { }

	[CompilerGenerated]
	// RVA: 0x3688750 Offset: 0x3684750 VA: 0x3688750
	public void set_DepthDate(DateTime value) { }

	// RVA: 0x3688758 Offset: 0x3684758 VA: 0x3688758 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3688760 Offset: 0x3684760 VA: 0x3688760 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x368892C Offset: 0x368492C VA: 0x368892C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
