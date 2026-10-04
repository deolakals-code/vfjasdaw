// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RecreateRecipeWindow : MonoBehaviour // TypeDefIndex: 8636
{
	// Fields
	[SerializeField]
	private RecreateRecipeElement elementOrigin; // 0x20
	private List<RecreateRecipeElement> addedElements; // 0x28
	[SerializeField]
	private Transform parentTrans; // 0x30
	[SerializeField]
	private UIIruna2Viewport scrollCamera; // 0x38

	// Properties
	public bool HasAddedElement { get; }
	public int AddedElementCount { get; }

	// Methods

	// RVA: 0x1DC60EC Offset: 0x1DC20EC VA: 0x1DC60EC
	public bool get_HasAddedElement() { }

	// RVA: 0x1DC613C Offset: 0x1DC213C VA: 0x1DC613C
	public int get_AddedElementCount() { }

	// RVA: 0x1DC6184 Offset: 0x1DC2184 VA: 0x1DC6184
	public void SetRecipe(RecreateType type, RecipeDBData recipe) { }

	// RVA: 0x1DC6858 Offset: 0x1DC2858 VA: 0x1DC6858
	public void RemoveRecipe(RecreateType type) { }

	// RVA: 0x1DC69F0 Offset: 0x1DC29F0 VA: 0x1DC69F0
	public void ResetRecipe() { }

	// RVA: 0x1DC6518 Offset: 0x1DC2518 VA: 0x1DC6518
	private void updateWindowButton(RecreateRecipeElement activeType) { }

	// RVA: 0x1DC6BF4 Offset: 0x1DC2BF4 VA: 0x1DC6BF4
	public void .ctor() { }
}
