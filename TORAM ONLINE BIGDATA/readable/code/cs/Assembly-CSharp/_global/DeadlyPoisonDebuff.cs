// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DeadlyPoisonDebuff : MobBuffBase // TypeDefIndex: 855
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x25
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <PoisonLevel>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <IsMine>k__BackingField; // 0x2D
	private const float MaxEffectTime = 10;
	private int sendArchetypeId; // 0x30
	private byte sendPoisonLevel; // 0x34

	// Properties
	public override MobBuffId Id { get; }
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public byte PoisonLevel { get; set; }
	public bool IsMine { get; set; }

	// Methods

	// RVA: 0x1ECE100 Offset: 0x1ECA100 VA: 0x1ECE100
	public void .ctor(int archetypeId, int poisonLevel) { }

	// RVA: 0x1ECE130 Offset: 0x1ECA130 VA: 0x1ECE130
	public void .ctor(byte actorArchetypeType, int actorArchetypeId, MobBuffData buffData) { }

	// RVA: 0x1ECE1B0 Offset: 0x1ECA1B0 VA: 0x1ECE1B0 Slot: 4
	public override MobBuffId get_Id() { }

	[CompilerGenerated]
	// RVA: 0x1ECE1B8 Offset: 0x1ECA1B8 VA: 0x1ECE1B8
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x1ECE1C0 Offset: 0x1ECA1C0 VA: 0x1ECE1C0
	private void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1ECE1C8 Offset: 0x1ECA1C8 VA: 0x1ECE1C8
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x1ECE1D0 Offset: 0x1ECA1D0 VA: 0x1ECE1D0
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ECE1D8 Offset: 0x1ECA1D8 VA: 0x1ECE1D8
	public byte get_PoisonLevel() { }

	[CompilerGenerated]
	// RVA: 0x1ECE1E0 Offset: 0x1ECA1E0 VA: 0x1ECE1E0
	private void set_PoisonLevel(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1ECE1E8 Offset: 0x1ECA1E8 VA: 0x1ECE1E8
	public bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x1ECE1F0 Offset: 0x1ECA1F0 VA: 0x1ECE1F0
	private void set_IsMine(bool value) { }

	// RVA: 0x1ECE1FC Offset: 0x1ECA1FC VA: 0x1ECE1FC Slot: 8
	public override MobBuffData GetSendData() { }

	// RVA: 0x1ECE248 Offset: 0x1ECA248 VA: 0x1ECE248
	public float GetNecessaryFreeDownRate() { }
}
