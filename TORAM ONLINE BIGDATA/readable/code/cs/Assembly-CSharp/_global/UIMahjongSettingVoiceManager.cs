// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongSettingVoiceManager : UIMahjongSettingContentManagerBase // TypeDefIndex: 5957
{
	// Fields
	[SerializeField]
	private UISprite[] voiceTypeIcons; // 0x30
	[SerializeField]
	private UISlider slider; // 0x38
	[SerializeField]
	private UILabel voiceVolumeLabel; // 0x40
	[SerializeField]
	private GameObject changeWarningLabel; // 0x48
	[SerializeField]
	private GameObject[] titleActiveObjects; // 0x50
	[SerializeField]
	private GameObject line; // 0x58
	private MahjongRoomData roomData; // 0x60
	private int[] auditionVoiceIds; // 0x68
	private int voiceVolume; // 0x70
	private float titleLinePosY; // 0x74

	// Properties
	public override UIMahjongSettingContentManagerBase.SettingType settingType { get; }

	// Methods

	// RVA: 0x1852A40 Offset: 0x184EA40 VA: 0x1852A40 Slot: 4
	public override UIMahjongSettingContentManagerBase.SettingType get_settingType() { }

	// RVA: 0x1852A48 Offset: 0x184EA48 VA: 0x1852A48 Slot: 5
	public override void Initialize(MahjongRoomData roomData) { }

	// RVA: 0x1852D40 Offset: 0x184ED40 VA: 0x1852D40
	public void OnClickChangeVoiceType(int type) { }

	// RVA: 0x1852DCC Offset: 0x184EDCC VA: 0x1852DCC
	public void OnClickAuditionVoice(int type) { }

	// RVA: 0x1852CC0 Offset: 0x184ECC0 VA: 0x1852CC0
	private void ChangeTogglesSprite(int activeType) { }

	// RVA: 0x1852E6C Offset: 0x184EE6C VA: 0x1852E6C
	public void OnSliderChange(float param) { }

	// RVA: 0x1852FE4 Offset: 0x184EFE4 VA: 0x1852FE4
	public void OnSliderValueChanged() { }

	// RVA: 0x185300C Offset: 0x184F00C VA: 0x185300C
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1853034 Offset: 0x184F034 VA: 0x1853034
	private void OnPressThumb(GameObject go, bool pressed) { }

	// RVA: 0x185305C Offset: 0x184F05C VA: 0x185305C
	private void OnDragThumb(GameObject go, Vector3 delta) { }

	// RVA: 0x1853084 Offset: 0x184F084 VA: 0x1853084
	private void OnPress(bool pressed) { }

	// RVA: 0x18530BC Offset: 0x184F0BC VA: 0x18530BC
	public void .ctor() { }
}
