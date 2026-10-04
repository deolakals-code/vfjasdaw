// Assembly: mscorlib.dll
// Namespace: System.Security
[ComVisible(True)]
[MonoTODO("CAS support is experimental (and unsupported).")]
[Serializable]
public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 10069
{
	// Methods

	// RVA: 0x2EA2AB0 Offset: 0x2E9EAB0 VA: 0x2EA2AB0
	protected void .ctor() { }

	[Conditional("MONO_FEATURE_CAS")]
	// RVA: 0x2EA2AB8 Offset: 0x2E9EAB8 VA: 0x2EA2AB8 Slot: 7
	public void Demand() { }

	[ComVisible(False)]
	// RVA: 0x2EA2BC8 Offset: 0x2E9EBC8 VA: 0x2EA2BC8 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x2EA2CEC Offset: 0x2E9ECEC VA: 0x2EA2CEC Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsSubsetOf(IPermission target);

	// RVA: 0x2EA2CF4 Offset: 0x2E9ECF4 VA: 0x2EA2CF4 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SecurityElement ToXml();

	// RVA: 0x2EA2D1C Offset: 0x2E9ED1C VA: 0x2EA2D1C
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	// RVA: 0x2EA2DC8 Offset: 0x2E9EDC8 VA: 0x2EA2DC8 Slot: 4
	private void System.Security.IPermission.Demand() { }
}
