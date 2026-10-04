// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class MoodMessageData : UnityHashBase // TypeDefIndex: 13180
{
	// Fields
	[CompilerGenerated]
	private string <MoodMessage>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsLog>k__BackingField; // 0x28

	// Properties
	[UnityHash(Code = 72, IsOptional = True)]
	public string MoodMessage { get; set; }
	[UnityHash(Code = 59, IsOptional = True)]
	public bool IsLog { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36C0778 Offset: 0x36BC778 VA: 0x36C0778
	public void .ctor() { }

	// RVA: 0x36C0780 Offset: 0x36BC780 VA: 0x36C0780
	public void .ctor(Dictionary<object, object> hash) { }

	[CompilerGenerated]
	// RVA: 0x36C0788 Offset: 0x36BC788 VA: 0x36C0788
	public string get_MoodMessage() { }

	[CompilerGenerated]
	// RVA: 0x36C0790 Offset: 0x36BC790 VA: 0x36C0790
	public void set_MoodMessage(string value) { }

	[CompilerGenerated]
	// RVA: 0x36C0798 Offset: 0x36BC798 VA: 0x36C0798
	public bool get_IsLog() { }

	[CompilerGenerated]
	// RVA: 0x36C07A0 Offset: 0x36BC7A0 VA: 0x36C07A0
	public void set_IsLog(bool value) { }

	// RVA: 0x36C07AC Offset: 0x36BC7AC VA: 0x36C07AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36C07B4 Offset: 0x36BC7B4 VA: 0x36C07B4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36C09F8 Offset: 0x36BC9F8 VA: 0x36C09F8 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
