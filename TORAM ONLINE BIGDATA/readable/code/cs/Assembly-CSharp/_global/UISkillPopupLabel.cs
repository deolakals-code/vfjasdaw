// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISkillPopupLabel : MonoBehaviour // TypeDefIndex: 6572
{
	// Fields
	private IUILabel skillLabel; // 0x20
	private TweenScale skillLabelTScale; // 0x28
	private TweenPosition skillLabelTPos; // 0x30
	private TweenAlpha skillLabelTAlpha; // 0x38
	private TweenColor skillLabelTColor; // 0x40
	private InactiveTimer skillLabelInactiveTimer; // 0x48
	private SkillTextManager skillTextManager; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private PlayerDataManager playerDataManager; // 0x60

	// Methods

	// RVA: 0x198AD6C Offset: 0x1986D6C VA: 0x198AD6C
	private void Awake() { }

	// RVA: 0x198B048 Offset: 0x1987048 VA: 0x198B048
	private void OnDisable() { }

	// RVA: 0x198B06C Offset: 0x198706C VA: 0x198B06C
	public void SetSkillPopUpText(string text) { }

	// RVA: 0x198B24C Offset: 0x198724C VA: 0x198B24C
	public void SkillPopUpLeave() { }

	// RVA: 0x198B270 Offset: 0x1987270 VA: 0x198B270
	public void SetSkillPopUp(SkillId skillId, ElementType elementType) { }

	// RVA: 0x198B430 Offset: 0x1987430 VA: 0x198B430
	public void SetSkillPopUp(SkillId skillId, string key) { }

	// RVA: 0x198B5F0 Offset: 0x19875F0 VA: 0x198B5F0
	public void SetSkillPopUpText(string text, Color form, Color effect) { }

	// RVA: 0x198B704 Offset: 0x1987704 VA: 0x198B704
	public void SetSkillMissPopUp(UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x198B95C Offset: 0x198795C VA: 0x198B95C
	public void .ctor() { }
}
