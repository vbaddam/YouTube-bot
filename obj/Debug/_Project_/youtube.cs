using youtube_yt = youtube.yt;

using youtube_ytt = youtube.ytt;

using System;

namespace youtube.Project
{
// Project-8D7EA613CE3CD7F
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D7EA613CE3CD7F")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class youtube : OpenSpan.Runtime.RuntimeProject
{
	
	public youtube() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.youtube_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public youtube(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.youtube_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public youtube(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.youtube_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public youtube(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.youtube_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private youtube(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.youtube_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void youtube_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D7EA613CE3CD7F");
		this.mVersion = new System.Version("19.1.21.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("19.1.0.3");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// Automator-8D7EA61D1806435
	public youtube_yt yt
	{
		get
		{
			return ((youtube_yt)(this["yt"]));
		}
	}
	
	// UniversalWebAdapter-8D7EA61716AFE09
	public youtube_ytt ytt
	{
		get
		{
			return ((youtube_ytt)(this["ytt"]));
		}
	}
}

}

