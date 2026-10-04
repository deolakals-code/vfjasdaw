// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/BaseClasses/BitField.h")]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeClass("BitField", "struct BitField;")]
public struct LayerMask // TypeDefIndex: 16357
{
	// Fields
	[NativeName("m_Bits")]
	private int m_Mask; // 0x0

	// Methods

	// RVA: 0x37EC684 Offset: 0x37E8684 VA: 0x37EC684
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x37EC688 Offset: 0x37E8688 VA: 0x37EC688
	public static LayerMask op_Implicit(int intVal) { }

	[NativeMethod("LayerToString")]
	[StaticAccessor("GetTagManager()", 0)]
	// RVA: 0x37EC690 Offset: 0x37E8690 VA: 0x37EC690
	public static string LayerToName(int layer) { }

	[StaticAccessor("GetTagManager()", 0)]
	[NativeMethod("StringToLayer")]
	// RVA: 0x37EC6CC Offset: 0x37E86CC VA: 0x37EC6CC
	public static int NameToLayer(string layerName) { }

	// RVA: 0x37EC708 Offset: 0x37E8708 VA: 0x37EC708
	public static int GetMask(string[] layerNames) { }
}
