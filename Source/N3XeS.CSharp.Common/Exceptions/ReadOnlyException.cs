#region Header: Copyright © 2020-XXXX, John Caruthers.

// --------------------------------------------------------------------------------------------------------------------
//	<copyright company="John Caruthers" file="ReadOnlyException.cs">
//		Copyright © 2020-XXXX, John Caruthers ("COMPANY")
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
//	</copyright>
////-------------------------------------------------------------------------------------------------------------------

#endregion

namespace N3XeS.CSharp.Common.Exceptions
{
	#region Directives

	using System;
	using System.Diagnostics.CodeAnalysis;
	using System.Runtime.Serialization;

	using JetBrains.Annotations;

	#endregion

	#region Delegates

	#endregion

	#region Enums

	#endregion

	/// <summary>
	///		Represents the exception that is thrown when you try to change a read-only value.
	/// </summary>
	/// <author>
	///		<AuthorName>John Caruthers, Jr.</AuthorName>
	///		<CreationDate>Friday, May 22, 2020  (05/22/2020)</CreationDate>
	///		<CreationTime>08:12:35 AM</CreationTime>
	/// </author>
	/// <history>
	///		<Modification>
	///			<ModifierName></ModifierName>
	///			<ModificationDate></ModificationDate>
	///			<ModificationTime></ModificationTime>
	///			<ModificationDescription></ModificationDescription>
	///		</Modification>
	/// </history>
	[Serializable]
	public class ReadOnlyException
		: SystemException
	{
		#region Constants

		#endregion

		#region Instance/Member/Field Variables

		#endregion

		#region Constructors

		/// <summary>
		///		Initializes a new instance of the <see cref="T:N3XeS.CSharp.Common.Exceptions.ReadOnlyException"/>
		///		class.
		/// </summary>
		public ReadOnlyException()
			: this(null)
		{
		}

		/// <summary>
		///		Initializes a new instance of the <see cref="T:N3XeS.CSharp.Common.Exceptions.ReadOnlyException"/>
		///		class with the provided <paramref name="message"/>.
		/// </summary>
		/// <param name="message">
		///		The <see cref="T:System.String"/> value that represents the message that explains the reason for the
		///		exception to display when the exception is thrown.
		/// </param>
		public ReadOnlyException([CanBeNull] String message)
			: this(message, null)
		{
		}

		/// <summary>
		///		Initializes a new instance of the <see cref="T:N3XeS.CSharp.Common.Exceptions.ReadOnlyException"/>
		///		class with the provided <paramref name="message"/> and a reference to the provided
		///		<paramref name="exceptionInner"/> that is the cause of this exception.
		/// </summary>
		/// <param name="message">
		///		The <see cref="T:System.String"/> value that represents the message that explains the reason for the
		///		exception to display when the exception is thrown.
		/// </param>
		/// <param name="exceptionInner">
		///		The <see cref="T:System.Exception"/> value that represents the exception that is the cause of the
		///		current exception, or a <see langword="null"/> reference (<see langword="Nothing" /> in Visual Basic)
		/// </param>
		public ReadOnlyException([CanBeNull] String message, [CanBeNull] Exception exceptionInner)
		  : base(message, exceptionInner)
		{
		}

		/// <summary>
		///		Initializes a new instance of the <see cref="T:N3XeS.CSharp.Common.Exceptions.ReadOnlyException"/>
		///		class with the provided <paramref name="infoSerialization"/> and <paramref name="contextStreaming"/>
		///		serialization information.
		/// </summary>
		/// <param name="infoSerialization">
		///		The data that is required to serialize or deserialize an object.
		/// </param>
		/// <param name="contextStreaming">
		///		Description of the source and destination of the specified serialized stream.
		/// </param>
		[ExcludeFromCodeCoverage]
		protected ReadOnlyException([NotNull] SerializationInfo infoSerialization, StreamingContext contextStreaming)
		  : base(infoSerialization, contextStreaming)
		{
		}

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

		#endregion

		#region Operators

		#endregion

		#region Nested Types

		#endregion
	}
}
