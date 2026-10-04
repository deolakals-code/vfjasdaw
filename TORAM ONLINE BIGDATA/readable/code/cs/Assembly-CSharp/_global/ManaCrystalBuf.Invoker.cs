// Assembly: Assembly-CSharp.dll
// Namespace: 
private class ManaCrystalBuf.Invoker // TypeDefIndex: 3244
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <EffectUid>k__BackingField; // 0x14
	[CompilerGenerated]
	private Vector3 <EffectPos>k__BackingField; // 0x18
	[CompilerGenerated]
	private float <Rotation>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <FirstHit>k__BackingField; // 0x28
	private ManaCrystalBuf.Invoker.State state; // 0x29

	// Properties
	public int ArchetypeId { get; set; }
	public int EffectUid { get; set; }
	public Vector3 EffectPos { get; set; }
	public float Rotation { get; set; }
	public bool FirstHit { get; set; }
	public bool IsHitStop { get; }
	public bool IsHit { get; }
	public bool IsHealStop { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x233DFB4 Offset: 0x2339FB4 VA: 0x233DFB4
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x233DFBC Offset: 0x2339FBC VA: 0x233DFBC
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x233DFC4 Offset: 0x2339FC4 VA: 0x233DFC4
	public int get_EffectUid() { }

	[CompilerGenerated]
	// RVA: 0x233DFCC Offset: 0x2339FCC VA: 0x233DFCC
	public void set_EffectUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x233DFD4 Offset: 0x2339FD4 VA: 0x233DFD4
	public Vector3 get_EffectPos() { }

	[CompilerGenerated]
	// RVA: 0x233DFE0 Offset: 0x2339FE0 VA: 0x233DFE0
	public void set_EffectPos(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x233DFEC Offset: 0x2339FEC VA: 0x233DFEC
	public float get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x233DFF4 Offset: 0x2339FF4 VA: 0x233DFF4
	public void set_Rotation(float value) { }

	[CompilerGenerated]
	// RVA: 0x233DFFC Offset: 0x2339FFC VA: 0x233DFFC
	public bool get_FirstHit() { }

	[CompilerGenerated]
	// RVA: 0x233E004 Offset: 0x233A004 VA: 0x233E004
	public void set_FirstHit(bool value) { }

	// RVA: 0x233CC54 Offset: 0x2338C54 VA: 0x233CC54
	public bool get_IsHitStop() { }

	// RVA: 0x233CC7C Offset: 0x2338C7C VA: 0x233CC7C
	public bool get_IsHit() { }

	// RVA: 0x233CC60 Offset: 0x2338C60 VA: 0x233CC60
	public bool get_IsHealStop() { }

	// RVA: 0x233D204 Offset: 0x2339204 VA: 0x233D204
	public void .ctor() { }

	// RVA: 0x233D008 Offset: 0x2339008 VA: 0x233D008
	public void HitStart() { }

	// RVA: 0x233CC88 Offset: 0x2338C88 VA: 0x233CC88
	public void Hit() { }

	// RVA: 0x233CC6C Offset: 0x2338C6C VA: 0x233CC6C
	public void Heal() { }
}
