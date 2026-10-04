// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongResultYakuContentManager : MonoBehaviour // TypeDefIndex: 5937
{
	// Fields
	[SerializeField]
	private UILabel yakuNameLabel; // 0x20
	[SerializeField]
	private UILabel hanLabel; // 0x28
	[SerializeField]
	private TweenAlpha tweenAlpha; // 0x30
	[SerializeField]
	private TweenPosition tweenPosition; // 0x38
	private SystemTextManager sys; // 0x40
	private MahjongRoomData roomData; // 0x48
	private MahjongYakuType yakuType; // 0x50
	private const int yakuNameLabelSize = 230;
	private const int hanLabelSize = 75;

	// Properties
	public MahjongYakuType YakuType { get; }

	// Methods

	// RVA: 0x184D564 Offset: 0x1849564 VA: 0x184D564
	public MahjongYakuType get_YakuType() { }

	// RVA: 0x184D56C Offset: 0x184956C VA: 0x184D56C
	public void SetYaku(MahjongRoomData roomData, MahjongYakuType yakuType, int han) { }

	// RVA: 0x184C63C Offset: 0x184863C VA: 0x184C63C
	public void PlayAnim() { }

	// RVA: 0x184D7D4 Offset: 0x18497D4 VA: 0x184D7D4
	public void .ctor() { }
}
