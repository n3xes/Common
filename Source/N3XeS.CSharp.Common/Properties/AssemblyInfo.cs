#region Header: Copyright © 2013, John Caruthers

// --------------------------------------------------------------------------------------------------------------------
//	<copyright company="John Caruthers" file="AssemblyInfo.cs">
//		Copyright © 2013, John Caruthers
//		All rights reserved.
//
//		THIS PROGRAM ND ALL OF THE INFORMATION CONTAINED HEREIN IS FREE SOFTWARE:
//		YOU CAN REDISTRIBUTE IT AND/OR MODIFY IT UNDER THE TERMS OF THE GNU GENERAL
//		PUBLIC LICENSE AS PUBLISHED BY THE FREE SOFTWARE FOUNDATION, EITHER VERSION
//		3 OF THE LICENSE, OR (AT YOUR OPTION) ANY LATER VERSION.
//
//		THIS PROGRAM IS DISTRIBUTED IN THE HOPE THAT IT WILL BE USEFUL, BUT WITHOUT
//		ANY WARRANTY; WITHOUT EVEN THE IMPLIED WARRANTY OF MERCHANTABILITY OR FITNESS
//		FOR A PARTICULAR PURPOSE.SEE THE GNU GENERAL PUBLIC LICENSE FOR MORE DETAILS.
//
//		YOU SHOULD HAVE RECEIVED A COPY OF THE GNU GENERAL PUBLIC LICENSE ALONG
//		WITH THIS PROGRAM.  IF NOT, SEE https://www.gnu.org/licenses/.
//
//	</copyright>
////-------------------------------------------------------------------------------------------------------------------

#endregion

#region Directives

using System;
using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#endregion

// System.Reflection

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("N3XeS C# - Common Library")]
[assembly: AssemblyDescription("The N3XeS C# library containing common elements that are shared by the other N3XeS libraries.")]
[assembly: AssemblyCompany("John Caruthers")]
[assembly: AssemblyProduct("N3XeS.CSharp.Common")]
[assembly: AssemblyCopyright("Copyright (c) 2013, John Caruthers")]
[assembly: AssemblyTrademark("N3XeS is a registered trademark of, John Caruthers")]

[assembly: AssemblyMetadata("ImplicitNullability.AppliesTo", "InputParameters, RefParameters, OutParametersAndResult, Fields, Properties")]
[assembly: AssemblyMetadata("ImplicitNullability.Fields", "RestrictToReadonly, RestrictToReferenceTypes")]
[assembly: AssemblyMetadata("ImplicitNullability.Properties", "RestrictToGetterOnly, RestrictToReferenceTypes")]
[assembly: AssemblyMetadata("ImplicitNullability.GeneratedCode", "Exclude")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyFileVersion("1.0.*")]
[assembly: AssemblyVersion("1.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0")]

[assembly: AssemblyCulture("neutral")]
[assembly: NeutralResourcesLanguage("en-US")]

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]

#else

[assembly: AssemblyConfiguration("Release")]

#endif

#if (!NETFX_V2 && !NETFX_V3 && !NETFX_V35 && !NETFX_V4)

[assembly: AssemblySignatureKey("002400000c8000009400000006020000002400005253413100040000010001008d945aa206e727aa85dd58612a2aa318521d5352d6b56c8f8063d37b280f515cba22b0cb75e09816ef5fc60cf6899c7a62bc6d8c8852082382f0424d5acb9645749cadd3b631a5425dbb755f5013dfa55c6ac2cf26808b698e92c834067816197fb60eb8560b925a6e5c9036edc67c57ca9fcc9b05a18b7229e2d558adbe7f9a",
								"2c3e3cea383549e875f4c9085747a6996b907c89d105e1b30001b2cc462dc53c916a3225b768f70816e4489cfa88d4e719e8ea5882cb5422d2e3ddda6162bc4c3ec63d7c257d5aacd51d8d651d48745b6408bff97852f3de8f71f7c74da4eba330f07726a54987db37b13be5b39694927e77bfb79dddedcaae5df13e2e787e1f")]

#endif

// System
[assembly: CLSCompliant(true)]

// System.Runtime.InteropServices

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following Guid is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("5e50c228-b073-4f55-bb68-b22bf796f35c")]

// System.Runtime.CompilerServices
[assembly: InternalsVisibleTo("Microsoft.Pex, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly: InternalsVisibleTo("N3XeS.CSharp.Common.UnitTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b9ec66971fdfb5d18c699afa5f125d42a861d907cff8e9bd7603d4c93a5cf7f81a8a3d6b2cfc44082198386666cdc48f49acb6841b063cc9028c5669ae3a724ddff3e385a5273f21d0178d9cca1783be1b38aac3323c8532fb7583b93cf7d13a0f2b379f3af5cae8649d4397f692340bc98675698d54dfdb1f3d2499ee8e4fdf")]
[assembly: InternalsVisibleTo("N3XeS.CSharp.Common.Explorables, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b9ec66971fdfb5d18c699afa5f125d42a861d907cff8e9bd7603d4c93a5cf7f81a8a3d6b2cfc44082198386666cdc48f49acb6841b063cc9028c5669ae3a724ddff3e385a5273f21d0178d9cca1783be1b38aac3323c8532fb7583b93cf7d13a0f2b379f3af5cae8649d4397f692340bc98675698d54dfdb1f3d2499ee8e4fdf")]

