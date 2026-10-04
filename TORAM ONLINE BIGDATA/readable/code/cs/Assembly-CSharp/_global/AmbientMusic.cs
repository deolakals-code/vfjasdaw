// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AmbientMusic : MonoBehaviour // TypeDefIndex: 5188
{
	// Fields
	[SerializeField]
	private int soundId; // 0x20
	[SerializeField]
	private float volume; // 0x24
	[SerializeField]
	private float dist; // 0x28
	[SerializeField]
	private VolumeRolloffType rolloffType; // 0x2C

	// Properties
	public int SoundId { get; }
	public float Volume { get; }
	public float Dist { get; }
	public VolumeRolloffType RolloffType { get; }

	// Methods

	// RVA: 0x2605990 Offset: 0x2601990 VA: 0x2605990
	public int get_SoundId() { }

	// RVA: 0x2605998 Offset: 0x2601998 VA: 0x2605998
	public float get_Volume() { }

	// RVA: 0x26059A0 Offset: 0x26019A0 VA: 0x26059A0
	public float get_Dist() { }

	// RVA: 0x26059A8 Offset: 0x26019A8 VA: 0x26059A8
	public VolumeRolloffType get_RolloffType() { }

	// RVA: 0x26059B0 Offset: 0x26019B0 VA: 0x26059B0
	public void .ctor() { }
}
