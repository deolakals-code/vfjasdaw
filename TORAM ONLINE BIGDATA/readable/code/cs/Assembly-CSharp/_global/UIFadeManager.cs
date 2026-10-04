// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFadeManager // TypeDefIndex: 8914
{
	// Fields
	private Dictionary<UIFadeManager.UIType, UIFadeManager.AlphaState> uiList; // 0x10
	private bool isBattle; // 0x18
	private bool menu; // 0x19
	private bool pushChatWindow; // 0x1A
	private byte isFadeFlag; // 0x1B
	private bool isUpdateFade; // 0x1C

	// Properties
	public byte IsFadeFlag { get; }
	public bool PushChatWindow { set; }

	// Methods

	// RVA: 0x1E525E4 Offset: 0x1E4E5E4 VA: 0x1E525E4
	public byte get_IsFadeFlag() { }

	// RVA: 0x1E527F0 Offset: 0x1E4E7F0 VA: 0x1E527F0
	public void set_PushChatWindow(bool value) { }

	// RVA: 0x1E527FC Offset: 0x1E4E7FC VA: 0x1E527FC
	public void Update() { }

	// RVA: 0x1E52E64 Offset: 0x1E4EE64 VA: 0x1E52E64
	public void OnRegistration(UIFadeManager.UIType uiType, UIWidget widget) { }

	// RVA: 0x1E53260 Offset: 0x1E4F260 VA: 0x1E53260
	public void OnRegistration(UIFadeManager.UIType uiType, UIGLWidget widget) { }

	// RVA: 0x1E53550 Offset: 0x1E4F550 VA: 0x1E53550
	public bool RemoveUI(UIFadeManager.UIType uiType) { }

	// RVA: 0x1E535E0 Offset: 0x1E4F5E0 VA: 0x1E535E0
	public bool Remove(UIFadeManager.UIType uiType, UIWidget widget) { }

	// RVA: 0x1E536E8 Offset: 0x1E4F6E8 VA: 0x1E536E8
	public bool Remove(UIFadeManager.UIType uiType, UIGLWidget widget) { }

	// RVA: 0x1E537F0 Offset: 0x1E4F7F0 VA: 0x1E537F0
	public bool Get(UIFadeManager.UIType uiType, ref UIFadeManager.AlphaState state) { }

	// RVA: 0x1E5389C Offset: 0x1E4F89C VA: 0x1E5389C
	public void Fade(UIFadeManager.UIType uiType, UIFadeManager.AlphaState.Fade fade) { }

	// RVA: 0x1E53954 Offset: 0x1E4F954 VA: 0x1E53954
	public bool FixationAlpha(UIFadeManager.UIType uiType, float alpha) { }

	// RVA: 0x1E53A58 Offset: 0x1E4FA58 VA: 0x1E53A58
	public bool StartFadeIn(UIFadeManager.UIType uiType, float changeValue = 0.5) { }

	// RVA: 0x1E53B50 Offset: 0x1E4FB50 VA: 0x1E53B50
	public bool StartFadeOut(UIFadeManager.UIType uiType, float changeValue = 0.5) { }

	// RVA: 0x1E53C48 Offset: 0x1E4FC48 VA: 0x1E53C48
	public bool StartFadeOutTimer(UIFadeManager.UIType uiType, float timer, float timerChangeValue = 0.5) { }

	// RVA: 0x1E52794 Offset: 0x1E4E794 VA: 0x1E52794
	public bool CheckFlag(UIFadeManager.UIType uiType) { }

	// RVA: 0x1E53D24 Offset: 0x1E4FD24 VA: 0x1E53D24
	public void FadeOutCloseMenu() { }

	// RVA: 0x1E53E50 Offset: 0x1E4FE50 VA: 0x1E53E50
	public void FadeOutCloseMainUI() { }

	// RVA: 0x1E53EC0 Offset: 0x1E4FEC0 VA: 0x1E53EC0
	public void MaxAlphaOpenUI() { }

	// RVA: 0x1E52A44 Offset: 0x1E4EA44 VA: 0x1E52A44
	public void FadeOutBattleEnd() { }

	// RVA: 0x1E52AF4 Offset: 0x1E4EAF4 VA: 0x1E52AF4
	public void FadeInGetHate() { }

	// RVA: 0x1E53F3C Offset: 0x1E4FF3C VA: 0x1E53F3C
	public void FadeInTargetOn() { }

	// RVA: 0x1E53F48 Offset: 0x1E4FF48 VA: 0x1E53F48
	public void FadeOutTargetOff() { }

	// RVA: 0x1E53F6C Offset: 0x1E4FF6C VA: 0x1E53F6C
	public void FadeInOutUpdateChat() { }

	// RVA: 0x1E53FA8 Offset: 0x1E4FFA8 VA: 0x1E53FA8
	public void FadeInSlideChat() { }

	// RVA: 0x1E54020 Offset: 0x1E50020 VA: 0x1E54020
	public void FadeOutNotSlideChat() { }

	// RVA: 0x1E54098 Offset: 0x1E50098 VA: 0x1E54098
	public void ResetAlphaUI() { }

	// RVA: 0x1E54218 Offset: 0x1E50218 VA: 0x1E54218
	public void .ctor() { }
}
