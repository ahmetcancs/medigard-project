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

[assembly: RegisterDocumentType(HomeMainSectionContainer.CLASS_NAME, typeof(HomeMainSectionContainer))]

namespace CMS.DocumentEngine.Types.Home
{
	/// <summary>
	/// Represents a content item of type HomeMainSectionContainer.
	/// </summary>
	public partial class HomeMainSectionContainer : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "Home.HomeMainSectionContainer";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomeMainSectionContainer fields.
		/// </summary>
		private readonly HomeMainSectionContainerFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeMainSectionContainerID.
		/// </summary>
		[DatabaseIDField]
		public int HomeMainSectionContainerID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeMainSectionContainerID"), 0);
			}
			set
			{
				SetValue("HomeMainSectionContainerID", value);
			}
		}


		/// <summary>
		/// Image2.
		/// </summary>
		[DatabaseField]
		public string Image2
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Image2"), @"");
			}
			set
			{
				SetValue("Image2", value);
			}
		}


		/// <summary>
		/// Image.
		/// </summary>
		[DatabaseField]
		public string Image
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Image"), @"");
			}
			set
			{
				SetValue("Image", value);
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
		/// Gets an object that provides extended API for working with HomeMainSectionContainer fields.
		/// </summary>
		[RegisterProperty]
		public HomeMainSectionContainerFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HomeMainSectionContainer fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomeMainSectionContainerFields : AbstractHierarchicalObject<HomeMainSectionContainerFields>
		{
			/// <summary>
			/// The content item of type HomeMainSectionContainer that is a target of the extended API.
			/// </summary>
			private readonly HomeMainSectionContainer mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeMainSectionContainerFields" /> class with the specified content item of type HomeMainSectionContainer.
			/// </summary>
			/// <param name="instance">The content item of type HomeMainSectionContainer that is a target of the extended API.</param>
			public HomeMainSectionContainerFields(HomeMainSectionContainer instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeMainSectionContainerID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomeMainSectionContainerID;
				}
				set
				{
					mInstance.HomeMainSectionContainerID = value;
				}
			}


			/// <summary>
			/// Image2.
			/// </summary>
			public string Image2
			{
				get
				{
					return mInstance.Image2;
				}
				set
				{
					mInstance.Image2 = value;
				}
			}


			/// <summary>
			/// Image.
			/// </summary>
			public string Image
			{
				get
				{
					return mInstance.Image;
				}
				set
				{
					mInstance.Image = value;
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
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomeMainSectionContainer" /> class.
		/// </summary>
		public HomeMainSectionContainer() : base(CLASS_NAME)
		{
			mFields = new HomeMainSectionContainerFields(this);
		}

		#endregion
	}
}