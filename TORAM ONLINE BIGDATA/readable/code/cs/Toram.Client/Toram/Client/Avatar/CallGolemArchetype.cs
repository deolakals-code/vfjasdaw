// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class CallGolemArchetype : Archetype // TypeDefIndex: 15146
{
	// Fields
	[CompilerGenerated]
	private CallGolemData <CallGolemData>k__BackingField; // 0x50
	private IArchetypeListener listener; // 0x58

	// Properties
	public CallGolemData CallGolemData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x35AC124 Offset: 0x35A8124 VA: 0x35AC124
	public CallGolemData get_CallGolemData() { }

	[CompilerGenerated]
	// RVA: 0x35AC12C Offset: 0x35A812C VA: 0x35AC12C
	private void set_CallGolemData(CallGolemData value) { }

	[CLSCompliant(False)]
	// RVA: 0x35AC078 Offset: 0x35A8078 VA: 0x35AC078
	public void .ctor(Game game, CompanionData companionData) { }

	// RVA: 0x35AC134 Offset: 0x35A8134 VA: 0x35AC134
	public void SetListener(IArchetypeListener listener) { }

	// RVA: 0x35AC13C Offset: 0x35A813C VA: 0x35AC13C Slot: 8
	internal override void OnOperation(PacketBase operation) { }

	// RVA: 0x35AC228 Offset: 0x35A8228 VA: 0x35AC228 Slot: 9
	internal override void OnEvent(PacketBase events) { }

	// RVA: 0x35AC318 Offset: 0x35A8318 VA: 0x35AC318 Slot: 10
	internal override void OnActionEvent(ArchetypeActionEvent action) { }
}
