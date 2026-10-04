// Assembly: mscorlib.dll
// Namespace: System.Security.Util
internal sealed class Parser // TypeDefIndex: 10078
{
	// Fields
	private SecurityDocument _doc; // 0x10
	private Tokenizer _t; // 0x18

	// Methods

	// RVA: 0x2EA60F8 Offset: 0x2EA20F8 VA: 0x2EA60F8
	internal SecurityElement GetTopElement() { }

	// RVA: 0x2EA6120 Offset: 0x2EA2120 VA: 0x2EA6120
	private void GetRequiredSizes(TokenizerStream stream, ref int index) { }

	// RVA: 0x2EA6664 Offset: 0x2EA2664 VA: 0x2EA6664
	private int DetermineFormat(TokenizerStream stream) { }

	// RVA: 0x2EA7280 Offset: 0x2EA3280 VA: 0x2EA7280
	private void ParseContents() { }

	// RVA: 0x2EA76E8 Offset: 0x2EA36E8 VA: 0x2EA76E8
	private void .ctor(Tokenizer t) { }

	// RVA: 0x2EA77AC Offset: 0x2EA37AC VA: 0x2EA77AC
	internal void .ctor(string input) { }
}
