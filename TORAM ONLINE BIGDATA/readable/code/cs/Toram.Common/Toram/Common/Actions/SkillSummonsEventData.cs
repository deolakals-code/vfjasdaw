// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public class SkillSummonsEventData : UnityHashBase // TypeDefIndex: 13195
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private ArchetypeUid <Summoner>k__BackingField; // 0x20
	[CompilerGenerated]
	private ArchetypeUid <Servant>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<byte, object> <NewServantData>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public short SkillId { get; set; }
	public ArchetypeUid Summoner { get; set; }
	public ArchetypeUid Servant { get; set; }
	public Dictionary<byte, object> NewServantData { get; set; }

	// Methods

	// RVA: 0x36C5720 Offset: 0x36C1720 VA: 0x36C5720 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x36C5728 Offset: 0x36C1728 VA: 0x36C5728
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x36C5730 Offset: 0x36C1730 VA: 0x36C5730
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x36C5738 Offset: 0x36C1738 VA: 0x36C5738
	public ArchetypeUid get_Summoner() { }

	[CompilerGenerated]
	// RVA: 0x36C5740 Offset: 0x36C1740 VA: 0x36C5740
	public void set_Summoner(ArchetypeUid value) { }

	[CompilerGenerated]
	// RVA: 0x36C5748 Offset: 0x36C1748 VA: 0x36C5748
	public ArchetypeUid get_Servant() { }

	[CompilerGenerated]
	// RVA: 0x36C5750 Offset: 0x36C1750 VA: 0x36C5750
	public void set_Servant(ArchetypeUid value) { }

	[CompilerGenerated]
	// RVA: 0x36C5758 Offset: 0x36C1758 VA: 0x36C5758
	public Dictionary<byte, object> get_NewServantData() { }

	[CompilerGenerated]
	// RVA: 0x36C5760 Offset: 0x36C1760 VA: 0x36C5760
	public void set_NewServantData(Dictionary<byte, object> value) { }

	// RVA: 0x36C5768 Offset: 0x36C1768 VA: 0x36C5768
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36C5770 Offset: 0x36C1770 VA: 0x36C5770 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36C5960 Offset: 0x36C1960 VA: 0x36C5960 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
