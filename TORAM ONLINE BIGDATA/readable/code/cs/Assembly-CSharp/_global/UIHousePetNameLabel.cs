// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHousePetNameLabel : UINameLabel // TypeDefIndex: 8928
{
	// Fields
	private long uid; // 0x88
	[SerializeField]
	private GameObject icon; // 0x90
	private PetDataManager.PetViewData petViewData; // 0x98

	// Properties
	protected override bool ActiveFlag { get; }
	public override bool IsEnabled { get; }

	// Methods

	// RVA: 0x1E58C04 Offset: 0x1E54C04 VA: 0x1E58C04 Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E58C0C Offset: 0x1E54C0C VA: 0x1E58C0C Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E58C68 Offset: 0x1E54C68 VA: 0x1E58C68
	public void Initialize(long uid, Transform traceObject, string name, float height) { }

	// RVA: 0x1E58EEC Offset: 0x1E54EEC VA: 0x1E58EEC Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E59074 Offset: 0x1E55074 VA: 0x1E59074 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E59158 Offset: 0x1E55158 VA: 0x1E59158
	public void .ctor() { }
}
