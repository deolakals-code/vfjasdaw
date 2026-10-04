// Assembly: System.dll
// Namespace: System.Diagnostics
public abstract class Switch // TypeDefIndex: 14098
{
	// Fields
	private readonly string description; // 0x10
	private readonly string displayName; // 0x18
	private string switchValueString; // 0x20
	private string defaultValue; // 0x28
	private static List<WeakReference> switches; // 0x0
	private static int s_LastCollectionCount; // 0x8

	// Methods

	// RVA: 0x348683C Offset: 0x348283C VA: 0x348683C
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x3487114 Offset: 0x3483114 VA: 0x3487114
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x3487384 Offset: 0x3483384 VA: 0x3487384
	private static void _pruneCachedSwitches() { }

	// RVA: 0x3487864 Offset: 0x3483864 VA: 0x3487864
	private static void .cctor() { }
}
