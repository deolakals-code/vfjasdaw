// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetRaceMaster : MonoBehaviour // TypeDefIndex: 4452
{
	// Fields
	private readonly short[] defaultSettingParams; // 0x20
	public float TestDownBurstSpeed; // 0x28
	public float TestJumpUp; // 0x2C
	public float TestDefaultSpeed; // 0x30
	public float TestStepDist; // 0x34
	public float TestStepTime; // 0x38
	public float TestCameraHeight; // 0x3C
	[SerializeField]
	private short[] settingParams; // 0x40
	[SerializeField]
	private short[] ferventBonus; // 0x48
	[SerializeField]
	private short[] swiftBonus; // 0x50
	[SerializeField]
	private short[] braveBonus; // 0x58
	[SerializeField]
	private short[] activeBonus; // 0x60
	[SerializeField]
	private short[] mildBonus; // 0x68
	[SerializeField]
	private short[] calmBonus; // 0x70
	[SerializeField]
	private short[] steadyBonus; // 0x78
	[SerializeField]
	private short[] justiceBonus; // 0x80
	[SerializeField]
	private short[] impulsiveBonus; // 0x88
	[SerializeField]
	private short[] timidBonus; // 0x90
	[SerializeField]
	private short[] sturdyBonus; // 0x98
	[SerializeField]
	private short[] intelligentBonus; // 0xA0
	[SerializeField]
	private short[] devotedBonus; // 0xA8
	[SerializeField]
	private short[] slyBonus; // 0xB0

	// Methods

	// RVA: 0x24F7E48 Offset: 0x24F3E48 VA: 0x24F7E48
	public float GeStatustParam(byte personal, PetRaceMaster.StatusType type, float statusParam = 0) { }

	// RVA: 0x24F7FB4 Offset: 0x24F3FB4 VA: 0x24F7FB4
	public float GeStatusRateParam(byte personal, PetRaceMaster.StatusType type, float statusParam = 0) { }

	// RVA: 0x24F7EE0 Offset: 0x24F3EE0 VA: 0x24F7EE0
	private short GetPetPersonalityTypeBonus(byte personal, PetRaceMaster.StatusType type) { }

	// RVA: 0x24F802C Offset: 0x24F402C VA: 0x24F802C
	public void .ctor() { }
}
