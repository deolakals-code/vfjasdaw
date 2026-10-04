// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITargetMenuBase : UIBasePanelControl // TypeDefIndex: 8067
{
	// Fields
	protected GameObject popWindowObject; // 0x58
	protected UIPopWindow popWindow; // 0x60
	protected GameObject popWindowOriginal; // 0x68
	protected IUserArchetype archetype; // 0x70
	protected int fromMailUuid; // 0x78
	protected string fromMailAvatarName; // 0x80
	protected bool isFromMail; // 0x88

	// Properties
	protected string GetTargetName { get; }

	// Methods

	// RVA: 0x1CB8694 Offset: 0x1CB4694 VA: 0x1CB8694
	public void SetFromMailData(int uuid, string name) { }

	// RVA: 0x1CB723C Offset: 0x1CB323C VA: 0x1CB723C
	protected IUserArchetype getTargetArchetype() { }

	// RVA: 0x1CB71DC Offset: 0x1CB31DC VA: 0x1CB71DC
	protected void changeUI() { }

	// RVA: 0x1CB86C0 Offset: 0x1CB46C0 VA: 0x1CB86C0
	protected string get_GetTargetName() { }

	// RVA: 0x1CB8160 Offset: 0x1CB4160 VA: 0x1CB8160
	protected void createWindow(string titleText, string messageText, string buttonText, Action openCallback, Action buttonCallback) { }

	// RVA: 0x1CB74B8 Offset: 0x1CB34B8 VA: 0x1CB74B8
	protected void createWindowSelect(string titleText, string messageText, string yes_button_text, string no_button_text, Action YesButtonCallBack, Action NoButtonCallBack) { }

	// RVA: 0x1CB78AC Offset: 0x1CB38AC VA: 0x1CB78AC
	protected void OnClose() { }

	// RVA: 0x1CB87C8 Offset: 0x1CB47C8 VA: 0x1CB87C8
	private void OnDestroy() { }

	// RVA: 0x1CB79F4 Offset: 0x1CB39F4 VA: 0x1CB79F4
	public void .ctor() { }
}
