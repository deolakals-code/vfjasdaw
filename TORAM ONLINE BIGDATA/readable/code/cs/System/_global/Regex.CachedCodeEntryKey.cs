// Assembly: System.dll
// Namespace: 
[IsReadOnly]
internal struct Regex.CachedCodeEntryKey : IEquatable<Regex.CachedCodeEntryKey> // TypeDefIndex: 14072
{
	// Fields
	private readonly RegexOptions _options; // 0x0
	private readonly string _cultureKey; // 0x8
	private readonly string _pattern; // 0x10

	// Methods

	// RVA: 0x346FCDC Offset: 0x346BCDC VA: 0x346FCDC
	public void .ctor(RegexOptions options, string cultureKey, string pattern) { }

	// RVA: 0x346FE40 Offset: 0x346BE40 VA: 0x346FE40 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x346FED0 Offset: 0x346BED0 VA: 0x346FED0 Slot: 4
	public bool Equals(Regex.CachedCodeEntryKey other) { }

	// RVA: 0x346D80C Offset: 0x346980C VA: 0x346D80C
	public static bool op_Equality(Regex.CachedCodeEntryKey left, Regex.CachedCodeEntryKey right) { }

	// RVA: 0x346FF38 Offset: 0x346BF38 VA: 0x346FF38 Slot: 2
	public override int GetHashCode() { }
}
