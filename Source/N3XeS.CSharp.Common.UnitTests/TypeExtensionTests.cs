// <copyright file="TypeExtensionTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace N3XeS.CSharp.Common.Extensions.UnitTests
{
	/// <summary>This class contains parameterized unit tests for TypeExtension</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(TypeExtension))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class TypeExtensionTests
	{
		/// <summary>Test stub for GetActualType(!!0)</summary>
		[PexGenericArguments(typeof(Int32))]
		[PexMethod]
		public Type GetActualTypeTest<T>(T source)
		{
			Type result = source.GetActualType();
			return result;
			// TODO: add assertions to method TypeExtensionTests.GetActualTypeTest(!!0)
		}

		/// <summary>Test stub for GetActualType(!!0)</summary>
		[PexGenericArguments(typeof(Int32?))]
		[PexMethod]
		public Type GetActualTypeTest1<T>(T source)
		{
			Type result = source.GetActualType();
			return result;
			// TODO: add assertions to method TypeExtensionTests.GetActualTypeTest(!!0)
		}
	}
}
