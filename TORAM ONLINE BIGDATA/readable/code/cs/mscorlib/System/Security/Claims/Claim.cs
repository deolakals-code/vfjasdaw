// Assembly: mscorlib.dll
// Namespace: System.Security.Claims
[Serializable]
public class Claim // TypeDefIndex: 10183
{
	// Fields
	private string m_issuer; // 0x10
	private string m_originalIssuer; // 0x18
	private string m_type; // 0x20
	private string m_value; // 0x28
	private string m_valueType; // 0x30
	private byte[] m_userSerializationData; // 0x38
	private Dictionary<string, string> m_properties; // 0x40
	private object m_propertyLock; // 0x48
	private ClaimsIdentity m_subject; // 0x50

	// Properties
	public IDictionary<string, string> Properties { get; }
	public ClaimsIdentity Subject { get; set; }
	public string Type { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x2EC880C Offset: 0x2EC480C VA: 0x2EC880C
	public void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject) { }

	// RVA: 0x2EC882C Offset: 0x2EC482C VA: 0x2EC882C
	internal void .ctor(string type, string value, string valueType, string issuer, string originalIssuer, ClaimsIdentity subject, string propertyKey, string propertyValue) { }

	// RVA: 0x2EC8BE8 Offset: 0x2EC4BE8 VA: 0x2EC8BE8
	protected void .ctor(Claim other, ClaimsIdentity subject) { }

	[OnDeserialized]
	// RVA: 0x2EC8F4C Offset: 0x2EC4F4C VA: 0x2EC8F4C
	private void OnDeserializedMethod(StreamingContext context) { }

	// RVA: 0x2EC8AB8 Offset: 0x2EC4AB8 VA: 0x2EC8AB8
	public IDictionary<string, string> get_Properties() { }

	// RVA: 0x2EC8FAC Offset: 0x2EC4FAC VA: 0x2EC8FAC
	public ClaimsIdentity get_Subject() { }

	// RVA: 0x2EC8FB4 Offset: 0x2EC4FB4 VA: 0x2EC8FB4
	internal void set_Subject(ClaimsIdentity value) { }

	// RVA: 0x2EC8FBC Offset: 0x2EC4FBC VA: 0x2EC8FBC
	public string get_Type() { }

	// RVA: 0x2EC8FC4 Offset: 0x2EC4FC4 VA: 0x2EC8FC4
	public string get_Value() { }

	// RVA: 0x2EC8FCC Offset: 0x2EC4FCC VA: 0x2EC8FCC Slot: 4
	public virtual Claim Clone(ClaimsIdentity identity) { }

	// RVA: 0x2EC9034 Offset: 0x2EC5034 VA: 0x2EC9034 Slot: 3
	public override string ToString() { }
}
