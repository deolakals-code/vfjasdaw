// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDefenceResultManager : UIBasePanel // TypeDefIndex: 5758
{
	// Fields
	[SerializeField]
	private GameObject modelParent; // 0x30
	[SerializeField]
	private GameObject titleObj; // 0x38
	[SerializeField]
	private UILabel[] titleLabel; // 0x40
	[SerializeField]
	private GameObject titleIcon; // 0x48
	[SerializeField]
	private GameObject titleBackIcon; // 0x50
	[SerializeField]
	private GameObject resultObj; // 0x58
	[SerializeField]
	private UILabel scorePointLabel; // 0x60
	[SerializeField]
	private UILabel scoreTimeLabel; // 0x68
	[SerializeField]
	private UILabel[] scoreBonusLabel; // 0x70
	[SerializeField]
	private UILabel expLabel; // 0x78
	[SerializeField]
	private UILabel buttonLabel; // 0x80
	[SerializeField]
	private GameObject[] panelObj; // 0x88
	private UIDefenceResultManager.PanelState panelState; // 0x90
	private bool successFlag; // 0x94
	private float successEffectAng; // 0x98
	private float successLabelScale; // 0x9C
	private bool labelScaleFlag; // 0xA0
	private bool retireFlag; // 0xA1
	private Action callback; // 0xA8
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0xB0
	[CompilerGenerated]
	private bool <IsResultEnd>k__BackingField; // 0xB1

	// Properties
	public bool IsClose { get; set; }
	public bool IsResultEnd { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x17DDFC4 Offset: 0x17D9FC4 VA: 0x17DDFC4
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x17DDFCC Offset: 0x17D9FCC VA: 0x17DDFCC
	private void set_IsClose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x17DDFD8 Offset: 0x17D9FD8 VA: 0x17DDFD8
	public bool get_IsResultEnd() { }

	[CompilerGenerated]
	// RVA: 0x17DDFE0 Offset: 0x17D9FE0 VA: 0x17DDFE0
	private void set_IsResultEnd(bool value) { }

	// RVA: 0x17DDFEC Offset: 0x17D9FEC VA: 0x17DDFEC
	private void Start() { }

	// RVA: 0x17DDFF0 Offset: 0x17D9FF0 VA: 0x17DDFF0
	public void Initialize(byte endCode, int totalScore, TimeSpan timeLeft, Dictionary<byte, int> bonusList, int exp) { }

	// RVA: 0x17DEFD4 Offset: 0x17DAFD4 VA: 0x17DEFD4
	public void SetCallback(Action callback) { }

	// RVA: 0x17DEFDC Offset: 0x17DAFDC VA: 0x17DEFDC
	private void Update() { }

	// RVA: 0x17DF1C8 Offset: 0x17DB1C8 VA: 0x17DF1C8
	private void onEnd() { }

	// RVA: 0x17DF504 Offset: 0x17DB504 VA: 0x17DF504 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17DF56C Offset: 0x17DB56C VA: 0x17DF56C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17DF610 Offset: 0x17DB610 VA: 0x17DF610
	public void .ctor() { }
}
