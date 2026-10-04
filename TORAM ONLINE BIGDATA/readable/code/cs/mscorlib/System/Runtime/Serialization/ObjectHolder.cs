// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
internal sealed class ObjectHolder // TypeDefIndex: 10354
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x2EFF214 Offset: 0x2EFB214 VA: 0x2EFF214
	internal void .ctor(long objID) { }

	// RVA: 0x2F01834 Offset: 0x2EFD834 VA: 0x2F01834
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x2F01158 Offset: 0x2EFD158 VA: 0x2F01158
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x2F02C10 Offset: 0x2EFEC10 VA: 0x2F02C10
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x2F00E84 Offset: 0x2EFCE84 VA: 0x2F00E84
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x2F00EA8 Offset: 0x2EFCEA8 VA: 0x2F00EA8
	internal void RemoveDependency(long id) { }

	// RVA: 0x2F022A0 Offset: 0x2EFE2A0 VA: 0x2F022A0
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x2F02C20 Offset: 0x2EFEC20 VA: 0x2F02C20
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x2F0236C Offset: 0x2EFE36C VA: 0x2F0236C
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x2F01A7C Offset: 0x2EFDA7C VA: 0x2F01A7C
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x2F00F24 Offset: 0x2EFCF24 VA: 0x2F00F24
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x2EFFAA8 Offset: 0x2EFBAA8 VA: 0x2EFFAA8
	internal void SetFlags() { }

	// RVA: 0x2EFF680 Offset: 0x2EFB680 VA: 0x2EFF680
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x2F00700 Offset: 0x2EFC700 VA: 0x2F00700
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x2F01A6C Offset: 0x2EFDA6C VA: 0x2F01A6C
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x2EFFDFC Offset: 0x2EFBDFC VA: 0x2EFFDFC
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x2EFFE08 Offset: 0x2EFBE08 VA: 0x2EFFE08
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x2F00ED0 Offset: 0x2EFCED0 VA: 0x2F00ED0
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x2F00D88 Offset: 0x2EFCD88 VA: 0x2F00D88
	internal bool get_HasISerializable() { }

	// RVA: 0x2EFF8E4 Offset: 0x2EFB8E4 VA: 0x2EFF8E4
	internal bool get_HasSurrogate() { }

	// RVA: 0x2EFF8F0 Offset: 0x2EFB8F0 VA: 0x2EFF8F0
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x2EFF660 Offset: 0x2EFB660 VA: 0x2EFF660
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x2F02DB4 Offset: 0x2EFEDB4 VA: 0x2F02DB4
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x2F01C28 Offset: 0x2EFDC28 VA: 0x2F01C28
	internal int get_TotalDependentObjects() { }

	// RVA: 0x2F02DBC Offset: 0x2EFEDBC VA: 0x2F02DBC
	internal bool get_Reachable() { }

	// RVA: 0x2F02DC4 Offset: 0x2EFEDC4 VA: 0x2F02DC4
	internal void set_Reachable(bool value) { }

	// RVA: 0x2F00EC0 Offset: 0x2EFCEC0 VA: 0x2F00EC0
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x2F02DD0 Offset: 0x2EFEDD0 VA: 0x2F02DD0
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x2F02DD8 Offset: 0x2EFEDD8 VA: 0x2F02DD8
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x2F02DE0 Offset: 0x2EFEDE0 VA: 0x2F02DE0
	internal object get_ObjectValue() { }

	// RVA: 0x2EFF998 Offset: 0x2EFB998 VA: 0x2EFF998
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x2F02DE8 Offset: 0x2EFEDE8 VA: 0x2F02DE8
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x2F02DF0 Offset: 0x2EFEDF0 VA: 0x2F02DF0
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x2F02DF8 Offset: 0x2EFEDF8 VA: 0x2F02DF8
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x2F02E00 Offset: 0x2EFEE00 VA: 0x2F02E00
	internal LongList get_DependentObjects() { }

	// RVA: 0x2F02E08 Offset: 0x2EFEE08 VA: 0x2F02E08
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x2F020F0 Offset: 0x2EFE0F0 VA: 0x2F020F0
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x2EFFDDC Offset: 0x2EFBDDC VA: 0x2EFFDDC
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x2F02E10 Offset: 0x2EFEE10 VA: 0x2F02E10
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x2EFF63C Offset: 0x2EFB63C VA: 0x2EFF63C
	internal bool get_CompletelyFixed() { }

	// RVA: 0x2F02D14 Offset: 0x2EFED14 VA: 0x2F02D14
	internal long get_ContainerID() { }
}
