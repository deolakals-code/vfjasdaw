// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGraphicOptionManager : UIOptionBaseManager // TypeDefIndex: 7504
{
	// Fields
	[SerializeField]
	protected GameObject attackAreaBlendPanel; // 0x90
	[SerializeField]
	protected UISlider attackAreaBlendSlider; // 0x98
	[SerializeField]
	protected UILabel attackAreaBlendLabel; // 0xA0
	[SerializeField]
	protected GameObject attackAreaLinePanel; // 0xA8
	[SerializeField]
	protected UISlider attackAreaLineSlider; // 0xB0
	[SerializeField]
	protected UILabel attackAreaLineLabel; // 0xB8
	protected OptionsGraphics optionsGraphics; // 0xC0

	// Methods

	// RVA: 0x1B78B0C Offset: 0x1B74B0C VA: 0x1B78B0C Slot: 7
	protected override void Initialize() { }

	// RVA: 0x1B798A4 Offset: 0x1B758A4 VA: 0x1B798A4 Slot: 26
	protected virtual void OnDestroy() { }

	// RVA: 0x1B798C4 Offset: 0x1B758C4 VA: 0x1B798C4 Slot: 21
	protected override bool SetFlag(bool setFlag) { }

	// RVA: 0x1B798F4 Offset: 0x1B758F4 VA: 0x1B798F4 Slot: 23
	protected override bool SetParam(int setParam) { }

	// RVA: 0x1B79920 Offset: 0x1B75920 VA: 0x1B79920 Slot: 24
	protected override string GetEnumType(int enumType) { }

	// RVA: 0x1B79984 Offset: 0x1B75984 VA: 0x1B79984 Slot: 27
	protected virtual void AttackAreaSettingPopUp() { }

	// RVA: 0x1B7A208 Offset: 0x1B76208 VA: 0x1B7A208
	public void OnAttackAreaSliderUpdate() { }

	// RVA: 0x1B7A324 Offset: 0x1B76324 VA: 0x1B7A324 Slot: 28
	protected virtual void AttackAreaSettingPopUpCallBack(int state) { }

	// RVA: 0x1B7A580 Offset: 0x1B76580 VA: 0x1B7A580 Slot: 25
	protected override bool CheckWarningPop(int param) { }

	// RVA: 0x1B7A59C Offset: 0x1B7659C VA: 0x1B7A59C Slot: 13
	public override void OnClickSelectButton(int id, int addParam, int param, string[] textList) { }

	// RVA: 0x1B7A874 Offset: 0x1B76874 VA: 0x1B7A874 Slot: 11
	public override void OnBitCheckBoxButton(int id, int bitParam, string[] textList, Vector2[] position) { }

	// RVA: 0x1B7AB6C Offset: 0x1B76B6C VA: 0x1B7AB6C
	public void .ctor() { }
}
