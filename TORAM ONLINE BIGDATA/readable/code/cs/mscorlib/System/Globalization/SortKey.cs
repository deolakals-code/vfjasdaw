// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class SortKey // TypeDefIndex: 10816
{
	// Fields
	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	// Properties
	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }

	// Methods

	// RVA: 0x2F9D7E4 Offset: 0x2F997E4 VA: 0x2F9D7E4
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x2F9D950 Offset: 0x2F99950 VA: 0x2F9D950
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x2F9DA40 Offset: 0x2F99A40 VA: 0x2F9DA40
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x2F9DAA0 Offset: 0x2F99AA0 VA: 0x2F9DAA0
	internal void .ctor(string localeName, string str, CompareOptions options, byte[] keyData) { }

	// RVA: 0x2F9DAE0 Offset: 0x2F99AE0 VA: 0x2F9DAE0 Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x2F9DAE8 Offset: 0x2F99AE8 VA: 0x2F9DAE8 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x2F9DAF0 Offset: 0x2F99AF0 VA: 0x2F9DAF0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2F9DBA0 Offset: 0x2F99BA0 VA: 0x2F9DBA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F9DC08 Offset: 0x2F99C08 VA: 0x2F9DC08 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F9DDA0 Offset: 0x2F99DA0 VA: 0x2F9DDA0
	internal void .ctor() { }
}
