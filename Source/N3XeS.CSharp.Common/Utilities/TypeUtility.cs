#region Header: Copyright © 2013, John Caruthers

// =====================================================================================================================
//	<copyright company="John Caruthers" file="TypeUtility.cs">
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
////====================================================================================================================

#endregion

namespace N3XeS.CSharp.Common.Utilities
{
	#region Directives

	using System;

	using JetBrains.Annotations;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		A type related utility.
	/// </summary>
	/// <author>
	///  <AuthorName>John Caruthers</AuthorName>
	///  <CreationDate>Wednesday, September 18, 2013  (09/18/2013)</CreationDate>
	///  <CreationTime>05:48:50 PM</CreationTime>
	/// </author>
	/// <history>
	///  <Modification>
	///   <ModifierName></ModifierName>
	///   <ModificationDate></ModificationDate>
	///   <ModificationTime></ModificationTime>
	///   <ModificationDescription></ModificationDescription>
	///  </Modification>
	/// </history>
	public static class TypeUtility
	{
		#region Constants

		#endregion

		#region Instance/Member/Field Variables

		#endregion

		#region Constructors

		#endregion

		#region Destructor

		#endregion

		#region Events

		#endregion

		#region Properties/Accessors/Mutators

		#endregion

		#region Indexers

		#endregion

		#region Event Handlers

		#endregion

		#region Methods/Functions

		/// <summary>
		///		Gets the actual type of the <paramref name="source"/> type.
		/// </summary>
		/// <typeparam name="T">The provided type of the actual type to get.</typeparam>
		/// <param name="source">The <typeparamref name="T"/> to get the actual type of.</param>
		/// <returns>The actual type of the <paramref name="source"/>.</returns>
		[CanBeNull]
		public static Type GetActualType<T>(T source)
		{
			Type type = typeof(T);

			if (Nullable.GetUnderlyingType(type) != null)
			{
				return type;
			}

			return source.GetType();
		}

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
