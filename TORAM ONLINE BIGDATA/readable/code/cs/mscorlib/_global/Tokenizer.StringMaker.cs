// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
internal sealed class Tokenizer.StringMaker // TypeDefIndex: 10080
{
	// Fields
	private string[] aStrings; // 0x10
	private uint cStringsMax; // 0x18
	private uint cStringsUsed; // 0x1C
	public StringBuilder _outStringBuilder; // 0x20
	public char[] _outChars; // 0x28
	public int _outIndex; // 0x30

	// Methods

	// RVA: 0x2EA7B78 Offset: 0x2EA3B78 VA: 0x2EA7B78
	private static uint HashString(string str) { }

	// RVA: 0x2EA7BE4 Offset: 0x2EA3BE4 VA: 0x2EA7BE4
	private static uint HashCharArray(char[] a, int l) { }

	// RVA: 0x2EA7C40 Offset: 0x2EA3C40 VA: 0x2EA7C40
	public void .ctor() { }

	// RVA: 0x2EA7CE8 Offset: 0x2EA3CE8 VA: 0x2EA7CE8
	private bool CompareStringAndChars(string str, char[] a, int l) { }

	// RVA: 0x2EA235C Offset: 0x2E9E35C VA: 0x2EA235C
	public string MakeString() { }
}
