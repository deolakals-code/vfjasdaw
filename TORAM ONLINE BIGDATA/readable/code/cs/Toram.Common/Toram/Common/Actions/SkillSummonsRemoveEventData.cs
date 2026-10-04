// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillSummonsRemoveEventData : UnityHashBase // TypeDefIndex: 13197
{
	// Fields
	[CompilerGenerated]
	private ArchetypeUid <RemoveServantArchetype>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public ArchetypeUid RemoveServantArchetype { get; set; }
	public short SkillId { get; set; }

	// Methods

	// RVA: 0x36C62EC Offset: 0x36C22EC VA: 0x36C62EC Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36C62F4 Offset: 0x36C22F4 VA: 0x36C62F4
	public ArchetypeUid get_RemoveServantArchetype() { }

	[CompilerGenerated]
	// RVA: 0x36C62FC Offset: 0x36C22FC VA: 0x36C62FC
	public void set_RemoveServantArchetype(ArchetypeUid value) { }

	[CompilerGenerated]
	// RVA: 0x36C6304 Offset: 0x36C2304 VA: 0x36C6304
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C630C Offset: 0x36C230C VA: 0x36C630C
	public void set_SkillId(short value) { }

	// RVA: 0x36C6314 Offset: 0x36C2314 VA: 0x36C6314
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36C631C Offset: 0x36C231C VA: 0x36C631C Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36C6480 Offset: 0x36C2480 VA: 0x36C6480 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
