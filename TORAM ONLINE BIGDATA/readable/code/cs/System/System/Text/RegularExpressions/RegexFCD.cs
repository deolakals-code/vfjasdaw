// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct RegexFCD // TypeDefIndex: 14082
{
	// Fields
	private readonly List<RegexFC> _fcStack; // 0x0
	private ValueListBuilder<int> _intStack; // 0x8
	private bool _skipAllChildren; // 0x28
	private bool _skipchild; // 0x29
	private bool _failed; // 0x2A

	// Methods

	// RVA: 0x34792F4 Offset: 0x34752F4 VA: 0x34792F4
	private void .ctor(Span<int> intStack) { }

	// RVA: 0x34793C8 Offset: 0x34753C8 VA: 0x34793C8
	public static Nullable<RegexPrefix> FirstChars(RegexTree t) { }

	// RVA: 0x3479774 Offset: 0x3475774 VA: 0x3479774
	public static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x3479A64 Offset: 0x3475A64 VA: 0x3479A64
	public static int Anchors(RegexTree tree) { }

	// RVA: 0x3479B94 Offset: 0x3475B94 VA: 0x3479B94
	private static int AnchorFromType(int type) { }

	// RVA: 0x3479C04 Offset: 0x3475C04 VA: 0x3479C04
	private void PushInt(int i) { }

	// RVA: 0x3479CB8 Offset: 0x3475CB8 VA: 0x3479CB8
	private bool IntIsEmpty() { }

	// RVA: 0x3479CFC Offset: 0x3475CFC VA: 0x3479CFC
	private int PopInt() { }

	// RVA: 0x3479D58 Offset: 0x3475D58 VA: 0x3479D58
	private void PushFC(RegexFC fc) { }

	// RVA: 0x3479E04 Offset: 0x3475E04 VA: 0x3479E04
	private bool FCIsEmpty() { }

	// RVA: 0x3479E54 Offset: 0x3475E54 VA: 0x3479E54
	private RegexFC PopFC() { }

	// RVA: 0x3479ED0 Offset: 0x3475ED0 VA: 0x3479ED0
	private RegexFC TopFC() { }

	// RVA: 0x34796CC Offset: 0x34756CC VA: 0x34796CC
	public void Dispose() { }

	// RVA: 0x3479534 Offset: 0x3475534 VA: 0x3479534
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x347A330 Offset: 0x3476330 VA: 0x347A330
	private void SkipChild() { }

	// RVA: 0x3479F34 Offset: 0x3475F34 VA: 0x3479F34
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }
}
