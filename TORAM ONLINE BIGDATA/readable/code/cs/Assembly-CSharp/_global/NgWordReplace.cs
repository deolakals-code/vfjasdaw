// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NgWordReplace // TypeDefIndex: 5506
{
	// Fields
	private List<string> ngWordTable; // 0x10
	private List<string> exceptionalNgWordTable; // 0x18
	private Dictionary<char, char> similarityList; // 0x20
	private string num_str_old; // 0x28
	private List<string> okWordTbl; // 0x30
	private bool isContainsNGWord; // 0x38
	private SystemLanguage systemLanguage; // 0x3C
	private readonly string[] create_name_check; // 0x40

	// Methods

	// RVA: 0x1780930 Offset: 0x177C930 VA: 0x1780930
	public void InitializeNgWord(byte[] ngBinary, byte[] okBinary) { }

	// RVA: 0x1780D84 Offset: 0x177CD84 VA: 0x1780D84
	public void ExternalNgWord(byte[] binary) { }

	// RVA: 0x17809B4 Offset: 0x177C9B4 VA: 0x17809B4
	private void LoadBinary(byte[] binary, List<string> tbl) { }

	// RVA: 0x17812AC Offset: 0x177D2AC VA: 0x17812AC
	public void CopyCharConversion(NgWordReplace copy) { }

	// RVA: 0x17812C8 Offset: 0x177D2C8 VA: 0x17812C8
	public void InitializeCharConversion(byte[] binary) { }

	// RVA: 0x17812D0 Offset: 0x177D2D0 VA: 0x17812D0
	private void LoadBinary(byte[] binary, Dictionary<char, char> tbl) { }

	// RVA: 0x1781694 Offset: 0x177D694 VA: 0x1781694
	public void ResetOldNumStr() { }

	// RVA: 0x17816E8 Offset: 0x177D6E8 VA: 0x17816E8
	public string ReplaceNGWord(string i_str, int i_start_index) { }

	// RVA: 0x17830A0 Offset: 0x177F0A0 VA: 0x17830A0
	public bool IsContainsNGWord(string i_str, int i_start_index) { }

	// RVA: 0x1784AA4 Offset: 0x1780AA4 VA: 0x1784AA4
	public bool IsContainsBanWord(string[] banWords, string i_str, int i_start_index) { }

	// RVA: 0x1785B5C Offset: 0x1781B5C VA: 0x1785B5C
	public bool IsContainsExceptionalNGWord(string str) { }

	// RVA: 0x1785CB0 Offset: 0x1781CB0 VA: 0x1785CB0
	private bool checkEnglish(char character) { }

	// RVA: 0x1785CE8 Offset: 0x1781CE8 VA: 0x1785CE8
	public Dictionary<byte, string> ContainsBanWord(Dictionary<byte, string> banWords, string i_str, int i_start_index) { }

	// RVA: 0x1786EF8 Offset: 0x1782EF8 VA: 0x1786EF8
	public string Trim2(string str, NgWordReplace.TrimType type) { }

	// RVA: 0x1787100 Offset: 0x1783100 VA: 0x1787100
	public bool KRCheckCharCreateWord(string name) { }

	// RVA: 0x1787184 Offset: 0x1783184 VA: 0x1787184
	public string ConvertWord(string input) { }

	// RVA: 0x178731C Offset: 0x178331C VA: 0x178731C
	public string wordNormalization(string inputText) { }

	// RVA: 0x17873E4 Offset: 0x17833E4 VA: 0x17873E4
	public void .ctor() { }
}
