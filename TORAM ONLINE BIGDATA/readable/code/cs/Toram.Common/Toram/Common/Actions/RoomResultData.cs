// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class RoomResultData : UnityHashBase // TypeDefIndex: 13144
{
	// Fields
	[CompilerGenerated]
	private ResultData <ResultData>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<byte, object> <BossResultData>k__BackingField; // 0x28

	// Properties
	public ResultData ResultData { get; set; }
	public Dictionary<byte, object> BossResultData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36B25D0 Offset: 0x36AE5D0 VA: 0x36B25D0
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36B25D8 Offset: 0x36AE5D8 VA: 0x36B25D8
	public ResultData get_ResultData() { }

	[CompilerGenerated]
	// RVA: 0x36B25E0 Offset: 0x36AE5E0 VA: 0x36B25E0
	public void set_ResultData(ResultData value) { }

	[CompilerGenerated]
	// RVA: 0x36B25E8 Offset: 0x36AE5E8 VA: 0x36B25E8
	public Dictionary<byte, object> get_BossResultData() { }

	[CompilerGenerated]
	// RVA: 0x36B25F0 Offset: 0x36AE5F0 VA: 0x36B25F0
	public void set_BossResultData(Dictionary<byte, object> value) { }

	// RVA: 0x36B25F8 Offset: 0x36AE5F8 VA: 0x36B25F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36B2600 Offset: 0x36AE600 VA: 0x36B2600 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36B272C Offset: 0x36AE72C VA: 0x36B272C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
