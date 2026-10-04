// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetDefaultTransition : MercenaryDefaultTransition // TypeDefIndex: 1277
{
	// Fields
	private readonly PetMemberSettingBase setting; // 0x88
	private readonly MobManager mobManager; // 0x90
	private float Counter; // 0x98
	private GameObject targetObject; // 0xA0

	// Methods

	// RVA: 0x1FB1FC0 Offset: 0x1FADFC0 VA: 0x1FB1FC0
	public void .ctor(AutoMemberAIAction aiAction, AutoMemberAIRetreat aiRetreat, PetMemberSettingBase setting, MobManager mobManager) { }

	// RVA: 0x1FB200C Offset: 0x1FAE00C VA: 0x1FB200C Slot: 13
	public override void ChackTransition(IAICentral central) { }

	// RVA: 0x1FB2014 Offset: 0x1FAE014 VA: 0x1FB2014 Slot: 19
	protected override void TraceAction(IAICentral central) { }

	// RVA: 0x1FB2464 Offset: 0x1FAE464 VA: 0x1FB2464 Slot: 20
	protected override GameObject searchTarget(IAICentral central) { }
}
