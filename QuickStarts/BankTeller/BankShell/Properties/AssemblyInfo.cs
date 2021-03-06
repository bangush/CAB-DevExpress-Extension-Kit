//===============================================================================
// Microsoft patterns & practices
// CompositeUI Application Block
//===============================================================================
// Copyright � Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyTitle("BankShell")]
[assembly: AssemblyDescription("CABDevExpress Composite UI Bank Teller QuickStart: Bank Shell")]
[assembly: AssemblyCompany("www.codeplex.com/CabDevExpress")]
[assembly: AssemblyCopyright("Copyright� 2007-2008")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: CLSCompliant(true)]

[assembly: ComVisible(false)]

[assembly: ReflectionPermission(SecurityAction.RequestMinimum, Flags = ReflectionPermissionFlag.MemberAccess)]

[assembly: AssemblyProductAttribute("CABDevExpress")]
[assembly: AssemblyVersionAttribute("0.5.0.0")]
[assembly: AssemblyFileVersionAttribute("0.5.0.0")]
