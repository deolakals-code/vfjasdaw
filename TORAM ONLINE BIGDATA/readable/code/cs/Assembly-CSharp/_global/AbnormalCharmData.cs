// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AbnormalCharmData : AbnormalData // TypeDefIndex: 1647
{
	// Fields
	[CompilerGenerated]
	private byte <EffectiveArchetypeType>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <EffectiveArchetypeId>k__BackingField; // 0x2C

	// Properties
	public byte EffectiveArchetypeType { get; set; }
	public int EffectiveArchetypeId { get; set; }

	// Methods

	// RVA: 0x20A0340 Offset: 0x209C340 VA: 0x20A0340
	public void .ctor(AbnormalType type, float time, float resistTime, byte localId, bool isForce, Action<AbnormalData> callback) { }

	[CompilerGenerated]
	// RVA: 0x20A0348 Offset: 0x209C348 VA: 0x20A0348
	public byte get_EffectiveArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x20A0350 Offset: 0x209C350 VA: 0x20A0350
	private void set_EffectiveArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x20A0358 Offset: 0x209C358 VA: 0x20A0358
	public int get_EffectiveArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x20A0360 Offset: 0x209C360 VA: 0x20A0360
	private void set_EffectiveArchetypeId(int value) { }

	// RVA: 0x20A0368 Offset: 0x209C368 VA: 0x20A0368
	public void SetEffectiveTarget(byte archetypeType, int archetypeId) { }
}
