using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using MonoDevelop.Core;

namespace MonoDevelop.Projects.MSBuild
{
	/// <summary>
	/// Used to add additional files when MSBuild-Remote is build
	/// </summary>
	public abstract class RemoteBuildDependencies
	{
		protected internal virtual void Resolve(string exesDir)
		{
		}

		protected RemoteBuildDependencies()
		{
		}

		public static void CopyDependentAssemblies (string binDir, FilePath exesDir)
		{
			var currentDomainBaseDirectory =
				AppDomain.CurrentDomain.BaseDirectory.TrimEnd (Path.DirectorySeparatorChar);
			var assembliesToCopy = new HashSet<string> ();
			try {
				var currentDomainAssemblies = AppDomain.CurrentDomain.GetAssemblies ().ToArray ()
					.Where (a => !a.IsDynamic && a?.Location != null &&
					             Path.GetDirectoryName (a.Location) == currentDomainBaseDirectory)
					.ToArray ();
				var currentDomainDllss = Directory.GetFiles (currentDomainBaseDirectory, "*.dll")
					.ToArray ();

				void AddAssembly (AssemblyName ass)
				{
					if (!assembliesToCopy.Contains (ass.Name) &&
					    currentDomainDllss.FirstOrDefault (d => Path.GetFileNameWithoutExtension (d) == ass.Name) is var
						    refAss) {
						if (refAss == null) return;
						assembliesToCopy.Add (ass.Name);
						AddReferencedAssemblies (refAss);
					}
				}

				void AddReferencedAssemblies (string f)
				{
					foreach (var a in System.Reflection.Assembly.ReflectionOnlyLoadFrom (f)?.GetReferencedAssemblies ()) {
						AddAssembly (a);
					}
				}

				foreach (var f in Directory.GetFiles (binDir, "*.dll")) {
					AddReferencedAssemblies (f);
				}

				foreach (var f in assembliesToCopy) {
					var fn = $"{f}.dll";
					var sf = Path.Combine (currentDomainBaseDirectory, fn);
					var df = exesDir.Combine (Path.GetFileName (fn));
					if (File.Exists (sf) && !File.Exists (df))
						File.Copy (sf, df);

				}
			} catch (Exception ex) {
				;
			}

		}
	}
}
