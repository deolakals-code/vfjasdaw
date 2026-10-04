// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCookingButton : MonoBehaviour // TypeDefIndex: 7199
{
	// Fields
	[SerializeField]
	private UILabel cookingNameLabel; // 0x20
	[SerializeField]
	private UILabel effectLabel; // 0x28
	[SerializeField]
	private UILabel expLabel; // 0x30
	[SerializeField]
	private UILabel ptLabel; // 0x38
	[SerializeField]
	private UITexture cookingIcon; // 0x40
	[SerializeField]
	private UIImageButton cookingButton; // 0x48
	private int cookingId; // 0x50
	private UIHouseCookingManager manager; // 0x58

	// Methods

	// RVA: 0x1AD5020 Offset: 0x1AD1020 VA: 0x1AD5020
	public void Initialize(UIHouseCookingManager manager, int cookingId, string cookingName, string effectText, string expText, string ptText, Texture icon, bool ieButtonFlag) { }

	// RVA: 0x1AD518C Offset: 0x1AD118C VA: 0x1AD518C
	public void OnClickTargetCooking() { }

	// RVA: 0x1AD5218 Offset: 0x1AD1218 VA: 0x1AD5218
	public void .ctor() { }
}
