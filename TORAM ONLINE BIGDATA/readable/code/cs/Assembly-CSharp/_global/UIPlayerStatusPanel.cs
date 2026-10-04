// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPlayerStatusPanel : UIStatusBasePanel // TypeDefIndex: 8055
{
	// Fields
	[SerializeField]
	private UILabel moneyLabel; // 0x20
	[SerializeField]
	private UILabel personalityLabel; // 0x28
	[SerializeField]
	private UILabel[] statusLabel; // 0x30
	[SerializeField]
	private UISprite[] statusBar; // 0x38
	[SerializeField]
	private GameObject buildLabelObject; // 0x40
	[SerializeField]
	private UILabel maxHpLabel; // 0x48
	[SerializeField]
	private UILabel maxMpLabel; // 0x50
	[SerializeField]
	private UISprite[] maxMpSprite; // 0x58
	[SerializeField]
	private GameObject[] mpGaugeSprite; // 0x60
	private GameObject[] mpSpriteList; // 0x68
	[SerializeField]
	private UILabel[] parametarLabel; // 0x70
	[SerializeField]
	private UISprite[] parametarBar; // 0x78
	[SerializeField]
	private UISprite[] parametarBarBack; // 0x80
	[SerializeField]
	private UILabel[] parametarTypeLabel; // 0x88
	[SerializeField]
	private UILabel popParametarMessage; // 0x90
	private PlayerDataManager playerDataManager; // 0x98
	private SystemTextManager systemTextManager; // 0xA0
	[SerializeField]
	private UIIruna2Anchor centerAnchor; // 0xA8
	[SerializeField]
	private UIPlayerStatusDetailPanel detailPanel; // 0xB0

	// Methods

	// RVA: 0x1CB1AC0 Offset: 0x1CADAC0 VA: 0x1CB1AC0 Slot: 4
	public override void Initialize(PlayerDataManager playerDataManager, SystemTextManager systemTextManager, UIStatusMainManager manager) { }

	// RVA: 0x1CB1AF0 Offset: 0x1CADAF0 VA: 0x1CB1AF0 Slot: 5
	public override void Open() { }

	// RVA: 0x1CB3038 Offset: 0x1CAF038 VA: 0x1CB3038
	private void SetSecondaryStatusLabel(int type, int param, float max) { }

	// RVA: 0x1CB2EC0 Offset: 0x1CAEEC0 VA: 0x1CB2EC0
	private void SetPrimaryStatusLabel(int type, int param, float max) { }

	// RVA: 0x1CB2FA4 Offset: 0x1CAEFA4 VA: 0x1CB2FA4
	private void SetPersonalityStatusLabel(string text, int param) { }

	// RVA: 0x1CB311C Offset: 0x1CAF11C VA: 0x1CB311C Slot: 6
	public override void Close() { }

	// RVA: 0x1CB32A8 Offset: 0x1CAF2A8 VA: 0x1CB32A8 Slot: 7
	public override bool PushLeftTopButton() { }

	// RVA: 0x1CB32D4 Offset: 0x1CAF2D4 VA: 0x1CB32D4
	private void OnClickStatus(int type) { }

	// RVA: 0x1CB3580 Offset: 0x1CAF580 VA: 0x1CB3580
	public void OnDetail() { }

	// RVA: 0x1CB35BC Offset: 0x1CAF5BC VA: 0x1CB35BC
	public void .ctor() { }
}
