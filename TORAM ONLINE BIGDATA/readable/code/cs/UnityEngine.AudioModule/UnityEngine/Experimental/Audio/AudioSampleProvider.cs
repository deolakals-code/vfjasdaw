// Assembly: UnityEngine.AudioModule.dll
// Namespace: UnityEngine.Experimental.Audio
[StaticAccessor("AudioSampleProviderBindings", 2)]
[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
public class AudioSampleProvider // TypeDefIndex: 17812
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37CB4E4 Offset: 0x37C74E4 VA: 0x37CB4E4
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCode]
	// RVA: 0x37CB50C Offset: 0x37C750C VA: 0x37CB50C
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }
}
