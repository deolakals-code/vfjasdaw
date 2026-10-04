// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class BackgroundMusic : MonoBehaviour // TypeDefIndex: 5189
{
	// Fields
	[SerializeField]
	private AudioClip sound; // 0x20
	[SerializeField]
	private float loopStartTime; // 0x28
	[SerializeField]
	private float loopEndTime; // 0x2C
	[SerializeField]
	private bool allLoop; // 0x30
	[Range(0, 1)]
	[SerializeField]
	private float volume; // 0x34

	// Properties
	public AudioClip Sound { get; }
	public float LoopStartTime { get; }
	public float LoopEndTime { get; }
	public bool AllLoop { get; }
	public float Volume { get; }

	// Methods

	// RVA: 0x26059B8 Offset: 0x26019B8 VA: 0x26059B8
	public AudioClip get_Sound() { }

	// RVA: 0x26059C0 Offset: 0x26019C0 VA: 0x26059C0
	public float get_LoopStartTime() { }

	// RVA: 0x26059C8 Offset: 0x26019C8 VA: 0x26059C8
	public float get_LoopEndTime() { }

	// RVA: 0x26059D0 Offset: 0x26019D0 VA: 0x26059D0
	public bool get_AllLoop() { }

	// RVA: 0x26059D8 Offset: 0x26019D8 VA: 0x26059D8
	public float get_Volume() { }

	// RVA: 0x26059E0 Offset: 0x26019E0 VA: 0x26059E0
	public void .ctor() { }
}
