// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MasterMissionSkipData // TypeDefIndex: 2205
{
	// Fields
	[CompilerGenerated]
	private int <MissionId>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <Chapter>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <Cost>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <ChapterTitle>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <EpisodeTitle>k__BackingField; // 0x28

	// Properties
	public int MissionId { get; set; }
	public byte Chapter { get; set; }
	public int Cost { get; set; }
	public string ChapterTitle { get; set; }
	public int Episode { get; }
	public string EpisodeTitle { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x216B064 Offset: 0x2167064 VA: 0x216B064
	public int get_MissionId() { }

	[CompilerGenerated]
	// RVA: 0x216B06C Offset: 0x216706C VA: 0x216B06C
	private void set_MissionId(int value) { }

	[CompilerGenerated]
	// RVA: 0x216B074 Offset: 0x2167074 VA: 0x216B074
	public byte get_Chapter() { }

	[CompilerGenerated]
	// RVA: 0x216B07C Offset: 0x216707C VA: 0x216B07C
	private void set_Chapter(byte value) { }

	[CompilerGenerated]
	// RVA: 0x216B084 Offset: 0x2167084 VA: 0x216B084
	public int get_Cost() { }

	[CompilerGenerated]
	// RVA: 0x216B08C Offset: 0x216708C VA: 0x216B08C
	private void set_Cost(int value) { }

	[CompilerGenerated]
	// RVA: 0x216B094 Offset: 0x2167094 VA: 0x216B094
	public string get_ChapterTitle() { }

	[CompilerGenerated]
	// RVA: 0x216B09C Offset: 0x216709C VA: 0x216B09C
	private void set_ChapterTitle(string value) { }

	// RVA: 0x216B0A4 Offset: 0x21670A4 VA: 0x216B0A4
	public int get_Episode() { }

	[CompilerGenerated]
	// RVA: 0x216B0B0 Offset: 0x21670B0 VA: 0x216B0B0
	public string get_EpisodeTitle() { }

	[CompilerGenerated]
	// RVA: 0x216B0B8 Offset: 0x21670B8 VA: 0x216B0B8
	private void set_EpisodeTitle(string value) { }

	// RVA: 0x216B0C0 Offset: 0x21670C0 VA: 0x216B0C0
	public void .ctor(int missionId, byte chapter, int pricecost) { }

	// RVA: 0x216B164 Offset: 0x2167164 VA: 0x216B164
	public void SetTitles(string chapterTitle, string episodeTitle) { }
}
