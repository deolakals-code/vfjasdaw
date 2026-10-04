// Assembly: mscorlib.dll
// Namespace: System.Globalization
internal interface ISimpleCollator // TypeDefIndex: 10817
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SortKey GetSortKey(string source, CompareOptions options);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsPrefix(string src, string target, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsSuffix(string src, string target, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int IndexOf(string s, string target, int start, int length, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int LastIndexOf(string s, string target, int start, int length, CompareOptions opt);
}
