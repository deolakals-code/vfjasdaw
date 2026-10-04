// Assembly: mscorlib.dll
// Namespace: System.Runtime
[Serializable]
public sealed class AmbiguousImplementationException : Exception // TypeDefIndex: 10186
{
	// Methods

	// RVA: 0x2ECC1D8 Offset: 0x2EC81D8 VA: 0x2ECC1D8
	public void .ctor() { }

	// RVA: 0x2ECC258 Offset: 0x2EC8258 VA: 0x2ECC258
	public void .ctor(string message) { }

	// RVA: 0x2ECC2D0 Offset: 0x2EC82D0 VA: 0x2ECC2D0
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}
