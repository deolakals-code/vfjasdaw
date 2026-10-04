// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICristalHp : MonoBehaviour // TypeDefIndex: 6403
{
	// Fields
	[SerializeField]
	private GameObject panelObj; // 0x20
	[SerializeField]
	private UILabel cristalHpLabel; // 0x28
	[SerializeField]
	private UILabel cristaNameLabel; // 0x30
	[SerializeField]
	private UIIcon cristalIcon; // 0x38
	private float hpTextScale; // 0x40
	private bool isScaleChange; // 0x44
	private int cristalHp; // 0x48
	private UIIruna2Anchor anchor; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private int iconId; // 0x60

	// Methods

	// RVA: 0x1927900 Offset: 0x1923900 VA: 0x1927900
	public void UpdateHp(int nowHp) { }

	// RVA: 0x1927908 Offset: 0x1923908 VA: 0x1927908
	public static GameObject CreateCristalHp() { }

	// RVA: 0x1927A28 Offset: 0x1923A28 VA: 0x1927A28
	public void Initialize(int hp, string crystalText, int iconId) { }

	// RVA: 0x1927C2C Offset: 0x1923C2C VA: 0x1927C2C
	public void SetEnable(bool enable) { }

	// RVA: 0x1927BD8 Offset: 0x1923BD8 VA: 0x1927BD8
	public void SetCristalLocalize(string text, int iconId) { }

	// RVA: 0x1927E2C Offset: 0x1923E2C VA: 0x1927E2C
	public void SetIcon(string spriteName) { }

	// RVA: 0x1927E48 Offset: 0x1923E48 VA: 0x1927E48
	private void Awake() { }

	// RVA: 0x1927EAC Offset: 0x1923EAC VA: 0x1927EAC
	private void Update() { }

	// RVA: 0x1927DE4 Offset: 0x1923DE4 VA: 0x1927DE4
	private void SetIconId(int iconId) { }

	// RVA: 0x19280C0 Offset: 0x19240C0 VA: 0x19280C0
	public void .ctor() { }
}
