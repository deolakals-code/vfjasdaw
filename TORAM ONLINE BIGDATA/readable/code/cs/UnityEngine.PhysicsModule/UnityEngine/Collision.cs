// Assembly: UnityEngine.PhysicsModule.dll
// Namespace: UnityEngine
public class Collision // TypeDefIndex: 17640
{
	// Fields
	private ContactPairHeader m_Header; // 0x10
	private ContactPair m_Pair; // 0x38
	private bool m_Flipped; // 0x60
	private ContactPoint[] m_LegacyContacts; // 0x68

	// Properties
	public Component body { get; }
	public Collider collider { get; }
	public GameObject gameObject { get; }
	internal bool Flipped { set; }

	// Methods

	// RVA: 0x3818528 Offset: 0x3814528 VA: 0x3818528
	public Component get_body() { }

	// RVA: 0x381862C Offset: 0x381462C VA: 0x381862C
	public Collider get_collider() { }

	// RVA: 0x3818758 Offset: 0x3814758 VA: 0x3818758
	public GameObject get_gameObject() { }

	// RVA: 0x38187EC Offset: 0x38147EC VA: 0x38187EC
	internal void set_Flipped(bool value) { }

	// RVA: 0x38187F8 Offset: 0x38147F8 VA: 0x38187F8
	public void .ctor() { }

	// RVA: 0x3818850 Offset: 0x3814850 VA: 0x3818850
	internal void .ctor(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x381899C Offset: 0x381499C VA: 0x381899C
	internal void Reuse(in ContactPairHeader header, in ContactPair pair) { }
}
