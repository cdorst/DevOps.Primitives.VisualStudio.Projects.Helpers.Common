namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class Properties
    {
        public static MsBuildProperty AdditionalLibPaths(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.AdditionalLibPaths, in value, in condition);

        public static MsBuildProperty AddModules(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.AddModules, in value, in condition);

        public static MsBuildProperty ALToolPath(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.ALToolPath, in value, in condition);

        public static MsBuildProperty ApplicationIcon(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.ApplicationIcon, in value, in condition);

        public static MsBuildProperty ApplicationManifest(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.ApplicationManifest, in value, in condition);

        public static MsBuildProperty AssemblyOriginatorKeyFile(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.AssemblyOriginatorKeyFile, in value, in condition);

        public static MsBuildProperty AssemblySearchPaths(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.AssemblySearchPaths, in value, in condition);

        public static MsBuildProperty AssemblyName(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.AssemblyName, in value, in condition);

        public static MsBuildProperty BaseAddress(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.BaseAddress, in value, in condition);

        public static MsBuildProperty BaseOutputPath(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.BaseOutputPath, in value, in condition);

        public static MsBuildProperty BaseIntermediateOutputPath(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.BaseIntermediateOutputPath, in value, in condition);

        public static MsBuildProperty BuildInParallel(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.BuildInParallel, in value, in condition);

        public static MsBuildProperty BuildProjectReferences(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.BuildProjectReferences, in value, in condition);

        public static MsBuildProperty CleanFile(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.CleanFile, in value, in condition);

        public static MsBuildProperty CodePage(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.CodePage, in value, in condition);

        public static MsBuildProperty CompilerResponseFile(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.CompilerResponseFile, in value, in condition);

        public static MsBuildProperty Configuration(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Configuration, in value, in condition);

        public static MsBuildProperty CscToolPath(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.CscToolPath, in value, in condition);

        public static MsBuildProperty CustomBeforeMicrosoftCommonTargets(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.CustomBeforeMicrosoftCommonTargets, in value, in condition);

        public static MsBuildProperty DebugSymbols(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.DebugSymbols, in value, in condition);

        public static MsBuildProperty DefineConstants(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.DefineConstants, in value, in condition);

        public static MsBuildProperty DefineDebug(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.DefineDebug, in value, in condition);

        public static MsBuildProperty DefineTrace(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.DefineTrace, in value, in condition);

        public static MsBuildProperty DebugType(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.DebugType, in value, in condition);

        public static MsBuildProperty DelaySign(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.DelaySign, in value, in condition);

        public static MsBuildProperty Deterministic(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Deterministic, in value, in condition);

        public static MsBuildProperty DisabledWarnings(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.DisabledWarnings, in value, in condition);

        public static MsBuildProperty DisableFastUpToDateCheck(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.DisableFastUpToDateCheck, in value, in condition);

        public static MsBuildProperty DocumentationFile(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.DocumentationFile, in value, in condition);

        public static MsBuildProperty ErrorReport(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.ErrorReport, in value, in condition);

        public static MsBuildProperty ExcludeDeploymentUrl(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.ExcludeDeploymentUrl, in value, in condition);

        public static MsBuildProperty FileAlignment(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.FileAlignment, in value, in condition);

        public static MsBuildProperty FrameworkPathOverride(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.FrameworkPathOverride, in value, in condition);

        public static MsBuildProperty GenerateDocumentation(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.GenerateDocumentation, in value, in condition);

        public static MsBuildProperty IntermediateOutputPath(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.IntermediateOutputPath, in value, in condition);

        public static MsBuildProperty KeyContainerName(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.KeyContainerName, in value, in condition);

        public static MsBuildProperty KeyOriginatorFile(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.KeyOriginatorFile, in value, in condition);

        public static MsBuildProperty ModuleAssemblyName(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.ModuleAssemblyName, in value, in condition);

        public static MsBuildProperty NoLogo(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.NoLogo, in value, in condition);

        public static MsBuildProperty NoStdLib(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.NoStdLib, in value, in condition);

        public static MsBuildProperty NoVBRuntimeReference(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.NoVBRuntimeReference, in value, in condition);

        public static MsBuildProperty NoWin32Manifest(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.NoWin32Manifest, in value, in condition);

        public static MsBuildProperty Optimize(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Optimize, in value, in condition);

        public static MsBuildProperty OptionCompare(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.OptionCompare, in value, in condition);

        public static MsBuildProperty OptionExplicit(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.OptionExplicit, in value, in condition);

        public static MsBuildProperty OptionInfer(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.OptionInfer, in value, in condition);

        public static MsBuildProperty OptionStrict(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.OptionStrict, in value, in condition);

        public static MsBuildProperty OutputPath(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.OutputPath, in value, in condition);

        public static MsBuildProperty OutputType(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.OutputType, in value, in condition);

        public static MsBuildProperty OverwriteReadOnlyFiles(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.OverwriteReadOnlyFiles, in value, in condition);

        public static MsBuildProperty PdbFile(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.PdbFile, in value, in condition);

        public static MsBuildProperty Platform(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Platform, in value, in condition);

        public static MsBuildProperty ProduceReferenceAssembly(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.ProduceReferenceAssembly, in value, in condition);

        public static MsBuildProperty RemoveIntegerChecks(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.RemoveIntegerChecks, in value, in condition);

        public static MsBuildProperty SGenUseProxyTypes(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.SGenUseProxyTypes, in value, in condition);

        public static MsBuildProperty SGenToolPath(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.SGenToolPath, in value, in condition);

        public static MsBuildProperty StartupObject(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.StartupObject, in value, in condition);

        public static MsBuildProperty ProcessorArchitecture(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.ProcessorArchitecture, in value, in condition);

        public static MsBuildProperty RootNamespace(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.RootNamespace, in value, in condition);

        public static MsBuildProperty Satellite_AlgorithmId(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_AlgorithmId, in value, in condition);

        public static MsBuildProperty Satellite_BaseAddress(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_BaseAddress, in value, in condition);

        public static MsBuildProperty Satellite_CompanyName(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_CompanyName, in value, in condition);

        public static MsBuildProperty Satellite_Configuration(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_Configuration, in value, in condition);

        public static MsBuildProperty Satellite_Description(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_Description, in value, in condition);

        public static MsBuildProperty Satellite_EvidenceFile(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_EvidenceFile, in value, in condition);

        public static MsBuildProperty Satellite_FileVersion(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_FileVersion, in value, in condition);

        public static MsBuildProperty Satellite_Flags(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_Flags, in value, in condition);

        public static MsBuildProperty Satellite_GenerateFullPaths(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_GenerateFullPaths, in value, in condition);

        public static MsBuildProperty Satellite_LinkResource(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_LinkResource, in value, in condition);

        public static MsBuildProperty Satellite_MainEntryPoint(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_MainEntryPoint, in value, in condition);

        public static MsBuildProperty Satellite_ProductName(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_ProductName, in value, in condition);

        public static MsBuildProperty Satellite_ProductVersion(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_ProductVersion, in value, in condition);

        public static MsBuildProperty Satellite_TargetType(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_TargetType, in value, in condition);

        public static MsBuildProperty Satellite_Title(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_Title, in value, in condition);

        public static MsBuildProperty Satellite_Trademark(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_Trademark, in value, in condition);

        public static MsBuildProperty Satellite_Version(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_Version, in value, in condition);

        public static MsBuildProperty Satellite_Win32Icon(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_Win32Icon, in value, in condition);

        public static MsBuildProperty Satellite_Win32Resource(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Satellite_Win32Resource, in value, in condition);

        public static MsBuildProperty SubsystemVersion(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.SubsystemVersion, in value, in condition);

        public static MsBuildProperty TargetCompactFramework(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.TargetCompactFramework, in value, in condition);

        public static MsBuildProperty TargetFrameworkVersion(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.TargetFrameworkVersion, in value, in condition);

        public static MsBuildProperty TreatWarningsAsErrors(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.TreatWarningsAsErrors, in value, in condition);

        public static MsBuildProperty UseHostCompilerIfAvailable(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.UseHostCompilerIfAvailable, in value, in condition);

        public static MsBuildProperty Utf8Output(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Utf8Output, in value, in condition);

        public static MsBuildProperty VbcToolPath(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.VbcToolPath, in value, in condition);

        public static MsBuildProperty VbcVerbosity(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.VbcVerbosity, in value, in condition);

        public static MsBuildProperty VisualStudioVersion(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.VisualStudioVersion, in value, in condition);

        public static MsBuildProperty WarningsAsErrors(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.WarningsAsErrors, in value, in condition);

        public static MsBuildProperty WarningsNotAsErrors(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.WarningsNotAsErrors, in value, in condition);

        public static MsBuildProperty Win32Manifest(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Win32Manifest, in value, in condition);

        public static MsBuildProperty Win32Resource(in string value, in string condition = default)
            => new MsBuildProperty(PropertyConstants.Win32Resource, in value, in condition);
    }
}
