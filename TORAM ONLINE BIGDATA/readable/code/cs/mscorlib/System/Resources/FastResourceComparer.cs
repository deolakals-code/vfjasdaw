// Assembly: mscorlib.dll
// Namespace: System.Resources
internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 10556
{
	// Fields
	internal static readonly FastResourceComparer Default; // 0x0

	// Methods

	// RVA: 0x2F24528 Offset: 0x2F20528 VA: 0x2F24528 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0x2F24620 Offset: 0x2F20620 VA: 0x2F24620 Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0x2F245B4 Offset: 0x2F205B4 VA: 0x2F245B4
	internal static int HashFunction(string key) { }

	// RVA: 0x2F24674 Offset: 0x2F20674 VA: 0x2F24674 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x2F24710 Offset: 0x2F20710 VA: 0x2F24710 Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0x2F24720 Offset: 0x2F20720 VA: 0x2F24720 Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0x2F24730 Offset: 0x2F20730 VA: 0x2F24730 Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0x2F247CC Offset: 0x2F207CC VA: 0x2F247CC
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0x2F24884 Offset: 0x2F20884 VA: 0x2F24884
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0x2F248F8 Offset: 0x2F208F8 VA: 0x2F248F8
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x2F24988 Offset: 0x2F20988 VA: 0x2F24988
	public void .ctor() { }

	// RVA: 0x2F24990 Offset: 0x2F20990 VA: 0x2F24990
	private static void .cctor() { }
}
