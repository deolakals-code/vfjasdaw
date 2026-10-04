// Assembly: UnityEngine.AudioModule.dll
// Namespace: 
public static class AudioSettings.Mobile // TypeDefIndex: 17803
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static bool <muteState>k__BackingField; // 0x0
	private static bool _stopAudioOutputOnMute; // 0x1
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool> OnMuteStateChanged; // 0x8

	// Properties
	public static bool muteState { get; set; }
	public static bool stopAudioOutputOnMute { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37CA9BC Offset: 0x37C69BC VA: 0x37CA9BC
	public static bool get_muteState() { }

	[CompilerGenerated]
	// RVA: 0x37CAA04 Offset: 0x37C6A04 VA: 0x37CAA04
	private static void set_muteState(bool value) { }

	// RVA: 0x37CAA54 Offset: 0x37C6A54 VA: 0x37CAA54
	public static bool get_stopAudioOutputOnMute() { }

	[RequiredByNativeCode]
	// RVA: 0x37CAA9C Offset: 0x37C6A9C VA: 0x37CAA9C
	internal static void InvokeOnMuteStateChanged(bool mute) { }

	[RequiredByNativeCode]
	// RVA: 0x37CAC6C Offset: 0x37C6C6C VA: 0x37CAC6C
	internal static bool InvokeIsStopAudioOutputOnMuteEnabled() { }

	// RVA: 0x37CAC44 Offset: 0x37C6C44 VA: 0x37CAC44
	public static void StartAudioOutput() { }

	// RVA: 0x37CAC1C Offset: 0x37C6C1C VA: 0x37CAC1C
	public static void StopAudioOutput() { }
}
