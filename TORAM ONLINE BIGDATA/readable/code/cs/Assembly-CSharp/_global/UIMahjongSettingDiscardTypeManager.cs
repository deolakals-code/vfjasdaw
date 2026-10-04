// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongSettingDiscardTypeManager : UIMahjongSettingContentManagerBase // TypeDefIndex: 5955
{
	// Fields
	[SerializeField]
	private UISprite doubleButton; // 0x30
	[SerializeField]
	private UILabel doubleLabel; // 0x38
	[SerializeField]
	private UISprite singleButton; // 0x40
	[SerializeField]
	private UILabel singleLabel; // 0x48
	private bool isSingleActive; // 0x50
	private MahjongRoomData roomData; // 0x58

	// Properties
	public override UIMahjongSettingContentManagerBase.SettingType settingType { get; }

	// Methods

	// RVA: 0x18524C8 Offset: 0x184E4C8 VA: 0x18524C8 Slot: 4
	public override UIMahjongSettingContentManagerBase.SettingType get_settingType() { }

	// RVA: 0x18524D0 Offset: 0x184E4D0 VA: 0x18524D0 Slot: 5
	public override void Initialize(MahjongRoomData roomData) { }

	// RVA: 0x18526A8 Offset: 0x184E6A8 VA: 0x18526A8
	public void OnClickDouble() { }

	// RVA: 0x1852798 Offset: 0x184E798 VA: 0x1852798
	public void OnClickSingle() { }

	// RVA: 0x1852718 Offset: 0x184E718 VA: 0x1852718
	private void ChangeButtonsSprite() { }

	// RVA: 0x185280C Offset: 0x184E80C VA: 0x185280C
	public void .ctor() { }
}
