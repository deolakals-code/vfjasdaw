// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.LowLevel
[MovedFrom("UnityEngine.Experimental.LowLevel")]
public class PlayerLoop // TypeDefIndex: 16450
{
	// Methods

	// RVA: 0x37F78F4 Offset: 0x37F38F4 VA: 0x37F78F4
	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	// RVA: 0x37F7C38 Offset: 0x37F3C38 VA: 0x37F7C38
	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	// RVA: 0x37F7D20 Offset: 0x37F3D20 VA: 0x37F7D20
	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys) { }

	// RVA: 0x37F798C Offset: 0x37F398C VA: 0x37F798C
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) { }

	[NativeMethod(IsFreeFunction = True)]
	// RVA: 0x37F7964 Offset: 0x37F3964 VA: 0x37F7964
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	[NativeMethod(IsFreeFunction = True)]
	// RVA: 0x37F7F28 Offset: 0x37F3F28 VA: 0x37F7F28
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }
}
