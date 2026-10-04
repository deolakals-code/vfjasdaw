// Assembly: Newtonsoft.Json.dll
// Namespace: 
[Nullable(0)]
internal static class DynamicUtils.BinderWrapper // TypeDefIndex: 15914
{
	// Fields
	[Nullable(2)]
	private static object _getCSharpArgumentInfoArray; // 0x0
	[Nullable(2)]
	private static object _setCSharpArgumentInfoArray; // 0x8
	[Nullable(2)]
	private static MethodCall<object, object> _getMemberCall; // 0x10
	[Nullable(2)]
	private static MethodCall<object, object> _setMemberCall; // 0x18
	private static bool _init; // 0x20

	// Methods

	// RVA: 0x308C418 Offset: 0x3088418 VA: 0x308C418
	private static void Init() { }

	// RVA: 0x308C608 Offset: 0x3088608 VA: 0x308C608
	private static object CreateSharpArgumentInfoArray(int[] values) { }

	// RVA: 0x308C904 Offset: 0x3088904 VA: 0x308C904
	private static void CreateMemberCalls() { }

	// RVA: 0x308CE58 Offset: 0x3088E58 VA: 0x308CE58
	public static CallSiteBinder GetMember(string name, Type context) { }

	// RVA: 0x308D05C Offset: 0x308905C VA: 0x308D05C
	public static CallSiteBinder SetMember(string name, Type context) { }
}
