// Assembly: System.dll
// Namespace: 
internal class ServicePointManager.SPKey // TypeDefIndex: 14500
{
	// Fields
	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private bool use_connect; // 0x20

	// Properties
	public bool UsesProxy { get; }

	// Methods

	// RVA: 0x35166C0 Offset: 0x35126C0 VA: 0x35166C0
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0x35167B0 Offset: 0x35127B0 VA: 0x35167B0
	public bool get_UsesProxy() { }

	// RVA: 0x3516810 Offset: 0x3512810 VA: 0x3516810 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x35168E4 Offset: 0x35128E4 VA: 0x35168E4 Slot: 0
	public override bool Equals(object obj) { }
}
