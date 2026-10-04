// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
[DefaultMember("Item")]
public class OperationResponse // TypeDefIndex: 16988
{
	// Fields
	public byte OperationCode; // 0x10
	public short ReturnCode; // 0x12
	public string DebugMessage; // 0x18
	public Dictionary<byte, object> Parameters; // 0x20

	// Properties
	public object Item { get; }

	// Methods

	// RVA: 0x3103C50 Offset: 0x30FFC50 VA: 0x3103C50
	public object get_Item(byte parameterCode) { }

	// RVA: 0x3103CC0 Offset: 0x30FFCC0 VA: 0x3103CC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3103D7C Offset: 0x30FFD7C VA: 0x3103D7C
	public string ToStringFull() { }

	// RVA: 0x3103F70 Offset: 0x30FFF70 VA: 0x3103F70
	public void .ctor() { }
}
