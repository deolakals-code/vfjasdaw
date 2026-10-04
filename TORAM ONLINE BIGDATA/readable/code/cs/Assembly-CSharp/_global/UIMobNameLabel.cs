// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobNameLabel : UINameLabel // TypeDefIndex: 9000
{
	// Fields
	protected MobActionManagerBase mobActionManager; // 0x88
	[SerializeField]
	private GameObject distObject; // 0x90
	private IUILabel distLabel; // 0x98
	[SerializeField]
	private GameObject hpBarObject; // 0xA0
	private UIGLSpriteSliced hpBar; // 0xA8
	private TweenAlpha hpBarTweenAlpha; // 0xB0
	[SerializeField]
	private GameObject hpEffectBarObject; // 0xB8
	[SerializeField]
	private GameObject damageBarObject; // 0xC0
	private UIGLSpriteSliced damageBar; // 0xC8
	[SerializeField]
	private GameObject abnormalIcon; // 0xD0
	[SerializeField]
	private GameObject bossIcon; // 0xD8
	[SerializeField]
	private GameObject popAlertMessageObject; // 0xE0
	private IUILabel popAlertMessageLabel; // 0xE8
	private int dist; // 0xF0
	protected float damageValue; // 0xF4
	private bool bossCheck; // 0xF8
	private bool changeTarget; // 0xF9
	private float fieldEnterTimer; // 0xFC
	private Dictionary<AbnormalType, GameObject> abnormalBuffer; // 0x100
	private bool isAlwaysDisplay; // 0x108
	private bool isAlwaysHide; // 0x109
	[SerializeField]
	private UIMobPropertyLabel propertyLabel; // 0x110
	[SerializeField]
	private GameObject guardGauge; // 0x118
	private bool guardGaugeActive; // 0x120
	[SerializeField]
	private GameObject heartGauge; // 0x128
	private UIGLSprite heartGaugeIcon; // 0x130
	[SerializeField]
	private GameObject heartEffectGauge; // 0x138
	[SerializeField]
	private UIGLLabel heartLabel; // 0x140
	private string heartGaugeLabel; // 0x148
	private bool heartGaugeActive; // 0x150
	private float baseRecoveryTime; // 0x154
	private float startRecoveryTime; // 0x158
	[SerializeField]
	private GameObject bufferIcon; // 0x160
	[SerializeField]
	private GameObject bufferIconParent; // 0x168
	private UIMobBufferIcon[] bufferIcons; // 0x170
	private float saveBufferX; // 0x178
	protected bool barFlag; // 0x17C
	protected bool targetFlag; // 0x17D
	protected bool popName; // 0x17E
	protected int bufferUpdateId; // 0x180
	private float popAlertMessageTimer; // 0x184

	// Properties
	private bool IsMobaPartyMember { get; }

	// Methods

	// RVA: 0x1E89F6C Offset: 0x1E85F6C VA: 0x1E89F6C
	private bool get_IsMobaPartyMember() { }

	// RVA: 0x1E8A028 Offset: 0x1E86028 VA: 0x1E8A028
	public void Initialize(Transform traceObject) { }

	// RVA: 0x1E8AB20 Offset: 0x1E86B20 VA: 0x1E8AB20 Slot: 10
	protected virtual void InitData() { }

	// RVA: 0x1E8AB24 Offset: 0x1E86B24 VA: 0x1E8AB24
	public void UpdateName(Transform traceObject) { }

	// RVA: 0x1E8AE80 Offset: 0x1E86E80 VA: 0x1E8AE80
	public void PopAlertMessage(float timer, string localizeKey) { }

	// RVA: 0x1E8AFD4 Offset: 0x1E86FD4 VA: 0x1E8AFD4 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E8DCD4 Offset: 0x1E89CD4 VA: 0x1E8DCD4
	private UIIconBase SetAddIcon(Vector3 position) { }

	// RVA: 0x1E8DE90 Offset: 0x1E89E90 VA: 0x1E8DE90
	public UIMobPropertyLabel ActivatePropetyLabel() { }

	// RVA: 0x1E8DF28 Offset: 0x1E89F28 VA: 0x1E8DF28
	public void HpRecovery(float time) { }

	// RVA: 0x1E8E094 Offset: 0x1E8A094 VA: 0x1E8E094
	public void UpdateMobGuardGauge(bool isActive) { }

	// RVA: 0x1E8E0A0 Offset: 0x1E8A0A0 VA: 0x1E8E0A0
	public void UpdateMobHeartGauge(bool isActive, List<MobIconLabelData> data) { }

	// RVA: 0x1E8E174 Offset: 0x1E8A174 VA: 0x1E8E174 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E8E3EC Offset: 0x1E8A3EC VA: 0x1E8E3EC Slot: 7
	protected override bool GetLabelChange() { }

	// RVA: 0x1E8E3F4 Offset: 0x1E8A3F4 VA: 0x1E8E3F4
	public void .ctor() { }
}
