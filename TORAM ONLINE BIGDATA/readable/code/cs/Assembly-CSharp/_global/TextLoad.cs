// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TextLoad // TypeDefIndex: 5586
{
	// Fields
	private char[] m_cText; // 0x10
	private int m_nSize; // 0x18
	private int m_nPosition; // 0x1C
	private int m_nRow; // 0x20
	public const char SPACE = '\x20';
	public const char ENTER = '\xd';
	public const char ENTER2 = '\xa';
	public const char TAB = '\x9';
	public const char SLASH = '\x2f';
	public const char CEND = '\x9f';
	public const char SEMICOLON = '\x3b';
	public const char COMMA = '\x2c';
	public const char COLOGNE = '\x3a';
	public const char DOUBLE = '\x22';
	public const char OPEN = '\x28';
	public const char CLOSE = '\x29';

	// Properties
	public int Position { get; }

	// Methods

	// RVA: 0x17A03E8 Offset: 0x179C3E8 VA: 0x17A03E8
	public int get_Position() { }

	// RVA: 0x17A03F0 Offset: 0x179C3F0 VA: 0x17A03F0
	public void OpenFile(TextAsset flie) { }

	// RVA: 0x17A0470 Offset: 0x179C470 VA: 0x17A0470
	public void CopyText(string flie) { }

	// RVA: 0x17A0428 Offset: 0x179C428 VA: 0x17A0428
	public void CopyText(char[] flie) { }

	// RVA: 0x17A049C Offset: 0x179C49C VA: 0x17A049C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17A0538 Offset: 0x179C538 VA: 0x17A0538
	public bool Skip() { }

	// RVA: 0x17A0660 Offset: 0x179C660 VA: 0x17A0660
	public bool Enter() { }

	// RVA: 0x17A0738 Offset: 0x179C738 VA: 0x17A0738
	public bool End() { }

	// RVA: 0x17A0748 Offset: 0x179C748 VA: 0x17A0748
	public bool ReStart() { }

	// RVA: 0x17A075C Offset: 0x179C75C VA: 0x17A075C
	public bool WordTop() { }

	// RVA: 0x17A089C Offset: 0x179C89C VA: 0x17A089C
	public bool NextEnter() { }

	// RVA: 0x17A0910 Offset: 0x179C910 VA: 0x17A0910
	public bool SearchRow(string lpWord) { }

	// RVA: 0x17A0AD8 Offset: 0x179CAD8 VA: 0x17A0AD8
	public int RowCount(string CountWord) { }

	// RVA: 0x17A0C48 Offset: 0x179CC48 VA: 0x17A0C48
	public int WordCount(string CountWord, string StopWord) { }

	// RVA: 0x17A0DA0 Offset: 0x179CDA0 VA: 0x17A0DA0
	public bool SearchWordStop(string lpWord, int nStop) { }

	// RVA: 0x17A0F00 Offset: 0x179CF00 VA: 0x17A0F00
	public bool SearchWordLimit(string lpWord, string lpLimtWord) { }

	// RVA: 0x17A1144 Offset: 0x179D144 VA: 0x17A1144
	public bool SearchWord(string lpWord, int nCount) { }

	// RVA: 0x17A1324 Offset: 0x179D324 VA: 0x17A1324
	public int SearchWordCount(string lpWord) { }

	// RVA: 0x17A14D8 Offset: 0x179D4D8 VA: 0x17A14D8
	public bool NextChar(char word) { }

	// RVA: 0x17A1528 Offset: 0x179D528 VA: 0x17A1528
	public void Replace(string word, string change) { }

	// RVA: 0x17A1958 Offset: 0x179D958 VA: 0x17A1958
	public string NextWord() { }

	// RVA: 0x17A1960 Offset: 0x179D960 VA: 0x17A1960
	public string NextWord(int nNum) { }

	// RVA: 0x17A1A94 Offset: 0x179DA94 VA: 0x17A1A94
	public string NextMessage() { }

	// RVA: 0x17A1B84 Offset: 0x179DB84 VA: 0x17A1B84
	public string CutWord(string lpCutWord) { }

	// RVA: 0x17A1CB8 Offset: 0x179DCB8 VA: 0x17A1CB8
	public string NextWordStop(string lpCutWord) { }

	// RVA: 0x17A1E28 Offset: 0x179DE28 VA: 0x17A1E28
	public string RowWord(int count) { }

	// RVA: 0x17A1F0C Offset: 0x179DF0C VA: 0x17A1F0C
	public int NextInt() { }

	// RVA: 0x17A2058 Offset: 0x179E058 VA: 0x17A2058
	public int NextInt(int num) { }

	// RVA: 0x17A2150 Offset: 0x179E150 VA: 0x17A2150
	public bool ReadInt(out int outParam) { }

	// RVA: 0x17A2180 Offset: 0x179E180 VA: 0x17A2180
	public bool ReadInt(int num, out int outParam) { }

	// RVA: 0x17A2288 Offset: 0x179E288 VA: 0x17A2288
	public int Get_Row() { }

	// RVA: 0x17A2290 Offset: 0x179E290 VA: 0x17A2290
	public void MovePass(int pass) { }

	// RVA: 0x17A23A4 Offset: 0x179E3A4 VA: 0x17A23A4
	public void .ctor() { }
}
