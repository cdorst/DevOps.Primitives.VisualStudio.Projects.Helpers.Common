﻿namespace DevOps.Primitives.VisualStudio.Projects.Helpers.Common
{
    public static class Properties
    {
        public static MsBuildProperty AdditionalLibPaths(string value, string condition = null) => new MsBuildProperty(PropertyConstants.AdditionalLibPaths, value, condition);
        public static MsBuildProperty AddModules(string value, string condition = null) => new MsBuildProperty(PropertyConstants.AddModules, value, condition);
        public static MsBuildProperty ALToolPath(string value, string condition = null) => new MsBuildProperty(PropertyConstants.ALToolPath, value, condition);
        public static MsBuildProperty ApplicationIcon(string value, string condition = null) => new MsBuildProperty(PropertyConstants.ApplicationIcon, value, condition);
        public static MsBuildProperty ApplicationManifest(string value, string condition = null) => new MsBuildProperty(PropertyConstants.ApplicationManifest, value, condition);
        public static MsBuildProperty AssemblyOriginatorKeyFile(string value, string condition = null) => new MsBuildProperty(PropertyConstants.AssemblyOriginatorKeyFile, value, condition);
        public static MsBuildProperty AssemblySearchPaths(string value, string condition = null) => new MsBuildProperty(PropertyConstants.AssemblySearchPaths, value, condition);
        public static MsBuildProperty AssemblyName(string value, string condition = null) => new MsBuildProperty(PropertyConstants.AssemblyName, value, condition);
        public static MsBuildProperty BaseAddress(string value, string condition = null) => new MsBuildProperty(PropertyConstants.BaseAddress, value, condition);
        public static MsBuildProperty BaseOutputPath(string value, string condition = null) => new MsBuildProperty(PropertyConstants.BaseOutputPath, value, condition);
        public static MsBuildProperty BaseIntermediateOutputPath(string value, string condition = null) => new MsBuildProperty(PropertyConstants.BaseIntermediateOutputPath, value, condition);
        public static MsBuildProperty BuildInParallel(string value, string condition = null) => new MsBuildProperty(PropertyConstants.BuildInParallel, value, condition);
        public static MsBuildProperty BuildProjectReferences(string value, string condition = null) => new MsBuildProperty(PropertyConstants.BuildProjectReferences, value, condition);
        public static MsBuildProperty CleanFile(string value, string condition = null) => new MsBuildProperty(PropertyConstants.CleanFile, value, condition);
        public static MsBuildProperty CodePage(string value, string condition = null) => new MsBuildProperty(PropertyConstants.CodePage, value, condition);
        public static MsBuildProperty CompilerResponseFile(string value, string condition = null) => new MsBuildProperty(PropertyConstants.CompilerResponseFile, value, condition);
        public static MsBuildProperty Configuration(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Configuration, value, condition);
        public static MsBuildProperty CscToolPath(string value, string condition = null) => new MsBuildProperty(PropertyConstants.CscToolPath, value, condition);
        public static MsBuildProperty CustomBeforeMicrosoftCommonTargets(string value, string condition = null) => new MsBuildProperty(PropertyConstants.CustomBeforeMicrosoftCommonTargets, value, condition);
        public static MsBuildProperty DebugSymbols(string value, string condition = null) => new MsBuildProperty(PropertyConstants.DebugSymbols, value, condition);
        public static MsBuildProperty DefineConstants(string value, string condition = null) => new MsBuildProperty(PropertyConstants.DefineConstants, value, condition);
        public static MsBuildProperty DefineDebug(string value, string condition = null) => new MsBuildProperty(PropertyConstants.DefineDebug, value, condition);
        public static MsBuildProperty DefineTrace(string value, string condition = null) => new MsBuildProperty(PropertyConstants.DefineTrace, value, condition);
        public static MsBuildProperty DebugType(string value, string condition = null) => new MsBuildProperty(PropertyConstants.DebugType, value, condition);
        public static MsBuildProperty DelaySign(string value, string condition = null) => new MsBuildProperty(PropertyConstants.DelaySign, value, condition);
        public static MsBuildProperty Deterministic(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Deterministic, value, condition);
        public static MsBuildProperty DisabledWarnings(string value, string condition = null) => new MsBuildProperty(PropertyConstants.DisabledWarnings, value, condition);
        public static MsBuildProperty DisableFastUpToDateCheck(string value, string condition = null) => new MsBuildProperty(PropertyConstants.DisableFastUpToDateCheck, value, condition);
        public static MsBuildProperty DocumentationFile(string value, string condition = null) => new MsBuildProperty(PropertyConstants.DocumentationFile, value, condition);
        public static MsBuildProperty ErrorReport(string value, string condition = null) => new MsBuildProperty(PropertyConstants.ErrorReport, value, condition);
        public static MsBuildProperty ExcludeDeploymentUrl(string value, string condition = null) => new MsBuildProperty(PropertyConstants.ExcludeDeploymentUrl, value, condition);
        public static MsBuildProperty FileAlignment(string value, string condition = null) => new MsBuildProperty(PropertyConstants.FileAlignment, value, condition);
        public static MsBuildProperty FrameworkPathOverride(string value, string condition = null) => new MsBuildProperty(PropertyConstants.FrameworkPathOverride, value, condition);
        public static MsBuildProperty GenerateDocumentation(string value, string condition = null) => new MsBuildProperty(PropertyConstants.GenerateDocumentation, value, condition);
        public static MsBuildProperty IntermediateOutputPath(string value, string condition = null) => new MsBuildProperty(PropertyConstants.IntermediateOutputPath, value, condition);
        public static MsBuildProperty KeyContainerName(string value, string condition = null) => new MsBuildProperty(PropertyConstants.KeyContainerName, value, condition);
        public static MsBuildProperty KeyOriginatorFile(string value, string condition = null) => new MsBuildProperty(PropertyConstants.KeyOriginatorFile, value, condition);
        public static MsBuildProperty ModuleAssemblyName(string value, string condition = null) => new MsBuildProperty(PropertyConstants.ModuleAssemblyName, value, condition);
        public static MsBuildProperty NoLogo(string value, string condition = null) => new MsBuildProperty(PropertyConstants.NoLogo, value, condition);
        public static MsBuildProperty NoStdLib(string value, string condition = null) => new MsBuildProperty(PropertyConstants.NoStdLib, value, condition);
        public static MsBuildProperty NoVBRuntimeReference(string value, string condition = null) => new MsBuildProperty(PropertyConstants.NoVBRuntimeReference, value, condition);
        public static MsBuildProperty NoWin32Manifest(string value, string condition = null) => new MsBuildProperty(PropertyConstants.NoWin32Manifest, value, condition);
        public static MsBuildProperty Optimize(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Optimize, value, condition);
        public static MsBuildProperty OptionCompare(string value, string condition = null) => new MsBuildProperty(PropertyConstants.OptionCompare, value, condition);
        public static MsBuildProperty OptionExplicit(string value, string condition = null) => new MsBuildProperty(PropertyConstants.OptionExplicit, value, condition);
        public static MsBuildProperty OptionInfer(string value, string condition = null) => new MsBuildProperty(PropertyConstants.OptionInfer, value, condition);
        public static MsBuildProperty OptionStrict(string value, string condition = null) => new MsBuildProperty(PropertyConstants.OptionStrict, value, condition);
        public static MsBuildProperty OutputPath(string value, string condition = null) => new MsBuildProperty(PropertyConstants.OutputPath, value, condition);
        public static MsBuildProperty OutputType(string value, string condition = null) => new MsBuildProperty(PropertyConstants.OutputType, value, condition);
        public static MsBuildProperty OverwriteReadOnlyFiles(string value, string condition = null) => new MsBuildProperty(PropertyConstants.OverwriteReadOnlyFiles, value, condition);
        public static MsBuildProperty PdbFile(string value, string condition = null) => new MsBuildProperty(PropertyConstants.PdbFile, value, condition);
        public static MsBuildProperty Platform(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Platform, value, condition);
        public static MsBuildProperty ProduceReferenceAssembly(string value, string condition = null) => new MsBuildProperty(PropertyConstants.ProduceReferenceAssembly, value, condition);
        public static MsBuildProperty RemoveIntegerChecks(string value, string condition = null) => new MsBuildProperty(PropertyConstants.RemoveIntegerChecks, value, condition);
        public static MsBuildProperty SGenUseProxyTypes(string value, string condition = null) => new MsBuildProperty(PropertyConstants.SGenUseProxyTypes, value, condition);
        public static MsBuildProperty SGenToolPath(string value, string condition = null) => new MsBuildProperty(PropertyConstants.SGenToolPath, value, condition);
        public static MsBuildProperty StartupObject(string value, string condition = null) => new MsBuildProperty(PropertyConstants.StartupObject, value, condition);
        public static MsBuildProperty ProcessorArchitecture(string value, string condition = null) => new MsBuildProperty(PropertyConstants.ProcessorArchitecture, value, condition);
        public static MsBuildProperty RootNamespace(string value, string condition = null) => new MsBuildProperty(PropertyConstants.RootNamespace, value, condition);
        public static MsBuildProperty Satellite_AlgorithmId(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_AlgorithmId, value, condition);
        public static MsBuildProperty Satellite_BaseAddress(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_BaseAddress, value, condition);
        public static MsBuildProperty Satellite_CompanyName(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_CompanyName, value, condition);
        public static MsBuildProperty Satellite_Configuration(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_Configuration, value, condition);
        public static MsBuildProperty Satellite_Description(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_Description, value, condition);
        public static MsBuildProperty Satellite_EvidenceFile(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_EvidenceFile, value, condition);
        public static MsBuildProperty Satellite_FileVersion(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_FileVersion, value, condition);
        public static MsBuildProperty Satellite_Flags(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_Flags, value, condition);
        public static MsBuildProperty Satellite_GenerateFullPaths(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_GenerateFullPaths, value, condition);
        public static MsBuildProperty Satellite_LinkResource(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_LinkResource, value, condition);
        public static MsBuildProperty Satellite_MainEntryPoint(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_MainEntryPoint, value, condition);
        public static MsBuildProperty Satellite_ProductName(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_ProductName, value, condition);
        public static MsBuildProperty Satellite_ProductVersion(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_ProductVersion, value, condition);
        public static MsBuildProperty Satellite_TargetType(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_TargetType, value, condition);
        public static MsBuildProperty Satellite_Title(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_Title, value, condition);
        public static MsBuildProperty Satellite_Trademark(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_Trademark, value, condition);
        public static MsBuildProperty Satellite_Version(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_Version, value, condition);
        public static MsBuildProperty Satellite_Win32Icon(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_Win32Icon, value, condition);
        public static MsBuildProperty Satellite_Win32Resource(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Satellite_Win32Resource, value, condition);
        public static MsBuildProperty SubsystemVersion(string value, string condition = null) => new MsBuildProperty(PropertyConstants.SubsystemVersion, value, condition);
        public static MsBuildProperty TargetCompactFramework(string value, string condition = null) => new MsBuildProperty(PropertyConstants.TargetCompactFramework, value, condition);
        public static MsBuildProperty TargetFrameworkVersion(string value, string condition = null) => new MsBuildProperty(PropertyConstants.TargetFrameworkVersion, value, condition);
        public static MsBuildProperty TreatWarningsAsErrors(string value, string condition = null) => new MsBuildProperty(PropertyConstants.TreatWarningsAsErrors, value, condition);
        public static MsBuildProperty UseHostCompilerIfAvailable(string value, string condition = null) => new MsBuildProperty(PropertyConstants.UseHostCompilerIfAvailable, value, condition);
        public static MsBuildProperty Utf8Output(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Utf8Output, value, condition);
        public static MsBuildProperty VbcToolPath(string value, string condition = null) => new MsBuildProperty(PropertyConstants.VbcToolPath, value, condition);
        public static MsBuildProperty VbcVerbosity(string value, string condition = null) => new MsBuildProperty(PropertyConstants.VbcVerbosity, value, condition);
        public static MsBuildProperty VisualStudioVersion(string value, string condition = null) => new MsBuildProperty(PropertyConstants.VisualStudioVersion, value, condition);
        public static MsBuildProperty WarningsAsErrors(string value, string condition = null) => new MsBuildProperty(PropertyConstants.WarningsAsErrors, value, condition);
        public static MsBuildProperty WarningsNotAsErrors(string value, string condition = null) => new MsBuildProperty(PropertyConstants.WarningsNotAsErrors, value, condition);
        public static MsBuildProperty Win32Manifest(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Win32Manifest, value, condition);
        public static MsBuildProperty Win32Resource(string value, string condition = null) => new MsBuildProperty(PropertyConstants.Win32Resource, value, condition);
    }
}
