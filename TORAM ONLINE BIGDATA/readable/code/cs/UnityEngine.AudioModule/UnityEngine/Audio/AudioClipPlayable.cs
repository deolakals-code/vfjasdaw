// Assembly: UnityEngine.AudioModule.dll
// Namespace: UnityEngine.Audio
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[StaticAccessor("AudioClipPlayableBindings", 2)]
[RequiredByNativeCode]
public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 17813
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x37CB654 Offset: 0x37C7654 VA: 0x37CB654 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37CB660 Offset: 0x37C7660 VA: 0x37CB660 Slot: 4
	public bool Equals(AudioClipPlayable other) { }
}
