﻿//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.Detail;

[assembly: RegisterDocumentType(DetailContent.CLASS_NAME, typeof(DetailContent))]

namespace CMS.DocumentEngine.Types.Detail
{
	/// <summary>
	/// Represents a content item of type DetailContent.
	/// </summary>
	public partial class DetailContent : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Detail.DetailContent";


		/// <summary>
		/// The instance of the class that provides extended API for working with DetailContent fields.
		/// </summary>
		private readonly DetailContentFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// DetailContentID.
		/// </summary>
		[DatabaseIDField]
		public int DetailContentID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("DetailContentID"), 0);
			}
			set
			{
				SetValue("DetailContentID", value);
			}
		}


		/// <summary>
		/// Name.
		/// </summary>
		[DatabaseField]
		public string Name
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Name"), @"");
			}
			set
			{
				SetValue("Name", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with DetailContent fields.
		/// </summary>
		[RegisterProperty]
		public DetailContentFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with DetailContent fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class DetailContentFields : AbstractHierarchicalObject<DetailContentFields>
		{
			/// <summary>
			/// The content item of type DetailContent that is a target of the extended API.
			/// </summary>
			private readonly DetailContent mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="DetailContentFields" /> class with the specified content item of type DetailContent.
			/// </summary>
			/// <param name="instance">The content item of type DetailContent that is a target of the extended API.</param>
			public DetailContentFields(DetailContent instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// DetailContentID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.DetailContentID;
				}
				set
				{
					mInstance.DetailContentID = value;
				}
			}


			/// <summary>
			/// Name.
			/// </summary>
			public string Name
			{
				get
				{
					return mInstance.Name;
				}
				set
				{
					mInstance.Name = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="DetailContent" /> class.
		/// </summary>
		public DetailContent() : base(CLASS_NAME)
		{
			mFields = new DetailContentFields(this);
		}

		#endregion
	}
}