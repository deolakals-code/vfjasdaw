// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnchantAgaralDebuff : MobBuffBase // TypeDefIndex: 856
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x25
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsMine>k__BackingField; // 0x2C
	private readonly int sendArchetypeId; // 0x30
	private readonly byte sendSkillLevel; // 0x34
	private byte max; // 0x35
	private byte count; // 0x36

	// Properties
	public override MobBuffId Id { get; }
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public bool IsMine { get; set; }

	// Methods

	// RVA: 0x1ECE298 Offset: 0x1ECA298 VA: 0x1ECE298
	public void .ctor(int archetypeId, byte skillLevel) { }

	// RVA: 0x1ECE2CC Offset: 0x1ECA2CC VA: 0x1ECE2CC
	public void .ctor(int actorArchetypeId, MobBuffData buffData) { }

	// RVA: 0x1ECE35C Offset: 0x1ECA35C VA: 0x1ECE35C Slot: 4
	public override MobBuffId get_Id() { }

	[CompilerGenerated]
	// RVA: 0x1ECE364 Offset: 0x1ECA364 VA: 0x1ECE364
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x1ECE36C Offset: 0x1ECA36C VA: 0x1ECE36C
	private void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1ECE374 Offset: 0x1ECA374 VA: 0x1ECE374
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x1ECE37C Offset: 0x1ECA37C VA: 0x1ECE37C
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ECE384 Offset: 0x1ECA384 VA: 0x1ECE384
	public bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x1ECE38C Offset: 0x1ECA38C VA: 0x1ECE38C
	private void set_IsMine(bool value) { }

	// RVA: 0x1ECE398 Offset: 0x1ECA398 VA: 0x1ECE398 Slot: 8
	public override MobBuffData GetSendData() { }
}
