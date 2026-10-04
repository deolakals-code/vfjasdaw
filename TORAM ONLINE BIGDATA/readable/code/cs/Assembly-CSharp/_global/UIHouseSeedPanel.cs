// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseSeedPanel : MonoBehaviour // TypeDefIndex: 7328
{
	// Fields
	[SerializeField]
	private UILabel pointLabel; // 0x20
	[SerializeField]
	private UILabel itemLabel; // 0x28
	[SerializeField]
	private UISprite barSrpite; // 0x30
	[SerializeField]
	private UILabel okButtonErrLabel; // 0x38
	[CompilerGenerated]
	private int <CreateSeedBonus>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <CreateSeedPoint>k__BackingField; // 0x44
	private string errText; // 0x48
	private int maxCookPoint; // 0x50

	// Properties
	public int CreateSeedBonus { get; set; }
	public int CreateSeedPoint { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B122D8 Offset: 0x1B0E2D8 VA: 0x1B122D8
	private void set_CreateSeedBonus(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B122E0 Offset: 0x1B0E2E0 VA: 0x1B122E0
	public int get_CreateSeedBonus() { }

	[CompilerGenerated]
	// RVA: 0x1B122E8 Offset: 0x1B0E2E8 VA: 0x1B122E8
	private void set_CreateSeedPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B122F0 Offset: 0x1B0E2F0 VA: 0x1B122F0
	public int get_CreateSeedPoint() { }

	// RVA: 0x1B122F8 Offset: 0x1B0E2F8 VA: 0x1B122F8
	public void Initialize(string itemText, string errText, int createSeedPoint, int maxCookPoint) { }

	// RVA: 0x1B1235C Offset: 0x1B0E35C VA: 0x1B1235C
	private void UpdateBar() { }

	// RVA: 0x1B124E8 Offset: 0x1B0E4E8 VA: 0x1B124E8
	public bool IsOKButton() { }

	// RVA: 0x1B12500 Offset: 0x1B0E500 VA: 0x1B12500
	public void OnMaxClick() { }

	// RVA: 0x1B1256C Offset: 0x1B0E56C VA: 0x1B1256C
	public void OnAddClick() { }

	// RVA: 0x1B12600 Offset: 0x1B0E600 VA: 0x1B12600
	public void OnSubClick() { }

	// RVA: 0x1B12694 Offset: 0x1B0E694 VA: 0x1B12694
	public void .ctor() { }
}
