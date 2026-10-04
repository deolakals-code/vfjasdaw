// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICardGameMarketCard : UICardGameCardBase // TypeDefIndex: 5686
{
	// Fields
	[SerializeField]
	private UISprite cardBase; // 0x58
	[SerializeField]
	private UITexture backTex; // 0x60
	[SerializeField]
	private UISprite spinaIcon; // 0x68
	[SerializeField]
	private UILabel spinaLabel; // 0x70
	private UICardGameMarketCardManager marketCardManager; // 0x78

	// Methods

	// RVA: 0x17C9158 Offset: 0x17C5158 VA: 0x17C9158
	private void Update() { }

	// RVA: 0x17C917C Offset: 0x17C517C VA: 0x17C917C Slot: 5
	public override void OnPressCard() { }

	// RVA: 0x17C9200 Offset: 0x17C5200 VA: 0x17C9200 Slot: 6
	public override void OnReleaseCard() { }

	// RVA: 0x17C92BC Offset: 0x17C52BC VA: 0x17C92BC
	public void Initialize(UICardGameMarketCardManager manager, CardGamePlayerCard cardData) { }

	// RVA: 0x17C9440 Offset: 0x17C5440 VA: 0x17C9440
	public void .ctor() { }
}
