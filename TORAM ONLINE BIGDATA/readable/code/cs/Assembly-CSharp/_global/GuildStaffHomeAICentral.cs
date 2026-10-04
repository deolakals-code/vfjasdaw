// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildStaffHomeAICentral : GuildStaffAICentral // TypeDefIndex: 1196
{
	// Fields
	private Vector4[] waitPosition; // 0x58
	protected const int waitActionId = 1;
	protected const int standardActionId = 2;
	protected GameObject setTarget; // 0x60
	protected GameObject eventAreaObject; // 0x68
	protected const int guildStaffEventId = 200;

	// Properties
	public override GameObject Target { get; }
	public override bool IsWaiting { get; }

	// Methods

	// RVA: 0x1F80220 Offset: 0x1F7C220 VA: 0x1F80220 Slot: 13
	public override GameObject get_Target() { }

	// RVA: 0x1F80238 Offset: 0x1F7C238 VA: 0x1F80238 Slot: 14
	public override bool get_IsWaiting() { }

	// RVA: 0x1F80248 Offset: 0x1F7C248 VA: 0x1F80248 Slot: 18
	public override void ChangeWaitingAction(bool isStop) { }

	// RVA: 0x1F80318 Offset: 0x1F7C318 VA: 0x1F80318
	private void OnDestroy() { }

	// RVA: 0x1F803F0 Offset: 0x1F7C3F0 VA: 0x1F803F0 Slot: 17
	protected override void CreateAction(bool isMan) { }

	// RVA: 0x1F80FB0 Offset: 0x1F7CFB0 VA: 0x1F80FB0
	private RouteDataManager CreateRouteData() { }

	// RVA: 0x1F86388 Offset: 0x1F82388 VA: 0x1F86388 Slot: 16
	protected override void Update() { }

	// RVA: 0x1F865A8 Offset: 0x1F825A8 VA: 0x1F865A8
	public void .ctor() { }
}
