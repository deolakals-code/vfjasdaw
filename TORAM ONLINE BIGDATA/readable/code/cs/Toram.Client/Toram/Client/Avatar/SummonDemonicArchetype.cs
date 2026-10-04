// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public class SummonDemonicArchetype : Archetype // TypeDefIndex: 15159
{
	// Fields
	[CompilerGenerated]
	private SummonDemonicData <SummonDemonicData>k__BackingField; // 0x50
	private IArchetypeListener listener; // 0x58

	// Properties
	public SummonDemonicData SummonDemonicData { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x35B1660 Offset: 0x35AD660 VA: 0x35B1660
	public SummonDemonicData get_SummonDemonicData() { }

	[CompilerGenerated]
	// RVA: 0x35B1668 Offset: 0x35AD668 VA: 0x35B1668
	private void set_SummonDemonicData(SummonDemonicData value) { }

	[CLSCompliant(False)]
	// RVA: 0x35ABFCC Offset: 0x35A7FCC VA: 0x35ABFCC
	public void .ctor(Game game, CompanionData companionData) { }

	// RVA: 0x35B1670 Offset: 0x35AD670 VA: 0x35B1670
	public void SetListener(IArchetypeListener listener) { }

	// RVA: 0x35B1678 Offset: 0x35AD678 VA: 0x35B1678 Slot: 8
	internal override void OnOperation(PacketBase operation) { }

	// RVA: 0x35B1764 Offset: 0x35AD764 VA: 0x35B1764 Slot: 9
	internal override void OnEvent(PacketBase events) { }

	// RVA: 0x35B1854 Offset: 0x35AD854 VA: 0x35B1854 Slot: 10
	internal override void OnActionEvent(ArchetypeActionEvent action) { }
}
