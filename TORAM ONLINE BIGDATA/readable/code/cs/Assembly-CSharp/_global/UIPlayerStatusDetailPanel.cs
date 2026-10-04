// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPlayerStatusDetailPanel : MonoBehaviour // TypeDefIndex: 8052
{
	// Fields
	[SerializeField]
	private GameObject mainViewPanel; // 0x20
	[SerializeField]
	private GameObject scrollViewPanel; // 0x28
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x30
	[SerializeField]
	private GameObject topMesElement; // 0x38
	[SerializeField]
	private GameObject changeButtonElement; // 0x40
	[SerializeField]
	private GameObject textElement; // 0x48
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x50
	private UIPlayerStatusDetailPanel.PanelType nowPanelType; // 0x54
	private PlayerDataManager playerDataManager; // 0x58
	private PlayerActionManagerBase actionManager; // 0x60
	private PlayerPrimaryStatus primaryStatus; // 0x68
	private PlayerStatusBase playerStatus; // 0x70
	private PlayerSecondaryStatus secondaryStatus; // 0x78
	private SystemTextManager systemTextManager; // 0x80
	private List<UIPlayerStatusDetailPanel.DetailStatusData> dataList; // 0x88
	private List<GameObject> elementList; // 0x90
	private const float TextObjextHeight = 35;
	private Vector3 scrollCameraPos; // 0x98
	private int[] serverBonusList; // 0xA8
	private bool isGetServerBonus; // 0xB0

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CAD754 Offset: 0x1CA9754 VA: 0x1CAD754
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x1CAD75C Offset: 0x1CA975C VA: 0x1CAD75C
	private void set_IsOpen(bool value) { }

	// RVA: 0x1CAD768 Offset: 0x1CA9768 VA: 0x1CAD768
	private void Start() { }

	// RVA: 0x1CADA10 Offset: 0x1CA9A10 VA: 0x1CADA10
	private void Update() { }

	// RVA: 0x1CADB30 Offset: 0x1CA9B30 VA: 0x1CADB30
	public void Open() { }

	// RVA: 0x1CADBBC Offset: 0x1CA9BBC VA: 0x1CADBBC
	public void Close() { }

	// RVA: 0x1CADC3C Offset: 0x1CA9C3C VA: 0x1CADC3C
	public void OnChangeButton() { }

	[IteratorStateMachine(typeof(UIPlayerStatusDetailPanel.<OpenRoutine>d__34))]
	// RVA: 0x1CADB50 Offset: 0x1CA9B50 VA: 0x1CADB50
	private IEnumerator OpenRoutine() { }

	// RVA: 0x1CADC50 Offset: 0x1CA9C50 VA: 0x1CADC50
	private void ChangePanel(UIPlayerStatusDetailPanel.PanelType panelType) { }

	// RVA: 0x1CAE46C Offset: 0x1CAA46C VA: 0x1CAE46C
	private GameObject CreateTextElement(UIPlayerStatusDetailPanel.DetailStatusData data, Vector3 pos) { }

	// RVA: 0x1CAE790 Offset: 0x1CAA790 VA: 0x1CAE790
	private void SetValueText(UIPlayerStatusDetailPanel.DetailStatusData data, UILabel numLabel, UILabel subLabel, UILabel overLabel) { }

	// RVA: 0x1CADA20 Offset: 0x1CA9A20 VA: 0x1CADA20
	private void UpdateElement() { }

	// RVA: 0x1CAEC90 Offset: 0x1CAAC90 VA: 0x1CAEC90
	private void InitData() { }

	// RVA: 0x1CAED6C Offset: 0x1CAAD6C VA: 0x1CAED6C
	private void AddBasicStatus() { }

	// RVA: 0x1CAEEAC Offset: 0x1CAAEAC VA: 0x1CAEEAC
	private void AddHpStatus() { }

	// RVA: 0x1CAF02C Offset: 0x1CAB02C VA: 0x1CAF02C
	private void AddBattleStatus() { }

	// RVA: 0x1CB0858 Offset: 0x1CAC858 VA: 0x1CB0858
	private int CalcSubAtkValue() { }

	// RVA: 0x1CB08F8 Offset: 0x1CAC8F8 VA: 0x1CB08F8
	private float CalcPhysicsResistBreakerValue() { }

	// RVA: 0x1CB097C Offset: 0x1CAC97C VA: 0x1CB097C
	private float CalcMagicResistBreakerValue() { }

	// RVA: 0x1CB0A00 Offset: 0x1CACA00 VA: 0x1CB0A00
	private int CalcPowerDmgCutValue() { }

	// RVA: 0x1CB0ACC Offset: 0x1CACACC VA: 0x1CB0ACC
	private int CalcMagicDmgCutValue() { }

	// RVA: 0x1CAF35C Offset: 0x1CAB35C VA: 0x1CAF35C
	private void AddCriticalStatus() { }

	// RVA: 0x1CAF4A4 Offset: 0x1CAB4A4 VA: 0x1CAF4A4
	private void AddSpeedStatus() { }

	// RVA: 0x1CAF5C4 Offset: 0x1CAB5C4 VA: 0x1CAF5C4
	private void AddRangeAttackStatus() { }

	// RVA: 0x1CB0B98 Offset: 0x1CACB98 VA: 0x1CB0B98
	private float CalcShortRangeValue() { }

	// RVA: 0x1CB0C14 Offset: 0x1CACC14 VA: 0x1CB0C14
	private float CalcLongRangeValue() { }

	// RVA: 0x1CAF6D4 Offset: 0x1CAB6D4 VA: 0x1CAF6D4
	private void AddHateToRespawnStatus() { }

	// RVA: 0x1CB0C90 Offset: 0x1CACC90 VA: 0x1CB0C90
	private int CalcExpValue() { }

	// RVA: 0x1CB0DE8 Offset: 0x1CACDE8 VA: 0x1CB0DE8
	private float CalcPetExpValue() { }

	// RVA: 0x1CB0EA0 Offset: 0x1CACEA0 VA: 0x1CB0EA0
	private int CalcDropValue() { }

	// RVA: 0x1CAF908 Offset: 0x1CAB908 VA: 0x1CAF908
	private void AddElementKillerStatus() { }

	// RVA: 0x1CAFAA0 Offset: 0x1CABAA0 VA: 0x1CAFAA0
	private void AddElementShieldStatus() { }

	// RVA: 0x1CAFC60 Offset: 0x1CABC60 VA: 0x1CAFC60
	private void AddResistStatus() { }

	// RVA: 0x1CAFEEC Offset: 0x1CABEEC VA: 0x1CAFEEC
	private void AddBarrierStatus() { }

	// RVA: 0x1CB01C8 Offset: 0x1CAC1C8 VA: 0x1CB01C8
	private void AddAbsoluteStatus() { }

	// RVA: 0x1CB0308 Offset: 0x1CAC308 VA: 0x1CB0308
	private void AddBreakerStatus() { }

	// RVA: 0x1CB0F40 Offset: 0x1CACF40 VA: 0x1CB0F40
	private float CalcAvoidBreakerValue() { }

	// RVA: 0x1CB10C4 Offset: 0x1CAD0C4 VA: 0x1CB10C4
	private float CalcGuardBreakerValue() { }

	// RVA: 0x1CB0380 Offset: 0x1CAC380 VA: 0x1CB0380
	private void AddDamageStatus() { }

	// RVA: 0x1CB124C Offset: 0x1CAD24C VA: 0x1CB124C
	private float CalcPhysicalPursuitValue() { }

	// RVA: 0x1CB12F0 Offset: 0x1CAD2F0 VA: 0x1CB12F0
	private float CalcMagicPursuitValue() { }

	// RVA: 0x1CB0528 Offset: 0x1CAC528 VA: 0x1CB0528
	private void AddGrantStopStatus() { }

	// RVA: 0x1CB0764 Offset: 0x1CAC764 VA: 0x1CB0764
	private void AddDataBlank() { }

	// RVA: 0x1CB0634 Offset: 0x1CAC634 VA: 0x1CB0634
	private void AddDataStatus(UIPlayerStatusDetailPanel.DetailStatusType statusType, float value, UIPlayerStatusDetailPanel.DisplayFormatType formatType, float defaultValue = 0, double maxValue = 2147483647, double minValue = -2147483648, float subValue = -1) { }

	// RVA: 0x1CB14F0 Offset: 0x1CAD4F0 VA: 0x1CB14F0
	public void .ctor() { }
}
