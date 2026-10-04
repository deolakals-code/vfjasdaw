// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobHyperModeManager : MonoBehaviour // TypeDefIndex: 938
{
	// Fields
	private MobStatusMaster baseMobMaster; // 0x20
	private MobStatusMaster nowMobMaster; // 0x28
	private Transform nowModel; // 0x30
	private MobHyperModeAnimation hyperModeAnimation; // 0x38

	// Properties
	public Transform NowModel { get; }

	// Methods

	// RVA: 0x1F098C0 Offset: 0x1F058C0 VA: 0x1F098C0
	public Transform get_NowModel() { }

	// RVA: 0x1F098C8 Offset: 0x1F058C8 VA: 0x1F098C8
	public void Initialize(MobStatusMaster baseMobMaster) { }

	// RVA: 0x1F0A0BC Offset: 0x1F060BC VA: 0x1F0A0BC
	public void ChangeHyperMode(MobStatusMaster mobMaster, out bool changeModel) { }

	// RVA: 0x1F0A500 Offset: 0x1F06500 VA: 0x1F0A500
	public bool CheckCurrentModel(GameObject model) { }

	// RVA: 0x1F0A5C0 Offset: 0x1F065C0 VA: 0x1F0A5C0
	public void .ctor() { }
}
