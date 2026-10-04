// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Data
public class BCollaborationEventData : GameEventDataBase // TypeDefIndex: 13078
{
	// Fields
	public const int MainVersion = 2025;
	public const byte NowInnerVersion = 1;
	protected readonly byte[] weeklyChallenge; // 0x20
	private GameEventScenarioData scenarioData; // 0x28
	[CompilerGenerated]
	private byte <InnerVersion>k__BackingField; // 0x30
	[CompilerGenerated]
	private long <WeeklyVersion>k__BackingField; // 0x38

	// Properties
	public override int Version { get; }
	public override byte Code { get; }
	public byte InnerVersion { get; set; }
	public byte[] WeeklyChallenge { get; }
	public long WeeklyVersion { get; set; }

	// Methods

	// RVA: 0x369E46C Offset: 0x369A46C VA: 0x369E46C
	public void .ctor() { }

	// RVA: 0x369E4D0 Offset: 0x369A4D0 VA: 0x369E4D0 Slot: 7
	public override int get_Version() { }

	// RVA: 0x369E4D8 Offset: 0x369A4D8 VA: 0x369E4D8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x369E4E0 Offset: 0x369A4E0 VA: 0x369E4E0
	public byte get_InnerVersion() { }

	[CompilerGenerated]
	// RVA: 0x369E4E8 Offset: 0x369A4E8 VA: 0x369E4E8
	private void set_InnerVersion(byte value) { }

	// RVA: 0x369E4F0 Offset: 0x369A4F0 VA: 0x369E4F0
	public byte[] get_WeeklyChallenge() { }

	[CompilerGenerated]
	// RVA: 0x369E4F8 Offset: 0x369A4F8 VA: 0x369E4F8
	public long get_WeeklyVersion() { }

	[CompilerGenerated]
	// RVA: 0x369E500 Offset: 0x369A500 VA: 0x369E500
	protected void set_WeeklyVersion(long value) { }

	// RVA: 0x369E508 Offset: 0x369A508 VA: 0x369E508 Slot: 8
	protected override bool VersionInitialize() { }

	// RVA: 0x369E5C0 Offset: 0x369A5C0 VA: 0x369E5C0 Slot: 9
	protected override void Serialize(MemoryStream ms) { }

	// RVA: 0x369E68C Offset: 0x369A68C VA: 0x369E68C Slot: 10
	protected override bool Deserialize(MemoryStream ms, bool isInitialize) { }
}
