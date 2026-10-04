// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChainMethod<TVal> // TypeDefIndex: 391
{
	// Fields
	private ChainMethod.Operator<TVal> ope; // 0x0
	private Func<TVal, bool> method; // 0x0
	private ChainMethod<TVal> Prev; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<TVal, bool> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C77684 Offset: 0x2C73684 VA: 0x2C77684
	|-ChainMethod<object>..ctor
	|
	|-RVA: 0x2C77854 Offset: 0x2C73854 VA: 0x2C77854
	|-ChainMethod<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ChainMethod<TVal> AND(Func<TVal, bool> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C776C0 Offset: 0x2C736C0 VA: 0x2C776C0
	|-ChainMethod<object>.AND
	|
	|-RVA: 0x2C77890 Offset: 0x2C73890 VA: 0x2C77890
	|-ChainMethod<__Il2CppFullySharedGenericType>.AND
	*/

	// RVA: -1 Offset: -1
	public ChainMethod<TVal> OR(Func<TVal, bool> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C77740 Offset: 0x2C73740 VA: 0x2C77740
	|-ChainMethod<object>.OR
	|
	|-RVA: 0x2C77914 Offset: 0x2C73914 VA: 0x2C77914
	|-ChainMethod<__Il2CppFullySharedGenericType>.OR
	*/

	// RVA: -1 Offset: -1
	public bool Run(TVal x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C777C4 Offset: 0x2C737C4 VA: 0x2C777C4
	|-ChainMethod<object>.Run
	|
	|-RVA: 0x2C7799C Offset: 0x2C7399C VA: 0x2C7799C
	|-ChainMethod<__Il2CppFullySharedGenericType>.Run
	*/
}
