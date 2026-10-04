// Assembly: mscorlib.dll
// Namespace: System.IO.Enumeration
public class FileSystemEnumerable<TResult> : IEnumerable<TResult>, IEnumerable // TypeDefIndex: 10756
{
	// Fields
	private FileSystemEnumerable.DelegateEnumerator<TResult> _enumerator; // 0x0
	private readonly FileSystemEnumerable.FindTransform<TResult> _transform; // 0x0
	private readonly EnumerationOptions _options; // 0x0
	private readonly string _directory; // 0x0
	[CompilerGenerated]
	private FileSystemEnumerable.FindPredicate<TResult> <ShouldIncludePredicate>k__BackingField; // 0x0
	[CompilerGenerated]
	private FileSystemEnumerable.FindPredicate<TResult> <ShouldRecursePredicate>k__BackingField; // 0x0

	// Properties
	public FileSystemEnumerable.FindPredicate<TResult> ShouldIncludePredicate { get; set; }
	public FileSystemEnumerable.FindPredicate<TResult> ShouldRecursePredicate { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string directory, FileSystemEnumerable.FindTransform<TResult> transform, EnumerationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FC580 Offset: 0x29F8580 VA: 0x29FC580
	|-FileSystemEnumerable<object>..ctor
	|
	|-RVA: 0x29FC7B4 Offset: 0x29F87B4 VA: 0x29FC7B4
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public FileSystemEnumerable.FindPredicate<TResult> get_ShouldIncludePredicate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FC728 Offset: 0x29F8728 VA: 0x29FC728
	|-FileSystemEnumerable<object>.get_ShouldIncludePredicate
	|
	|-RVA: 0x29FC960 Offset: 0x29F8960 VA: 0x29FC960
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.get_ShouldIncludePredicate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_ShouldIncludePredicate(FileSystemEnumerable.FindPredicate<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FC730 Offset: 0x29F8730 VA: 0x29FC730
	|-FileSystemEnumerable<object>.set_ShouldIncludePredicate
	|
	|-RVA: 0x29FC968 Offset: 0x29F8968 VA: 0x29FC968
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.set_ShouldIncludePredicate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public FileSystemEnumerable.FindPredicate<TResult> get_ShouldRecursePredicate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FC738 Offset: 0x29F8738 VA: 0x29FC738
	|-FileSystemEnumerable<object>.get_ShouldRecursePredicate
	|
	|-RVA: 0x29FC970 Offset: 0x29F8970 VA: 0x29FC970
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.get_ShouldRecursePredicate
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TResult> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FC740 Offset: 0x29F8740 VA: 0x29FC740
	|-FileSystemEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x29FC978 Offset: 0x29F8978 VA: 0x29FC978
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FC7A4 Offset: 0x29F87A4 VA: 0x29FC7A4
	|-FileSystemEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29FC9E0 Offset: 0x29F89E0 VA: 0x29FC9E0
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
