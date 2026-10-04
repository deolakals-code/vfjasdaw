// Assembly: mscorlib.dll
// Namespace: System.Globalization
[Serializable]
public sealed class SortVersion : IEquatable<SortVersion> // TypeDefIndex: 10786
{
	// Fields
	private int m_NlsVersion; // 0x10
	private Guid m_SortId; // 0x14

	// Methods

	// RVA: 0x2F88CC0 Offset: 0x2F84CC0 VA: 0x2F88CC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F88D5C Offset: 0x2F84D5C VA: 0x2F88D5C Slot: 4
	public bool Equals(SortVersion other) { }

	// RVA: 0x2F88DE4 Offset: 0x2F84DE4 VA: 0x2F88DE4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F88DC4 Offset: 0x2F84DC4 VA: 0x2F88DC4
	public static bool op_Equality(SortVersion left, SortVersion right) { }

	// RVA: 0x2F88D44 Offset: 0x2F84D44 VA: 0x2F88D44
	public static bool op_Inequality(SortVersion left, SortVersion right) { }
}
