using System;

namespace youtube
{
/// <summary>
/// OpenSpan design component.
/// </summary>
// UniversalWebAdapter-8D7EA61716AFE09
[OpenSpan.Design.ComponentIdentityAttribute("UniversalWebAdapter-8D7EA61716AFE09")]
[System.ComponentModel.ToolboxItemAttribute(false)]
public sealed class ytt : OpenSpan.Adapters.Web.Universal.UniversalWebAdapter
{
	
	[OpenSpan.Design.ComponentIdentityAttribute("UniversalWebAdapter-8D7EA61716AFE09\\WebPage-8D7EA619FF2B113")]
	public OpenSpan.Adapters.Web.WebBase.Controls.WebPage YouTube1;
	
	[OpenSpan.Design.ComponentIdentityAttribute("UniversalWebAdapter-8D7EA61716AFE09\\Form-8D7EA619FCBDE1D")]
	public OpenSpan.Adapters.Web.WebBase.Controls.Form ___________________________________;
	
	[OpenSpan.Design.ComponentIdentityAttribute("UniversalWebAdapter-8D7EA61716AFE09\\TextBox-8D7EA619FB1E1B9")]
	public OpenSpan.Adapters.Web.WebBase.Controls.TextBox SearchTxt;
	
	private OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule4;
	
	private OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule5;
	
	[OpenSpan.Design.ComponentIdentityAttribute("UniversalWebAdapter-8D7EA61716AFE09\\BasicButton-8D7EA61A45B5C2D")]
	public OpenSpan.Adapters.Web.WebBase.Controls.BasicButton Search;
	
	private OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule6;
	
	private OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule3;
	
	private OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule1;
	
	private OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule2;
	
	public ytt()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Setup field members
		// 
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(ytt));
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		this.YouTube1 = new OpenSpan.Adapters.Web.WebBase.Controls.WebPage();
		this.___________________________________ = new OpenSpan.Adapters.Web.WebBase.Controls.Form();
		this.SearchTxt = new OpenSpan.Adapters.Web.WebBase.Controls.TextBox();
		this.virtualPropertyMatchRule4 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.virtualPropertyMatchRule5 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.Search = new OpenSpan.Adapters.Web.WebBase.Controls.BasicButton();
		this.virtualPropertyMatchRule6 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.virtualPropertyMatchRule3 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.virtualPropertyMatchRule1 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.virtualPropertyMatchRule2 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// Initialize design component
		// 
		this.Initialize();
		// 
		// Set design component Id
		// 
		this.Id = new OpenSpan.Design.ComponentIdentity("UniversalWebAdapter-8D7EA61716AFE09");
		// 
		// Set component Ids
		// 
		this.SetId(this.YouTube1, new OpenSpan.Design.ComponentIdentity("WebPage-8D7EA619FF2B113"));
		this.SetId(this.___________________________________, new OpenSpan.Design.ComponentIdentity("Form-8D7EA619FCBDE1D"));
		this.SetId(this.SearchTxt, new OpenSpan.Design.ComponentIdentity("TextBox-8D7EA619FB1E1B9"));
		this.SetId(this.virtualPropertyMatchRule4, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A02EAD42"));
		this.SetId(this.virtualPropertyMatchRule5, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A03CB677"));
		this.SetId(this.Search, new OpenSpan.Design.ComponentIdentity("BasicButton-8D7EA61A45B5C2D"));
		this.SetId(this.virtualPropertyMatchRule6, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A475B7EA"));
		this.SetId(this.virtualPropertyMatchRule3, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A01E6AD1"));
		this.SetId(this.virtualPropertyMatchRule1, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA619FFB0413"));
		this.SetId(this.virtualPropertyMatchRule2, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A0056369"));
		// 
		// ytt
		// 
		this.AdditionalArguments = null;
		this.AdvancedConfiguration = null;
		this.BrowserStopMethod = OpenSpan.Adapters.Web.Universal.UniversalWebAdapter.BrowserStopMethodEnum.StopTrackedDocuments;
		this.BrowserType = OpenSpan.Adapters.Web.Universal.Service.BrowserType.Chrome;
		ComponentInfo.CodeDomData = _resources_.GetString("_ytt_1_");
		// 
		// YouTube1
		// 
		// 
		// ___________________________________
		// 
		// 
		// SearchTxt
		// 
		this.SearchTxt.ElementId = null;
		this.SearchTxt.Extender = null;
		this.SearchTxt.ExtensibleTypeName = null;
		this.SearchTxt.ForwardObjectExplorerEvent = true;
		this.SearchTxt.MatchingIndex = 0;
		// 
		// virtualPropertyMatchRule4
		// 
		this.virtualPropertyMatchRule4.PropertyName = "type";
		textmatchdata1.Text = "text";
		this.virtualPropertyMatchRule4.Text = textmatchdata1;
		// 
		// virtualPropertyMatchRule5
		// 
		this.virtualPropertyMatchRule5.PropertyName = "id";
		textmatchdata2.Text = "search";
		this.virtualPropertyMatchRule5.Text = textmatchdata2;
		this.SearchTxt.MatchRules.Add(this.virtualPropertyMatchRule4);
		this.SearchTxt.MatchRules.Add(this.virtualPropertyMatchRule5);
		this.SearchTxt.Name = "SearchTxt";
		this.SearchTxt.TagName = "INPUT";
		this.SearchTxt.TargetTypeString = _resources_.GetString("_ytt_2_");
		this.SearchTxt.UseElementId = false;
		// 
		// Search
		// 
		this.Search.ElementId = "search-icon-legacy";
		this.Search.Extender = null;
		this.Search.ExtensibleTypeName = null;
		this.Search.ForwardObjectExplorerEvent = true;
		this.Search.MatchingIndex = 0;
		// 
		// virtualPropertyMatchRule6
		// 
		this.virtualPropertyMatchRule6.PropertyName = "id";
		textmatchdata3.Text = "search-icon-legacy";
		this.virtualPropertyMatchRule6.Text = textmatchdata3;
		this.Search.MatchRules.Add(this.virtualPropertyMatchRule6);
		this.Search.Name = "Search";
		this.Search.TagName = "BUTTON";
		this.Search.TargetTypeString = _resources_.GetString("_ytt_3_");
		this.Search.UseElementId = true;
		this.___________________________________.Controls.Add(this.SearchTxt);
		this.___________________________________.Controls.Add(this.Search);
		this.___________________________________.ElementId = "search-form";
		this.___________________________________.Extender = null;
		this.___________________________________.ExtensibleTypeName = null;
		this.___________________________________.ForwardObjectExplorerEvent = true;
		this.___________________________________.MatchingIndex = 0;
		// 
		// virtualPropertyMatchRule3
		// 
		this.virtualPropertyMatchRule3.PropertyName = "id";
		textmatchdata4.Text = "search-form";
		this.virtualPropertyMatchRule3.Text = textmatchdata4;
		this.___________________________________.MatchRules.Add(this.virtualPropertyMatchRule3);
		this.___________________________________.Name = "___________________________________";
		this.___________________________________.TagName = "FORM";
		this.___________________________________.TargetTypeString = _resources_.GetString("_ytt_4_");
		this.___________________________________.UseElementId = true;
		this.YouTube1.Controls.Add(this.___________________________________);
		this.YouTube1.Extender = null;
		this.YouTube1.ForwardObjectExplorerEvent = true;
		this.YouTube1.IsGlobal = true;
		this.YouTube1.MatchingIndex = 0;
		// 
		// virtualPropertyMatchRule1
		// 
		this.virtualPropertyMatchRule1.PropertyName = "url";
		textmatchdata5.Text = "https://www.youtube.com/";
		this.virtualPropertyMatchRule1.Text = textmatchdata5;
		// 
		// virtualPropertyMatchRule2
		// 
		this.virtualPropertyMatchRule2.PropertyName = "title";
		textmatchdata6.Text = "YouTube";
		this.virtualPropertyMatchRule2.Text = textmatchdata6;
		this.YouTube1.MatchRules.Add(this.virtualPropertyMatchRule1);
		this.YouTube1.MatchRules.Add(this.virtualPropertyMatchRule2);
		this.YouTube1.Name = "YouTube1";
		this.YouTube1.TargetTypeString = _resources_.GetString("_ytt_5_");
		this.Controls.Add(this.YouTube1);
		this.ElectronConfiguration.Path = "";
		this.ElectronConfiguration.TargetPath = null;
		this.ElectronConfiguration.WorkingDirectory = null;
		this.ExpressNativeTypes = null;
		this.Extender = null;
		this.FriendlyName = "ytt";
		this.IgnoreMainBrowser = false;
		this.Name = "ytt";
		this.ReasonAdapterNotReady = null;
		this.StartMyDay = OpenSpan.ApplicationFramework.StartMyDay.StartOptions.None;
		this.StartMyDayControls = null;
		this.StartOnProjectStart = false;
		this.StartPage = "https://www.youtube.com/";
		this.StartTimeout = 20000;
		// 
		// Add components
		// 
		this.mComponents = new System.Collections.Generic.List<System.ComponentModel.IComponent>(20);
		this.Components.Add(this.YouTube1);
		this.Components.Add(this.___________________________________);
		this.Components.Add(this.SearchTxt);
		this.Components.Add(this.virtualPropertyMatchRule4);
		this.Components.Add(this.virtualPropertyMatchRule5);
		this.Components.Add(this.Search);
		this.Components.Add(this.virtualPropertyMatchRule6);
		this.Components.Add(this.virtualPropertyMatchRule3);
		this.Components.Add(this.virtualPropertyMatchRule1);
		this.Components.Add(this.virtualPropertyMatchRule2);
	}
	
	private System.Collections.Generic.List<System.ComponentModel.IComponent> mComponents;
	
	public System.Collections.Generic.List<System.ComponentModel.IComponent> Components
	{
		get
		{
			return this.mComponents;
		}
	}
	
	/// <summary>
	/// Start design component.
	/// </summary>
	public override void Start()
	{
		base.Start();
	}
	
	/// <summary>
	/// Stop design component.
	/// </summary>
	public override void Stop()
	{
		base.Stop();
	}
	
	internal OpenSpan.Adapters.Web.WebBase.Controls.WebPage Create_YouTube1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(ytt));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.Controls.WebPage YouTube1 = new OpenSpan.Adapters.Web.WebBase.Controls.WebPage();
		this.SetId(YouTube1, new OpenSpan.Design.ComponentIdentity("WebPage-8D7EA619FF2B113"));
		OpenSpan.Adapters.Web.WebBase.Controls.Form ___________________________________;
		___________________________________ = new OpenSpan.Adapters.Web.WebBase.Controls.Form();
		// 
		// ___________________________________
		// 
		OpenSpan.Adapters.Web.WebBase.Controls.TextBox SearchTxt;
		SearchTxt = new OpenSpan.Adapters.Web.WebBase.Controls.TextBox();
		// 
		// SearchTxt
		// 
		SearchTxt.ElementId = null;
		SearchTxt.Extender = null;
		SearchTxt.ExtensibleTypeName = null;
		SearchTxt.ForwardObjectExplorerEvent = true;
		SearchTxt.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule4;
		virtualPropertyMatchRule4 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule4
		// 
		virtualPropertyMatchRule4.PropertyName = "type";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "text";
		virtualPropertyMatchRule4.Text = textmatchdata1;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule5;
		virtualPropertyMatchRule5 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule5
		// 
		virtualPropertyMatchRule5.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "search";
		virtualPropertyMatchRule5.Text = textmatchdata2;
		SearchTxt.MatchRules.Add(virtualPropertyMatchRule4);
		SearchTxt.MatchRules.Add(virtualPropertyMatchRule5);
		SearchTxt.Name = "SearchTxt";
		SearchTxt.TagName = "INPUT";
		SearchTxt.TargetTypeString = _resources_.GetString("_ytt_2_");
		SearchTxt.UseElementId = false;
		OpenSpan.Adapters.Web.WebBase.Controls.BasicButton Search;
		Search = new OpenSpan.Adapters.Web.WebBase.Controls.BasicButton();
		// 
		// Search
		// 
		Search.ElementId = "search-icon-legacy";
		Search.Extender = null;
		Search.ExtensibleTypeName = null;
		Search.ForwardObjectExplorerEvent = true;
		Search.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule6;
		virtualPropertyMatchRule6 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule6
		// 
		virtualPropertyMatchRule6.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "search-icon-legacy";
		virtualPropertyMatchRule6.Text = textmatchdata3;
		Search.MatchRules.Add(virtualPropertyMatchRule6);
		Search.Name = "Search";
		Search.TagName = "BUTTON";
		Search.TargetTypeString = _resources_.GetString("_ytt_3_");
		Search.UseElementId = true;
		___________________________________.Controls.Add(SearchTxt);
		___________________________________.Controls.Add(Search);
		___________________________________.ElementId = "search-form";
		___________________________________.Extender = null;
		___________________________________.ExtensibleTypeName = null;
		___________________________________.ForwardObjectExplorerEvent = true;
		___________________________________.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule3;
		virtualPropertyMatchRule3 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule3
		// 
		virtualPropertyMatchRule3.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata4.Text = "search-form";
		virtualPropertyMatchRule3.Text = textmatchdata4;
		___________________________________.MatchRules.Add(virtualPropertyMatchRule3);
		___________________________________.Name = "___________________________________";
		___________________________________.TagName = "FORM";
		___________________________________.TargetTypeString = _resources_.GetString("_ytt_4_");
		___________________________________.UseElementId = true;
		YouTube1.Controls.Add(___________________________________);
		YouTube1.Extender = null;
		YouTube1.ForwardObjectExplorerEvent = true;
		YouTube1.IsGlobal = true;
		YouTube1.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule1;
		virtualPropertyMatchRule1 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule1
		// 
		virtualPropertyMatchRule1.PropertyName = "url";
		OpenSpan.Adapters.TextMatchData textmatchdata5 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata5.Text = "https://www.youtube.com/";
		virtualPropertyMatchRule1.Text = textmatchdata5;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule2;
		virtualPropertyMatchRule2 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule2
		// 
		virtualPropertyMatchRule2.PropertyName = "title";
		OpenSpan.Adapters.TextMatchData textmatchdata6 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata6.Text = "YouTube";
		virtualPropertyMatchRule2.Text = textmatchdata6;
		YouTube1.MatchRules.Add(virtualPropertyMatchRule1);
		YouTube1.MatchRules.Add(virtualPropertyMatchRule2);
		YouTube1.Name = "YouTube1";
		YouTube1.TargetTypeString = _resources_.GetString("_ytt_5_");
		// 
		// Set designComp Ids
		// 
		this.SetId(___________________________________, new OpenSpan.Design.ComponentIdentity("Form-8D7EA619FCBDE1D"));
		this.SetId(SearchTxt, new OpenSpan.Design.ComponentIdentity("TextBox-8D7EA619FB1E1B9"));
		this.SetId(virtualPropertyMatchRule4, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A02EAD42"));
		this.SetId(virtualPropertyMatchRule5, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A03CB677"));
		this.SetId(Search, new OpenSpan.Design.ComponentIdentity("BasicButton-8D7EA61A45B5C2D"));
		this.SetId(virtualPropertyMatchRule6, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A475B7EA"));
		this.SetId(virtualPropertyMatchRule3, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A01E6AD1"));
		this.SetId(virtualPropertyMatchRule1, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA619FFB0413"));
		this.SetId(virtualPropertyMatchRule2, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A0056369"));
		// 
		// Add components
		// 
		components.Add(___________________________________);
		components.Add(SearchTxt);
		components.Add(virtualPropertyMatchRule4);
		components.Add(virtualPropertyMatchRule5);
		components.Add(Search);
		components.Add(virtualPropertyMatchRule6);
		components.Add(virtualPropertyMatchRule3);
		components.Add(virtualPropertyMatchRule1);
		components.Add(virtualPropertyMatchRule2);
		// 
		// Result
		// 
		return YouTube1;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.Controls.Form Create____________________________________(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(ytt));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.Controls.Form ___________________________________ = new OpenSpan.Adapters.Web.WebBase.Controls.Form();
		this.SetId(___________________________________, new OpenSpan.Design.ComponentIdentity("Form-8D7EA619FCBDE1D"));
		OpenSpan.Adapters.Web.WebBase.Controls.TextBox SearchTxt;
		SearchTxt = new OpenSpan.Adapters.Web.WebBase.Controls.TextBox();
		// 
		// SearchTxt
		// 
		SearchTxt.ElementId = null;
		SearchTxt.Extender = null;
		SearchTxt.ExtensibleTypeName = null;
		SearchTxt.ForwardObjectExplorerEvent = true;
		SearchTxt.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule4;
		virtualPropertyMatchRule4 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule4
		// 
		virtualPropertyMatchRule4.PropertyName = "type";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "text";
		virtualPropertyMatchRule4.Text = textmatchdata1;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule5;
		virtualPropertyMatchRule5 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule5
		// 
		virtualPropertyMatchRule5.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "search";
		virtualPropertyMatchRule5.Text = textmatchdata2;
		SearchTxt.MatchRules.Add(virtualPropertyMatchRule4);
		SearchTxt.MatchRules.Add(virtualPropertyMatchRule5);
		SearchTxt.Name = "SearchTxt";
		SearchTxt.TagName = "INPUT";
		SearchTxt.TargetTypeString = _resources_.GetString("_ytt_2_");
		SearchTxt.UseElementId = false;
		OpenSpan.Adapters.Web.WebBase.Controls.BasicButton Search;
		Search = new OpenSpan.Adapters.Web.WebBase.Controls.BasicButton();
		// 
		// Search
		// 
		Search.ElementId = "search-icon-legacy";
		Search.Extender = null;
		Search.ExtensibleTypeName = null;
		Search.ForwardObjectExplorerEvent = true;
		Search.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule6;
		virtualPropertyMatchRule6 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule6
		// 
		virtualPropertyMatchRule6.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata3 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata3.Text = "search-icon-legacy";
		virtualPropertyMatchRule6.Text = textmatchdata3;
		Search.MatchRules.Add(virtualPropertyMatchRule6);
		Search.Name = "Search";
		Search.TagName = "BUTTON";
		Search.TargetTypeString = _resources_.GetString("_ytt_3_");
		Search.UseElementId = true;
		___________________________________.Controls.Add(SearchTxt);
		___________________________________.Controls.Add(Search);
		___________________________________.ElementId = "search-form";
		___________________________________.Extender = null;
		___________________________________.ExtensibleTypeName = null;
		___________________________________.ForwardObjectExplorerEvent = true;
		___________________________________.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule3;
		virtualPropertyMatchRule3 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule3
		// 
		virtualPropertyMatchRule3.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata4 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata4.Text = "search-form";
		virtualPropertyMatchRule3.Text = textmatchdata4;
		___________________________________.MatchRules.Add(virtualPropertyMatchRule3);
		___________________________________.Name = "___________________________________";
		___________________________________.TagName = "FORM";
		___________________________________.TargetTypeString = _resources_.GetString("_ytt_4_");
		___________________________________.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(SearchTxt, new OpenSpan.Design.ComponentIdentity("TextBox-8D7EA619FB1E1B9"));
		this.SetId(virtualPropertyMatchRule4, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A02EAD42"));
		this.SetId(virtualPropertyMatchRule5, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A03CB677"));
		this.SetId(Search, new OpenSpan.Design.ComponentIdentity("BasicButton-8D7EA61A45B5C2D"));
		this.SetId(virtualPropertyMatchRule6, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A475B7EA"));
		this.SetId(virtualPropertyMatchRule3, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A01E6AD1"));
		// 
		// Add components
		// 
		components.Add(SearchTxt);
		components.Add(virtualPropertyMatchRule4);
		components.Add(virtualPropertyMatchRule5);
		components.Add(Search);
		components.Add(virtualPropertyMatchRule6);
		components.Add(virtualPropertyMatchRule3);
		// 
		// Result
		// 
		return ___________________________________;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.Controls.TextBox Create_SearchTxt(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(ytt));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.Controls.TextBox SearchTxt = new OpenSpan.Adapters.Web.WebBase.Controls.TextBox();
		this.SetId(SearchTxt, new OpenSpan.Design.ComponentIdentity("TextBox-8D7EA619FB1E1B9"));
		SearchTxt.ElementId = null;
		SearchTxt.Extender = null;
		SearchTxt.ExtensibleTypeName = null;
		SearchTxt.ForwardObjectExplorerEvent = true;
		SearchTxt.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule4;
		virtualPropertyMatchRule4 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule4
		// 
		virtualPropertyMatchRule4.PropertyName = "type";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "text";
		virtualPropertyMatchRule4.Text = textmatchdata1;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule5;
		virtualPropertyMatchRule5 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule5
		// 
		virtualPropertyMatchRule5.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata2 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata2.Text = "search";
		virtualPropertyMatchRule5.Text = textmatchdata2;
		SearchTxt.MatchRules.Add(virtualPropertyMatchRule4);
		SearchTxt.MatchRules.Add(virtualPropertyMatchRule5);
		SearchTxt.Name = "SearchTxt";
		SearchTxt.TagName = "INPUT";
		SearchTxt.TargetTypeString = _resources_.GetString("_ytt_2_");
		SearchTxt.UseElementId = false;
		// 
		// Set designComp Ids
		// 
		this.SetId(virtualPropertyMatchRule4, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A02EAD42"));
		this.SetId(virtualPropertyMatchRule5, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A03CB677"));
		// 
		// Add components
		// 
		components.Add(virtualPropertyMatchRule4);
		components.Add(virtualPropertyMatchRule5);
		// 
		// Result
		// 
		return SearchTxt;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Create_virtualPropertyMatchRule4(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule4 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.SetId(virtualPropertyMatchRule4, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A02EAD42"));
		virtualPropertyMatchRule4.PropertyName = "type";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "text";
		virtualPropertyMatchRule4.Text = textmatchdata1;
		// 
		// Result
		// 
		return virtualPropertyMatchRule4;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Create_virtualPropertyMatchRule5(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule5 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.SetId(virtualPropertyMatchRule5, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A03CB677"));
		virtualPropertyMatchRule5.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "search";
		virtualPropertyMatchRule5.Text = textmatchdata1;
		// 
		// Result
		// 
		return virtualPropertyMatchRule5;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.Controls.BasicButton Create_Search(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		System.ComponentModel.ComponentResourceManager _resources_ = new System.ComponentModel.ComponentResourceManager(typeof(ytt));
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.Controls.BasicButton Search = new OpenSpan.Adapters.Web.WebBase.Controls.BasicButton();
		this.SetId(Search, new OpenSpan.Design.ComponentIdentity("BasicButton-8D7EA61A45B5C2D"));
		Search.ElementId = "search-icon-legacy";
		Search.Extender = null;
		Search.ExtensibleTypeName = null;
		Search.ForwardObjectExplorerEvent = true;
		Search.MatchingIndex = 0;
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule6;
		virtualPropertyMatchRule6 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		// 
		// virtualPropertyMatchRule6
		// 
		virtualPropertyMatchRule6.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "search-icon-legacy";
		virtualPropertyMatchRule6.Text = textmatchdata1;
		Search.MatchRules.Add(virtualPropertyMatchRule6);
		Search.Name = "Search";
		Search.TagName = "BUTTON";
		Search.TargetTypeString = _resources_.GetString("_ytt_3_");
		Search.UseElementId = true;
		// 
		// Set designComp Ids
		// 
		this.SetId(virtualPropertyMatchRule6, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A475B7EA"));
		// 
		// Add components
		// 
		components.Add(virtualPropertyMatchRule6);
		// 
		// Result
		// 
		return Search;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Create_virtualPropertyMatchRule6(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule6 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.SetId(virtualPropertyMatchRule6, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A475B7EA"));
		virtualPropertyMatchRule6.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "search-icon-legacy";
		virtualPropertyMatchRule6.Text = textmatchdata1;
		// 
		// Result
		// 
		return virtualPropertyMatchRule6;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Create_virtualPropertyMatchRule3(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule3 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.SetId(virtualPropertyMatchRule3, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A01E6AD1"));
		virtualPropertyMatchRule3.PropertyName = "id";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "search-form";
		virtualPropertyMatchRule3.Text = textmatchdata1;
		// 
		// Result
		// 
		return virtualPropertyMatchRule3;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Create_virtualPropertyMatchRule1(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule1 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.SetId(virtualPropertyMatchRule1, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA619FFB0413"));
		virtualPropertyMatchRule1.PropertyName = "url";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "https://www.youtube.com/";
		virtualPropertyMatchRule1.Text = textmatchdata1;
		// 
		// Result
		// 
		return virtualPropertyMatchRule1;
	}
	
	internal OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule Create_virtualPropertyMatchRule2(out System.Collections.Generic.ICollection<System.ComponentModel.IComponent> components)
	{
		components = new System.Collections.Generic.List<System.ComponentModel.IComponent>();
		OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule virtualPropertyMatchRule2 = new OpenSpan.Adapters.Web.WebBase.MatchRules.VirtualPropertyMatchRule();
		this.SetId(virtualPropertyMatchRule2, new OpenSpan.Design.ComponentIdentity("VirtualPropertyMatchRule-8D7EA61A0056369"));
		virtualPropertyMatchRule2.PropertyName = "title";
		OpenSpan.Adapters.TextMatchData textmatchdata1 = new OpenSpan.Adapters.TextMatchData();
		textmatchdata1.Text = "YouTube";
		virtualPropertyMatchRule2.Text = textmatchdata1;
		// 
		// Result
		// 
		return virtualPropertyMatchRule2;
	}
}

}

