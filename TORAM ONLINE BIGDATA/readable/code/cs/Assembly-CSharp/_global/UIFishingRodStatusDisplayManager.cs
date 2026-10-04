// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingRodStatusDisplayManager : MonoBehaviour // TypeDefIndex: 7062
{
	// Fields
	[SerializeField]
	private UISprite rodIcon; // 0x20
	[SerializeField]
	private UISprite iconBase; // 0x28
	[SerializeField]
	private UISprite iconFrame; // 0x30
	[SerializeField]
	private UILabel[] statusTitleLabel; // 0x38
	[SerializeField]
	private UILabel[] statusLabels; // 0x40
	[SerializeField]
	private UILabel durabilityLabel; // 0x48
	[SerializeField]
	private UISlider durabilitySlider; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private string[] statusNameLocalizeIds; // 0x60

	// Methods

	// RVA: 0x1A87588 Offset: 0x1A83588 VA: 0x1A87588
	public void Initialize(FishingRodClientData rodData) { }

	// RVA: 0x1A8808C Offset: 0x1A8408C VA: 0x1A8808C
	public void ChangeRodIcon(byte index) { }

	// RVA: 0x1A88170 Offset: 0x1A84170 VA: 0x1A88170
	public void .ctor() { }
}
