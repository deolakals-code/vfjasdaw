// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 9667
{
	// Fields
	private static readonly CultureAwareComparer s_invariantCulture; // 0x0
	private static readonly CultureAwareComparer s_invariantCultureIgnoreCase; // 0x8
	private static readonly OrdinalCaseSensitiveComparer s_ordinal; // 0x10
	private static readonly OrdinalIgnoreCaseComparer s_ordinalIgnoreCase; // 0x18

	// Properties
	public static StringComparer InvariantCultureIgnoreCase { get; }
	public static StringComparer Ordinal { get; }
	public static StringComparer OrdinalIgnoreCase { get; }

	// Methods

	// RVA: 0x2FFAC80 Offset: 0x2FF6C80 VA: 0x2FFAC80
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	// RVA: 0x2FFACD8 Offset: 0x2FF6CD8 VA: 0x2FFACD8
	public static StringComparer get_Ordinal() { }

	// RVA: 0x2FFAD30 Offset: 0x2FF6D30 VA: 0x2FFAD30
	public static StringComparer get_OrdinalIgnoreCase() { }

	// RVA: 0x2FFAD88 Offset: 0x2FF6D88 VA: 0x2FFAD88
	public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x2FFAE7C Offset: 0x2FF6E7C VA: 0x2FFAE7C Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x2FFB008 Offset: 0x2FF7008 VA: 0x2FFB008 Slot: 5
	public bool Equals(object x, object y) { }

	// RVA: 0x2FFB0D0 Offset: 0x2FF70D0 VA: 0x2FFB0D0 Slot: 6
	public int GetHashCode(object obj) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(string x, string y);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Equals(string x, string y);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetHashCode(string obj);

	// RVA: 0x2FFB194 Offset: 0x2FF7194 VA: 0x2FFB194
	protected void .ctor() { }

	// RVA: 0x2FFB19C Offset: 0x2FF719C VA: 0x2FFB19C
	private static void .cctor() { }
}
