// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
internal sealed class RegexFC // TypeDefIndex: 14083
{
	// Fields
	private RegexCharClass _cc; // 0x10
	public bool _nullable; // 0x18
	[CompilerGenerated]
	private bool <CaseInsensitive>k__BackingField; // 0x19

	// Properties
	public bool CaseInsensitive { get; set; }

	// Methods

	// RVA: 0x347A33C Offset: 0x347633C VA: 0x347A33C
	public void .ctor(bool nullable) { }

	// RVA: 0x347A46C Offset: 0x347646C VA: 0x347A46C
	public void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x347A570 Offset: 0x3476570 VA: 0x347A570
	public void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x347A3C0 Offset: 0x34763C0 VA: 0x347A3C0
	public bool AddFC(RegexFC fc, bool concatenate) { }

	[CompilerGenerated]
	// RVA: 0x347A614 Offset: 0x3476614 VA: 0x347A614
	public bool get_CaseInsensitive() { }

	[CompilerGenerated]
	// RVA: 0x347A61C Offset: 0x347661C VA: 0x347A61C
	private void set_CaseInsensitive(bool value) { }

	// RVA: 0x3479714 Offset: 0x3475714 VA: 0x3479714
	public string GetFirstChars(CultureInfo culture) { }
}
