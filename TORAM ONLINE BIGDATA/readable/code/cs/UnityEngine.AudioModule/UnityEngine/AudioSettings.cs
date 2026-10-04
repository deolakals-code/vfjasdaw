// Assembly: UnityEngine.AudioModule.dll
// Namespace: UnityEngine
[StaticAccessor("GetAudioManager()", 0)]
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
public sealed class AudioSettings // TypeDefIndex: 17804
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action OnAudioSystemShuttingDown; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action OnAudioSystemStartedUp; // 0x10

	// Properties
	public static double dspTime { get; }

	// Methods

	[NativeMethod(Name = "GetDSPTime", IsThreadSafe = True)]
	// RVA: 0x37CA758 Offset: 0x37C6758 VA: 0x37CA758
	public static double get_dspTime() { }

	[RequiredByNativeCode]
	// RVA: 0x37CA780 Offset: 0x37C6780 VA: 0x37CA780
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x37CA7EC Offset: 0x37C67EC VA: 0x37CA7EC
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[RequiredByNativeCode]
	// RVA: 0x37CA850 Offset: 0x37C6850 VA: 0x37CA850
	internal static void InvokeOnAudioSystemStartedUp() { }

	// RVA: 0x37CA8B4 Offset: 0x37C68B4 VA: 0x37CA8B4
	internal static bool StartAudioOutput() { }

	// RVA: 0x37CA8DC Offset: 0x37C68DC VA: 0x37CA8DC
	internal static bool StopAudioOutput() { }
}
