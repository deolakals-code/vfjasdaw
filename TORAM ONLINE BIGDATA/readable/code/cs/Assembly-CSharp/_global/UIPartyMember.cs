// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyMember : MonoBehaviour // TypeDefIndex: 7698
{
	// Fields
	[SerializeField]
	private UILabel lvLabel; // 0x20
	[SerializeField]
	private UILabel nameLabel; // 0x28
	[SerializeField]
	private UIIcon icon; // 0x30
	[SerializeField]
	private UIStaminaIcon staminaIcon; // 0x38
	[SerializeField]
	private UIIcon subWeaponIcon; // 0x40
	private SystemTextManager st; // 0x48

	// Methods

	// RVA: 0x1BE7EB0 Offset: 0x1BE3EB0 VA: 0x1BE7EB0
	private void Awake() { }

	// RVA: 0x1BE80FC Offset: 0x1BE40FC VA: 0x1BE80FC
	public void SetData(int lv, string name, byte weaponType, byte subWeaponType, bool isPending, Color setColor) { }

	// RVA: 0x1BE81AC Offset: 0x1BE41AC VA: 0x1BE81AC
	public void SetData(int lv, string name, byte weaponType, byte subWeaponType, bool isPending) { }

	// RVA: 0x1BE8404 Offset: 0x1BE4404 VA: 0x1BE8404
	public void SetStamina(int id, byte type) { }

	// RVA: 0x1BE7FA8 Offset: 0x1BE3FA8 VA: 0x1BE7FA8
	public void Reset() { }

	// RVA: 0x1BE84D4 Offset: 0x1BE44D4 VA: 0x1BE84D4
	public void NoData() { }

	// RVA: 0x1BE8628 Offset: 0x1BE4628 VA: 0x1BE8628
	public void .ctor() { }
}
