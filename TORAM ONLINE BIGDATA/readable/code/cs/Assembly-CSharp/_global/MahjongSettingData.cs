// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongSettingData // TypeDefIndex: 4434
{
	// Fields
	private MahjongSettingData.DiscardType discardType; // 0x10
	private bool isMoveCamera; // 0x14
	private int voiceTypeId; // 0x18
	private int voiceVolume; // 0x1C
	private bool isTileLabelActive; // 0x20

	// Properties
	public MahjongSettingData.DiscardType UserDiscardType { get; }
	public bool IsMoveCamera { get; }
	public int VoiceTypeId { get; }
	public int VoiceVolume { get; }
	public bool IsTileLabelActive { get; }

	// Methods

	// RVA: 0x24F40A4 Offset: 0x24F00A4 VA: 0x24F40A4
	public MahjongSettingData.DiscardType get_UserDiscardType() { }

	// RVA: 0x24F40AC Offset: 0x24F00AC VA: 0x24F40AC
	public bool get_IsMoveCamera() { }

	// RVA: 0x24F40B4 Offset: 0x24F00B4 VA: 0x24F40B4
	public int get_VoiceTypeId() { }

	// RVA: 0x24F40BC Offset: 0x24F00BC VA: 0x24F40BC
	public int get_VoiceVolume() { }

	// RVA: 0x24F40C4 Offset: 0x24F00C4 VA: 0x24F40C4
	public bool get_IsTileLabelActive() { }

	// RVA: 0x24F40CC Offset: 0x24F00CC VA: 0x24F40CC
	public void .ctor(byte discardType, bool isMoveCamera, int voiceType, int voiceVolume, bool isTileLabelActive) { }

	// RVA: 0x24F4124 Offset: 0x24F0124 VA: 0x24F4124
	public void ChangeDiscardType(MahjongSettingData.DiscardType discardType) { }

	// RVA: 0x24F412C Offset: 0x24F012C VA: 0x24F412C
	public void ChangeMoveCameraFlag(bool flag) { }

	// RVA: 0x24F4138 Offset: 0x24F0138 VA: 0x24F4138
	public void ChangeVoiceTypeId(int id) { }

	// RVA: 0x24F4154 Offset: 0x24F0154 VA: 0x24F4154
	public void ChangeVoiceVolume(int volume) { }

	// RVA: 0x24F416C Offset: 0x24F016C VA: 0x24F416C
	public void ChangeTileLabelActive(bool flag) { }
}
