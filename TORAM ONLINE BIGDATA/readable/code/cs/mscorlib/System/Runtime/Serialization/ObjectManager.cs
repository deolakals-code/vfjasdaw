// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public class ObjectManager // TypeDefIndex: 10353
{
	// Fields
	private DeserializationEventHandler m_onDeserializationHandler; // 0x10
	private SerializationEventHandler m_onDeserializedHandler; // 0x18
	internal ObjectHolder[] m_objects; // 0x20
	internal object m_topObject; // 0x28
	internal ObjectHolderList m_specialFixupObjects; // 0x30
	internal long m_fixupCount; // 0x38
	internal ISurrogateSelector m_selector; // 0x40
	internal StreamingContext m_context; // 0x48

	// Properties
	internal object TopObject { get; set; }
	internal ObjectHolderList SpecialFixupObjects { get; }

	// Methods

	// RVA: 0x2EFEFF0 Offset: 0x2EFAFF0 VA: 0x2EFEFF0
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x2EFF094 Offset: 0x2EFB094 VA: 0x2EFF094
	private bool CanCallGetType(object obj) { }

	// RVA: 0x2EFF09C Offset: 0x2EFB09C VA: 0x2EFF09C
	internal void set_TopObject(object value) { }

	// RVA: 0x2EFF0A4 Offset: 0x2EFB0A4 VA: 0x2EFF0A4
	internal object get_TopObject() { }

	// RVA: 0x2EFF0AC Offset: 0x2EFB0AC VA: 0x2EFF0AC
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x2EFF124 Offset: 0x2EFB124 VA: 0x2EFF124
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x2EFF17C Offset: 0x2EFB17C VA: 0x2EFF17C
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x2EFF248 Offset: 0x2EFB248 VA: 0x2EFF248
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x2EFF374 Offset: 0x2EFB374 VA: 0x2EFF374
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x2EFF68C Offset: 0x2EFB68C VA: 0x2EFF68C
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x2F00484 Offset: 0x2EFC484 VA: 0x2F00484
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x2EFFE40 Offset: 0x2EFBE40 VA: 0x2EFFE40
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x2F00710 Offset: 0x2EFC710 VA: 0x2F00710
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x2F003AC Offset: 0x2EFC3AC VA: 0x2F003AC
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x2F00FB0 Offset: 0x2EFCFB0 VA: 0x2F00FB0 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x2F01060 Offset: 0x2EFD060 VA: 0x2F01060
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x2F01280 Offset: 0x2EFD280 VA: 0x2F01280
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x2EFFB60 Offset: 0x2EFBB60 VA: 0x2EFFB60
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F01C34 Offset: 0x2EFDC34 VA: 0x2F01C34
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x2F01D64 Offset: 0x2EFDD64 VA: 0x2F01D64 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x2F021C8 Offset: 0x2EFE1C8 VA: 0x2F021C8
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x2F023EC Offset: 0x2EFE3EC VA: 0x2F023EC Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x2F026CC Offset: 0x2EFE6CC VA: 0x2F026CC Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x2F02830 Offset: 0x2EFE830 VA: 0x2F02830 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x2F02994 Offset: 0x2EFE994 VA: 0x2F02994 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x2F029E0 Offset: 0x2EFE9E0 VA: 0x2F029E0 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x2F02A70 Offset: 0x2EFEA70 VA: 0x2F02A70 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x2F02B08 Offset: 0x2EFEB08 VA: 0x2F02B08 Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x2F02B8C Offset: 0x2EFEB8C VA: 0x2F02B8C
	public void RaiseOnDeserializingEvent(object obj) { }
}
