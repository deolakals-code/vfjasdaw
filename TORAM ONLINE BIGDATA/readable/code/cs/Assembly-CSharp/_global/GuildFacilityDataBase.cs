// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class GuildFacilityDataBase // TypeDefIndex: 1895
{
	// Fields
	[CompilerGenerated]
	private int <Level>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <MaxLevel>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x18

	// Properties
	public abstract GuildFacilityId FacilityId { get; }
	public int Level { get; set; }
	public int MaxLevel { get; set; }
	public bool IsValid { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract GuildFacilityId get_FacilityId();

	[CompilerGenerated]
	// RVA: 0x20FAB78 Offset: 0x20F6B78 VA: 0x20FAB78
	public int get_Level() { }

	[CompilerGenerated]
	// RVA: 0x20FAB80 Offset: 0x20F6B80 VA: 0x20FAB80
	private void set_Level(int value) { }

	[CompilerGenerated]
	// RVA: 0x20FAB88 Offset: 0x20F6B88 VA: 0x20FAB88
	public int get_MaxLevel() { }

	[CompilerGenerated]
	// RVA: 0x20FAB90 Offset: 0x20F6B90 VA: 0x20FAB90
	private void set_MaxLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x20FAB98 Offset: 0x20F6B98 VA: 0x20FAB98
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x20FABA0 Offset: 0x20F6BA0 VA: 0x20FABA0
	private void set_IsValid(bool value) { }

	// RVA: 0x20FAA44 Offset: 0x20F6A44 VA: 0x20FAA44
	public void .ctor(int level, int max) { }

	// RVA: 0x20FABAC Offset: 0x20F6BAC VA: 0x20FABAC Slot: 5
	public virtual int GetValue() { }

	// RVA: 0x20FABB4 Offset: 0x20F6BB4 VA: 0x20FABB4
	public void Valid() { }

	// RVA: 0x20FABC0 Offset: 0x20F6BC0 VA: 0x20FABC0
	public void Invalid() { }
}
