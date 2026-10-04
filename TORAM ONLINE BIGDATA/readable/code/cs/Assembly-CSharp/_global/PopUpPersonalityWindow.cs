// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpPersonalityWindow : PopBaseWindow // TypeDefIndex: 8807
{
	// Fields
	private readonly string[] PersonalityType; // 0x20
	private int messageAction; // 0x28
	private int selectPersonality; // 0x2C
	private UILabel selectPersonalityLabel; // 0x30
	private UILabel selectPersonalityLabelText; // 0x38
	private UILabel selectPersonalityText; // 0x40
	private GameObject leftButton; // 0x48
	private GameObject rightButton; // 0x50

	// Methods

	// RVA: 0x1E10FE8 Offset: 0x1E0CFE8 VA: 0x1E10FE8
	public void .ctor(GameObject leftButton, GameObject rightButton) { }

	// RVA: 0x1E11154 Offset: 0x1E0D154 VA: 0x1E11154 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E115A0 Offset: 0x1E0D5A0 VA: 0x1E115A0
	private void changeText() { }

	// RVA: 0x1E1170C Offset: 0x1E0D70C VA: 0x1E1170C Slot: 5
	public override void Update() { }

	// RVA: 0x1E11710 Offset: 0x1E0D710 VA: 0x1E11710 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E11794 Offset: 0x1E0D794 VA: 0x1E11794 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E1179C Offset: 0x1E0D79C VA: 0x1E1179C Slot: 8
	public override void Close() { }
}
