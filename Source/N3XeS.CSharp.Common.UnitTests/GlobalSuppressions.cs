#region Header: Copyright © 2013-#{YearCurrent}#, N3XeS LLC

// =====================================================================================================================
// <copyright file="GlobalSupresssions.cs" company="N3XeS LLC">
//		Copyright © 2013-#{YearCurrent}#, N3XeS LLC ("COMPANY")
//		All rights reserved.
//
//		THIS PROGRAM AND ALL OF THE INFORMATION CONTAINED HEREIN ARE THE PROPERTY OF 
//		COMPANY AND ARE TO BE HELD IN THE STRICTEST OF CONFIDENCE.  COMPANY RESERVES 
//		ALL PATENT, COPYRIGHT AND OTHER PROPRIETARY RIGHTS TO THIS PROGRAM AND THE 
//		INFORMATION CONTAINED HEREIN, INCLUDING DESIGN, MANUFACTURING, REPRODUCTION, 
//		USE AND SALES RIGHTS THERETO.  NO PART OF THIS PROGRAM IN SOURCE CODE OR BINARY 
//		FORM MAY BE COPIED, REPRODUCED, DISCLOSED, PUBLISHED, DISPLAYED, COMPILED, SOLD, 
//		OR DISTRIBUTED IN ANY FORM AND BY ANY MEANS, ELECTRONIC, MECHANICAL, OR 
//		OTHERWISE, WITH OR WITHOUT MODIFICATION, TO ANY THIRD PARTIES WITHOUT THE 
//		EXPRESS WRITTEN CONSENT OF COMPANY.  
//
// </copyright>
////====================================================================================================================

#endregion

#region Directives

#if !DEBUG

using System.Diagnostics.CodeAnalysis;

#endif

#endregion

// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

#if !DEBUG

[assembly: SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames")]

#endif
