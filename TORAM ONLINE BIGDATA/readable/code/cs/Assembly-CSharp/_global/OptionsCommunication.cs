// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class OptionsCommunication // TypeDefIndex: 5368
{
	// Fields
	public static readonly int CommunicationBarMax; // 0x0
	private List<EmotionPlayer.EmotionType> communicationBarList; // 0x10
	private int saveFlag; // 0x18
	private bool updateFlag; // 0x1C

	// Properties
	public EmotionPlayer.EmotionType[] CommunicationBarList { get; }
	public bool IsInvisible { get; }
	public bool IsSimpleView { get; }

	// Methods

	// RVA: 0x264E318 Offset: 0x264A318 VA: 0x264E318
	public EmotionPlayer.EmotionType[] get_CommunicationBarList() { }

	// RVA: 0x264E368 Offset: 0x264A368 VA: 0x264E368
	public bool get_IsInvisible() { }

	// RVA: 0x264E374 Offset: 0x264A374 VA: 0x264E374
	public bool get_IsSimpleView() { }

	// RVA: 0x264D858 Offset: 0x2649858 VA: 0x264D858
	public void .ctor() { }

	// RVA: 0x264E380 Offset: 0x264A380 VA: 0x264E380
	public bool UpdateCommunicationBarList(EmotionPlayer.EmotionType[] listData) { }

	// RVA: 0x264B4C4 Offset: 0x26474C4 VA: 0x264B4C4
	public void UpdateInvisible(bool invisible) { }

	// RVA: 0x264E448 Offset: 0x264A448 VA: 0x264E448
	public void UpdateSimpleView(bool simpleView) { }

	// RVA: 0x264B4DC Offset: 0x26474DC VA: 0x264B4DC
	public void SaveData() { }

	// RVA: 0x264DAD4 Offset: 0x2649AD4 VA: 0x264DAD4
	public void LoadData() { }

	// RVA: 0x264E470 Offset: 0x264A470 VA: 0x264E470
	private static void .cctor() { }
}
