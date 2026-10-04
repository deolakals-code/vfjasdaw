// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.XPath
internal class XPathParser // TypeDefIndex: 13886
{
	// Fields
	private XPathScanner _scanner; // 0x10
	private int _parseDepth; // 0x18
	private static readonly XPathResultType[] s_temparray1; // 0x0
	private static readonly XPathResultType[] s_temparray2; // 0x8
	private static readonly XPathResultType[] s_temparray3; // 0x10
	private static readonly XPathResultType[] s_temparray4; // 0x18
	private static readonly XPathResultType[] s_temparray5; // 0x20
	private static readonly XPathResultType[] s_temparray6; // 0x28
	private static readonly XPathResultType[] s_temparray7; // 0x30
	private static readonly XPathResultType[] s_temparray8; // 0x38
	private static readonly XPathResultType[] s_temparray9; // 0x40
	private static Dictionary<string, XPathParser.ParamInfo> s_functionTable; // 0x48
	private static Dictionary<string, Axis.AxisType> s_AxesTable; // 0x50

	// Methods

	// RVA: 0x3382DC4 Offset: 0x337EDC4 VA: 0x3382DC4
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x3382DF4 Offset: 0x337EDF4 VA: 0x3382DF4
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	// RVA: 0x3382F9C Offset: 0x337EF9C VA: 0x3382F9C
	private AstNode ParseExpression(AstNode qyInput) { }

	// RVA: 0x3383000 Offset: 0x337F000 VA: 0x3383000
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x33830E4 Offset: 0x337F0E4 VA: 0x33830E4
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x338322C Offset: 0x337F22C VA: 0x338322C
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x3383304 Offset: 0x337F304 VA: 0x3383304
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x3383404 Offset: 0x337F404 VA: 0x3383404
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x33834DC Offset: 0x337F4DC VA: 0x33834DC
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x3383608 Offset: 0x337F608 VA: 0x3383608
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x33836D8 Offset: 0x337F6D8 VA: 0x33836D8
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x338394C Offset: 0x337F94C VA: 0x338394C
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x33837D8 Offset: 0x337F7D8 VA: 0x33837D8
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x3383AF0 Offset: 0x337FAF0 VA: 0x3383AF0
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x3383FC8 Offset: 0x337FFC8 VA: 0x3383FC8
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x3383C68 Offset: 0x337FC68 VA: 0x3383C68
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x3383BA0 Offset: 0x337FBA0 VA: 0x3383BA0
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x3384054 Offset: 0x3380054 VA: 0x3384054
	private static bool IsStep(XPathScanner.LexKind lexKind) { }

	// RVA: 0x3384098 Offset: 0x3380098 VA: 0x3384098
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x33842E8 Offset: 0x33802E8 VA: 0x33842E8
	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x3383A40 Offset: 0x337FA40 VA: 0x3383A40
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x3383DA8 Offset: 0x337FDA8 VA: 0x3383DA8
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x3384650 Offset: 0x3380650 VA: 0x3384650
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x33845EC Offset: 0x33805EC VA: 0x33845EC
	private void CheckToken(XPathScanner.LexKind t) { }

	// RVA: 0x3384034 Offset: 0x3380034 VA: 0x3384034
	private void PassToken(XPathScanner.LexKind t) { }

	// RVA: 0x3383214 Offset: 0x337F214 VA: 0x3383214
	private void NextLex() { }

	// RVA: 0x33831C8 Offset: 0x337F1C8 VA: 0x33831C8
	private bool TestOp(string op) { }

	// RVA: 0x33838F0 Offset: 0x337F8F0 VA: 0x33838F0
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x3384FB0 Offset: 0x3380FB0 VA: 0x3384FB0
	private static Dictionary<string, XPathParser.ParamInfo> CreateFunctionTable() { }

	// RVA: 0x3385BDC Offset: 0x3381BDC VA: 0x3385BDC
	private static Dictionary<string, Axis.AxisType> CreateAxesTable() { }

	// RVA: 0x3384200 Offset: 0x3380200 VA: 0x3384200
	private Axis.AxisType GetAxis() { }

	// RVA: 0x3385E8C Offset: 0x3381E8C VA: 0x3385E8C
	private static void .cctor() { }
}
