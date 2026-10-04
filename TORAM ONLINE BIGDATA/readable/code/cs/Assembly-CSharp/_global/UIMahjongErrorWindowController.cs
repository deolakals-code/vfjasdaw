// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongErrorWindowController : MonoBehaviour // TypeDefIndex: 5879
{
	// Fields
	[SerializeField]
	private UILabel errorLabel; // 0x20
	[SerializeField]
	private UIButtonCallAction okButton; // 0x28
	[SerializeField]
	private UILabel okButtonLabel; // 0x30
	private MahjongRoomData roomData; // 0x38
	private UIMahjongMainManager main; // 0x40
	private Action errorButtonAction; // 0x48
	private Action closeButtonAction; // 0x50

	// Methods

	// RVA: 0x1816E98 Offset: 0x1812E98 VA: 0x1816E98
	public void Initialize(MahjongRoomData room, UIMahjongMainManager main) { }

	// RVA: 0x1816EC8 Offset: 0x1812EC8 VA: 0x1816EC8
	public void PopUpErrorWindow(string errorMes, byte operationSubCode) { }

	// RVA: 0x181713C Offset: 0x181313C VA: 0x181713C
	public void SetErrorTexts(string message, Action buttonAction, Action closeButtonAction, string buttonMes = "") { }

	// RVA: 0x181725C Offset: 0x181325C VA: 0x181725C
	public void OnClickOkButton() { }

	// RVA: 0x18172A0 Offset: 0x18132A0 VA: 0x18172A0
	public void OnClickCloseButton() { }

	// RVA: 0x18172E4 Offset: 0x18132E4 VA: 0x18172E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18172EC Offset: 0x18132EC VA: 0x18172EC
	private void <PopUpErrorWindow>b__8_2() { }

	[CompilerGenerated]
	// RVA: 0x181730C Offset: 0x181330C VA: 0x181730C
	private void <PopUpErrorWindow>b__8_3() { }

	[CompilerGenerated]
	// RVA: 0x181732C Offset: 0x181332C VA: 0x181732C
	private void <PopUpErrorWindow>b__8_4() { }

	[CompilerGenerated]
	// RVA: 0x1817714 Offset: 0x1813714 VA: 0x1817714
	private void <PopUpErrorWindow>b__8_5() { }

	[CompilerGenerated]
	// RVA: 0x1817734 Offset: 0x1813734 VA: 0x1817734
	private void <PopUpErrorWindow>b__8_0() { }

	[CompilerGenerated]
	// RVA: 0x1817754 Offset: 0x1813754 VA: 0x1817754
	private void <PopUpErrorWindow>b__8_1() { }
}
