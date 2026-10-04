// Assembly: System.Core.dll
// Namespace: System.Runtime.CompilerServices
[EditorBrowsable(1)]
[DebuggerStepThrough]
public static class CallSiteOps // TypeDefIndex: 15748
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static CallSite<T> CreateMatchmaker<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE600 Offset: 0x27DA600 VA: 0x27DE600
	|-CallSiteOps.CreateMatchmaker<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x3181930 Offset: 0x317D930 VA: 0x3181930
	public static bool SetNotMatched(CallSite site) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x3181950 Offset: 0x317D950 VA: 0x3181950
	public static bool GetMatch(CallSite site) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x3181968 Offset: 0x317D968 VA: 0x3181968
	public static void ClearMatch(CallSite site) { }

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static void AddRule<T>(CallSite<T> site, T rule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE560 Offset: 0x27DA560 VA: 0x27DE560
	|-CallSiteOps.AddRule<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static void UpdateRules<T>(CallSite<T> this, int matched) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE748 Offset: 0x27DA748 VA: 0x27DE748
	|-CallSiteOps.UpdateRules<object>
	*/

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static T[] GetRules<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE6C0 Offset: 0x27DA6C0 VA: 0x27DE6C0
	|-CallSiteOps.GetRules<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static RuleCache<T> GetRuleCache<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE67C Offset: 0x27DA67C VA: 0x27DE67C
	|-CallSiteOps.GetRuleCache<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static void MoveRule<T>(RuleCache<T> cache, T rule, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE6D8 Offset: 0x27DA6D8 VA: 0x27DE6D8
	|-CallSiteOps.MoveRule<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static T[] GetCachedRules<T>(RuleCache<T> cache) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE650 Offset: 0x27DA650 VA: 0x27DE650
	|-CallSiteOps.GetCachedRules<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static T Bind<T>(CallSiteBinder binder, CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DE5A8 Offset: 0x27DA5A8 VA: 0x27DE5A8
	|-CallSiteOps.Bind<object>
	*/
}
