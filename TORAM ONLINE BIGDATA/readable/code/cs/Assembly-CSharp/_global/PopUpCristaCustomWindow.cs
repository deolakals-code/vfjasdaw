// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpCristaCustomWindow : PopBaseWindow // TypeDefIndex: 8784
{
	// Fields
	private int cristaItemId; // 0x20
	private GameObject systemIconObject; // 0x28
	private GameObject iconObject; // 0x30
	private readonly int[] SpecificCristaIds; // 0x38
	private int messageAction; // 0x40

	// Methods

	// RVA: 0x1E0B120 Offset: 0x1E07120 VA: 0x1E0B120
	public void .ctor(int cristaId, GameObject systemIcon, GameObject icon) { }

	// RVA: 0x1E0B1F0 Offset: 0x1E071F0 VA: 0x1E0B1F0 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E0BDA4 Offset: 0x1E07DA4 VA: 0x1E0BDA4 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E0BDB8 Offset: 0x1E07DB8 VA: 0x1E0BDB8 Slot: 7
	public override int MessageCheck() { }
}
