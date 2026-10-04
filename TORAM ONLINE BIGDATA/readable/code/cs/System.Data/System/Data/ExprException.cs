// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class ExprException // TypeDefIndex: 14738
{
	// Methods

	// RVA: 0x32042A8 Offset: 0x32002A8 VA: 0x32042A8
	private static OverflowException _Overflow(string error) { }

	// RVA: 0x3204310 Offset: 0x3200310 VA: 0x3204310
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0x3204378 Offset: 0x3200378 VA: 0x3204378
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0x32043E0 Offset: 0x32003E0 VA: 0x32043E0
	private static EvaluateException _Eval(string error) { }

	// RVA: 0x3204448 Offset: 0x3200448 VA: 0x3204448
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0x320208C Offset: 0x31FE08C VA: 0x320208C
	public static Exception InvokeArgument() { }

	// RVA: 0x32044B0 Offset: 0x32004B0 VA: 0x32044B0
	public static Exception NYI(string moreinfo) { }

	// RVA: 0x3202694 Offset: 0x31FE694 VA: 0x3202694
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0x3202978 Offset: 0x31FE978 VA: 0x3202978
	public static Exception MissingOperator(string token) { }

	// RVA: 0x3204500 Offset: 0x3200500 VA: 0x3204500
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0x3204550 Offset: 0x3200550 VA: 0x3204550
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0x32034A4 Offset: 0x31FF4A4 VA: 0x32034A4
	public static Exception ExpressionTooComplex() { }

	// RVA: 0x31F6F40 Offset: 0x31F2F40 VA: 0x31F6F40
	public static Exception UnboundName(string name) { }

	// RVA: 0x3203D5C Offset: 0x31FFD5C VA: 0x3203D5C
	public static Exception InvalidString(string str) { }

	// RVA: 0x31F6B94 Offset: 0x31F2B94 VA: 0x31F6B94
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0x3202E08 Offset: 0x31FEE08 VA: 0x3202E08
	public static Exception SyntaxError() { }

	// RVA: 0x32045B8 Offset: 0x32005B8 VA: 0x32045B8
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0x3202938 Offset: 0x31FE938 VA: 0x3202938
	public static Exception MissingRightParen() { }

	// RVA: 0x32033C0 Offset: 0x31FF3C0 VA: 0x32033C0
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0x32034E4 Offset: 0x31FF4E4 VA: 0x32034E4
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0x3204608 Offset: 0x3200608 VA: 0x3204608
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0x3201F24 Offset: 0x31FDF24 VA: 0x3201F24
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0x3204694 Offset: 0x3200694 VA: 0x3204694
	public static Exception InvalidName(string name) { }

	// RVA: 0x3203CE0 Offset: 0x31FFCE0 VA: 0x3203CE0
	public static Exception InvalidDate(string date) { }

	// RVA: 0x32046E4 Offset: 0x32006E4 VA: 0x32046E4
	public static Exception NonConstantArgument() { }

	// RVA: 0x31FFF44 Offset: 0x31FBF44 VA: 0x31FFF44
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0x31FF208 Offset: 0x31FB208 VA: 0x31FF208
	public static Exception InWithoutParentheses() { }

	// RVA: 0x3204724 Offset: 0x3200724 VA: 0x3204724
	public static Exception InWithoutList() { }

	// RVA: 0x31FD2B4 Offset: 0x31F92B4 VA: 0x31FD2B4
	public static Exception InvalidIsSyntax() { }

	// RVA: 0x31FF2C8 Offset: 0x31FB2C8 VA: 0x31FF2C8
	public static Exception Overflow(Type type) { }

	// RVA: 0x3204764 Offset: 0x3200764 VA: 0x3204764
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0x320482C Offset: 0x320082C VA: 0x320482C
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0x31FD648 Offset: 0x31F9648 VA: 0x31FD648
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0x31FF5D0 Offset: 0x31FB5D0 VA: 0x31FF5D0
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0x31FF248 Offset: 0x31FB248 VA: 0x31FF248
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0x3203C90 Offset: 0x31FFC90 VA: 0x3203C90
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0x32031C0 Offset: 0x31FF1C0 VA: 0x32031C0
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0x320312C Offset: 0x31FF12C VA: 0x320312C
	public static Exception TooManyRightParentheses() { }

	// RVA: 0x31F6EE0 Offset: 0x31F2EE0 VA: 0x31F6EE0
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0x32048D0 Offset: 0x32008D0 VA: 0x32048D0
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0x3203464 Offset: 0x31FF464 VA: 0x3203464
	public static Exception AggregateArgument() { }

	// RVA: 0x31F6E90 Offset: 0x31F2E90 VA: 0x31F6E90
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0x31F747C Offset: 0x31F347C VA: 0x31F747C
	public static Exception EvalNoContext() { }

	// RVA: 0x3204920 Offset: 0x3200920 VA: 0x3204920
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0x31F7530 Offset: 0x31F3530 VA: 0x31F7530
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0x32020D0 Offset: 0x31FE0D0 VA: 0x32020D0
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0x3202C28 Offset: 0x31FEC28 VA: 0x3202C28
	public static Exception LookupArgument() { }

	// RVA: 0x3204970 Offset: 0x3200970 VA: 0x3204970
	public static Exception InvalidType(string typeName) { }

	// RVA: 0x32049C0 Offset: 0x32009C0 VA: 0x32049C0
	public static Exception InvalidHoursArgument() { }

	// RVA: 0x3204A00 Offset: 0x3200A00 VA: 0x3204A00
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0x3204A40 Offset: 0x3200A40 VA: 0x3204A40
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0x3204A80 Offset: 0x3200A80 VA: 0x3204A80
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0x3200E54 Offset: 0x31FCE54 VA: 0x3200E54
	public static Exception UnsupportedDataType(Type type) { }
}
