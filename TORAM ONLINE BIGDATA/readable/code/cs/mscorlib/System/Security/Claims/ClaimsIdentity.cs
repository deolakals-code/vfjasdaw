// Assembly: mscorlib.dll
// Namespace: System.Security.Claims
[ComVisible(True)]
[Serializable]
public class ClaimsIdentity : IIdentity // TypeDefIndex: 10185
{
	// Fields
	private byte[] m_userSerializationData; // 0x10
	private List<Claim> m_instanceClaims; // 0x18
	private Collection<IEnumerable<Claim>> m_externalClaims; // 0x20
	private string m_nameType; // 0x28
	private string m_roleType; // 0x30
	[OptionalField(VersionAdded = 2)]
	private string m_version; // 0x38
	[OptionalField(VersionAdded = 2)]
	private ClaimsIdentity m_actor; // 0x40
	[OptionalField(VersionAdded = 2)]
	private string m_authenticationType; // 0x48
	[OptionalField(VersionAdded = 2)]
	private object m_bootstrapContext; // 0x50
	[OptionalField(VersionAdded = 2)]
	private string m_label; // 0x58
	[OptionalField(VersionAdded = 2)]
	private string m_serializedNameType; // 0x60
	[OptionalField(VersionAdded = 2)]
	private string m_serializedRoleType; // 0x68
	[OptionalField(VersionAdded = 2)]
	private string m_serializedClaims; // 0x70

	// Properties
	public virtual string AuthenticationType { get; }
	public ClaimsIdentity Actor { get; set; }
	public virtual IEnumerable<Claim> Claims { get; }
	public virtual string Name { get; }

	// Methods

	// RVA: 0x2EC90AC Offset: 0x2EC50AC VA: 0x2EC90AC
	public void .ctor() { }

	// RVA: 0x2EC90C8 Offset: 0x2EC50C8 VA: 0x2EC90C8
	public void .ctor(IEnumerable<Claim> claims) { }

	// RVA: 0x2EC90E4 Offset: 0x2EC50E4 VA: 0x2EC90E4
	public void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType) { }

	// RVA: 0x2EC90EC Offset: 0x2EC50EC VA: 0x2EC90EC
	internal void .ctor(IIdentity identity, IEnumerable<Claim> claims, string authenticationType, string nameType, string roleType, bool checkAuthType) { }

	// RVA: 0x2EC9D64 Offset: 0x2EC5D64 VA: 0x2EC9D64
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2ECA79C Offset: 0x2EC679C VA: 0x2ECA79C Slot: 6
	public virtual string get_AuthenticationType() { }

	// RVA: 0x2ECA7A4 Offset: 0x2EC67A4 VA: 0x2ECA7A4
	public ClaimsIdentity get_Actor() { }

	// RVA: 0x2ECA7AC Offset: 0x2EC67AC VA: 0x2ECA7AC
	public void set_Actor(ClaimsIdentity value) { }

	[IteratorStateMachine(typeof(ClaimsIdentity.<get_Claims>d__51))]
	// RVA: 0x2ECA838 Offset: 0x2EC6838 VA: 0x2ECA838 Slot: 7
	public virtual IEnumerable<Claim> get_Claims() { }

	// RVA: 0x2ECA8E8 Offset: 0x2EC68E8 VA: 0x2ECA8E8 Slot: 8
	public virtual string get_Name() { }

	// RVA: 0x2ECA90C Offset: 0x2EC690C VA: 0x2ECA90C Slot: 9
	public virtual ClaimsIdentity Clone() { }

	// RVA: 0x2EC9844 Offset: 0x2EC5844 VA: 0x2EC9844
	private void SafeAddClaims(IEnumerable<Claim> claims) { }

	// RVA: 0x2EC9C38 Offset: 0x2EC5C38 VA: 0x2EC9C38
	private void SafeAddClaim(Claim claim) { }

	// RVA: 0x2ECAA90 Offset: 0x2EC6A90 VA: 0x2ECAA90 Slot: 10
	public virtual Claim FindFirst(string type) { }

	[OnSerializing]
	// RVA: 0x2ECADEC Offset: 0x2EC6DEC VA: 0x2ECADEC
	private void OnSerializingMethod(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x2ECB0D0 Offset: 0x2EC70D0 VA: 0x2ECB0D0
	private void OnDeserializedMethod(StreamingContext context) { }

	[OnDeserializing]
	// RVA: 0x2ECB550 Offset: 0x2EC7550 VA: 0x2ECB550
	private void OnDeserializingMethod(StreamingContext context) { }

	// RVA: 0x2ECB640 Offset: 0x2EC7640 VA: 0x2ECB640 Slot: 11
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2ECB1D0 Offset: 0x2EC71D0 VA: 0x2ECB1D0
	private void DeserializeClaims(string serializedClaims) { }

	// RVA: 0x2ECAE7C Offset: 0x2EC6E7C VA: 0x2ECAE7C
	private string SerializeClaims() { }

	// RVA: 0x2EC9808 Offset: 0x2EC5808 VA: 0x2EC9808
	private bool IsCircular(ClaimsIdentity subject) { }

	// RVA: 0x2EC9F2C Offset: 0x2EC5F2C VA: 0x2EC9F2C
	private void Deserialize(SerializationInfo info, StreamingContext context, bool useContext) { }
}
