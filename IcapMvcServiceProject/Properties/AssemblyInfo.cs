// ============================================================================ 
// AssemblyInfo.cs 
// Copyright (c) 2007-2018, PeopleNet Communications Corporation. 
// All rights reserved.  Unauthorized copying prohibited. 
// ============================================================================ 
 
using System; 
using System.Reflection; 
using System.Runtime.InteropServices; 
using PNet.Icap.Platform.PlatformSdk; 
 
// ---------------------------------------------------------------------------- 
// Required Attributes 
// ---------------------------------------------------------------------------- 
[assembly: AssemblyTitle("$safeprojectname$")]
[assembly: AssemblyDescription("PeopleNet ICAP $safeprojectname$ Plugin for Android")]
[assembly: AssemblyDefaultAlias("PNet.$safeprojectname$")] 
[assembly: Guid("$guid2$")]
#if DEBUG 
[assembly: AssemblyConfiguration("Debug")] 
#else 
[assembly: AssemblyConfiguration("Release")] 
#endif 
 
// ---------------------------------------------------------------------------- 
// Overridable Attributes 
// ---------------------------------------------------------------------------- 
[assembly: AssemblyProduct(CommonAssemblyInfo.AssemblyProduct)] 
[assembly: AssemblyCompany(CommonAssemblyInfo.AssemblyCompany)] 
[assembly: AssemblyCopyright(CommonAssemblyInfo.AssemblyCopyright)] 
[assembly: AssemblyTrademark(CommonAssemblyInfo.AssemblyTrademark)] 
 
[assembly: AssemblyCulture(CommonAssemblyInfo.AssemblyCulture)] 
 
[assembly: AssemblyFlags(CommonAssemblyInfo.AssemblyFlags)] 
 
[assembly: ComVisible(CommonAssemblyInfo.ComVisible)] 
 
[assembly: CLSCompliant(CommonAssemblyInfo.CLSCompliant)] 
 
[assembly: AssemblyDelaySign(CommonAssemblyInfo.AssemblyDelaySign)] 
[assembly: AssemblyKeyFile(CommonAssemblyInfo.AssemblyKeyFile)] 
[assembly: AssemblyKeyName(CommonAssemblyInfo.AssemblyKeyName)] 
 
[assembly: AssemblyVersion(CommonAssemblyInfo.AssemblyVersion)] 
[assembly: AssemblyFileVersion(CommonAssemblyInfo.AssemblyFileVersion)] 
[assembly: AssemblyInformationalVersion(CommonAssemblyInfo.AssemblyInformationalVersion)] 
