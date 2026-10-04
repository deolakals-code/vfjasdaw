// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
private class UICreateFishingRodManager.FishingRodManagementButton // TypeDefIndex: 7011
{
	// Fields
	[SerializeField]
	private BoxCollider buttonCollider; // 0x10
	[SerializeField]
	private UISprite buttonBase; // 0x18
	[SerializeField]
	private UILabel buttonLabel; // 0x20
	[SerializeField]
	private GameObject[] icons; // 0x28
	private byte rodIndex; // 0x30
	private const int createButtonWidth = 400;
	private const int discardButtonWidth = 280;
	private readonly string[] buttonLabelLocalizeKey; // 0x38
	private UICreateFishingRodManager.RodManagementType managementType; // 0x40

	// Properties
	public byte RodIndex { get; }
	public UICreateFishingRodManager.RodManagementType ManagementType { get; }

	// Methods

	// RVA: 0x1A7688C Offset: 0x1A7288C VA: 0x1A7688C
	public byte get_RodIndex() { }

	// RVA: 0x1A76894 Offset: 0x1A72894 VA: 0x1A76894
	public UICreateFishingRodManager.RodManagementType get_ManagementType() { }

	// RVA: 0x1A7689C Offset: 0x1A7289C VA: 0x1A7689C
	public void Initialize(byte index, SystemTextManager systemTextManager, UICreateFishingRodManager.RodManagementType rodManagementType) { }

	// RVA: 0x1A769DC Offset: 0x1A729DC VA: 0x1A769DC
	public void .ctor() { }
}
