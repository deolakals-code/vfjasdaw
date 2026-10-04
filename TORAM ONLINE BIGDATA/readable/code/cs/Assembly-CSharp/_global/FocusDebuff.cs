// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FocusDebuff : MobBuffBase // TypeDefIndex: 857
{
	// Fields
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x25
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsMine>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x30
	private int sendArchetypeId; // 0x34

	// Properties
	public override MobBuffId Id { get; }
	public byte ArchetypeType { get; set; }
	public int ArchetypeId { get; set; }
	public bool IsMine { get; set; }
	public int Level { get; set; }
	public int ImpactAcceleration { get; }
	public int IntervalAcceleration { get; }

	// Methods

	// RVA: 0x1ECE3E4 Offset: 0x1ECA3E4 VA: 0x1ECE3E4 Slot: 4
	public override MobBuffId get_Id() { }

	[CompilerGenerated]
	// RVA: 0x1ECE3EC Offset: 0x1ECA3EC VA: 0x1ECE3EC
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x1ECE3F4 Offset: 0x1ECA3F4 VA: 0x1ECE3F4
	private void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1ECE3FC Offset: 0x1ECA3FC VA: 0x1ECE3FC
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x1ECE404 Offset: 0x1ECA404 VA: 0x1ECE404
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ECE40C Offset: 0x1ECA40C VA: 0x1ECE40C
	public bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x1ECE414 Offset: 0x1ECA414 VA: 0x1ECE414
	private void set_IsMine(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1ECE420 Offset: 0x1ECA420 VA: 0x1ECE420
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x1ECE428 Offset: 0x1ECA428 VA: 0x1ECE428
	private void set_Level(int value) { }

	// RVA: 0x1ECE430 Offset: 0x1ECA430 VA: 0x1ECE430
	public int get_ImpactAcceleration() { }

	// RVA: 0x1ECE438 Offset: 0x1ECA438 VA: 0x1ECE438
	public int get_IntervalAcceleration() { }

	// RVA: 0x1ECE448 Offset: 0x1ECA448 VA: 0x1ECE448
	public void .ctor(int archetypeId, int focusLevel) { }

	// RVA: 0x1ECE474 Offset: 0x1ECA474 VA: 0x1ECE474
	public void .ctor(int actorArchetypeId, MobBuffData buffData) { }

	// RVA: 0x1ECE4EC Offset: 0x1ECA4EC VA: 0x1ECE4EC Slot: 8
	public override MobBuffData GetSendData() { }
}
