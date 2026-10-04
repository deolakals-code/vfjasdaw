// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[Serializable]
public class SerializationException : SystemException // TypeDefIndex: 10334
{
	// Fields
	private static string s_nullMessage; // 0x0

	// Methods

	// RVA: 0x2EFA848 Offset: 0x2EF6848 VA: 0x2EFA848
	public void .ctor() { }

	// RVA: 0x2EFA8BC Offset: 0x2EF68BC VA: 0x2EFA8BC
	public void .ctor(string message) { }

	// RVA: 0x2EFA8E0 Offset: 0x2EF68E0 VA: 0x2EFA8E0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x2EFA904 Offset: 0x2EF6904 VA: 0x2EFA904
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2EFA90C Offset: 0x2EF690C VA: 0x2EFA90C
	private static void .cctor() { }
}
