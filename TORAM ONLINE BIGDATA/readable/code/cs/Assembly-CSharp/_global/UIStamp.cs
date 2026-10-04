// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStamp : UIBasePanelControl // TypeDefIndex: 7992
{
	// Fields
	[SerializeField]
	protected UITexture stampCard; // 0x58
	[SerializeField]
	protected UITexture pageFont; // 0x60
	[SerializeField]
	protected UITexture carryOverPageFont; // 0x68
	[SerializeField]
	protected UILabel TextMessageLabel; // 0x70
	[SerializeField]
	private GameObject StampGameObject; // 0x78
	[SerializeField]
	private UIStampReceive stampReceive; // 0x80
	[SerializeField]
	protected UIStampIcon[] icon; // 0x88
	[SerializeField]
	protected UISprite[] pageSprite; // 0x90
	[SerializeField]
	protected GameObject normalStampUI; // 0x98
	[SerializeField]
	protected GameObject carryOverUI; // 0xA0
	[SerializeField]
	private UITexture prevBackground; // 0xA8
	[SerializeField]
	private UITexture nextBackground; // 0xB0
	[SerializeField]
	private UIStampIcon[] carryOverIcon; // 0xB8
	[SerializeField]
	protected UIPanel panel; // 0xC0
	protected string[] pageSpriteName; // 0xC8
	protected PlayerDataManager playerDataManager; // 0xD0
	protected bool isInitialized; // 0xD8
	protected bool loadedBackTexture; // 0xD9
	protected bool loadedPageTexture; // 0xDA

	// Methods

	// RVA: 0x1C8D314 Offset: 0x1C89314 VA: 0x1C8D314 Slot: 14
	protected virtual void Awake() { }

	// RVA: 0x1C8D4F0 Offset: 0x1C894F0 VA: 0x1C8D4F0 Slot: 15
	protected virtual void Start() { }

	// RVA: 0x1C8D52C Offset: 0x1C8952C VA: 0x1C8D52C
	private void OnDestroy() { }

	// RVA: 0x1C8D58C Offset: 0x1C8958C VA: 0x1C8D58C
	public void InitializeReceive() { }

	[IteratorStateMachine(typeof(UIStamp.<InitializeStamp>d__24))]
	// RVA: 0x1C8D620 Offset: 0x1C89620 VA: 0x1C8D620 Slot: 16
	public virtual IEnumerator InitializeStamp() { }

	// RVA: 0x1C8D6B4 Offset: 0x1C896B4 VA: 0x1C8D6B4
	protected void initializeOneMore() { }

	// RVA: 0x1C8D9F0 Offset: 0x1C899F0 VA: 0x1C8D9F0
	protected void onCloseClick() { }

	// RVA: 0x1C8D9F4 Offset: 0x1C899F4 VA: 0x1C8D9F4
	protected void onClose() { }

	[IteratorStateMachine(typeof(UIStamp.<setCardMaterial>d__28))]
	// RVA: 0x1C8DB08 Offset: 0x1C89B08 VA: 0x1C8DB08
	protected IEnumerator setCardMaterial(UITexture texture, int card) { }

	[IteratorStateMachine(typeof(UIStamp.<setPageMaterial>d__29))]
	// RVA: 0x1C8DBC0 Offset: 0x1C89BC0 VA: 0x1C8DBC0
	protected IEnumerator setPageMaterial(int page) { }

	// RVA: 0x1C8DC64 Offset: 0x1C89C64 VA: 0x1C8DC64
	public void .ctor() { }
}
