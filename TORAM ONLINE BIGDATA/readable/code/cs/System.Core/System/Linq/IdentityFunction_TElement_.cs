// Assembly: System.Core.dll
// Namespace: System.Linq
internal class IdentityFunction<TElement> // TypeDefIndex: 15206
{
	// Properties
	public static Func<TElement, TElement> Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Func<TElement, TElement> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A208A8 Offset: 0x2A1C8A8 VA: 0x2A208A8
	|-IdentityFunction<int>.get_Instance
	|
	|-RVA: 0x2A20A78 Offset: 0x2A1CA78 VA: 0x2A20A78
	|-IdentityFunction<object>.get_Instance
	|
	|-RVA: 0x2A20C48 Offset: 0x2A1CC48 VA: 0x2A20C48
	|-IdentityFunction<__Il2CppFullySharedGenericType>.get_Instance
	*/
}
