// <copyright file="TypeExtensionTest.cs" company="N3XeS LLC">Copyright © N3XeS LLC 2016</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Common.Extensions;

namespace N3XeS.CSharp.Common.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for TypeExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(TypeExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class TypeExtensionTest
	{

		/// <summary>Test stub for GetActualType(!!0)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public Type GetActualTypeTest<T>(T source)
		{
			Type result = TypeExtension.GetActualType<T>(source);
			return result;
			// TODO: add assertions to method TypeExtensionTest.GetActualTypeTest(!!0)
		}
	}
}
