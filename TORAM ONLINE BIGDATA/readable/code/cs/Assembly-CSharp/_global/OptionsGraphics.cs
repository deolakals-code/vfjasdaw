// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class OptionsGraphics // TypeDefIndex: 5375
{
	// Fields
	[CompilerGenerated]
	private byte <ShowSupportSkillIcon>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <MiniMapScale>k__BackingField; // 0x11
	[CompilerGenerated]
	private byte <MiniMapAlpha>k__BackingField; // 0x12
	[CompilerGenerated]
	private byte <ViewPlayerMax>k__BackingField; // 0x13
	[CompilerGenerated]
	private byte <ViewEffectLevel>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <DirectionDamageView>k__BackingField; // 0x15
	[CompilerGenerated]
	private byte <SelectOtherPlayerViewLevel>k__BackingField; // 0x16
	[CompilerGenerated]
	private bool <ShowSignBoard>k__BackingField; // 0x17
	[CompilerGenerated]
	private byte <SignboardCategory>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <ShowSkillHitTypeLabel>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <SkillEffectAlphaFlag>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <SkillEffectAlphaSelectDist>k__BackingField; // 0x1B
	[CompilerGenerated]
	private byte <SkillEffectAlphaSelectData>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <OtherPlayerLabelColor>k__BackingField; // 0x1D
	[CompilerGenerated]
	private bool <OtherPlayerLabelChatColor>k__BackingField; // 0x1E
	[CompilerGenerated]
	private bool <D3SignBoardFlag>k__BackingField; // 0x1F
	[CompilerGenerated]
	private bool <HouseAreaViewFlag>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <HouseLimitOverFlag>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <HouseItemViewDist>k__BackingField; // 0x22
	[CompilerGenerated]
	private byte <HouseItemViewNum>k__BackingField; // 0x23
	[CompilerGenerated]
	private byte <InvisibleMainUIFlag>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <DamageLabelScaleSelectId>k__BackingField; // 0x25
	[CompilerGenerated]
	private byte <DamageLabelScaleSelect>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <IsAttackAreaEx>k__BackingField; // 0x27
	[CompilerGenerated]
	private byte <AttackAreaBlendPower>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <AttackAreaOutLine>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <IsAndroidNotchUI>k__BackingField; // 0x2A
	public const byte DefaultSkillEffectAlphaSelectDist = 11;
	public const byte DefaultHouseItemViewDist = 0;
	public const byte DefaultHouseItemViewNum = 0;

	// Properties
	[SerializeField]
	public byte ShowSupportSkillIcon { get; set; }
	public bool IsViewSupportSkillIcon { get; }
	public bool IsViewSupportSkillLimitTime { get; }
	public bool IsViewSupportSkillCount { get; }
	public bool IsViewSupportSkillOrder { get; }
	public bool IsViewSupportSkillOnlyMine { get; }
	public bool IsViewSupportSkilHideRProperty { get; }
	[SerializeField]
	public byte MiniMapScale { get; set; }
	[SerializeField]
	public byte MiniMapAlpha { get; set; }
	[SerializeField]
	public byte ViewPlayerMax { get; set; }
	[SerializeField]
	public byte ViewEffectLevel { get; set; }
	public bool IsViewEffectAll { get; }
	public bool IsViewEffectParty { get; }
	public bool IsViewEffectNone { get; }
	[SerializeField]
	public bool DirectionDamageView { get; set; }
	public OptionsGraphics.OtherPlayerViewFlag OtherPlayerViewLevel { get; }
	public byte SelectOtherPlayerViewLevel { get; set; }
	[SerializeField]
	public bool ShowSignBoard { get; set; }
	[SerializeField]
	public byte SignboardCategory { get; set; }
	public bool ShowSkillHitTypeLabel { get; set; }
	[SerializeField]
	public bool SkillEffectAlphaFlag { get; set; }
	[SerializeField]
	public float SkillEffectAlphaDist { get; }
	[SerializeField]
	public byte SkillEffectAlphaSelectDist { get; set; }
	[SerializeField]
	public float SkillEffectAlphaData { get; }
	[SerializeField]
	public byte SkillEffectAlphaSelectData { get; set; }
	[SerializeField]
	public bool OtherPlayerLabelColor { get; set; }
	[SerializeField]
	public bool OtherPlayerLabelChatColor { get; set; }
	[SerializeField]
	public bool D3SignBoardFlag { get; set; }
	[SerializeField]
	public bool HouseAreaViewFlag { get; set; }
	[SerializeField]
	public bool HouseLimitOverFlag { get; set; }
	[SerializeField]
	public float HouseItemMaxDist { get; }
	[SerializeField]
	public bool IsHouseItemMaxCheck { get; }
	[SerializeField]
	public byte HouseItemViewDist { get; set; }
	public int HouseItemMaxNum { get; }
	[SerializeField]
	public bool IsHouseItemViewNumCheck { get; }
	[SerializeField]
	public byte HouseItemViewNum { get; set; }
	public byte InvisibleMainUIFlag { get; set; }
	[SerializeField]
	public byte DamageLabelScaleSelectId { get; set; }
	[SerializeField]
	public byte DamageLabelScaleSelect { get; set; }
	public float DamageLabelScale { get; }
	public bool IsPopDamageLabel { get; }
	[SerializeField]
	public bool IsAttackAreaEx { get; set; }
	public byte AttackAreaBlendPower { get; set; }
	public byte AttackAreaOutLine { get; set; }
	public bool IsAndroidNotchUI { get; set; }
	public virtual byte DefaultDamageLabelScaleSelect { get; }
	public virtual bool DefaultD3SignBoardFlag { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x264E4BC Offset: 0x264A4BC VA: 0x264E4BC
	private void set_ShowSupportSkillIcon(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E4C4 Offset: 0x264A4C4 VA: 0x264E4C4
	public byte get_ShowSupportSkillIcon() { }

	// RVA: 0x264E4CC Offset: 0x264A4CC VA: 0x264E4CC
	public bool get_IsViewSupportSkillIcon() { }

	// RVA: 0x264E4D8 Offset: 0x264A4D8 VA: 0x264E4D8
	public bool get_IsViewSupportSkillLimitTime() { }

	// RVA: 0x264E4E4 Offset: 0x264A4E4 VA: 0x264E4E4
	public bool get_IsViewSupportSkillCount() { }

	// RVA: 0x264E4F0 Offset: 0x264A4F0 VA: 0x264E4F0
	public bool get_IsViewSupportSkillOrder() { }

	// RVA: 0x264E4FC Offset: 0x264A4FC VA: 0x264E4FC
	public bool get_IsViewSupportSkillOnlyMine() { }

	// RVA: 0x264E508 Offset: 0x264A508 VA: 0x264E508
	public bool get_IsViewSupportSkilHideRProperty() { }

	[CompilerGenerated]
	// RVA: 0x264E514 Offset: 0x264A514 VA: 0x264E514
	private void set_MiniMapScale(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E51C Offset: 0x264A51C VA: 0x264E51C
	public byte get_MiniMapScale() { }

	[CompilerGenerated]
	// RVA: 0x264E524 Offset: 0x264A524 VA: 0x264E524
	private void set_MiniMapAlpha(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E52C Offset: 0x264A52C VA: 0x264E52C
	public byte get_MiniMapAlpha() { }

	[CompilerGenerated]
	// RVA: 0x264E534 Offset: 0x264A534 VA: 0x264E534
	private void set_ViewPlayerMax(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E53C Offset: 0x264A53C VA: 0x264E53C
	public byte get_ViewPlayerMax() { }

	[CompilerGenerated]
	// RVA: 0x264E544 Offset: 0x264A544 VA: 0x264E544
	private void set_ViewEffectLevel(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E54C Offset: 0x264A54C VA: 0x264E54C
	public byte get_ViewEffectLevel() { }

	// RVA: 0x264E554 Offset: 0x264A554 VA: 0x264E554
	public bool get_IsViewEffectAll() { }

	// RVA: 0x264E564 Offset: 0x264A564 VA: 0x264E564
	public bool get_IsViewEffectParty() { }

	// RVA: 0x264E574 Offset: 0x264A574 VA: 0x264E574
	public bool get_IsViewEffectNone() { }

	[CompilerGenerated]
	// RVA: 0x264E584 Offset: 0x264A584 VA: 0x264E584
	private void set_DirectionDamageView(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E590 Offset: 0x264A590 VA: 0x264E590
	public bool get_DirectionDamageView() { }

	// RVA: 0x264E598 Offset: 0x264A598 VA: 0x264E598
	public OptionsGraphics.OtherPlayerViewFlag get_OtherPlayerViewLevel() { }

	[CompilerGenerated]
	// RVA: 0x264E5A8 Offset: 0x264A5A8 VA: 0x264E5A8
	private void set_SelectOtherPlayerViewLevel(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E5B0 Offset: 0x264A5B0 VA: 0x264E5B0
	public byte get_SelectOtherPlayerViewLevel() { }

	[CompilerGenerated]
	// RVA: 0x264E5B8 Offset: 0x264A5B8 VA: 0x264E5B8
	private void set_ShowSignBoard(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E5C4 Offset: 0x264A5C4 VA: 0x264E5C4
	public bool get_ShowSignBoard() { }

	[CompilerGenerated]
	// RVA: 0x264E5CC Offset: 0x264A5CC VA: 0x264E5CC
	private void set_SignboardCategory(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E5D4 Offset: 0x264A5D4 VA: 0x264E5D4
	public byte get_SignboardCategory() { }

	[CompilerGenerated]
	// RVA: 0x264E5DC Offset: 0x264A5DC VA: 0x264E5DC
	private void set_ShowSkillHitTypeLabel(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E5E8 Offset: 0x264A5E8 VA: 0x264E5E8
	public bool get_ShowSkillHitTypeLabel() { }

	[CompilerGenerated]
	// RVA: 0x264E5F0 Offset: 0x264A5F0 VA: 0x264E5F0
	private void set_SkillEffectAlphaFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E5FC Offset: 0x264A5FC VA: 0x264E5FC
	public bool get_SkillEffectAlphaFlag() { }

	// RVA: 0x264E604 Offset: 0x264A604 VA: 0x264E604
	public float get_SkillEffectAlphaDist() { }

	[CompilerGenerated]
	// RVA: 0x264E614 Offset: 0x264A614 VA: 0x264E614
	private void set_SkillEffectAlphaSelectDist(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E61C Offset: 0x264A61C VA: 0x264E61C
	public byte get_SkillEffectAlphaSelectDist() { }

	// RVA: 0x264E624 Offset: 0x264A624 VA: 0x264E624
	public float get_SkillEffectAlphaData() { }

	[CompilerGenerated]
	// RVA: 0x264E63C Offset: 0x264A63C VA: 0x264E63C
	private void set_SkillEffectAlphaSelectData(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E644 Offset: 0x264A644 VA: 0x264E644
	public byte get_SkillEffectAlphaSelectData() { }

	[CompilerGenerated]
	// RVA: 0x264E64C Offset: 0x264A64C VA: 0x264E64C
	private void set_OtherPlayerLabelColor(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E658 Offset: 0x264A658 VA: 0x264E658
	public bool get_OtherPlayerLabelColor() { }

	[CompilerGenerated]
	// RVA: 0x264E660 Offset: 0x264A660 VA: 0x264E660
	private void set_OtherPlayerLabelChatColor(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E66C Offset: 0x264A66C VA: 0x264E66C
	public bool get_OtherPlayerLabelChatColor() { }

	[CompilerGenerated]
	// RVA: 0x264E674 Offset: 0x264A674 VA: 0x264E674
	private void set_D3SignBoardFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E680 Offset: 0x264A680 VA: 0x264E680
	public bool get_D3SignBoardFlag() { }

	[CompilerGenerated]
	// RVA: 0x264E688 Offset: 0x264A688 VA: 0x264E688
	private void set_HouseAreaViewFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E694 Offset: 0x264A694 VA: 0x264E694
	public bool get_HouseAreaViewFlag() { }

	[CompilerGenerated]
	// RVA: 0x264E69C Offset: 0x264A69C VA: 0x264E69C
	private void set_HouseLimitOverFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E6A8 Offset: 0x264A6A8 VA: 0x264E6A8
	public bool get_HouseLimitOverFlag() { }

	// RVA: 0x264E6B0 Offset: 0x264A6B0 VA: 0x264E6B0
	public float get_HouseItemMaxDist() { }

	// RVA: 0x264E6C4 Offset: 0x264A6C4 VA: 0x264E6C4
	public bool get_IsHouseItemMaxCheck() { }

	[CompilerGenerated]
	// RVA: 0x264E6D4 Offset: 0x264A6D4 VA: 0x264E6D4
	private void set_HouseItemViewDist(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E6DC Offset: 0x264A6DC VA: 0x264E6DC
	public byte get_HouseItemViewDist() { }

	// RVA: 0x264E6E4 Offset: 0x264A6E4 VA: 0x264E6E4
	public int get_HouseItemMaxNum() { }

	// RVA: 0x264E6F8 Offset: 0x264A6F8 VA: 0x264E6F8
	public bool get_IsHouseItemViewNumCheck() { }

	[CompilerGenerated]
	// RVA: 0x264E708 Offset: 0x264A708 VA: 0x264E708
	private void set_HouseItemViewNum(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E710 Offset: 0x264A710 VA: 0x264E710
	public byte get_HouseItemViewNum() { }

	[CompilerGenerated]
	// RVA: 0x264E718 Offset: 0x264A718 VA: 0x264E718
	private void set_InvisibleMainUIFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E720 Offset: 0x264A720 VA: 0x264E720
	public byte get_InvisibleMainUIFlag() { }

	[CompilerGenerated]
	// RVA: 0x264E728 Offset: 0x264A728 VA: 0x264E728
	private void set_DamageLabelScaleSelectId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E730 Offset: 0x264A730 VA: 0x264E730
	public byte get_DamageLabelScaleSelectId() { }

	[CompilerGenerated]
	// RVA: 0x264E738 Offset: 0x264A738 VA: 0x264E738
	private void set_DamageLabelScaleSelect(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E740 Offset: 0x264A740 VA: 0x264E740
	public byte get_DamageLabelScaleSelect() { }

	// RVA: 0x264E748 Offset: 0x264A748 VA: 0x264E748
	public float get_DamageLabelScale() { }

	// RVA: 0x264E760 Offset: 0x264A760 VA: 0x264E760
	public bool get_IsPopDamageLabel() { }

	[CompilerGenerated]
	// RVA: 0x264E780 Offset: 0x264A780 VA: 0x264E780
	private void set_IsAttackAreaEx(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E78C Offset: 0x264A78C VA: 0x264E78C
	public bool get_IsAttackAreaEx() { }

	[CompilerGenerated]
	// RVA: 0x264E794 Offset: 0x264A794 VA: 0x264E794
	private void set_AttackAreaBlendPower(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E79C Offset: 0x264A79C VA: 0x264E79C
	public byte get_AttackAreaBlendPower() { }

	[CompilerGenerated]
	// RVA: 0x264E7A4 Offset: 0x264A7A4 VA: 0x264E7A4
	private void set_AttackAreaOutLine(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264E7AC Offset: 0x264A7AC VA: 0x264E7AC
	public byte get_AttackAreaOutLine() { }

	[CompilerGenerated]
	// RVA: 0x264E7B4 Offset: 0x264A7B4 VA: 0x264E7B4
	private void set_IsAndroidNotchUI(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264E7C0 Offset: 0x264A7C0 VA: 0x264E7C0
	public bool get_IsAndroidNotchUI() { }

	// RVA: 0x264E7C8 Offset: 0x264A7C8 VA: 0x264E7C8 Slot: 4
	public virtual byte get_DefaultDamageLabelScaleSelect() { }

	// RVA: 0x264E7D0 Offset: 0x264A7D0 VA: 0x264E7D0 Slot: 5
	public virtual bool get_DefaultD3SignBoardFlag() { }

	// RVA: 0x264D5E0 Offset: 0x26495E0 VA: 0x264D5E0
	public void .ctor() { }

	// RVA: 0x264E7D8 Offset: 0x264A7D8 VA: 0x264E7D8 Slot: 6
	public virtual void GrahicsOptionSave() { }

	// RVA: 0x264EA4C Offset: 0x264AA4C VA: 0x264EA4C
	private void ColorToInt(string save, Color32 colorData) { }

	// RVA: 0x264EA74 Offset: 0x264AA74 VA: 0x264EA74 Slot: 7
	public virtual void GrahicsOptionLoad() { }

	// RVA: 0x264ED60 Offset: 0x264AD60 VA: 0x264ED60 Slot: 8
	public virtual bool SetFlag(OptionsGraphics.GraphicOptionType Type, bool setFlag) { }

	// RVA: 0x264EE08 Offset: 0x264AE08 VA: 0x264EE08 Slot: 9
	public virtual bool SetParam(OptionsGraphics.GraphicOptionType Type, int setParam) { }
}
