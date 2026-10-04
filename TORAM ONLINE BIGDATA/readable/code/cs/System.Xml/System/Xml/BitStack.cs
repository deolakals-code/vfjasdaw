// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class BitStack // TypeDefIndex: 13271
{
	// Fields
	private uint[] bitStack; // 0x10
	private int stackPos; // 0x18
	private uint curr; // 0x1C

	// Methods

	// RVA: 0x32B70C0 Offset: 0x32B30C0 VA: 0x32B70C0
	public void .ctor() { }

	// RVA: 0x32B70E0 Offset: 0x32B30E0 VA: 0x32B70E0
	public void PushBit(bool bit) { }

	// RVA: 0x32B7210 Offset: 0x32B3210 VA: 0x32B7210
	public bool PopBit() { }

	// RVA: 0x32B727C Offset: 0x32B327C VA: 0x32B727C
	public bool PeekBit() { }

	// RVA: 0x32B7118 Offset: 0x32B3118 VA: 0x32B7118
	private void PushCurr() { }

	// RVA: 0x32B7238 Offset: 0x32B3238 VA: 0x32B7238
	private void PopCurr() { }
}
