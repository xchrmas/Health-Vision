/**
 * @file        Program.cs
 * @project     Health-Vision — 3D Interactive Human Anatomy Platform
 * @author      Health-Vision
 * @copyright   Copyright (c) 2026 Health-Vision. All Rights Reserved.
 * @license     Proprietary — See LICENSE file for full terms.
 *
 * CONFIDENTIAL AND PROPRIETARY SOURCE CODE.
 * This file contains trade secrets and confidential information of Health-Vision.
 * Unauthorized copying, modification, distribution, or use of this file,
 * via any medium, is strictly prohibited without the express written
 * permission of Health-Vision.
 *
 * UNAUTHORIZED USE OF THIS SOFTWARE IS A VIOLATION OF COPYRIGHT LAW AND
 * MAY RESULT IN CIVIL AND CRIMINAL PROSECUTION.
 *
 * For licensing inquiries: legal@healthvision.io
 */

using HealthVision.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(HealthVision.Web.Client._Imports).Assembly);

app.Run();