// Assembly: UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms.Impl
public class Leaderboard : ILeaderboard // TypeDefIndex: 17849
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <id>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UserScope <userScope>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Range <range>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TimeScope <timeScope>k__BackingField; // 0x24

	// Properties
	public bool loading { get; }
	public string id { get; }
	public UserScope userScope { get; }
	public Range range { get; }
	public TimeScope timeScope { get; }

	// Methods

	// RVA: 0x3800750 Offset: 0x37FC750 VA: 0x3800750 Slot: 4
	public bool get_loading() { }

	[CompilerGenerated]
	// RVA: 0x3800CD4 Offset: 0x37FCCD4 VA: 0x3800CD4 Slot: 5
	public string get_id() { }

	[CompilerGenerated]
	// RVA: 0x3800CDC Offset: 0x37FCCDC VA: 0x3800CDC Slot: 6
	public UserScope get_userScope() { }

	[CompilerGenerated]
	// RVA: 0x3800CE4 Offset: 0x37FCCE4 VA: 0x3800CE4 Slot: 7
	public Range get_range() { }

	[CompilerGenerated]
	// RVA: 0x3800CEC Offset: 0x37FCCEC VA: 0x3800CEC Slot: 8
	public TimeScope get_timeScope() { }
}
