// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CookingLinkAnimationObject : LinkAnimationObject // TypeDefIndex: 3851
{
	// Fields
	[SerializeField]
	private int cookingWaitMotionId; // 0x84
	private HouseCuisineManager cuisineManager; // 0x88
	private float timer; // 0x90

	// Properties
	private HouseCuisineManager manager { get; }
	protected override int PlayWaitMotionId { get; }

	// Methods

	// RVA: 0x23F7B40 Offset: 0x23F3B40 VA: 0x23F7B40
	private HouseCuisineManager get_manager() { }

	// RVA: 0x23F7BAC Offset: 0x23F3BAC VA: 0x23F7BAC Slot: 4
	protected override int get_PlayWaitMotionId() { }

	// RVA: 0x23F7BE8 Offset: 0x23F3BE8 VA: 0x23F7BE8
	private void Update() { }

	// RVA: 0x23F7C38 Offset: 0x23F3C38 VA: 0x23F7C38
	public void .ctor() { }
}
