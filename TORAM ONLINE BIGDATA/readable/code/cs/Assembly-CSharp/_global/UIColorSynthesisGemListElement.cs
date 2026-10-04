// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIColorSynthesisGemListElement : MonoBehaviour // TypeDefIndex: 6721
{
	// Fields
	[SerializeField]
	private GameObject color; // 0x20
	[SerializeField]
	private UISprite colorBack; // 0x28
	[SerializeField]
	private UILabel colorIdLabel; // 0x30
	[SerializeField]
	private UISprite itemIcon; // 0x38
	[SerializeField]
	private UILabel nameLabel; // 0x40
	[SerializeField]
	private UILabel countLabel; // 0x48
	private int itemId; // 0x50
	private Action<int> onClick; // 0x58
	private static readonly Color OwnedColor; // 0x0
	private static readonly Color NotOwnedColor; // 0x10

	// Methods

	// RVA: 0x19C7AD0 Offset: 0x19C3AD0 VA: 0x19C7AD0
	public void SetupGem(int itemId, string itemName, int count, bool owned, Action<int> onClick, int previewColorId = -1) { }

	// RVA: 0x19C6D48 Offset: 0x19C2D48 VA: 0x19C6D48
	public void SetupColor(byte colorId) { }

	// RVA: 0x19C80BC Offset: 0x19C40BC VA: 0x19C80BC
	public void SetupRemove(string label, Action<int> onClick) { }

	// RVA: 0x19C83F4 Offset: 0x19C43F4 VA: 0x19C83F4
	public void SetupEmpty(string placeholder) { }

	// RVA: 0x19C81DC Offset: 0x19C41DC VA: 0x19C81DC
	private void SetLabelOnly(string label, Color labelColor) { }

	// RVA: 0x19C7F38 Offset: 0x19C3F38 VA: 0x19C7F38
	private void SetColorPreview(int colorId) { }

	// RVA: 0x19C847C Offset: 0x19C447C VA: 0x19C847C
	public void Clear() { }

	// RVA: 0x19C85F4 Offset: 0x19C45F4 VA: 0x19C85F4
	public void OnClick() { }

	// RVA: 0x19C8678 Offset: 0x19C4678 VA: 0x19C8678
	public void .ctor() { }

	// RVA: 0x19C8680 Offset: 0x19C4680 VA: 0x19C8680
	private static void .cctor() { }
}
