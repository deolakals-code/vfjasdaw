// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Tween/Tween Volume")]
public class TweenVolume : UITweener // TypeDefIndex: 142
{
	// Fields
	[Range(0, 1)]
	public float from; // 0x74
	[Range(0, 1)]
	public float to; // 0x78
	private AudioSource mSource; // 0x80

	// Properties
	public AudioSource audioSource { get; }
	public float volume { get; set; }

	// Methods

	// RVA: 0x1EE0F98 Offset: 0x1EDCF98 VA: 0x1EE0F98
	public AudioSource get_audioSource() { }

	// RVA: 0x1EE10F4 Offset: 0x1EDD0F4 VA: 0x1EE10F4
	public float get_volume() { }

	// RVA: 0x1EE1188 Offset: 0x1EDD188 VA: 0x1EE1188
	public void set_volume(float value) { }

	// RVA: 0x1EE122C Offset: 0x1EDD22C VA: 0x1EE122C Slot: 4
	protected override void OnUpdate(float factor, bool isFinished) { }

	// RVA: 0x1EE1288 Offset: 0x1EDD288 VA: 0x1EE1288
	public static TweenVolume Begin(GameObject go, float duration, float targetVolume) { }

	// RVA: 0x1EE1328 Offset: 0x1EDD328 VA: 0x1EE1328
	public void .ctor() { }
}
