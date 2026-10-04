// Assembly: UnityEngine.AudioModule.dll
// Namespace: UnityEngine
[StaticAccessor("AudioSourceBindings", 2)]
[RequireComponent(typeof(Transform))]
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 17810
{
	// Properties
	public float volume { get; set; }
	public float pitch { set; }
	[NativeProperty("SecPosition")]
	public float time { get; set; }
	[NativeProperty("AudioClip")]
	public AudioClip clip { get; set; }
	public bool isPlaying { get; }
	public bool loop { get; set; }
	public bool mute { set; }

	// Methods

	// RVA: 0x37CAF20 Offset: 0x37C6F20 VA: 0x37CAF20
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x37CAF6C Offset: 0x37C6F6C VA: 0x37CAF6C
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x37CAFB0 Offset: 0x37C6FB0 VA: 0x37CAFB0
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x37CB004 Offset: 0x37C7004 VA: 0x37CB004
	private void Stop(bool stopOneShots) { }

	// RVA: 0x37CB048 Offset: 0x37C7048 VA: 0x37CB048
	public float get_volume() { }

	// RVA: 0x37CB084 Offset: 0x37C7084 VA: 0x37CB084
	public void set_volume(float value) { }

	// RVA: 0x37CB0D0 Offset: 0x37C70D0 VA: 0x37CB0D0
	public void set_pitch(float value) { }

	// RVA: 0x37CB11C Offset: 0x37C711C VA: 0x37CB11C
	public float get_time() { }

	// RVA: 0x37CB158 Offset: 0x37C7158 VA: 0x37CB158
	public void set_time(float value) { }

	// RVA: 0x37CB1A4 Offset: 0x37C71A4 VA: 0x37CB1A4
	public AudioClip get_clip() { }

	// RVA: 0x37CB1E0 Offset: 0x37C71E0 VA: 0x37CB1E0
	public void set_clip(AudioClip value) { }

	[ExcludeFromDocs]
	// RVA: 0x37CB224 Offset: 0x37C7224 VA: 0x37CB224
	public void Play() { }

	// RVA: 0x37CB264 Offset: 0x37C7264 VA: 0x37CB264
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x37CB360 Offset: 0x37C7360 VA: 0x37CB360
	public void Stop() { }

	// RVA: 0x37CB3A0 Offset: 0x37C73A0 VA: 0x37CB3A0
	public void Pause() { }

	[NativeName("IsPlayingScripting")]
	// RVA: 0x37CB3DC Offset: 0x37C73DC VA: 0x37CB3DC
	public bool get_isPlaying() { }

	// RVA: 0x37CB418 Offset: 0x37C7418 VA: 0x37CB418
	public bool get_loop() { }

	// RVA: 0x37CB454 Offset: 0x37C7454 VA: 0x37CB454
	public void set_loop(bool value) { }

	// RVA: 0x37CB498 Offset: 0x37C7498 VA: 0x37CB498
	public void set_mute(bool value) { }

	// RVA: 0x37CB4DC Offset: 0x37C74DC VA: 0x37CB4DC
	public void .ctor() { }
}
