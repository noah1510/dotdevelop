using System.IO;
using System.Linq;
using MonoDevelop.Projects.MSBuild;

namespace MonoDevelop.PackageManagement
{

	class NuGetRemoteBuildDependencies : RemoteBuildDependencies
	{
		private static readonly string sourceLocation =
			Path.GetDirectoryName (typeof(NuGetRemoteBuildDependencies).Assembly.Location);

		private static string[] _filesToCopy = default;

		protected override void Resolve (string exesDir)
		{
			_filesToCopy ??= Directory.GetFiles (sourceLocation, "NuGet.*")
				.ToArray ();
			foreach (var file in _filesToCopy) {
				File.Copy (file, Path.Combine (exesDir, Path.GetFileName (file)));
			}

			// TODO: refactor to copy only of files list RemoteBuildDependencies.CopyDependentAssemblies (_filesToCopy,exesDir);
		}
	}

}