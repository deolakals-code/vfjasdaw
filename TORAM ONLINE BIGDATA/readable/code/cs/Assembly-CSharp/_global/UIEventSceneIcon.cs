// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEventSceneIcon : MonoBehaviour // TypeDefIndex: 6405
{
	// Fields
	private int uuid; // 0x20
	private string title; // 0x28
	private string message; // 0x30
	private UIIcon m_effectIcon; // 0x38
	private TweenAlpha m_twa; // 0x40
	private readonly float _IconScale; // 0x48
	private readonly float _IconWidth; // 0x4C
	private IUIEventSceceIconResponse response; // 0x50

	// Properties
	public int Uuid { get; }

	// Methods

	// RVA: 0x19280E4 Offset: 0x19240E4 VA: 0x19280E4
	public int get_Uuid() { }

	// RVA: 0x19280EC Offset: 0x19240EC VA: 0x19280EC
	public void Initialize(IUIEventSceceIconResponse response, int uuid, int iconType, int iconid, string title, string message) { }

	// RVA: 0x1928480 Offset: 0x1924480 VA: 0x1928480
	public void UpdatePosition(float x, float y) { }

	// RVA: 0x19285B0 Offset: 0x19245B0 VA: 0x19285B0
	public void PlayTweenAlpha(float duration, float alpha) { }

	// RVA: 0x19286A4 Offset: 0x19246A4 VA: 0x19286A4
	private void OnClick() { }

	// RVA: 0x1928754 Offset: 0x1924754 VA: 0x1928754
	public void OnEventScenePopUpMessage() { }

	// RVA: 0x1928894 Offset: 0x1924894 VA: 0x1928894
	public void .ctor() { }
}
