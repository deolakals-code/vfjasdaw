// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISnowballHpPanel : MonoBehaviour // TypeDefIndex: 6018
{
	// Fields
	[SerializeField]
	private UISprite[] hpSprites; // 0x20
	[SerializeField]
	private UILabel hpLabel; // 0x28
	private const int hpWidth = 200;
	private float redHpPercent; // 0x30
	private float blueHpPercent; // 0x34
	private MiniGameRoomData roomData; // 0x38
	private UIIruna2Anchor anchor; // 0x40
	private bool isEnable; // 0x48
	private SystemTextManager systemTextManager; // 0x50

	// Methods

	// RVA: 0x186CDDC Offset: 0x1868DDC VA: 0x186CDDC
	private void Start() { }

	// RVA: 0x1869350 Offset: 0x1865350 VA: 0x1869350
	public void SetEnable(bool isEnable) { }

	// RVA: 0x18694BC Offset: 0x18654BC VA: 0x18694BC
	public void InitHp(MiniGameRoomData roomData) { }

	// RVA: 0x186696C Offset: 0x186296C VA: 0x186696C
	public void UpdateHp() { }

	// RVA: 0x186CEC4 Offset: 0x1868EC4 VA: 0x186CEC4
	public void .ctor() { }
}
