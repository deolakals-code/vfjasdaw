// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopBaseWindow // TypeDefIndex: 8775
{
	// Fields
	protected UIPopBaseWindow uiPopBaseWindow; // 0x10
	private SystemTextManager textManager; // 0x18

	// Properties
	protected SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x1E0719C Offset: 0x1E0319C VA: 0x1E0719C
	protected SystemTextManager get_systemTextManager() { }

	// RVA: 0x1E08F30 Offset: 0x1E04F30 VA: 0x1E08F30
	public void Initialize(UIPopBaseWindow baseWindow) { }

	// RVA: 0x1E08F54 Offset: 0x1E04F54 VA: 0x1E08F54 Slot: 4
	protected virtual void Initialize() { }

	// RVA: 0x1E08954 Offset: 0x1E04954 VA: 0x1E08954
	protected GameObject SettingObject(GameObject obj, Vector2 pos, float scale, Transform parent) { }

	// RVA: 0x1E08DB0 Offset: 0x1E04DB0 VA: 0x1E08DB0
	protected void SettingActionMessage(GameObject obj, int id) { }

	// RVA: 0x1E08F58 Offset: 0x1E04F58 VA: 0x1E08F58
	public void AddTitlePanel(GameObject addBaseObject, Vector3 pos, float scale) { }

	// RVA: 0x1E08FD4 Offset: 0x1E04FD4 VA: 0x1E08FD4
	public void AddMainPanel(GameObject addBaseObject, Vector3 pos, float scale) { }

	// RVA: 0x1E09050 Offset: 0x1E05050 VA: 0x1E09050
	public void AddMainPanelEx(GameObject addBaseObject, Vector3 pos, float scale) { }

	// RVA: 0x1E09138 Offset: 0x1E05138 VA: 0x1E09138 Slot: 5
	public virtual void Update() { }

	// RVA: 0x1E0913C Offset: 0x1E0513C VA: 0x1E0913C Slot: 6
	public virtual void MessageAction(int id) { }

	// RVA: 0x1E09140 Offset: 0x1E05140 VA: 0x1E09140 Slot: 7
	public virtual int MessageCheck() { }

	// RVA: 0x1E09148 Offset: 0x1E05148 VA: 0x1E09148 Slot: 8
	public virtual void Close() { }

	// RVA: 0x1E07E14 Offset: 0x1E03E14 VA: 0x1E07E14
	public void .ctor() { }
}
