// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRaidMobNameLabel : UIMobNameLabel // TypeDefIndex: 8920
{
	// Fields
	[SerializeField]
	private GameObject[] breakDamageGauge; // 0x188
	private UIGLSpriteSliced[] breakDamageGaugeSprite; // 0x190
	[SerializeField]
	private GameObject raidHeartGaugePanelObject; // 0x198
	private UIGLSprite raidHeartGaugeSprite; // 0x1A0
	[SerializeField]
	private GameObject raidHeartGaugeObject; // 0x1A8
	private IUILabel raidHeartGaugeLabel; // 0x1B0
	private int currentHpGauge; // 0x1B8
	private IRaidBossMobGauge guildRaidBossMobActionManager; // 0x1C0
	private float effectRate; // 0x1C8
	private int viewHeartCount; // 0x1CC

	// Methods

	// RVA: 0x1E55A70 Offset: 0x1E51A70 VA: 0x1E55A70 Slot: 10
	protected override void InitData() { }

	// RVA: 0x1E55DE8 Offset: 0x1E51DE8 VA: 0x1E55DE8
	private void SetRaidHeartGaugeSprite(string spriteName) { }

	// RVA: 0x1E55E88 Offset: 0x1E51E88 VA: 0x1E55E88 Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E56264 Offset: 0x1E52264 VA: 0x1E56264
	public void .ctor() { }
}
