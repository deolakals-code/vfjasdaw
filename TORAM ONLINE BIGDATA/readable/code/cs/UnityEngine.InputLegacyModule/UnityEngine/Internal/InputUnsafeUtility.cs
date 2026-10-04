// Assembly: UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine.Internal
[NativeHeader("Runtime/Input/InputBindings.h")]
internal static class InputUnsafeUtility // TypeDefIndex: 17771
{
	// Methods

	[NativeThrows]
	// RVA: 0x3818308 Offset: 0x3814308 VA: 0x3818308
	internal static bool GetKeyString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x381834C Offset: 0x381434C VA: 0x381834C
	internal static bool GetKeyUpString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x3818390 Offset: 0x3814390 VA: 0x3818390
	internal static bool GetKeyDownString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x3816900 Offset: 0x3812900 VA: 0x3816900
	internal static float GetAxis(string axisName) { }

	[NativeThrows]
	// RVA: 0x38183D4 Offset: 0x38143D4 VA: 0x38183D4
	internal static float GetAxis__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x3818418 Offset: 0x3814418 VA: 0x3818418
	internal static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x381845C Offset: 0x381445C VA: 0x381845C
	internal static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x38184A0 Offset: 0x38144A0 VA: 0x38184A0
	internal static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x38184E4 Offset: 0x38144E4 VA: 0x38184E4
	internal static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen) { }
}
