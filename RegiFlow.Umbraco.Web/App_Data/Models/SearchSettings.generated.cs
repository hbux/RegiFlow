//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.18.14
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace RegiFlow.Umbraco.Web.App_Data.Models
{
	// Mixin Content Type with alias "searchSettings"
	/// <summary>Search Settings</summary>
	public partial interface ISearchSettings : IPublishedElement
	{
		/// <summary>Hide From Search?</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.14")]
		bool HideFromSearch { get; }
	}

	/// <summary>Search Settings</summary>
	[PublishedModel("searchSettings")]
	public partial class SearchSettings : PublishedElementModel, ISearchSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.14")]
		public new const string ModelTypeAlias = "searchSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.14")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.14")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.14")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SearchSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SearchSettings(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Hide From Search?: If enabled, this will not appear in searches.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.14")]
		[ImplementPropertyType("hideFromSearch")]
		public virtual bool HideFromSearch => GetHideFromSearch(this);

		/// <summary>Static getter for Hide From Search?</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.18.14")]
		public static bool GetHideFromSearch(ISearchSettings that) => that.Value<bool>("hideFromSearch");
	}
}
