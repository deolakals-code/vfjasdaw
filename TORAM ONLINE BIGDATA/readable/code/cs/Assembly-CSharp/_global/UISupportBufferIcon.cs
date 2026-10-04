// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISupportBufferIcon : MonoBehaviour // TypeDefIndex: 6576
{
	// Fields
	[SerializeField]
	private Vector3 TextScale; // 0x20
	[SerializeField]
	private Vector3 TimeLabelPosition; // 0x2C
	[SerializeField]
	private Vector3 CountLabelPosition; // 0x38
	[SerializeField]
	private Vector3 iconScale; // 0x44
	[SerializeField]
	private UIGLIcon icon; // 0x50
	[SerializeField]
	private UIGLLabel timeLabel; // 0x58
	[SerializeField]
	private UIGLLabel countLabel; // 0x60
	private UISupportBufferIcon.BufferType buffType; // 0x68
	private float remainingTime; // 0x6C
	private bool isLabelEnabled; // 0x70
	private byte lastCheckFlag; // 0x71
	private OptionsGraphics opGraphics; // 0x78
	[CompilerGenerated]
	private int <DestPosX>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <IsSelf>k__BackingField; // 0x84
	[CompilerGenerated]
	private bool <IsEquip>k__BackingField; // 0x85
	private ItemDBData.EquipType equipType; // 0x88
	[CompilerGenerated]
	private bool <IsHide>k__BackingField; // 0x8C
	[CompilerGenerated]
	private DateTime <CreateTime>k__BackingField; // 0x90
	private UISupportBufferIcon.IconType iconType; // 0x98

	// Properties
	public UIGLIcon Icon { get; }
	public UIGLLabel CountLabel { get; }
	public UISupportBufferIcon.BufferType BuffType { get; }
	public float RemainingTime { get; }
	public bool IsLabelEnabled { get; }
	public int BuffTypePriority { get; }
	private OptionsGraphics optionsGraphics { get; }
	public int DestPosX { get; set; }
	public bool IsSelf { get; set; }
	public bool IsEquip { get; set; }
	public ItemDBData.EquipType EquipType { get; }
	public bool IsHide { get; set; }
	public DateTime CreateTime { get; set; }
	private bool IsSkillIcon { get; }
	private bool IsRPropertyIcon { get; }

	// Methods

	// RVA: 0x198C6FC Offset: 0x19886FC VA: 0x198C6FC
	public UIGLIcon get_Icon() { }

	// RVA: 0x198C704 Offset: 0x1988704 VA: 0x198C704
	public UIGLLabel get_CountLabel() { }

	// RVA: 0x198C708 Offset: 0x1988708 VA: 0x198C708
	public UISupportBufferIcon.BufferType get_BuffType() { }

	// RVA: 0x198C710 Offset: 0x1988710 VA: 0x198C710
	public float get_RemainingTime() { }

	// RVA: 0x198C748 Offset: 0x1988748 VA: 0x198C748
	public bool get_IsLabelEnabled() { }

	// RVA: 0x198C750 Offset: 0x1988750 VA: 0x198C750
	public int get_BuffTypePriority() { }

	// RVA: 0x198C820 Offset: 0x1988820 VA: 0x198C820
	private OptionsGraphics get_optionsGraphics() { }

	[CompilerGenerated]
	// RVA: 0x198C88C Offset: 0x198888C VA: 0x198C88C
	public int get_DestPosX() { }

	[CompilerGenerated]
	// RVA: 0x198C894 Offset: 0x1988894 VA: 0x198C894
	private void set_DestPosX(int value) { }

	[CompilerGenerated]
	// RVA: 0x198C89C Offset: 0x198889C VA: 0x198C89C
	public bool get_IsSelf() { }

	[CompilerGenerated]
	// RVA: 0x198C8A4 Offset: 0x19888A4 VA: 0x198C8A4
	private void set_IsSelf(bool value) { }

	[CompilerGenerated]
	// RVA: 0x198C8B0 Offset: 0x19888B0 VA: 0x198C8B0
	public bool get_IsEquip() { }

	[CompilerGenerated]
	// RVA: 0x198C8B8 Offset: 0x19888B8 VA: 0x198C8B8
	private void set_IsEquip(bool value) { }

	// RVA: 0x198C8C4 Offset: 0x19888C4 VA: 0x198C8C4
	public ItemDBData.EquipType get_EquipType() { }

	[CompilerGenerated]
	// RVA: 0x198C8CC Offset: 0x19888CC VA: 0x198C8CC
	public bool get_IsHide() { }

	[CompilerGenerated]
	// RVA: 0x198C8D4 Offset: 0x19888D4 VA: 0x198C8D4
	private void set_IsHide(bool value) { }

	[CompilerGenerated]
	// RVA: 0x198C8E0 Offset: 0x19888E0 VA: 0x198C8E0
	public DateTime get_CreateTime() { }

	[CompilerGenerated]
	// RVA: 0x198C8E8 Offset: 0x19888E8 VA: 0x198C8E8
	private void set_CreateTime(DateTime value) { }

	// RVA: 0x198C8F0 Offset: 0x19888F0 VA: 0x198C8F0
	private bool get_IsSkillIcon() { }

	// RVA: 0x198C900 Offset: 0x1988900 VA: 0x198C900
	private bool get_IsRPropertyIcon() { }

	// RVA: 0x198C910 Offset: 0x1988910 VA: 0x198C910
	private void OnEnable() { }

	// RVA: 0x198CC9C Offset: 0x1988C9C VA: 0x198CC9C
	private void OnDisable() { }

	// RVA: 0x198CD00 Offset: 0x1988D00 VA: 0x198CD00
	public void Initialize() { }

	// RVA: 0x198CD1C Offset: 0x1988D1C VA: 0x198CD1C
	public void ResetTime() { }

	// RVA: 0x198CD78 Offset: 0x1988D78 VA: 0x198CD78
	public void SetIconType(UISupportBufferIcon.IconType iconType) { }

	// RVA: 0x198C98C Offset: 0x198898C VA: 0x198C98C
	public void IconViewUpdate() { }

	// RVA: 0x198CE40 Offset: 0x1988E40 VA: 0x198CE40
	public bool IsSkillTextUpdate() { }

	// RVA: 0x198CEB0 Offset: 0x1988EB0 VA: 0x198CEB0
	public void TextScaleChange(bool isActive) { }

	// RVA: 0x198D0DC Offset: 0x19890DC VA: 0x198D0DC
	public void HideIcon() { }

	// RVA: 0x198D23C Offset: 0x198923C VA: 0x198D23C
	public void UpdateText(string timeText, float time = 0, string countText = "") { }

	// RVA: 0x198D2D4 Offset: 0x19892D4 VA: 0x198D2D4
	public void TextClear() { }

	// RVA: 0x198D33C Offset: 0x198933C VA: 0x198D33C
	public void SetBufferType(UISupportBufferIcon.BufferType type) { }

	// RVA: 0x198D344 Offset: 0x1989344 VA: 0x198D344
	public void SetDestPos(int posX) { }

	// RVA: 0x198D34C Offset: 0x198934C VA: 0x198D34C
	public void SetSelfFlag(bool isSelf) { }

	// RVA: 0x198D358 Offset: 0x1989358 VA: 0x198D358
	public void SetEquipType(ItemDBData.EquipType type) { }

	// RVA: 0x198D094 Offset: 0x1989094 VA: 0x198D094
	private bool IsCountLabelActive() { }

	// RVA: 0x198CD80 Offset: 0x1988D80 VA: 0x198CD80
	private bool CheckViewOption() { }

	// RVA: 0x198D104 Offset: 0x1989104 VA: 0x198D104
	private void SetHide(bool isHide) { }

	// RVA: 0x198D03C Offset: 0x198903C VA: 0x198D03C
	private bool CheckOptionViewIcon() { }

	// RVA: 0x198CDD8 Offset: 0x1988DD8 VA: 0x198CDD8
	private bool CheckOptionViewTime() { }

	// RVA: 0x198CE0C Offset: 0x1988E0C VA: 0x198CE0C
	private bool CheckOptionViewCount() { }

	// RVA: 0x198D368 Offset: 0x1989368 VA: 0x198D368
	public void .ctor() { }
}
