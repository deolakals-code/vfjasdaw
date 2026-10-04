// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CatarabomosDebuff : MobBuffBase // TypeDefIndex: 854
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <SkillLevel>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <IsMine>k__BackingField; // 0x2D
	private byte sendLevel; // 0x2E
	private int sendStable; // 0x30

	// Properties
	public override MobBuffId Id { get; }
	public int ArchetypeId { get; set; }
	public byte SkillLevel { get; set; }
	public bool IsMine { get; set; }
	public override int EffectTakeId { get; }

	// Methods

	// RVA: 0x1ECDFD4 Offset: 0x1EC9FD4 VA: 0x1ECDFD4 Slot: 4
	public override MobBuffId get_Id() { }

	[CompilerGenerated]
	// RVA: 0x1ECDFDC Offset: 0x1EC9FDC VA: 0x1ECDFDC
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x1ECDFE4 Offset: 0x1EC9FE4 VA: 0x1ECDFE4
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ECDFEC Offset: 0x1EC9FEC VA: 0x1ECDFEC
	public byte get_SkillLevel() { }

	[CompilerGenerated]
	// RVA: 0x1ECDFF4 Offset: 0x1EC9FF4 VA: 0x1ECDFF4
	private void set_SkillLevel(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1ECDFFC Offset: 0x1EC9FFC VA: 0x1ECDFFC
	public bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x1ECE004 Offset: 0x1ECA004 VA: 0x1ECE004
	private void set_IsMine(bool value) { }

	// RVA: 0x1ECE010 Offset: 0x1ECA010 VA: 0x1ECE010 Slot: 5
	public override int get_EffectTakeId() { }

	// RVA: 0x1ECE01C Offset: 0x1ECA01C VA: 0x1ECE01C
	public void .ctor(int archetypeId, int level, int stable) { }

	// RVA: 0x1ECE04C Offset: 0x1ECA04C VA: 0x1ECE04C
	public void .ctor(int actorArchetypeId, MobBuffData buffData) { }

	// RVA: 0x1ECE0B4 Offset: 0x1ECA0B4 VA: 0x1ECE0B4 Slot: 8
	public override MobBuffData GetSendData() { }
}
