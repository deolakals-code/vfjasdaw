// Assembly: UnityEngine.AudioModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", 2)]
public sealed class AudioClip : Object // TypeDefIndex: 17807
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties
	[NativeProperty("LengthSec")]
	public float length { get; }

	// Methods

	// RVA: 0x37CACB4 Offset: 0x37C6CB4 VA: 0x37CACB4
	private void .ctor() { }

	// RVA: 0x37CAD2C Offset: 0x37C6D2C VA: 0x37CAD2C
	public float get_length() { }

	[RequiredByNativeCode]
	// RVA: 0x37CAD68 Offset: 0x37C6D68 VA: 0x37CAD68
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCode]
	// RVA: 0x37CAD84 Offset: 0x37C6D84 VA: 0x37CAD84
	private void InvokePCMSetPositionCallback_Internal(int position) { }
}
