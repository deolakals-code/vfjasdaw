// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SyntheticMedicineCreateBar : MonoBehaviour // TypeDefIndex: 8733
{
	// Fields
	[SerializeField]
	private LocalizeText completeLabel; // 0x20
	[SerializeField]
	private UIScrollBar createBar; // 0x28
	[SerializeField]
	private UISprite messageBackGround; // 0x30
	[CompilerGenerated]
	private bool <IsFinished>k__BackingField; // 0x38
	private static readonly int MaxCreateSetNum; // 0x0
	private SystemTextManager systemTextManager; // 0x40
	private int successNum; // 0x48
	private float createTime; // 0x4C
	private int receiveCount; // 0x50

	// Properties
	public bool IsFinished { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DF9710 Offset: 0x1DF5710 VA: 0x1DF9710
	public bool get_IsFinished() { }

	[CompilerGenerated]
	// RVA: 0x1DF9718 Offset: 0x1DF5718 VA: 0x1DF9718
	private void set_IsFinished(bool value) { }

	// RVA: 0x1DF9724 Offset: 0x1DF5724 VA: 0x1DF9724
	private void Awake() { }

	[IteratorStateMachine(typeof(SyntheticMedicineCreateBar.<StartProgress>d__13))]
	// RVA: 0x1DF7E88 Offset: 0x1DF3E88 VA: 0x1DF7E88
	public IEnumerator StartProgress(int createSetNum, int createValue) { }

	// RVA: 0x1DF6E40 Offset: 0x1DF2E40 VA: 0x1DF6E40
	public void ProgressResponseUpdate(int successNum, int sendCreateNum, int createValue) { }

	// RVA: 0x1DF6E14 Offset: 0x1DF2E14 VA: 0x1DF6E14
	public void MessageBackHeightChange(bool canCancel) { }

	[IteratorStateMachine(typeof(SyntheticMedicineCreateBar.<FailureCreateBar>d__16))]
	// RVA: 0x1DF9834 Offset: 0x1DF5834 VA: 0x1DF9834
	private IEnumerator FailureCreateBar() { }

	// RVA: 0x1DF98C8 Offset: 0x1DF58C8 VA: 0x1DF98C8
	public void .ctor() { }

	// RVA: 0x1DF98D0 Offset: 0x1DF58D0 VA: 0x1DF98D0
	private static void .cctor() { }
}
