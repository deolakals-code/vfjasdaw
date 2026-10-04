// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class DelegateProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 17328
{
	// Fields
	private readonly PropertyGetter<TContainer, TValue> m_Getter; // 0x0
	private readonly PropertySetter<TContainer, TValue> m_Setter; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB3A0 Offset: 0x2DC73A0 VA: 0x2DCB3A0
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name, PropertyGetter<TContainer, TValue> getter, PropertySetter<TContainer, TValue> setter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCB3A8 Offset: 0x2DC73A8 VA: 0x2DCB3A8
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
