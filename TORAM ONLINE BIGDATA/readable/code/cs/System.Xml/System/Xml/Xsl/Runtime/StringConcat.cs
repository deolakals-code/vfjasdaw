// Assembly: System.Xml.dll
// Namespace: System.Xml.Xsl.Runtime
[EditorBrowsable(1)]
public struct StringConcat // TypeDefIndex: 13574
{
	// Fields
	private string s1; // 0x0
	private string s2; // 0x8
	private string s3; // 0x10
	private string s4; // 0x18
	private string delimiter; // 0x20
	private List<string> strList; // 0x28
	private int idxStr; // 0x30

	// Properties
	internal int Count { get; }

	// Methods

	// RVA: 0x341461C Offset: 0x341061C VA: 0x341461C
	public void Clear() { }

	// RVA: 0x341462C Offset: 0x341062C VA: 0x341462C
	internal int get_Count() { }

	// RVA: 0x3414634 Offset: 0x3410634 VA: 0x3414634
	public string GetResult() { }

	// RVA: 0x3414728 Offset: 0x3410728 VA: 0x3414728
	internal void ConcatNoDelimiter(string s) { }
}
