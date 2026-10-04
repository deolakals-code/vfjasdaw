// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Interface
public class Alert // TypeDefIndex: 16902
{
	// Fields
	private AlertLevel level; // 0x10
	private AlertDescription description; // 0x11

	// Properties
	public AlertLevel Level { get; }
	public AlertDescription Description { get; }

	// Methods

	// RVA: 0x2E57A38 Offset: 0x2E53A38 VA: 0x2E57A38
	public AlertLevel get_Level() { }

	// RVA: 0x2E57A40 Offset: 0x2E53A40 VA: 0x2E57A40
	public AlertDescription get_Description() { }

	// RVA: 0x2E57A48 Offset: 0x2E53A48 VA: 0x2E57A48
	public void .ctor(AlertDescription description) { }

	// RVA: 0x2E57AB4 Offset: 0x2E53AB4 VA: 0x2E57AB4
	private void inferAlertLevel() { }

	// RVA: 0x2E57AF4 Offset: 0x2E53AF4 VA: 0x2E57AF4 Slot: 3
	public override string ToString() { }
}
