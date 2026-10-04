// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class OptionsMoodMessage // TypeDefIndex: 5376
{
	// Fields
	private Dictionary<byte, string> moodMessageList; // 0x10
	[CompilerGenerated]
	private byte <SelectedId>k__BackingField; // 0x18
	private bool updateFlag; // 0x19

	// Properties
	public byte SelectedId { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x264EEC0 Offset: 0x264AEC0 VA: 0x264EEC0
	public byte get_SelectedId() { }

	[CompilerGenerated]
	// RVA: 0x264EEC8 Offset: 0x264AEC8 VA: 0x264EEC8
	private void set_SelectedId(byte value) { }

	// RVA: 0x264E108 Offset: 0x264A108 VA: 0x264E108
	public void ChangeAccountClear() { }

	// RVA: 0x264EED0 Offset: 0x264AED0 VA: 0x264EED0
	public void UpdateSelectId(byte selectId) { }

	// RVA: 0x264EEEC Offset: 0x264AEEC VA: 0x264EEEC
	public string[] GetMoodMessageList() { }

	// RVA: 0x264EFC8 Offset: 0x264AFC8 VA: 0x264EFC8
	public string GetMoodMessage() { }

	// RVA: 0x264F158 Offset: 0x264B158 VA: 0x264F158
	public void UpdateMoodMessageList(string[] mesList) { }

	// RVA: 0x264F350 Offset: 0x264B350 VA: 0x264F350
	public void SaveData() { }

	// RVA: 0x264DD08 Offset: 0x2649D08 VA: 0x264DD08
	public void LoadData() { }

	// RVA: 0x264F5D4 Offset: 0x264B5D4 VA: 0x264F5D4
	private bool IsColorCode(string message) { }

	// RVA: 0x264DC80 Offset: 0x2649C80 VA: 0x264DC80
	public void .ctor() { }
}
