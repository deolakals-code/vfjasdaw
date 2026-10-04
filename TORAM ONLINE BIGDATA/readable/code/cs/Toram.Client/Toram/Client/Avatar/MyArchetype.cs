// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class MyArchetype : Archetype // TypeDefIndex: 15155
{
	// Fields
	private IAvatarListener listener; // 0x50
	[CompilerGenerated]
	private byte <ParameterId>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <ParameterName>k__BackingField; // 0x60

	// Properties
	public override bool IsMine { get; }
	private byte ParameterId { set; }
	public string ParameterName { get; set; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x35AF504 Offset: 0x35AB504 VA: 0x35AF504
	public void .ctor(Game game, byte archetypeType, int archetypeId, byte parameterId, string parameterName) { }

	// RVA: 0x35AF544 Offset: 0x35AB544 VA: 0x35AF544 Slot: 5
	public override bool get_IsMine() { }

	[CompilerGenerated]
	// RVA: 0x35AF54C Offset: 0x35AB54C VA: 0x35AF54C
	private void set_ParameterId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35AF554 Offset: 0x35AB554 VA: 0x35AF554
	public string get_ParameterName() { }

	[CompilerGenerated]
	// RVA: 0x35AF55C Offset: 0x35AB55C VA: 0x35AF55C
	private void set_ParameterName(string value) { }

	// RVA: 0x35AF564 Offset: 0x35AB564 VA: 0x35AF564
	public void SetListener(IAvatarListener listener) { }

	// RVA: 0x35AF56C Offset: 0x35AB56C VA: 0x35AF56C
	internal bool SetEquipProperties(EquipResponseData response) { }

	// RVA: 0x35AF640 Offset: 0x35AB640 VA: 0x35AF640
	private bool SetUpdateProperties(int propertiesRevision, Dictionary<byte, object> newProperties) { }

	// RVA: 0x35AF8A4 Offset: 0x35AB8A4 VA: 0x35AF8A4 Slot: 8
	internal override void OnOperation(PacketBase operation) { }

	// RVA: 0x35AFA94 Offset: 0x35ABA94 VA: 0x35AFA94 Slot: 9
	internal override void OnEvent(PacketBase events) { }

	// RVA: 0x35B0560 Offset: 0x35AC560 VA: 0x35B0560 Slot: 10
	internal override void OnActionEvent(ArchetypeActionEvent action) { }
}
