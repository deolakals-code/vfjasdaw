// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyRecruitmentBoard : UIBaseSignBoard // TypeDefIndex: 8841
{
	// Fields
	private Vector3 mouseOverTracePos; // 0xD0
	private Vector3 mouseOverScale; // 0xDC
	private const float MaxSetMeter = 100;
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0xE8
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0xEC

	// Properties
	public override bool IsEnabled { get; }
	public int ArchetypeId { get; set; }
	public int RecruitmentId { get; set; }
	public override bool IsRemoveState { get; }
	public override bool IsStopMouseOver { get; }

	// Methods

	// RVA: 0x1E32A7C Offset: 0x1E2EA7C VA: 0x1E32A7C
	public static UIPartyRecruitmentBoard CreateBoard(GameObject tracePlayerObject, int recruitmentId, int archetypeId, string name) { }

	// RVA: 0x1E32C10 Offset: 0x1E2EC10 VA: 0x1E32C10 Slot: 6
	public override bool get_IsEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1E32D44 Offset: 0x1E2ED44 VA: 0x1E32D44
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x1E32D4C Offset: 0x1E2ED4C VA: 0x1E32D4C
	private void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1E32D54 Offset: 0x1E2ED54 VA: 0x1E32D54
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x1E32D5C Offset: 0x1E2ED5C VA: 0x1E32D5C
	private void set_RecruitmentId(int value) { }

	// RVA: 0x1E32D64 Offset: 0x1E2ED64 VA: 0x1E32D64 Slot: 4
	public override bool get_IsRemoveState() { }

	// RVA: 0x1E32DC4 Offset: 0x1E2EDC4 VA: 0x1E32DC4 Slot: 8
	public override bool get_IsStopMouseOver() { }

	// RVA: 0x1E32DCC Offset: 0x1E2EDCC VA: 0x1E32DCC Slot: 9
	protected override void StatusInit() { }

	// RVA: 0x1E32E08 Offset: 0x1E2EE08 VA: 0x1E32E08 Slot: 10
	public override void UpdateActiveBoard(bool isPrint, int index, bool isUpdateOrbItem, bool isFirst) { }

	// RVA: 0x1E32ED0 Offset: 0x1E2EED0 VA: 0x1E32ED0 Slot: 17
	public override bool PositionUpdate(float dist) { }

	// RVA: 0x1E333A8 Offset: 0x1E2F3A8 VA: 0x1E333A8 Slot: 14
	protected override bool CheckCanClick() { }

	// RVA: 0x1E33578 Offset: 0x1E2F578 VA: 0x1E33578 Slot: 11
	public override void onClick() { }

	// RVA: 0x1E33644 Offset: 0x1E2F644 VA: 0x1E33644 Slot: 12
	public override void OnMouseOver() { }

	// RVA: 0x1E33654 Offset: 0x1E2F654 VA: 0x1E33654 Slot: 13
	public override void OnMouseOut() { }

	// RVA: 0x1E33664 Offset: 0x1E2F664 VA: 0x1E33664 Slot: 15
	protected override void ChangeOpenBoard(bool isOpen) { }

	// RVA: 0x1E32C08 Offset: 0x1E2EC08 VA: 0x1E32C08
	public void SetData(int recruitmentId, int archetypeId) { }

	// RVA: 0x1E336BC Offset: 0x1E2F6BC VA: 0x1E336BC
	public void .ctor() { }
}
