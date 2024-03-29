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
using CMS.DocumentEngine.Types.Home;

[assembly: RegisterDocumentType(HomeMainSectionExplanation.CLASS_NAME, typeof(HomeMainSectionExplanation))]

namespace CMS.DocumentEngine.Types.Home
{
	/// <summary>
	/// Represents a content item of type HomeMainSectionExplanation.
	/// </summary>
	public partial class HomeMainSectionExplanation : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Home.HomeMainSectionExplanation";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomeMainSectionExplanation fields.
		/// </summary>
		private readonly HomeMainSectionExplanationFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeMainSectionExplanationID.
		/// </summary>
		[DatabaseIDField]
		public int HomeMainSectionExplanationID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeMainSectionExplanationID"), 0);
			}
			set
			{
				SetValue("HomeMainSectionExplanationID", value);
			}
		}


		/// <summary>
		/// Title.
		/// </summary>
		[DatabaseField]
		public string Title
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Title"), @"");
			}
			set
			{
				SetValue("Title", value);
			}
		}


		/// <summary>
		/// Description.
		/// </summary>
		[DatabaseField]
		public string Description
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Description"), @"");
			}
			set
			{
				SetValue("Description", value);
			}
		}


		/// <summary>
		/// SubTitle.
		/// </summary>
		[DatabaseField]
		public string SubTitle
		{
			get
			{
				return ValidationHelper.GetString(GetValue("SubTitle"), @"");
			}
			set
			{
				SetValue("SubTitle", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with HomeMainSectionExplanation fields.
		/// </summary>
		[RegisterProperty]
		public HomeMainSectionExplanationFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HomeMainSectionExplanation fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomeMainSectionExplanationFields : AbstractHierarchicalObject<HomeMainSectionExplanationFields>
		{
			/// <summary>
			/// The content item of type HomeMainSectionExplanation that is a target of the extended API.
			/// </summary>
			private readonly HomeMainSectionExplanation mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeMainSectionExplanationFields" /> class with the specified content item of type HomeMainSectionExplanation.
			/// </summary>
			/// <param name="instance">The content item of type HomeMainSectionExplanation that is a target of the extended API.</param>
			public HomeMainSectionExplanationFields(HomeMainSectionExplanation instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeMainSectionExplanationID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomeMainSectionExplanationID;
				}
				set
				{
					mInstance.HomeMainSectionExplanationID = value;
				}
			}


			/// <summary>
			/// Title.
			/// </summary>
			public string Title
			{
				get
				{
					return mInstance.Title;
				}
				set
				{
					mInstance.Title = value;
				}
			}


			/// <summary>
			/// Description.
			/// </summary>
			public string Description
			{
				get
				{
					return mInstance.Description;
				}
				set
				{
					mInstance.Description = value;
				}
			}


			/// <summary>
			/// SubTitle.
			/// </summary>
			public string SubTitle
			{
				get
				{
					return mInstance.SubTitle;
				}
				set
				{
					mInstance.SubTitle = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomeMainSectionExplanation" /> class.
		/// </summary>
		public HomeMainSectionExplanation() : base(CLASS_NAME)
		{
			mFields = new HomeMainSectionExplanationFields(this);
		}

		#endregion
	}
}