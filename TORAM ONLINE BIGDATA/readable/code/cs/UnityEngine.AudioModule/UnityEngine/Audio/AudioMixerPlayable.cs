// Assembly: UnityEngine.AudioModule.dll
// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
[StaticAccessor("AudioMixerPlayableBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable> // TypeDefIndex: 17814
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x37CB6D8 Offset: 0x37C76D8 VA: 0x37CB6D8 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x37CB6E4 Offset: 0x37C76E4 VA: 0x37CB6E4 Slot: 4
	public bool Equals(AudioMixerPlayable other) { }
}
