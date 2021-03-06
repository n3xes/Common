// <copyright file="TypeUtilityTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace N3XeS.CSharp.Common.Utilities.UnitTests
{
	/// <summary>This class contains parameterized unit tests for TypeUtility</summary>
	[TestClass]
	[ExcludeFromCodeCoverage]
	[PexClass(typeof(TypeUtility))]
	[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
	[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
	public partial class TypeUtilityTests
	{

		/// <summary>Test stub for GetActualType(!!0)</summary>
		[PexGenericArguments(typeof(Int32))]
		[PexMethod]
		public Type GetActualTypeTest<T>(T source)
		{
			Type result = TypeUtility.GetActualType<T>(source);
			return result;
			// TODO: add assertions to method TypeUtilityTests.GetActualTypeTest(!!0)
		}

		/// <summary>Test stub for GetActualType(!!0)</summary>
		[PexGenericArguments(typeof(Int32?))]
		[PexMethod]
		public Type GetActualTypeTest1<T>(T source)
		{
			Type result = TypeUtility.GetActualType<T>(source);
			return result;
			// TODO: add assertions to method TypeUtilityTests.GetActualTypeTest(!!0)
		}
	}
}
