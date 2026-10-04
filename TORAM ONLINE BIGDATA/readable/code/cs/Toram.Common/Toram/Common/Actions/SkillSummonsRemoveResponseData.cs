// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillSummonsRemoveResponseData : UnityHashBase // TypeDefIndex: 13198
{
	// Fields
	[CompilerGenerated]
	private ArchetypeUid <RemoveServantArchetype>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <ForceRemove>k__BackingField; // 0x2A
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public ArchetypeUid RemoveServantArchetype { get; set; }
	public short SkillId { get; set; }
	public bool ForceRemove { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }

	// Methods

	// RVA: 0x36C66C8 Offset: 0x36C26C8 VA: 0x36C66C8 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36C66D0 Offset: 0x36C26D0 VA: 0x36C66D0
	public ArchetypeUid get_RemoveServantArchetype() { }

	[CompilerGenerated]
	// RVA: 0x36C66D8 Offset: 0x36C26D8 VA: 0x36C66D8
	public void set_RemoveServantArchetype(ArchetypeUid value) { }

	[CompilerGenerated]
	// RVA: 0x36C66E0 Offset: 0x36C26E0 VA: 0x36C66E0
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C66E8 Offset: 0x36C26E8 VA: 0x36C66E8
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C66F0 Offset: 0x36C26F0 VA: 0x36C66F0
	public bool get_ForceRemove() { }

	[CompilerGenerated]
	// RVA: 0x36C66F8 Offset: 0x36C26F8 VA: 0x36C66F8
	public void set_ForceRemove(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36C6704 Offset: 0x36C2704 VA: 0x36C6704
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x36C670C Offset: 0x36C270C VA: 0x36C670C
	public void set_PlayerStatus(PlayerStatusData value) { }

	// RVA: 0x36C6714 Offset: 0x36C2714 VA: 0x36C6714
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36C671C Offset: 0x36C271C VA: 0x36C671C Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36C6920 Offset: 0x36C2920 VA: 0x36C6920 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
