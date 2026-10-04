// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NewOptionElementBase // TypeDefIndex: 7476
{
	// Fields
	protected int type; // 0x10
	protected string mes; // 0x18
	protected Transform parent; // 0x20
	protected Action<int> selectAction; // 0x28
	protected UILabel mesLabel; // 0x30
	private UINewOptionBaseElement uiNewOptionBaseElement; // 0x38

	// Methods

	// RVA: 0x1B65B68 Offset: 0x1B61B68 VA: 0x1B65B68
	public void .ctor(int type, string mes, Transform parent, Action<int> selectAction) { }

	// RVA: 0x1B65C28 Offset: 0x1B61C28 VA: 0x1B65C28
	public void Initialize(UINewOptionBaseElement element) { }

	// RVA: 0x1B65C4C Offset: 0x1B61C4C VA: 0x1B65C4C Slot: 4
	protected virtual void Initialize() { }

	// RVA: 0x1B65E2C Offset: 0x1B61E2C VA: 0x1B65E2C
	protected GameObject SettingObject(GameObject obj, Vector2 pos, float scale, Transform parent) { }

	// RVA: 0x1B65F74 Offset: 0x1B61F74 VA: 0x1B65F74 Slot: 5
	public virtual void ElementUpdate() { }

	// RVA: 0x1B65F78 Offset: 0x1B61F78 VA: 0x1B65F78
	private void Update() { }
}
