// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildStaffFieldAICentral : GuildStaffAICentral // TypeDefIndex: 1195
{
	// Fields
	private const int waitActionId = 4;
	private const int standardActionId = 1;

	// Properties
	public override bool IsWaiting { get; }

	// Methods

	// RVA: 0x1F7F774 Offset: 0x1F7B774 VA: 0x1F7F774 Slot: 14
	public override bool get_IsWaiting() { }

	// RVA: 0x1F7F784 Offset: 0x1F7B784 VA: 0x1F7F784
	public void RecoverySupportAction() { }

	// RVA: 0x1F7F7D8 Offset: 0x1F7B7D8 VA: 0x1F7F7D8
	public void EscapeAction() { }

	// RVA: 0x1F7F810 Offset: 0x1F7B810 VA: 0x1F7F810 Slot: 18
	public override void ChangeWaitingAction(bool isStop) { }

	// RVA: 0x1F7F8F8 Offset: 0x1F7B8F8 VA: 0x1F7F8F8 Slot: 17
	protected override void CreateAction(bool isMan) { }

	// RVA: 0x1F801D0 Offset: 0x1F7C1D0 VA: 0x1F801D0 Slot: 19
	public override void EnterField() { }

	// RVA: 0x1F80210 Offset: 0x1F7C210 VA: 0x1F80210
	public void .ctor() { }
}
