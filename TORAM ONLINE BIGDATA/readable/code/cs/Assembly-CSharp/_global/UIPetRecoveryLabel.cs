// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetRecoveryLabel : UINameLabel // TypeDefIndex: 9012
{
	// Fields
	private PetMember petMember; // 0x88
	private TakeController takeController; // 0x90
	private float takeCount; // 0x98
	private bool isTake; // 0x9C

	// Properties
	protected override bool ActiveFlag { get; }
	public override bool IsEnabled { get; }

	// Methods

	// RVA: 0x1E9191C Offset: 0x1E8D91C VA: 0x1E9191C Slot: 4
	protected override bool get_ActiveFlag() { }

	// RVA: 0x1E91924 Offset: 0x1E8D924 VA: 0x1E91924 Slot: 5
	public override bool get_IsEnabled() { }

	// RVA: 0x1E91B04 Offset: 0x1E8DB04 VA: 0x1E91B04
	public void Initialize(Transform traceObject) { }

	// RVA: 0x1E91BFC Offset: 0x1E8DBFC VA: 0x1E91BFC Slot: 8
	protected override void StatusUpdate() { }

	// RVA: 0x1E91C30 Offset: 0x1E8DC30 VA: 0x1E91C30 Slot: 9
	protected override void OnClick() { }

	// RVA: 0x1E91F50 Offset: 0x1E8DF50 VA: 0x1E91F50
	private void OnTakeEndEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	// RVA: 0x1E91FEC Offset: 0x1E8DFEC VA: 0x1E91FEC
	public void .ctor() { }
}
