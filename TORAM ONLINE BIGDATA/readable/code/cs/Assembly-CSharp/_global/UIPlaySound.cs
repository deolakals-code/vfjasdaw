// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Play Sound")]
public class UIPlaySound : MonoBehaviour // TypeDefIndex: 44
{
	// Fields
	public AudioClip audioClip; // 0x20
	public UIPlaySound.Trigger trigger; // 0x28
	[Range(0, 1)]
	public float volume; // 0x2C
	[Range(0, 2)]
	public float pitch; // 0x30

	// Methods

	// RVA: 0x171F6E4 Offset: 0x171B6E4 VA: 0x171F6E4
	private void OnHover(bool isOver) { }

	// RVA: 0x171F790 Offset: 0x171B790 VA: 0x171F790
	private void OnPress(bool isPressed) { }

	// RVA: 0x171F83C Offset: 0x171B83C VA: 0x171F83C
	private void OnClick() { }

	// RVA: 0x171F8D4 Offset: 0x171B8D4 VA: 0x171F8D4
	public void .ctor() { }
}
