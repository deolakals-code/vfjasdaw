// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
internal sealed class RegexNode // TypeDefIndex: 14086
{
	// Fields
	public int NType; // 0x10
	public List<RegexNode> Children; // 0x18
	public string Str; // 0x20
	public char Ch; // 0x28
	public int M; // 0x2C
	public int N; // 0x30
	public readonly RegexOptions Options; // 0x34
	public RegexNode Next; // 0x38

	// Methods

	// RVA: 0x347CFC0 Offset: 0x3478FC0 VA: 0x347CFC0
	public void .ctor(int type, RegexOptions options) { }

	// RVA: 0x347CFF0 Offset: 0x3478FF0 VA: 0x347CFF0
	public void .ctor(int type, RegexOptions options, char ch) { }

	// RVA: 0x347D030 Offset: 0x3479030 VA: 0x347D030
	public void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x347D078 Offset: 0x3479078 VA: 0x347D078
	public void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x347D0B8 Offset: 0x34790B8 VA: 0x347D0B8
	public void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x347D0FC Offset: 0x34790FC VA: 0x347D0FC
	public bool UseOptionR() { }

	// RVA: 0x347D108 Offset: 0x3479108 VA: 0x347D108
	public RegexNode ReverseLeft() { }

	// RVA: 0x347D184 Offset: 0x3479184 VA: 0x347D184
	private void MakeRep(int type, int min, int max) { }

	// RVA: 0x347D19C Offset: 0x347919C VA: 0x347D19C
	private RegexNode Reduce() { }

	// RVA: 0x347DCA0 Offset: 0x3479CA0 VA: 0x347DCA0
	private RegexNode StripEnation(int emptyType) { }

	// RVA: 0x347DB30 Offset: 0x3479B30 VA: 0x347DB30
	private RegexNode ReduceGroup() { }

	// RVA: 0x347D9A8 Offset: 0x34799A8 VA: 0x347D9A8
	private RegexNode ReduceRep() { }

	// RVA: 0x347DB5C Offset: 0x3479B5C VA: 0x347DB5C
	private RegexNode ReduceSet() { }

	// RVA: 0x347D204 Offset: 0x3479204 VA: 0x347D204
	private RegexNode ReduceAlternation() { }

	// RVA: 0x347D5EC Offset: 0x34795EC VA: 0x347D5EC
	private RegexNode ReduceConcatenation() { }

	// RVA: 0x347DD54 Offset: 0x3479D54 VA: 0x347DD54
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x347DE6C Offset: 0x3479E6C VA: 0x347DE6C
	public void AddChild(RegexNode newChild) { }

	// RVA: 0x3479A0C Offset: 0x3475A0C VA: 0x3479A0C
	public RegexNode Child(int i) { }

	// RVA: 0x34799C0 Offset: 0x34759C0 VA: 0x34799C0
	public int ChildCount() { }

	// RVA: 0x347DF9C Offset: 0x3479F9C VA: 0x347DF9C
	public int Type() { }
}
