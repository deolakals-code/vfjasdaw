// Assembly: UnityEngine.PropertiesModule.dll
// Namespace: Unity.Properties
public class ReflectedMemberProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 17339
{
	// Fields
	private readonly IMemberInfo m_Info; // 0x0
	private readonly bool m_IsStructContainerType; // 0x0
	private ReflectedMemberProperty.GetStructValueAction<TContainer, TValue> m_GetStructValueAction; // 0x0
	private ReflectedMemberProperty.SetStructValueAction<TContainer, TValue> m_SetStructValueAction; // 0x0
	private ReflectedMemberProperty.GetClassValueAction<TContainer, TValue> m_GetClassValueAction; // 0x0
	private ReflectedMemberProperty.SetClassValueAction<TContainer, TValue> m_SetClassValueAction; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <IsReadOnly>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C54B94 Offset: 0x2C50B94 VA: 0x2C54B94
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IMemberInfo info, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C54B9C Offset: 0x2C50B9C VA: 0x2C54B9C
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
