// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LifeExplosionDebuff : MobBuffBase // TypeDefIndex: 858
{
	// Fields
	[CompilerGenerated]
	private byte <SkillLevel>k__BackingField; // 0x25
	public byte sendLevel; // 0x26

	// Properties
	public override MobBuffId Id { get; }
	public byte SkillLevel { get; set; }
	public override int EffectTakeId { get; }

	// Methods

	// RVA: 0x1ECE538 Offset: 0x1ECA538 VA: 0x1ECE538 Slot: 4
	public override MobBuffId get_Id() { }

	[CompilerGenerated]
	// RVA: 0x1ECE540 Offset: 0x1ECA540 VA: 0x1ECE540
	public byte get_SkillLevel() { }

	[CompilerGenerated]
	// RVA: 0x1ECE548 Offset: 0x1ECA548 VA: 0x1ECE548
	private void set_SkillLevel(byte value) { }

	// RVA: 0x1ECE550 Offset: 0x1ECA550 VA: 0x1ECE550 Slot: 5
	public override int get_EffectTakeId() { }

	// RVA: 0x1ECE55C Offset: 0x1ECA55C VA: 0x1ECE55C
	public void .ctor(int level) { }

	// RVA: 0x1ECE584 Offset: 0x1ECA584 VA: 0x1ECE584
	public void .ctor(MobBuffData buffData) { }

	// RVA: 0x1ECE5B8 Offset: 0x1ECA5B8 VA: 0x1ECE5B8 Slot: 8
	public override MobBuffData GetSendData() { }

	// RVA: 0x1ECE5F4 Offset: 0x1ECA5F4 VA: 0x1ECE5F4
	public int GetAttackMpRecovery() { }
}
