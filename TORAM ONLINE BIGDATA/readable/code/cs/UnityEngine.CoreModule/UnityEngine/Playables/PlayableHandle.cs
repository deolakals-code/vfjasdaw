// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Playables
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 16657
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	[VisibleToOtherModules]
	// RVA: -1 Offset: -1
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DE978 Offset: 0x26DA978 VA: 0x26DE978
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|
	|-RVA: 0x26DEA28 Offset: 0x26DAA28 VA: 0x26DEA28
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|
	|-RVA: 0x26DEAD8 Offset: 0x26DAAD8 VA: 0x26DEAD8
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0x26DEB88 Offset: 0x26DAB88 VA: 0x26DEB88
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|
	|-RVA: 0x26DEC38 Offset: 0x26DAC38 VA: 0x26DEC38
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|
	|-RVA: 0x26DECE8 Offset: 0x26DACE8 VA: 0x26DECE8
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|
	|-RVA: 0x26DED98 Offset: 0x26DAD98 VA: 0x26DED98
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|
	|-RVA: 0x26DEE48 Offset: 0x26DAE48 VA: 0x26DEE48
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	|
	|-RVA: 0x26DEEF8 Offset: 0x26DAEF8 VA: 0x26DEEF8
	|-PlayableHandle.IsPlayableOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37FCC14 Offset: 0x37F8C14 VA: 0x37FCC14
	public static PlayableHandle get_Null() { }

	// RVA: 0x37FCB1C Offset: 0x37F8B1C VA: 0x37FCB1C
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x37FCFBC Offset: 0x37F8FBC VA: 0x37FCFBC Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x37FD064 Offset: 0x37F9064 VA: 0x37FD064 Slot: 4
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x37FD0E4 Offset: 0x37F90E4 VA: 0x37FD0E4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37FCF88 Offset: 0x37F8F88 VA: 0x37FCF88
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModules]
	// RVA: 0x37FD118 Offset: 0x37F9118 VA: 0x37FD118
	internal bool IsValid() { }

	[VisibleToOtherModules]
	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37FD1C8 Offset: 0x37F91C8 VA: 0x37FD1C8
	internal Type GetPlayableType() { }

	// RVA: 0x37FD278 Offset: 0x37F9278 VA: 0x37FD278
	private static void .cctor() { }

	// RVA: 0x37FD18C Offset: 0x37F918C VA: 0x37FD18C
	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x37FD23C Offset: 0x37F923C VA: 0x37FD23C
	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }
}
