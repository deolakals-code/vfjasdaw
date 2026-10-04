// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UINecromancerExSkillElement : MonoBehaviour // TypeDefIndex: 6748
{
	// Fields
	[SerializeField]
	private UIImageButton button; // 0x20
	[SerializeField]
	private UISprite[] buttonIcon; // 0x28
	[SerializeField]
	private UILabel[] buttonLabel; // 0x30
	[SerializeField]
	private UILabel pointLabel; // 0x38
	[SerializeField]
	private UILabel titleLable; // 0x40
	[SerializeField]
	private UILabel mesLabel; // 0x48
	private int ability; // 0x50
	private bool flag; // 0x54
	private int point; // 0x58
	private Action<int, bool> setAction; // 0x60
	private Func<int, bool> pointCheck; // 0x68
	private SystemTextManager systemTextManager; // 0x70

	// Methods

	// RVA: 0x19EA73C Offset: 0x19E673C VA: 0x19EA73C
	public void Initialize(int ability, bool flag, int point, Action<int, bool> setAction, Func<int, bool> pointCheck) { }

	// RVA: 0x19EAB2C Offset: 0x19E6B2C VA: 0x19EAB2C
	public void SetRestPoint(int restPoint) { }

	// RVA: 0x19EAC40 Offset: 0x19E6C40 VA: 0x19EAC40
	public void OnClick() { }

	// RVA: 0x19EAA0C Offset: 0x19E6A0C VA: 0x19EAA0C
	private void UpdateButton() { }

	// RVA: 0x19EAD1C Offset: 0x19E6D1C VA: 0x19EAD1C
	public void .ctor() { }
}
