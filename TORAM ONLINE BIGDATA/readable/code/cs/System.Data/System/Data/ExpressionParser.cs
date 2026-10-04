// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class ExpressionParser // TypeDefIndex: 14732
{
	// Fields
	private static readonly ExpressionParser.ReservedWords[] s_reservedwords; // 0x0
	private char _escape; // 0x10
	private char _decimalSeparator; // 0x12
	private char _listSeparator; // 0x14
	private char _exponentL; // 0x16
	private char _exponentU; // 0x18
	internal char[] _text; // 0x20
	internal int _pos; // 0x28
	internal int _start; // 0x2C
	internal Tokens _token; // 0x30
	internal int _op; // 0x34
	internal OperatorInfo[] _ops; // 0x38
	internal int _topOperator; // 0x40
	internal int _topNode; // 0x44
	private readonly DataTable _table; // 0x48
	internal ExpressionNode[] _nodeStack; // 0x50
	internal int _prevOperand; // 0x58
	internal ExpressionNode _expression; // 0x60

	// Methods

	// RVA: 0x3200C90 Offset: 0x31FCC90 VA: 0x3200C90
	internal void .ctor(DataTable table) { }

	// RVA: 0x3200D54 Offset: 0x31FCD54 VA: 0x3200D54
	internal void LoadExpression(string data) { }

	// RVA: 0x3202220 Offset: 0x31FE220 VA: 0x3202220
	internal void StartScan() { }

	// RVA: 0x3200EC8 Offset: 0x31FCEC8 VA: 0x3200EC8
	internal ExpressionNode Parse() { }

	// RVA: 0x3202E84 Offset: 0x31FEE84 VA: 0x3202E84
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0x3202E48 Offset: 0x31FEE48 VA: 0x3202E48
	private ExpressionNode NodePop() { }

	// RVA: 0x3202DC4 Offset: 0x31FEDC4 VA: 0x3202DC4
	private ExpressionNode NodePeek() { }

	// RVA: 0x3202D2C Offset: 0x31FED2C VA: 0x3202D2C
	private void NodePush(ExpressionNode node) { }

	// RVA: 0x3202720 Offset: 0x31FE720 VA: 0x3202720
	private void BuildExpression(int pri) { }

	// RVA: 0x3202BE4 Offset: 0x31FEBE4 VA: 0x3202BE4
	internal void CheckToken(Tokens token) { }

	// RVA: 0x32022F4 Offset: 0x31FE2F4 VA: 0x32022F4
	internal Tokens Scan() { }

	// RVA: 0x32038C8 Offset: 0x31FF8C8 VA: 0x32038C8
	private void ScanNumeric() { }

	// RVA: 0x3203C28 Offset: 0x31FFC28 VA: 0x3203C28
	private void ScanName() { }

	// RVA: 0x32037BC Offset: 0x31FF7BC VA: 0x32037BC
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	// RVA: 0x320364C Offset: 0x31FF64C VA: 0x320364C
	private void ScanDate() { }

	// RVA: 0x32039F4 Offset: 0x31FF9F4 VA: 0x32039F4
	private void ScanBinaryConstant() { }

	// RVA: 0x3203A0C Offset: 0x31FFA0C VA: 0x3203A0C
	private void ScanReserved() { }

	// RVA: 0x32036EC Offset: 0x31FF6EC VA: 0x32036EC
	private void ScanString(char escape) { }

	// RVA: 0x32029C8 Offset: 0x31FE9C8 VA: 0x32029C8
	internal void ScanToken(Tokens token) { }

	// RVA: 0x32035F4 Offset: 0x31FF5F4 VA: 0x32035F4
	private void ScanWhite() { }

	// RVA: 0x3203DAC Offset: 0x31FFDAC VA: 0x3203DAC
	private bool IsWhiteSpace(char ch) { }

	// RVA: 0x3203BEC Offset: 0x31FFBEC VA: 0x3203BEC
	private bool IsAlphaNumeric(char ch) { }

	// RVA: 0x32039F8 Offset: 0x31FF9F8 VA: 0x32039F8
	private bool IsDigit(char ch) { }

	// RVA: 0x3203D30 Offset: 0x31FFD30 VA: 0x3203D30
	private bool IsAlpha(char ch) { }

	// RVA: 0x3203DC0 Offset: 0x31FFDC0 VA: 0x3203DC0
	private static void .cctor() { }
}
