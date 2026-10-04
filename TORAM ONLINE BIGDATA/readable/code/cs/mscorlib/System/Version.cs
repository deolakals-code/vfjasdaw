// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public sealed class Version : ICloneable, IComparable, IComparable<Version>, IEquatable<Version>, ISpanFormattable // TypeDefIndex: 9704
{
	// Fields
	private readonly int _Major; // 0x10
	private readonly int _Minor; // 0x14
	private readonly int _Build; // 0x18
	private readonly int _Revision; // 0x1C

	// Properties
	public int Major { get; }
	public int Minor { get; }
	public int Build { get; }
	public int Revision { get; }
	private int DefaultFormatFieldCount { get; }

	// Methods

	// RVA: 0x30040CC Offset: 0x30000CC VA: 0x30040CC
	public void .ctor(int major, int minor, int build, int revision) { }

	// RVA: 0x30041E0 Offset: 0x30001E0 VA: 0x30041E0
	public void .ctor(int major, int minor, int build) { }

	// RVA: 0x30042CC Offset: 0x30002CC VA: 0x30042CC
	public void .ctor(int major, int minor) { }

	// RVA: 0x3004384 Offset: 0x3000384 VA: 0x3004384
	public void .ctor(string version) { }

	// RVA: 0x3004460 Offset: 0x3000460 VA: 0x3004460
	public void .ctor() { }

	// RVA: 0x3004484 Offset: 0x3000484 VA: 0x3004484
	private void .ctor(Version version) { }

	// RVA: 0x30044C0 Offset: 0x30004C0 VA: 0x30044C0 Slot: 4
	public object Clone() { }

	// RVA: 0x3004518 Offset: 0x3000518 VA: 0x3004518
	public int get_Major() { }

	// RVA: 0x3004520 Offset: 0x3000520 VA: 0x3004520
	public int get_Minor() { }

	// RVA: 0x3004528 Offset: 0x3000528 VA: 0x3004528
	public int get_Build() { }

	// RVA: 0x3004530 Offset: 0x3000530 VA: 0x3004530
	public int get_Revision() { }

	// RVA: 0x3004538 Offset: 0x3000538 VA: 0x3004538 Slot: 5
	public int CompareTo(object version) { }

	// RVA: 0x3004604 Offset: 0x3000604 VA: 0x3004604 Slot: 6
	public int CompareTo(Version value) { }

	// RVA: 0x300466C Offset: 0x300066C VA: 0x300466C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x30046D0 Offset: 0x30006D0 VA: 0x30046D0 Slot: 7
	public bool Equals(Version obj) { }

	// RVA: 0x3004730 Offset: 0x3000730 VA: 0x3004730 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x300474C Offset: 0x300074C VA: 0x300474C Slot: 3
	public override string ToString() { }

	// RVA: 0x300479C Offset: 0x300079C VA: 0x300479C
	public string ToString(int fieldCount) { }

	// RVA: 0x3004A70 Offset: 0x3000A70 VA: 0x3004A70
	public bool TryFormat(Span<char> destination, out int charsWritten) { }

	// RVA: 0x3004A9C Offset: 0x3000A9C VA: 0x3004A9C
	public bool TryFormat(Span<char> destination, int fieldCount, out int charsWritten) { }

	// RVA: 0x3004BC4 Offset: 0x3000BC4 VA: 0x3004BC4 Slot: 8
	private bool System.ISpanFormattable.TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x3004774 Offset: 0x3000774 VA: 0x3004774
	private int get_DefaultFormatFieldCount() { }

	// RVA: 0x3004828 Offset: 0x3000828 VA: 0x3004828
	private StringBuilder ToCachedStringBuilder(int fieldCount) { }

	// RVA: 0x30043C8 Offset: 0x30003C8 VA: 0x30043C8
	public static Version Parse(string input) { }

	// RVA: 0x300503C Offset: 0x300103C VA: 0x300503C
	public static bool TryParse(string input, out Version result) { }

	// RVA: 0x3004BF0 Offset: 0x3000BF0 VA: 0x3004BF0
	private static Version ParseVersion(ReadOnlySpan<char> input, bool throwOnFailure) { }

	// RVA: 0x30050F0 Offset: 0x30010F0 VA: 0x30050F0
	private static bool TryParseComponent(ReadOnlySpan<char> component, string componentName, bool throwOnFailure, out int parsedComponent) { }

	// RVA: 0x30045F0 Offset: 0x30005F0 VA: 0x30045F0
	public static bool op_Equality(Version v1, Version v2) { }

	// RVA: 0x30050C8 Offset: 0x30010C8 VA: 0x30050C8
	public static bool op_Inequality(Version v1, Version v2) { }

	// RVA: 0x3005204 Offset: 0x3001204 VA: 0x3005204
	public static bool op_LessThan(Version v1, Version v2) { }
}
