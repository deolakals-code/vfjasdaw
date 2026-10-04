// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseOtherMemberButton : MonoBehaviour // TypeDefIndex: 7294
{
	// Fields
	[SerializeField]
	private UILabel nameLabel; // 0x20
	[SerializeField]
	private UILabel timeLabel; // 0x28
	[SerializeField]
	private UISprite iconSprite; // 0x30
	[SerializeField]
	private UILabel cuisineLabel; // 0x38
	private int buttonId; // 0x40
	private int cuisineId; // 0x44
	private UIHouseOtherMemberManager manager; // 0x48

	// Methods

	// RVA: 0x1B01C78 Offset: 0x1AFDC78 VA: 0x1B01C78
	public void Initialize(int buttonId, string name, int cuisineId, string cuisineText, string time, UIHouseOtherMemberManager manager) { }

	// RVA: 0x1B01E8C Offset: 0x1AFDE8C VA: 0x1B01E8C
	public void OnMemberClick() { }

	// RVA: 0x1B02108 Offset: 0x1AFE108 VA: 0x1B02108
	public void .ctor() { }
}
