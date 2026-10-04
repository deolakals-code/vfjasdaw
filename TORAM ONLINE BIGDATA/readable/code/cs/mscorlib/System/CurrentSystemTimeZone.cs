// Assembly: mscorlib.dll
// Namespace: System
[Obsolete("System.CurrentSystemTimeZone has been deprecated.  Please investigate the use of System.TimeZoneInfo.Local instead.")]
[Serializable]
internal class CurrentSystemTimeZone : TimeZone // TypeDefIndex: 9565
{
	// Fields
	private long m_ticksOffset; // 0x10
	private string m_standardName; // 0x18
	private string m_daylightName; // 0x20
	private readonly Hashtable m_CachedDaylightChanges; // 0x28

	// Methods

	// RVA: 0x2FC4B88 Offset: 0x2FC0B88 VA: 0x2FC4B88
	internal void .ctor() { }

	// RVA: 0x2FC4C98 Offset: 0x2FC0C98 VA: 0x2FC4C98
	public static bool GetTimeZoneData(int year, out long[] data, out string[] names, out bool daylight_inverted) { }
}
