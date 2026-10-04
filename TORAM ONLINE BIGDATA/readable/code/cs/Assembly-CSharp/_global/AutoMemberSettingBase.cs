// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AutoMemberSettingBase : NPCPartySettingBase // TypeDefIndex: 490
{
	// Fields
	[CompilerGenerated]
	private bool <IsMan>k__BackingField; // 0x90
	public AIPersonalityType Personal; // 0x94
	public List<Pair<short, short>> Properties; // 0x98

	// Properties
	public bool IsMan { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x182856C Offset: 0x182456C VA: 0x182856C
	private void set_IsMan(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1828578 Offset: 0x1824578 VA: 0x1828578
	public bool get_IsMan() { }

	// RVA: 0x1828580 Offset: 0x1824580 VA: 0x1828580
	public void .ctor(NpcOtherData npc) { }

	// RVA: 0x1828C40 Offset: 0x1824C40 VA: 0x1828C40
	public void .ctor(NpcAvatarJoinResponse npc) { }

	// RVA: 0x1829DC8 Offset: 0x1825DC8 VA: 0x1829DC8
	public void .ctor(NpcAvatarRejoinResponse npc) { }

	// RVA: 0x182A150 Offset: 0x1826150 VA: 0x182A150
	public void .ctor(RoomNpcJoinEvent npc) { }

	// RVA: 0x182A4D4 Offset: 0x18264D4 VA: 0x182A4D4
	public void .ctor(string nameKey) { }

	// RVA: 0x1829C18 Offset: 0x1825C18 VA: 0x1829C18
	protected void SetEquipProperty(NpcEquipData equipData) { }
}
