// Assembly: mscorlib.dll
// Namespace: System
public sealed class EventHandler<TEventArgs> : MulticastDelegate // TypeDefIndex: 9577
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FA9BC Offset: 0x29F69BC VA: 0x29FA9BC
	|-EventHandler<object>..ctor
	|
	|-RVA: 0x29FAADC Offset: 0x29F6ADC VA: 0x29FAADC
	|-EventHandler<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(object sender, TEventArgs e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FAAC8 Offset: 0x29F6AC8 VA: 0x29FAAC8
	|-EventHandler<object>.Invoke
	|
	|-RVA: 0x29FABE8 Offset: 0x29F6BE8 VA: 0x29FABE8
	|-EventHandler<__Il2CppFullySharedGenericType>.Invoke
	*/
}
