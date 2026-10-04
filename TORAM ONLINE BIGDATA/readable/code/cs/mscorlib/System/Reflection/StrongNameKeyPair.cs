// Assembly: mscorlib.dll
// Namespace: System.Reflection
[ComVisible(True)]
[Serializable]
public class StrongNameKeyPair : ISerializable, IDeserializationCallback // TypeDefIndex: 10661
{
	// Fields
	private byte[] _publicKey; // 0x10
	private string _keyPairContainer; // 0x18
	private bool _keyPairExported; // 0x20
	private byte[] _keyPairArray; // 0x28

	// Methods

	// RVA: 0x2F3CCF4 Offset: 0x2F38CF4 VA: 0x2F3CCF4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3CF24 Offset: 0x2F38F24 VA: 0x2F3CF24 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3D06C Offset: 0x2F3906C VA: 0x2F3D06C Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
}
