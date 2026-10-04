// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
internal class AttributeHelperEngine // TypeDefIndex: 16330
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37E9E2C Offset: 0x37E5E2C VA: 0x37E9E2C
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCode]
	// RVA: 0x37E9F60 Offset: 0x37E5F60 VA: 0x37E9F60
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x37EA464 Offset: 0x37E6464 VA: 0x37EA464
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCode]
	// RVA: 0x37EA578 Offset: 0x37E6578 VA: 0x37EA578
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCode]
	// RVA: 0x37EA688 Offset: 0x37E6688 VA: 0x37EA688
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DB668 Offset: 0x27D7668 VA: 0x27DB668
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	*/

	// RVA: 0x37EA708 Offset: 0x37E6708 VA: 0x37EA708
	private static void .cctor() { }
}
