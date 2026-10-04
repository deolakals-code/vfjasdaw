// Assembly: System.Core.dll
// Namespace: System.Runtime.CompilerServices
public class CallSite<T> : CallSite // TypeDefIndex: 15745
{
	// Fields
	public T Target; // 0x0
	internal T[] Rules; // 0x0
	private static T s_cachedUpdate; // 0x0
	private static T s_cachedNoMatch; // 0x0

	// Properties
	public T Update { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C74B94 Offset: 0x2C70B94 VA: 0x2C74B94
	|-CallSite<object>.get_Update
	*/

	// RVA: -1 Offset: -1
	private void .ctor(CallSiteBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C74BDC Offset: 0x2C70BDC VA: 0x2C74BDC
	|-CallSite<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C74C20 Offset: 0x2C70C20 VA: 0x2C74C20
	|-CallSite<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal CallSite<T> CreateMatchMaker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C74C2C Offset: 0x2C70C2C VA: 0x2C74C2C
	|-CallSite<object>.CreateMatchMaker
	*/

	// RVA: -1 Offset: -1
	public static CallSite<T> Create(CallSiteBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C74C68 Offset: 0x2C70C68 VA: 0x2C74C68
	|-CallSite<object>.Create
	*/

	// RVA: -1 Offset: -1
	private T GetUpdateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C74DC8 Offset: 0x2C70DC8 VA: 0x2C74DC8
	|-CallSite<object>.GetUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T GetUpdateDelegate(ref T addr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C74E18 Offset: 0x2C70E18 VA: 0x2C74E18
	|-CallSite<object>.GetUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	internal void AddRule(T newRule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C74E58 Offset: 0x2C70E58 VA: 0x2C74E58
	|-CallSite<object>.AddRule
	*/

	// RVA: -1 Offset: -1
	internal void MoveRule(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C74F54 Offset: 0x2C70F54 VA: 0x2C74F54
	|-CallSite<object>.MoveRule
	*/

	// RVA: -1 Offset: -1
	internal T MakeUpdateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C75014 Offset: 0x2C71014 VA: 0x2C75014
	|-CallSite<object>.MakeUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T CreateCustomUpdateDelegate(MethodInfo invoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7512C Offset: 0x2C7112C VA: 0x2C7512C
	|-CallSite<object>.CreateCustomUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T CreateCustomNoMatchDelegate(MethodInfo invoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C764E4 Offset: 0x2C724E4 VA: 0x2C764E4
	|-CallSite<object>.CreateCustomNoMatchDelegate
	*/

	// RVA: -1 Offset: -1
	private static Expression Convert(Expression arg, Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7680C Offset: 0x2C7280C VA: 0x2C7680C
	|-CallSite<object>.Convert
	*/
}
